namespace MyNotepad {
    partial class PageSetupHeaderFooter {
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.controlHeaderTextBox = new System.Windows.Forms.TextBox();
            this.controlFooterTextBox = new System.Windows.Forms.TextBox();
            this.labelFooter = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(15, 15);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(45, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Header:";
            // 
            // controlHeaderTextBox
            // 
            this.controlHeaderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlHeaderTextBox.Location = new System.Drawing.Point(78, 12);
            this.controlHeaderTextBox.Name = "controlHeaderTextBox";
            this.controlHeaderTextBox.Size = new System.Drawing.Size(260, 20);
            this.controlHeaderTextBox.TabIndex = 1;
            // 
            // controlFooterTextBox
            // 
            this.controlFooterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlFooterTextBox.Location = new System.Drawing.Point(78, 38);
            this.controlFooterTextBox.Name = "controlFooterTextBox";
            this.controlFooterTextBox.Size = new System.Drawing.Size(260, 20);
            this.controlFooterTextBox.TabIndex = 3;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Location = new System.Drawing.Point(15, 41);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(40, 13);
            this.labelFooter.TabIndex = 2;
            this.labelFooter.Text = "Footer:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(263, 71);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(182, 71);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // PageSetupHeaderFooter
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(350, 106);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.controlFooterTextBox);
            this.Controls.Add(this.labelFooter);
            this.Controls.Add(this.controlHeaderTextBox);
            this.Controls.Add(this.labelHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PageSetupHeaderFooter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Page Setup - Header & Footer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox controlHeaderTextBox;
        private System.Windows.Forms.TextBox controlFooterTextBox;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}