using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

// TODO: In order to mimic Notepad exactly the status bar should be hidden if Word Wrap is turned off and the option should be disabled. Setting should be restored if Word Wrap is turned back off.

namespace MyNotepad {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            if (!Settings.WindowPosition.IsEmpty) {
                Bounds = Settings.WindowPosition;
                StartPosition = FormStartPosition.Manual;
            }
        }

        private Encoding _encoding = Encoding.ASCII;

        private string _Filename;
        public string Filename {
            get {
                return _Filename;
            }
            set {
                var oldvalue = value;
                _Filename = value;
                OnFilenameChanged(oldvalue, value);
            }
        }

        private void OnFilenameChanged(string oldvalue, string value) {
            OnDocumentNameChanged();
        }

        private void OnDocumentNameChanged() {
            UpdateTitle();
        }

        private void UpdateTitle() {
            if (this.Tag == null) {
                this.Tag = base.Text;
            }

            base.Text = ((string)this.Tag).FormatUsingObject(new { DocumentName });
        }

        public string DocumentName {
            get {
                if (Filename == null) return "Untitled";
                return Path.GetFileName(Filename);
            }
        }

        public string Content {
            get { return controlContentTextBox.Text; }
            set { controlContentTextBox.Text = value; }
        }

        private void controlContentTextBox_TextChanged(object sender, EventArgs e) {
            IsDirty = true;
        }

        private void Main_Load(object sender, EventArgs e) {
            UpdateTitle();
            menuitemFormatWordWrap.Checked = controlContentTextBox.WordWrap;
            CurrentFont = Settings.CurrentFont;
            UpdateStatusBar();
            menuitemViewStatusBar.Checked = controlStatusBar.Visible = Settings.IsStatusBarVisible;
            controlContentTextBox.BringToFront(); // in order to docking to respond correctly to the status bar being turned off and on
        }

        public bool IsStatusBarVisible {
            get {
                return Settings.IsStatusBarVisible;
            }
            set {
                menuitemViewStatusBar.Checked = controlStatusBar.Visible = Settings.IsStatusBarVisible = value;
                Settings.Save();
            }
        }

        public bool WordWrap {
            get { 
                return controlContentTextBox.WordWrap; 
            }
            set {
                menuitemFormatWordWrap.Checked = controlContentTextBox.WordWrap = value; 
            }
        }

        private void menuitemFormatWordWrap_Click(object sender, EventArgs e) {
            WordWrap = !WordWrap;
        }

        private void menuitemFormatWordWrap_CheckedChanged(object sender, EventArgs e) {
            var Sender = (ToolStripMenuItem)sender;
            WordWrap = Sender.Checked;
        }

        private static Properties.Settings Settings {
            get { return Properties.Settings.Default; }
        }

        private Font CurrentFont {
            get {
                return Settings.CurrentFont;
            }
            set {
                controlContentTextBox.Font = Settings.CurrentFont = value;
                Settings.Save();
            }
        }

        private void menuitemFormatFont_Click(object sender, EventArgs e) {
            var FontDialog = new FontDialog();
            FontDialog.Font = CurrentFont;
            if (FontDialog.ShowDialog(this) != DialogResult.OK) return;
            CurrentFont = FontDialog.Font;
        }

        private bool _IsDirty;
        public bool IsDirty {
            get {
                if (Filename == null && Content.IsEmpty()) return false;
                return _IsDirty;
            }
            set {
                _IsDirty = value;
            }
        }

        private bool Save() {
            if (!IsDirty) return true;

            if ((Filename == null) || new FileInfo(Filename).IsReadOnly) {
                return SaveAs();
            }

            File.WriteAllText(Filename, Content);
            IsDirty = false;
            return true;
        }

        private bool SaveAs() {
            var SaveDialog = new SaveOpenDialog();
            SaveDialog.FileDlgFileName = Filename;
            SaveDialog.FileDlgDefaultExt = ".txt";
            SaveDialog.FileDlgFilter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            SaveDialog.Encoding = _encoding;
            SaveDialog.FileDlgCaption = "Save";
            SaveDialog.FileDlgOkCaption = "Save";
            
            if (SaveDialog.ShowDialog(this) != DialogResult.OK) return false;

            var PotentialFilename = SaveDialog.MSDialog.FileName;

            _encoding = SaveDialog.Encoding;
            File.WriteAllText(PotentialFilename, Content, _encoding);

            Filename = PotentialFilename;
            IsDirty = false;

            return true;
        }

        private void menuitemFileOpen_Click(object sender, EventArgs e) {
            if (!EnsureWorkNotLost()) return;

            var OpenDialog = new SaveOpenDialog();
            OpenDialog.FileDlgDefaultExt = ".txt";
            OpenDialog.FileDlgFileName = Filename;
            OpenDialog.FileDlgFilter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            OpenDialog.FileDlgType = Win32Types.FileDialogType.OpenFileDlg;
            OpenDialog.FileDlgCaption = "Open";
            OpenDialog.FileDlgOkCaption = "Open";

            if (OpenDialog.ShowDialog(this) != DialogResult.OK) return;

            Open(OpenDialog.MSDialog.FileName, OpenDialog.Encoding);
        }

        public void Open(string pFilename, Encoding encoding = null) {
            var Filename = pFilename;

            if (!File.Exists(Filename)) {
                var FileExists = false;

                var Extension = Path.GetExtension(Filename);
                if (Extension == "") {
                    Filename = Filename + ".txt";
                    FileExists = File.Exists(Filename);
                }

                if (!FileExists) {
                    #region Message

                    var Message = @"Cannot find the {Filename} file.

Do you want to create a new file?
".FormatUsingObject(new { Filename = Filename });

                    #endregion

                    var Result = MessageBox.Show(Message, "Notepad Clone", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    switch (Result) {
                        case DialogResult.Yes:
                            File.WriteAllText(Filename, "");
                            break;
                        case DialogResult.No:
                        case DialogResult.Cancel:
                            return;
                        default:
                            throw new Exception();
                    }
                }
            }

            #region Determine Encoding

            if (encoding == null) { // generally this means it was not opened by a user using the open file dialog
                using (var streamReader = new StreamReader(Filename, detectEncodingFromByteOrderMarks: true)) {
                    var text = streamReader.ReadToEnd();
                    _encoding = streamReader.CurrentEncoding;
                }
            }

            #endregion

            Content = ReadAllText(Filename, encoding);
            SelectionStart = 0;
            this.Filename = Filename;
            IsDirty = false;
        }

        private static string ReadAllText(string pFilename, Encoding encoding) {
            using (var FileStream = new FileStream(pFilename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
                if (encoding == null) {
                    using (var StreamReader = new StreamReader(FileStream)) {
                        var text = StreamReader.ReadToEnd();
                        return text;
                    }
                } else {
                    using (var StreamReader = new StreamReader(FileStream, encoding, false)) {
                        var text = StreamReader.ReadToEnd();
                        return text;
                    }
                }
            }
        }

        private void menuitemFileSave_Click(object sender, EventArgs e) {
            Save();
        }

        private void menuitemFileSaveAs_Click(object sender, EventArgs e) {
            SaveAs();
        }

        private void menuitemFileNew_Click(object sender, EventArgs e) {
            New();
        }

        private bool EnsureWorkNotLost() {
            if (!IsDirty) return true;

            var DialogResult  = new SaveChangesPrompt(Filename).ShowDialog(this);

            switch(DialogResult) {
                case DialogResult.Yes:
                    return Save();
                case DialogResult.No:
                    return true;
                case DialogResult.Cancel:
                    return false;
                default:
                    throw new Exception();
            }
        }

        private bool New() {
            if (!EnsureWorkNotLost()) return false;

            Filename = null;
            Content = "";
            IsDirty = false;
            _encoding = Encoding.ASCII;

            return true;
        }

        private void menuitemFilePageSetup_Click(object sender, EventArgs e) {
            var PageSetupDialog = new PageSetupDialog();
            PageSetupDialog.PageSettings = PageSettings;
            if (PageSetupDialog.ShowDialog(this) != DialogResult.OK) return;
            PageSettings = PageSetupDialog.PageSettings;
        }

        private PageSettings _PageSettings;
        private PageSettings PageSettings {
            get {
                if (_PageSettings == null) {
                    if (Settings.MoreSettings.PageSettings != null) {
                        _PageSettings = Settings.MoreSettings.PageSettings;
                    } else {
                        var PageSettings = new PageSettings() {
                            Margins = new Margins(75, 75, 100, 100), // 100 = 1 inch
                        };

                        _PageSettings = PageSettings;
                    }
                }

                return _PageSettings;
            }
            set {
                Settings.MoreSettings.PageSettings = value;
                Settings.Save();
            }
        }

        private void menuitemFilePrint_Click(object IGNORE_sender, EventArgs IGNORE_e) {
            var PrintDialog = new PrintDialog();

            if (Settings.MoreSettings.PrinterSettings != null) {
                PrintDialog.PrinterSettings = Settings.MoreSettings.PrinterSettings;
            }

            if (PrintDialog.ShowDialog(this) != DialogResult.OK) return;
            Settings.MoreSettings.PrinterSettings = PrintDialog.PrinterSettings;
            Settings.Save();

            var PrintDocument = new PrintDocument();
            PrintDocument.DefaultPageSettings = PageSettings;
            PrintDocument.PrinterSettings = Settings.MoreSettings.PrinterSettings;
            PrintDocument.DocumentName = DocumentName + " - Notepad Clone";

            var RemainingContentToPrint = Content;
            var PageIndex = 0;

            PrintDocument.PrintPage += (sender, e) => {
                { // header
                    var HeaderText = FormatHeaderFooterText(Settings.Header, PageIndex);
                    var Top = PageSettings.Margins.Top;
                    DrawStringAtPosition(e.Graphics, HeaderText.Left, Top, DrawStringPosition.Left);
                    DrawStringAtPosition(e.Graphics, HeaderText.Center, Top, DrawStringPosition.Center);
                    DrawStringAtPosition(e.Graphics, HeaderText.Right, Top, DrawStringPosition.Right);
                }

                { // body
                    var CharactersFitted = 0;
                    var LinesFilled = 0;

                    var MarginBounds = new RectangleF(e.MarginBounds.X, e.MarginBounds.Y + /* header */ CurrentFont.Height, e.MarginBounds.Width, e.MarginBounds.Height - (/* header and footer */ CurrentFont.Height * 2));

                    e.Graphics.MeasureString(RemainingContentToPrint, CurrentFont, MarginBounds.Size, StringFormat.GenericTypographic, out CharactersFitted, out LinesFilled);
                    e.Graphics.DrawString(RemainingContentToPrint, CurrentFont, Brushes.Black, MarginBounds, StringFormat.GenericTypographic);

                    RemainingContentToPrint = RemainingContentToPrint.Substring(CharactersFitted);

                    e.HasMorePages = (RemainingContentToPrint.Length > 0);
                }

                { // footer
                    var FooterText = FormatHeaderFooterText(Settings.Footer, PageIndex);
                    var Top = PageSettings.Bounds.Bottom - PageSettings.Margins.Bottom - CurrentFont.Height;
                    DrawStringAtPosition(e.Graphics, FooterText.Left, Top, DrawStringPosition.Left);
                    DrawStringAtPosition(e.Graphics, FooterText.Center, Top, DrawStringPosition.Center);
                    DrawStringAtPosition(e.Graphics, FooterText.Right, Top, DrawStringPosition.Right);
                }

                PageIndex++;
            };

            PrintDocument.Print();
        }

        private enum DrawStringPosition {
            Left,
            Center,
            Right,
        }

        private void DrawStringAtPosition(Graphics pGraphics, string pText, int Top, DrawStringPosition pPosition) {
            var HeaderTextSize = new SizeF(pGraphics.MeasureString(pText, CurrentFont));
            var HeaderTextWidth = HeaderTextSize.Width;
            var PageWidth = PageSettings.Bounds.Right - PageSettings.Bounds.Left;

            float Left;

            if (pPosition == DrawStringPosition.Left) {
                Left = PageSettings.Margins.Left;
            } else if (pPosition == DrawStringPosition.Center) {
                Left = ((PageWidth - HeaderTextWidth) / 2);
            } else if (pPosition == DrawStringPosition.Right) {
                Left = PageWidth - PageSettings.Margins.Right - HeaderTextWidth;
            } else {
                throw new Exception();
            }

            pGraphics.DrawString(pText, CurrentFont, Brushes.Black, Left, Top);
        }

        private class HeaderOrFooterInfo {
            public string Left = "";
            public string Center = "";
            public string Right = "";
        }

        private HeaderOrFooterInfo FormatHeaderFooterText(string pText, int PageIndex) {
            var HeaderOrFooterInfo = GetHeaderOrFooterInfo(pText);

            HeaderOrFooterInfo.Left = FormatSingleHeaderFooterText(HeaderOrFooterInfo.Left, PageIndex);
            HeaderOrFooterInfo.Center = FormatSingleHeaderFooterText(HeaderOrFooterInfo.Center, PageIndex);
            HeaderOrFooterInfo.Right = FormatSingleHeaderFooterText(HeaderOrFooterInfo.Right, PageIndex);

            return HeaderOrFooterInfo;
        }

        private string FormatSingleHeaderFooterText(string pText, int PageIndex) {
            return pText
                        .Replace("&f", DocumentName)
                        .Replace("&p", (PageIndex + 1).ToString())
                        .Replace("&d", DateTime.Now.ToLongDateString())
                        .Replace("&t", DateTime.Now.ToLongTimeString())
                        ;
        }

        private static HeaderOrFooterInfo GetHeaderOrFooterInfo(string pText) {
            const string CONST_Left = "Left";
            const string CONST_Center = "Center";
            const string CONST_Right = "Right";

            var LeftIndexes = Helper.GetIndexes(pText, "&l", false);
            var CenterIndexes = Helper.GetIndexes(pText, "&c", false);
            var RightIndexes = Helper.GetIndexes(pText, "&r", false);

            var SideInfos =
                LeftIndexes.Select(o => new { Side = CONST_Left, Index = o })
                .Union(CenterIndexes.Select(o => new { Side = CONST_Center, Index = o }))
                .Union(RightIndexes.Select(o => new { Side = CONST_Right, Index = o }))
                .OrderBy(o => o.Index)
                .ToList()
                ;

            var HeaderOrFooterInfo = new HeaderOrFooterInfo();

            if (SideInfos.Count == 0) {
                HeaderOrFooterInfo.Center = pText;
                return HeaderOrFooterInfo;
            }


            for (int i = 0; i < SideInfos.Count; i++) {
                var SideInfo = SideInfos[i];
                var IsFirstSideInfo = (i == 0);
                var IsLastSideInfo = (i == (SideInfos.Count - 1));

                if (IsFirstSideInfo) {
                    if (SideInfo.Index != 0) {
                        HeaderOrFooterInfo.Center = pText.Substring(0, SideInfo.Index - 1);
                    }
                }

                var StartIndex = SideInfo.Index + 2;

                var EndIndex = 0;
                if (IsLastSideInfo) {
                    EndIndex = pText.Length - 1;
                } else {
                    var NextSideInfo = SideInfos[i + 1];
                    EndIndex = NextSideInfo.Index - 1;
                }

                var Length = EndIndex - StartIndex + 1;
                var Text = pText.Substring(StartIndex, Length);

                switch (SideInfo.Side) {
                    case CONST_Left:
                        HeaderOrFooterInfo.Left += Text;
                        break;
                    case CONST_Center:
                        HeaderOrFooterInfo.Center += Text;
                        break;
                    case CONST_Right:
                        HeaderOrFooterInfo.Right += Text;
                        break;
                    default:
                        throw new Exception();
                }
            }
            return HeaderOrFooterInfo;
        }

        private void menuitemFileExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void menuitemEditUndo_Click(object sender, EventArgs e) {
            controlContentTextBox.Undo();
        }

        private void menuitemEditCut_Click(object sender, EventArgs e) {
            controlContentTextBox.Cut();
        }

        private void menuitemEditCopy_Click(object sender, EventArgs e) {
            controlContentTextBox.Copy();
        }

        private void menuitemEditPaste_Click(object sender, EventArgs e) {
            controlContentTextBox.Paste();
        }

        private void menuitemEditDelete_Click(object sender, EventArgs e) {
            if (SelectionLength == 0) {
                SelectionLength = 1;
            }

            SelectedText = "";
        }

        public string SelectedText {
            get { return controlContentTextBox.SelectedText; }
            set {
                controlContentTextBox.SelectedText = value;
                IsDirty = true;
            }
        }

        private void menuitemEditSelectAll_Click(object sender, EventArgs e) {
            controlContentTextBox.SelectAll();
        }

        private void menuitemEditTimeDate_Click(object sender, EventArgs e) {
            SelectedText = DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString();
        }

        private void menuitemEditGoTo_Click(object sender, EventArgs e) {
            var GoToLinePrompt = new GoToLinePrompt(LineIndex + 1);
            GoToLinePrompt.Left = Left + 5;
            GoToLinePrompt.Top = Top + 44;

            if (GoToLinePrompt.ShowDialog(this) != DialogResult.OK) return;

            var TargetLineIndex = GoToLinePrompt.LineNumber - 1;

            if (TargetLineIndex > controlContentTextBox.Lines.Length) {
                MessageBox.Show(this, "The line number is beyond the total number of lines", "NotepadClone.Net - Goto Line");
                return;
            }

            LineIndex = TargetLineIndex;
        }

        private class ContentPosition {
            public int LineIndex;
            public int ColumnIndex;
        }

        private ContentPosition CaretPosition {
            get {
                return CharIndexToPosition(SelectionStart);
            }
        }

        private ContentPosition CharIndexToPosition(int pCharIndex) {
            var CurrentCharIndex = 0;

            if (controlContentTextBox.Lines.Length == 0 && CurrentCharIndex == 0) return new ContentPosition { LineIndex = 0, ColumnIndex = 0 };

            for (var CurrentLineIndex = 0; CurrentLineIndex < controlContentTextBox.Lines.Length; CurrentLineIndex++) {
                var LineStartCharIndex = CurrentCharIndex;
                var Line = controlContentTextBox.Lines[CurrentLineIndex];
                var LineEndCharIndex = LineStartCharIndex + Line.Length + 1;

                if (pCharIndex >= LineStartCharIndex && pCharIndex <= LineEndCharIndex) {
                    var ColumnIndex = pCharIndex - LineStartCharIndex;
                    return new ContentPosition { LineIndex = CurrentLineIndex, ColumnIndex = ColumnIndex };
                }

                CurrentCharIndex += controlContentTextBox.Lines[CurrentLineIndex].Length + Environment.NewLine.Length;
            }

            return null;
        }

        private void UpdateStatusBar() {
            if (controlCaretPositionLabel.Tag == null) {
                controlCaretPositionLabel.Tag = controlCaretPositionLabel.Text;
            }

            controlCaretPositionLabel.Text = ((string)controlCaretPositionLabel.Tag).FormatUsingObject(new { 
                LineNumber = CaretPosition.LineIndex + 1, 
                ColumnNumber = CaretPosition.ColumnIndex + 1,
            });
        }

        private int LineIndex {
            get {
                return CaretPosition.LineIndex;
            }
            set {
                var TargetLineIndex = value;

                if (TargetLineIndex < 0) {
                    TargetLineIndex = 0;
                }

                if (TargetLineIndex >= controlContentTextBox.Lines.Length) {
                    TargetLineIndex = controlContentTextBox.Lines.Length - 1;
                }

                var CharIndex = 0;

                for (var CurrentLineIndex = 0; CurrentLineIndex < TargetLineIndex; CurrentLineIndex++) {
                    CharIndex += controlContentTextBox.Lines[CurrentLineIndex].Length + Environment.NewLine.Length;
                }

                SelectionStart = CharIndex;
                controlContentTextBox.ScrollToCaret();
            }
        }

        public int SelectionEnd {
            get { return SelectionStart + SelectionLength; }
        }


        public int SelectionStart {
            get { return controlContentTextBox.SelectionStart; }
            set { 
                controlContentTextBox.SelectionStart = value;
                controlContentTextBox.ScrollToCaret();
            }
        }

        public int SelectionLength {
            get { return controlContentTextBox.SelectionLength; }
            set { controlContentTextBox.SelectionLength = value; }
        }

        private void menuitemAbout_Click(object sender, EventArgs e) {
            new About().ShowDialog(this);
        }

        private void controlContentTextBox_KeyDown(object sender, KeyEventArgs e) {
            UpdateStatusBar();
        }

        private void controlContentTextBox_KeyUp(object sender, KeyEventArgs e) {
            UpdateStatusBar();
        }

        private void menuitemViewStatusBar_Click(object sender, EventArgs e) {
            IsStatusBarVisible = !IsStatusBarVisible;
        }

        private void menuitemEdit_DropDownOpening(object sender, EventArgs e) {
            menuitemEditCut.Enabled =
                menuitemEditCopy.Enabled =
                menuitemEditDelete.Enabled = (SelectionLength > 0);

            menuitemEditFind.Enabled =
                menuitemEditFindNext.Enabled = (Content.Length > 0);
        }

        private string _LastSearchText;
        private bool _LastMatchCase;
        private bool _LastSearchDown;

        public bool FindAndSelect(string pSearchText, bool pMatchCase, bool pSearchDown) {
            int Index;

            var eStringComparison = pMatchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;

            if (pSearchDown) {
                Index = Content.IndexOf(pSearchText, SelectionEnd, eStringComparison);
            } else {
                Index = Content.LastIndexOf(pSearchText, SelectionStart, SelectionStart, eStringComparison);
            }

            if (Index == -1) return false;

            _LastSearchText = pSearchText;
            _LastMatchCase = pMatchCase;
            _LastSearchDown = pSearchDown;

            SelectionStart = Index;
            SelectionLength = pSearchText.Length;

            return true;
        }

        private FindDialog _FindDialog;

        private void menuitemEditFind_Click(object sender, EventArgs e) {
            Find();
        }

        private void Find() {
            if (Content.Length == 0) return;

            if (_FindDialog == null) {
                _FindDialog = new FindDialog(this);
            }

            _FindDialog.Left = this.Left + 56;
            _FindDialog.Top = this.Top + 160;

            if (!_FindDialog.Visible) {
                _FindDialog.Show(this);
            } else {
                _FindDialog.Show();
            }

            _FindDialog.Triggered();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !EnsureWorkNotLost();
        }

        private void menuitemEditFindNext_Click(object sender, EventArgs e) {
            if (_LastSearchText == null) {
                Find();
                return;
            }

            if(!FindAndSelect(_LastSearchText, _LastMatchCase, _LastSearchDown)) {
                MessageBox.Show(this, CONST.CannotFindMessage.FormatUsingObject(new { SearchText = _LastSearchText }), "Notepad Clone");
            }
        }

        private ReplaceDialog _ReplaceDialog;

        private void menuitemEditReplace_Click(object sender, EventArgs e) {
            if (Content.Length == 0) return;

            if (_ReplaceDialog == null) {
                _ReplaceDialog = new ReplaceDialog(this);
            }

            _ReplaceDialog.Left = this.Left + 56;
            _ReplaceDialog.Top = this.Top + 113;

            if (!_ReplaceDialog.Visible) {
                _ReplaceDialog.Show(this);
            } else {
                _ReplaceDialog.Show();
            }

            _ReplaceDialog.Triggered();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e) {
            Settings.WindowPosition = Bounds;
            Settings.Save();
        }

        private void menuitemFileHeaderAndFooter_Click(object sender, EventArgs e) {
            var PageSetupHeaderFooter = new PageSetupHeaderFooter();
            PageSetupHeaderFooter.Header = Settings.Header;
            PageSetupHeaderFooter.Footer = Settings.Footer;
            if (PageSetupHeaderFooter.ShowDialog(this) != DialogResult.OK) return;
            Settings.Header = PageSetupHeaderFooter.Header;
            Settings.Footer = PageSetupHeaderFooter.Footer;
            Settings.Save();
        }

        private void controlContentTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateStatusBar();
        }
    }
}
