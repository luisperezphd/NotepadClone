using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad {
    public partial class SaveChangesPrompt : Form {
        public SaveChangesPrompt(string Filename) {
            InitializeComponent();

            labelMessage.Text = labelMessage.Text.FormatUsingObject(new { Filename = Filename ?? "Untitled" });
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void buttonDontSave_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.No;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
