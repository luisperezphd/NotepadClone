namespace MyNotepad {
    partial class FindDialog {
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
            this.buttonFindNext = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFindWhat = new System.Windows.Forms.Label();
            this.controlMatchCaseCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.controlDownRadioButton = new System.Windows.Forms.RadioButton();
            this.controlUpRadioButton = new System.Windows.Forms.RadioButton();
            this.controlTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFindNext
            // 
            this.buttonFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindNext.Location = new System.Drawing.Point(273, 12);
            this.buttonFindNext.Name = "buttonFindNext";
            this.buttonFindNext.Size = new System.Drawing.Size(75, 23);
            this.buttonFindNext.TabIndex = 4;
            this.buttonFindNext.Text = "&Find Next";
            this.buttonFindNext.UseVisualStyleBackColor = true;
            this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(273, 41);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelFindWhat
            // 
            this.labelFindWhat.AutoSize = true;
            this.labelFindWhat.Location = new System.Drawing.Point(8, 18);
            this.labelFindWhat.Name = "labelFindWhat";
            this.labelFindWhat.Size = new System.Drawing.Size(56, 13);
            this.labelFindWhat.TabIndex = 0;
            this.labelFindWhat.Text = "Fi&nd what:";
            // 
            // controlMatchCaseCheckbox
            // 
            this.controlMatchCaseCheckbox.AutoSize = true;
            this.controlMatchCaseCheckbox.Location = new System.Drawing.Point(11, 71);
            this.controlMatchCaseCheckbox.Name = "controlMatchCaseCheckbox";
            this.controlMatchCaseCheckbox.Size = new System.Drawing.Size(82, 17);
            this.controlMatchCaseCheckbox.TabIndex = 2;
            this.controlMatchCaseCheckbox.Text = "Match &case";
            this.controlMatchCaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.controlDownRadioButton);
            this.groupBox1.Controls.Add(this.controlUpRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(151, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // controlDownRadioButton
            // 
            this.controlDownRadioButton.AutoSize = true;
            this.controlDownRadioButton.Checked = true;
            this.controlDownRadioButton.Location = new System.Drawing.Point(51, 19);
            this.controlDownRadioButton.Name = "controlDownRadioButton";
            this.controlDownRadioButton.Size = new System.Drawing.Size(53, 17);
            this.controlDownRadioButton.TabIndex = 1;
            this.controlDownRadioButton.TabStop = true;
            this.controlDownRadioButton.Text = "&Down";
            this.controlDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // controlUpRadioButton
            // 
            this.controlUpRadioButton.AutoSize = true;
            this.controlUpRadioButton.Location = new System.Drawing.Point(6, 19);
            this.controlUpRadioButton.Name = "controlUpRadioButton";
            this.controlUpRadioButton.Size = new System.Drawing.Size(39, 17);
            this.controlUpRadioButton.TabIndex = 0;
            this.controlUpRadioButton.TabStop = true;
            this.controlUpRadioButton.Text = "&Up";
            this.controlUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // controlTextBox
            // 
            this.controlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlTextBox.Location = new System.Drawing.Point(78, 16);
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Size = new System.Drawing.Size(182, 20);
            this.controlTextBox.TabIndex = 1;
            this.controlTextBox.TextChanged += new System.EventHandler(this.controlTextBox_TextChanged);
            this.controlTextBox.Enter += new System.EventHandler(this.controlTextBox_Enter);
            // 
            // FindDialog
            // 
            this.AcceptButton = this.buttonFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(360, 101);
            this.Controls.Add(this.controlTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.controlMatchCaseCheckbox);
            this.Controls.Add(this.labelFindWhat);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFindNext);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindDialog_FormClosing);
            this.Load += new System.EventHandler(this.FindDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindNext;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFindWhat;
        private System.Windows.Forms.CheckBox controlMatchCaseCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton controlDownRadioButton;
        private System.Windows.Forms.RadioButton controlUpRadioButton;
        private System.Windows.Forms.TextBox controlTextBox;
    }
}