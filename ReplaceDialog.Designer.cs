namespace MyNotepad {
    partial class ReplaceDialog {
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
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonReplaceAll = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFindWhat = new System.Windows.Forms.Label();
            this.controlFindWhatTextBox = new System.Windows.Forms.TextBox();
            this.controlReplaceWithTextBox = new System.Windows.Forms.TextBox();
            this.labelReplaceWith = new System.Windows.Forms.Label();
            this.controlMatchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonFindNext
            // 
            this.buttonFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindNext.Location = new System.Drawing.Point(253, 8);
            this.buttonFindNext.Name = "buttonFindNext";
            this.buttonFindNext.Size = new System.Drawing.Size(75, 23);
            this.buttonFindNext.TabIndex = 0;
            this.buttonFindNext.Text = "&Find Next";
            this.buttonFindNext.UseVisualStyleBackColor = true;
            this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Location = new System.Drawing.Point(253, 37);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 0;
            this.buttonReplace.Text = "&Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonReplaceAll
            // 
            this.buttonReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplaceAll.Location = new System.Drawing.Point(253, 66);
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.buttonReplaceAll.TabIndex = 0;
            this.buttonReplaceAll.Text = "Replace &All";
            this.buttonReplaceAll.UseVisualStyleBackColor = true;
            this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(253, 95);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelFindWhat
            // 
            this.labelFindWhat.AutoSize = true;
            this.labelFindWhat.Location = new System.Drawing.Point(4, 16);
            this.labelFindWhat.Name = "labelFindWhat";
            this.labelFindWhat.Size = new System.Drawing.Size(56, 13);
            this.labelFindWhat.TabIndex = 1;
            this.labelFindWhat.Text = "Fi&nd what:";
            // 
            // controlFindWhatTextBox
            // 
            this.controlFindWhatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlFindWhatTextBox.Location = new System.Drawing.Point(82, 12);
            this.controlFindWhatTextBox.Name = "controlFindWhatTextBox";
            this.controlFindWhatTextBox.Size = new System.Drawing.Size(165, 20);
            this.controlFindWhatTextBox.TabIndex = 2;
            this.controlFindWhatTextBox.TextChanged += new System.EventHandler(this.controlFindWhatTextBox_TextChanged);
            this.controlFindWhatTextBox.Enter += new System.EventHandler(this.controlFindWhatTextBox_Enter);
            // 
            // controlReplaceWithTextBox
            // 
            this.controlReplaceWithTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlReplaceWithTextBox.Location = new System.Drawing.Point(82, 42);
            this.controlReplaceWithTextBox.Name = "controlReplaceWithTextBox";
            this.controlReplaceWithTextBox.Size = new System.Drawing.Size(165, 20);
            this.controlReplaceWithTextBox.TabIndex = 4;
            this.controlReplaceWithTextBox.Enter += new System.EventHandler(this.controlReplaceWithTextBox_Enter);
            // 
            // labelReplaceWith
            // 
            this.labelReplaceWith.AutoSize = true;
            this.labelReplaceWith.Location = new System.Drawing.Point(4, 45);
            this.labelReplaceWith.Name = "labelReplaceWith";
            this.labelReplaceWith.Size = new System.Drawing.Size(72, 13);
            this.labelReplaceWith.TabIndex = 3;
            this.labelReplaceWith.Text = "Re&place with:";
            // 
            // controlMatchCaseCheckBox
            // 
            this.controlMatchCaseCheckBox.AutoSize = true;
            this.controlMatchCaseCheckBox.Location = new System.Drawing.Point(7, 108);
            this.controlMatchCaseCheckBox.Name = "controlMatchCaseCheckBox";
            this.controlMatchCaseCheckBox.Size = new System.Drawing.Size(82, 17);
            this.controlMatchCaseCheckBox.TabIndex = 5;
            this.controlMatchCaseCheckBox.Text = "Match &case";
            this.controlMatchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReplaceDialog
            // 
            this.AcceptButton = this.buttonFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(337, 155);
            this.Controls.Add(this.controlMatchCaseCheckBox);
            this.Controls.Add(this.controlReplaceWithTextBox);
            this.Controls.Add(this.labelReplaceWith);
            this.Controls.Add(this.controlFindWhatTextBox);
            this.Controls.Add(this.labelFindWhat);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReplaceAll);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonFindNext);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceDialog_FormClosing);
            this.Load += new System.EventHandler(this.ReplaceDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindNext;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonReplaceAll;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFindWhat;
        private System.Windows.Forms.TextBox controlFindWhatTextBox;
        private System.Windows.Forms.TextBox controlReplaceWithTextBox;
        private System.Windows.Forms.Label labelReplaceWith;
        private System.Windows.Forms.CheckBox controlMatchCaseCheckBox;
    }
}