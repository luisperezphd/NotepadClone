using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad {
    public partial class ReplaceDialog : Form {
        private Main _Main;
        public ReplaceDialog(Main pMain) {
            InitializeComponent();
            _Main = pMain;
        }

        private void controlFindWhatTextBox_Enter(object sender, EventArgs e) {
            var Sender = (TextBox)sender;
            Sender.SelectAll();
        }

        private void controlReplaceWithTextBox_Enter(object sender, EventArgs e) {
            var Sender = (TextBox)sender;
            Sender.SelectAll();
        }

        private void controlFindWhatTextBox_TextChanged(object sender, EventArgs e) {
            UpdateButtons();
        }

        private void ReplaceDialog_Load(object sender, EventArgs e) {
            UpdateButtons();
        }

        private void UpdateButtons() {
            buttonFindNext.Enabled = 
                buttonReplace.Enabled =
                buttonReplaceAll.Enabled = controlFindWhatTextBox.Text.Length > 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Hide();
        }

        private void ReplaceDialog_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            Hide();
        }

        public void Triggered() {
            controlFindWhatTextBox.Focus();
        }

        private void buttonFindNext_Click(object sender, EventArgs e) {
            var SearchText = controlFindWhatTextBox.Text;
            var MatchCase = controlMatchCaseCheckBox.Checked;
            var bSearchDown = true;

            if (!_Main.FindAndSelect(SearchText, MatchCase, bSearchDown)) {
                MessageBox.Show(this, CONST.CannotFindMessage.FormatUsingObject(new { SearchText = SearchText }), "Notepad Clone");
            }
        }

        private void buttonReplace_Click(object sender, EventArgs e) {
            var SearchText = controlFindWhatTextBox.Text;
            var ReplaceWithText = controlReplaceWithTextBox.Text;
            var MatchCase = controlMatchCaseCheckBox.Checked;
            var eStringComparison = MatchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
            var bSearchDown = true;

            if (_Main.SelectedText.Equals(SearchText)) {
                _Main.SelectedText = ReplaceWithText;
            }

            if (!_Main.FindAndSelect(SearchText, MatchCase, bSearchDown)) {
                MessageBox.Show(this, CONST.CannotFindMessage.FormatUsingObject(new { SearchText = SearchText }), "Notepad Clone");
            }
        }

        private void buttonReplaceAll_Click(object sender, EventArgs e) {
            var Content = _Main.Content;
            var SearchText = controlFindWhatTextBox.Text;
            var MatchCase = controlMatchCaseCheckBox.Checked;

            var Indexes = Helper.GetIndexes(Content, SearchText, MatchCase);

            //if (!Indexes.Any()) { // TODO: Notepad doesn't do this
            //    MessageBox.Show(this, CONST.CannotFindMessage.FormatUsingObject(new { SearchText = SearchText }), "Notepad Clone");
            //    return;
            //}

            var Builder = new StringBuilder();
            var ReplaceWith = controlReplaceWithTextBox.Text;

            { // scope
                var LastIndex = -1;
                foreach (var Index in Indexes) {
                    if (Index != 0) {
                        #region TakeStart

                        int TakeStart;

                        if (LastIndex == -1) {
                            TakeStart = 0;
                        } else {
                            TakeStart = LastIndex + SearchText.Length;
                        }

                        #endregion

                        var TakeEnd = Index - 1;
                        var Length = (TakeEnd - TakeStart) + 1;

                        var InBetween = Content.Substring(TakeStart, Length);
                        Builder.Append(InBetween);
                    }

                    Builder.Append(ReplaceWith);
                    LastIndex = Index;
                }

                {
                    #region TakeStart

                    int TakeStart;

                    if (LastIndex == -1) {
                        TakeStart = 0;
                    } else {
                        TakeStart = LastIndex + SearchText.Length;
                    }

                    #endregion

                    var TakeEnd = Content.Length - 1;
                    var Length = (TakeEnd - TakeStart) + 1;
                    Builder.Append(Content.Substring(TakeStart, Length));
                }
            }

            _Main.Content = Builder.ToString();
        }
    }
}
