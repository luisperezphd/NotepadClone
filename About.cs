using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad {
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            Close();
        }

        private void controlSimplyGoodCodeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://simplygoodcode.com");
        }
    }
}
