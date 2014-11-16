using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad {
    public partial class PageSetupHeaderFooter : Form {
        public PageSetupHeaderFooter() {
            InitializeComponent();
        }

        public string Header { get { return controlHeaderTextBox.Text; } set { controlHeaderTextBox.Text = value; } }
        public string Footer { get { return controlFooterTextBox.Text; } set { controlFooterTextBox.Text = value; } }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
