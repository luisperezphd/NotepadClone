using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad {
    public partial class GoToLinePrompt : Form {
        public GoToLinePrompt(int pLineNumber) {
            InitializeComponent();
            LineNumber = pLineNumber;
            controlLineNumberTextBox.Text = LineNumber.ToString();
        }

        public int LineNumber;

        private void GoToLinePrompt_Load(object sender, EventArgs e) {
            controlLineNumberTextBox.SelectAll();
        }

        private void buttonGoTo_Click(object sender, EventArgs e) {
            if (controlLineNumberTextBox.Text.IsEmpty()) {
                MessageBox.Show(this, "You must enter a value.", "Notepad Clone - Goto Line");
                return;
            }

            var PotentialLineNumber = Int32.Parse(controlLineNumberTextBox.Text);

            if (PotentialLineNumber == 0) {
                MessageBox.Show(this, "Zero (0) is not a valid line number, line numbers start at 1.", "Notepad Clone - Goto Line");
                return;
            }

            LineNumber = PotentialLineNumber;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void controlLineNumberTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar)) {
                var Sender = (TextBox)sender;
                controlToolTip.Show("Unacceptable Charater - You can only type a number here.", Sender);
                e.Handled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
