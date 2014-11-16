namespace MyNotepad {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.controlContentTextBox = new System.Windows.Forms.TextBox();
            this.menubarMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemFileHeaderAndFooter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemFormatWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.controlStatusBar = new System.Windows.Forms.StatusStrip();
            this.controlCaretPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menubarMain.SuspendLayout();
            this.controlStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlContentTextBox
            // 
            this.controlContentTextBox.AcceptsReturn = true;
            this.controlContentTextBox.AcceptsTab = true;
            this.controlContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContentTextBox.HideSelection = false;
            this.controlContentTextBox.Location = new System.Drawing.Point(0, 24);
            this.controlContentTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.controlContentTextBox.MaxLength = 0;
            this.controlContentTextBox.Multiline = true;
            this.controlContentTextBox.Name = "controlContentTextBox";
            this.controlContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.controlContentTextBox.Size = new System.Drawing.Size(632, 369);
            this.controlContentTextBox.TabIndex = 0;
            this.controlContentTextBox.WordWrap = false;
            this.controlContentTextBox.TextChanged += new System.EventHandler(this.controlContentTextBox_TextChanged);
            this.controlContentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controlContentTextBox_KeyDown);
            this.controlContentTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.controlContentTextBox_KeyUp);
            this.controlContentTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlContentTextBox_MouseDown);
            // 
            // menubarMain
            // 
            this.menubarMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.menubarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuitemEdit,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menubarMain.Location = new System.Drawing.Point(0, 0);
            this.menubarMain.Name = "menubarMain";
            this.menubarMain.Padding = new System.Windows.Forms.Padding(0);
            this.menubarMain.Size = new System.Drawing.Size(632, 24);
            this.menubarMain.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemFileNew,
            this.menuitemFileOpen,
            this.menuitemFileSave,
            this.menuitemFileSaveAs,
            this.toolStripSeparator1,
            this.menuitemFilePageSetup,
            this.menuitemFileHeaderAndFooter,
            this.menuitemFilePrint,
            this.toolStripSeparator2,
            this.menuitemFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuitemFileNew
            // 
            this.menuitemFileNew.Name = "menuitemFileNew";
            this.menuitemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuitemFileNew.Size = new System.Drawing.Size(171, 22);
            this.menuitemFileNew.Text = "&New";
            this.menuitemFileNew.Click += new System.EventHandler(this.menuitemFileNew_Click);
            // 
            // menuitemFileOpen
            // 
            this.menuitemFileOpen.Name = "menuitemFileOpen";
            this.menuitemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuitemFileOpen.Size = new System.Drawing.Size(171, 22);
            this.menuitemFileOpen.Text = "&Open...";
            this.menuitemFileOpen.Click += new System.EventHandler(this.menuitemFileOpen_Click);
            // 
            // menuitemFileSave
            // 
            this.menuitemFileSave.Name = "menuitemFileSave";
            this.menuitemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuitemFileSave.Size = new System.Drawing.Size(171, 22);
            this.menuitemFileSave.Text = "&Save";
            this.menuitemFileSave.Click += new System.EventHandler(this.menuitemFileSave_Click);
            // 
            // menuitemFileSaveAs
            // 
            this.menuitemFileSaveAs.Name = "menuitemFileSaveAs";
            this.menuitemFileSaveAs.Size = new System.Drawing.Size(171, 22);
            this.menuitemFileSaveAs.Text = "Save &As...";
            this.menuitemFileSaveAs.Click += new System.EventHandler(this.menuitemFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // menuitemFilePageSetup
            // 
            this.menuitemFilePageSetup.Name = "menuitemFilePageSetup";
            this.menuitemFilePageSetup.Size = new System.Drawing.Size(171, 22);
            this.menuitemFilePageSetup.Text = "Page Set&up...";
            this.menuitemFilePageSetup.Click += new System.EventHandler(this.menuitemFilePageSetup_Click);
            // 
            // menuitemFileHeaderAndFooter
            // 
            this.menuitemFileHeaderAndFooter.Name = "menuitemFileHeaderAndFooter";
            this.menuitemFileHeaderAndFooter.Size = new System.Drawing.Size(171, 22);
            this.menuitemFileHeaderAndFooter.Text = "&Header && Footer...";
            this.menuitemFileHeaderAndFooter.Click += new System.EventHandler(this.menuitemFileHeaderAndFooter_Click);
            // 
            // menuitemFilePrint
            // 
            this.menuitemFilePrint.Name = "menuitemFilePrint";
            this.menuitemFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuitemFilePrint.Size = new System.Drawing.Size(171, 22);
            this.menuitemFilePrint.Text = "&Print...";
            this.menuitemFilePrint.Click += new System.EventHandler(this.menuitemFilePrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // menuitemFileExit
            // 
            this.menuitemFileExit.Name = "menuitemFileExit";
            this.menuitemFileExit.Size = new System.Drawing.Size(171, 22);
            this.menuitemFileExit.Text = "E&xit";
            this.menuitemFileExit.Click += new System.EventHandler(this.menuitemFileExit_Click);
            // 
            // menuitemEdit
            // 
            this.menuitemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemEditUndo,
            this.toolStripSeparator5,
            this.menuitemEditCut,
            this.menuitemEditCopy,
            this.menuitemEditPaste,
            this.menuitemEditDelete,
            this.toolStripSeparator6,
            this.menuitemEditFind,
            this.menuitemEditFindNext,
            this.menuitemEditReplace,
            this.menuitemEditGoTo,
            this.toolStripSeparator3,
            this.menuitemEditSelectAll,
            this.menuitemEditTimeDate});
            this.menuitemEdit.Name = "menuitemEdit";
            this.menuitemEdit.Size = new System.Drawing.Size(39, 24);
            this.menuitemEdit.Text = "&Edit";
            this.menuitemEdit.DropDownOpening += new System.EventHandler(this.menuitemEdit_DropDownOpening);
            // 
            // menuitemEditUndo
            // 
            this.menuitemEditUndo.Name = "menuitemEditUndo";
            this.menuitemEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuitemEditUndo.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditUndo.Text = "&Undo";
            this.menuitemEditUndo.Click += new System.EventHandler(this.menuitemEditUndo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // menuitemEditCut
            // 
            this.menuitemEditCut.Name = "menuitemEditCut";
            this.menuitemEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuitemEditCut.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditCut.Text = "Cu&t";
            this.menuitemEditCut.Click += new System.EventHandler(this.menuitemEditCut_Click);
            // 
            // menuitemEditCopy
            // 
            this.menuitemEditCopy.Name = "menuitemEditCopy";
            this.menuitemEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuitemEditCopy.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditCopy.Text = "&Copy";
            this.menuitemEditCopy.Click += new System.EventHandler(this.menuitemEditCopy_Click);
            // 
            // menuitemEditPaste
            // 
            this.menuitemEditPaste.Name = "menuitemEditPaste";
            this.menuitemEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuitemEditPaste.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditPaste.Text = "&Paste";
            this.menuitemEditPaste.Click += new System.EventHandler(this.menuitemEditPaste_Click);
            // 
            // menuitemEditDelete
            // 
            this.menuitemEditDelete.Name = "menuitemEditDelete";
            this.menuitemEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuitemEditDelete.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditDelete.Text = "De&lete";
            this.menuitemEditDelete.Click += new System.EventHandler(this.menuitemEditDelete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(164, 6);
            // 
            // menuitemEditFind
            // 
            this.menuitemEditFind.Name = "menuitemEditFind";
            this.menuitemEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuitemEditFind.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditFind.Text = "&Find...";
            this.menuitemEditFind.Click += new System.EventHandler(this.menuitemEditFind_Click);
            // 
            // menuitemEditFindNext
            // 
            this.menuitemEditFindNext.Name = "menuitemEditFindNext";
            this.menuitemEditFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuitemEditFindNext.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditFindNext.Text = "Find &Next";
            this.menuitemEditFindNext.Click += new System.EventHandler(this.menuitemEditFindNext_Click);
            // 
            // menuitemEditReplace
            // 
            this.menuitemEditReplace.Name = "menuitemEditReplace";
            this.menuitemEditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuitemEditReplace.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditReplace.Text = "&Replace...";
            this.menuitemEditReplace.Click += new System.EventHandler(this.menuitemEditReplace_Click);
            // 
            // menuitemEditGoTo
            // 
            this.menuitemEditGoTo.Name = "menuitemEditGoTo";
            this.menuitemEditGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menuitemEditGoTo.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditGoTo.Text = "&Go To...";
            this.menuitemEditGoTo.Click += new System.EventHandler(this.menuitemEditGoTo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // menuitemEditSelectAll
            // 
            this.menuitemEditSelectAll.Name = "menuitemEditSelectAll";
            this.menuitemEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuitemEditSelectAll.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditSelectAll.Text = "Select &All";
            this.menuitemEditSelectAll.Click += new System.EventHandler(this.menuitemEditSelectAll_Click);
            // 
            // menuitemEditTimeDate
            // 
            this.menuitemEditTimeDate.Name = "menuitemEditTimeDate";
            this.menuitemEditTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuitemEditTimeDate.Size = new System.Drawing.Size(167, 22);
            this.menuitemEditTimeDate.Text = "Time/&Date";
            this.menuitemEditTimeDate.Click += new System.EventHandler(this.menuitemEditTimeDate_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemFormatWordWrap,
            this.menuitemFormatFont});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // menuitemFormatWordWrap
            // 
            this.menuitemFormatWordWrap.Name = "menuitemFormatWordWrap";
            this.menuitemFormatWordWrap.Size = new System.Drawing.Size(134, 22);
            this.menuitemFormatWordWrap.Text = "&Word Wrap";
            this.menuitemFormatWordWrap.CheckedChanged += new System.EventHandler(this.menuitemFormatWordWrap_CheckedChanged);
            this.menuitemFormatWordWrap.Click += new System.EventHandler(this.menuitemFormatWordWrap_Click);
            // 
            // menuitemFormatFont
            // 
            this.menuitemFormatFont.Name = "menuitemFormatFont";
            this.menuitemFormatFont.Size = new System.Drawing.Size(134, 22);
            this.menuitemFormatFont.Text = "&Font...";
            this.menuitemFormatFont.Click += new System.EventHandler(this.menuitemFormatFont_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemViewStatusBar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // menuitemViewStatusBar
            // 
            this.menuitemViewStatusBar.Name = "menuitemViewStatusBar";
            this.menuitemViewStatusBar.Size = new System.Drawing.Size(126, 22);
            this.menuitemViewStatusBar.Text = "&Status Bar";
            this.menuitemViewStatusBar.Click += new System.EventHandler(this.menuitemViewStatusBar_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemHelp,
            this.toolStripSeparator4,
            this.menuitemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // menuitemHelp
            // 
            this.menuitemHelp.Name = "menuitemHelp";
            this.menuitemHelp.Size = new System.Drawing.Size(190, 22);
            this.menuitemHelp.Text = "View &Help";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // menuitemAbout
            // 
            this.menuitemAbout.Name = "menuitemAbout";
            this.menuitemAbout.Size = new System.Drawing.Size(190, 22);
            this.menuitemAbout.Text = "&About Notepad Clone";
            this.menuitemAbout.Click += new System.EventHandler(this.menuitemAbout_Click);
            // 
            // controlStatusBar
            // 
            this.controlStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlCaretPositionLabel});
            this.controlStatusBar.Location = new System.Drawing.Point(0, 371);
            this.controlStatusBar.Name = "controlStatusBar";
            this.controlStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.controlStatusBar.Size = new System.Drawing.Size(632, 22);
            this.controlStatusBar.SizingGrip = false;
            this.controlStatusBar.TabIndex = 2;
            // 
            // controlCaretPositionLabel
            // 
            this.controlCaretPositionLabel.AutoSize = false;
            this.controlCaretPositionLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.controlCaretPositionLabel.Name = "controlCaretPositionLabel";
            this.controlCaretPositionLabel.Size = new System.Drawing.Size(219, 17);
            this.controlCaretPositionLabel.Text = "Ln {LineNumber}, Col {ColumnNumber}";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 393);
            this.Controls.Add(this.controlStatusBar);
            this.Controls.Add(this.controlContentTextBox);
            this.Controls.Add(this.menubarMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menubarMain;
            this.Name = "Main";
            this.Text = "{DocumentName} - Notepad Clone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menubarMain.ResumeLayout(false);
            this.menubarMain.PerformLayout();
            this.controlStatusBar.ResumeLayout(false);
            this.controlStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox controlContentTextBox;
        private System.Windows.Forms.MenuStrip menubarMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuitemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuitemFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuitemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuitemFilePageSetup;
        private System.Windows.Forms.ToolStripMenuItem menuitemFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuitemFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuitemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditFind;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditFindNext;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditReplace;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditGoTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditTimeDate;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemFormatWordWrap;
        private System.Windows.Forms.ToolStripMenuItem menuitemFormatFont;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemViewStatusBar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuitemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.StatusStrip controlStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel controlCaretPositionLabel;
        private System.Windows.Forms.ToolStripMenuItem menuitemFileHeaderAndFooter;
    }
}

