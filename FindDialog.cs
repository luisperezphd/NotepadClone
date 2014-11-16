using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad {
    public partial class FindDialog : Form {
        private readonly Main _Main;

        public FindDialog(Main pMain) {
            InitializeComponent();
            _Main = pMain;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Hide();
        }

        private void FindDialog_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            Hide();
        }

        private void controlTextBox_TextChanged(object sender, EventArgs e) {
            UpdateFindNextButton();
        }

        private void UpdateFindNextButton() {
            buttonFindNext.Enabled = controlTextBox.Text.Length > 0;
        }

        private void FindDialog_Load(object sender, EventArgs e) {
            UpdateFindNextButton();
        }

        private void buttonFindNext_Click(object sender, EventArgs e) {
            var SearchText = controlTextBox.Text;
            var MatchCase = controlMatchCaseCheckbox.Checked;
            var bSearchDown = controlDownRadioButton.Checked;

            if (!_Main.FindAndSelect(SearchText, MatchCase, bSearchDown)) {
                MessageBox.Show(this, CONST.CannotFindMessage.FormatUsingObject(new { SearchText = SearchText }), "Notepad Clone");
            }
        }

        public void Triggered() {
            controlTextBox.Focus();
        }

        private void controlTextBox_Enter(object sender, EventArgs e) {
            var Sender = (TextBox)sender;
            Sender.SelectAll();
        }

        public new void Show(IWin32Window window = null) {
            controlTextBox.Focus();
            controlTextBox.SelectAll();

            if (window == null) {
                base.Show();
            } else {
                base.Show(window);
            }
        }
    }
}
