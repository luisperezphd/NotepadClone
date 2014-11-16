//  Copyright (c) 2006, Gustavo Franco
//  Copyright © Decebal Mihailescu 2007-2010

//  Email:  gustavo_franco@hotmail.com
//  All rights reserved.

//  Redistribution and use in source and binary forms, with or without modification, 
//  are permitted provided that the following conditions are met:

//  Redistributions of source code must retain the above copyright notice, 
//  this list of conditions and the following disclaimer. 
//  Redistributions in binary form must reproduce the above copyright notice, 
//  this list of conditions and the following disclaimer in the documentation 
//  and/or other materials provided with the distribution. 

//  THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
//  PURPOSE. IT CAN BE DISTRIBUTED FREE OF CHARGE AS LONG AS THIS HEADER 
//  REMAINS UNCHANGED.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using FileDialogExtenders;
using System.Linq;


namespace MyNotepad {
    public partial class SaveOpenDialog : FileDialogControlBase {
        private class EncodingComboBoxItem {
            public string Display { get; set; }
            public EncodingInfo Value { get; set; }
        }

        public SaveOpenDialog() {
            InitializeComponent();

            var items = new List<EncodingComboBoxItem>();

            controlEncodingComboBox.DataSource = new [] {
                new { Display = "ANSI", Value = Encoding.ASCII },
                new { Display = "Unicode", Value = Encoding.Unicode },
                new { Display = "Unicode big endian", Value = Encoding.BigEndianUnicode },
                new { Display = "UTF-8", Value = Encoding.UTF8 },
            };

            controlEncodingComboBox.SelectedIndex = 0;
        }

        public Encoding Encoding { 
            get { return (Encoding)controlEncodingComboBox.SelectedValue; } 
            set { controlEncodingComboBox.SelectedValue = value; } 
        }

        protected override void OnPrepareMSDialog() {
            base.OnPrepareMSDialog();

            // TODO: Assign any settings to the underlyining FileDialog (this.MSDialog)

            //if (Environment.OSVersion.Version.Major < 6)
            //    MSDialog.SetPlaces(new object[] { (int)Places.Desktop, (int)Places.Printers, (int)Places.Favorites, (int)Places.Programs, (int)Places.Fonts, });
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void SaveOpenDialog_EventFileNameChanged(IWin32Window sender, string Filename) {
            #region Determine Encoding

            if (FileDlgType == Win32Types.FileDialogType.OpenFileDlg) {
                if (File.Exists(Filename)) {
                    using (var streamReader = new StreamReader(Filename, Encoding.ASCII, detectEncodingFromByteOrderMarks: true)) {
                        var text = streamReader.ReadToEnd();
                        controlEncodingComboBox.SelectedValue = streamReader.CurrentEncoding;
                    }
                }
            }

            #endregion

        }
    }
}

