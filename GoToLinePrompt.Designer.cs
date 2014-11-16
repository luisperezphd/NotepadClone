namespace MyNotepad {
    partial class GoToLinePrompt {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToLinePrompt));
            this.labelLineNumber = new System.Windows.Forms.Label();
            this.controlLineNumberTextBox = new System.Windows.Forms.TextBox();
            this.buttonGoTo = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.controlToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelLineNumber
            // 
            this.labelLineNumber.AutoSize = true;
            this.labelLineNumber.Location = new System.Drawing.Point(12, 9);
            this.labelLineNumber.Name = "labelLineNumber";
            this.labelLineNumber.Size = new System.Drawing.Size(68, 13);
            this.labelLineNumber.TabIndex = 0;
            this.labelLineNumber.Text = "&Line number:";
            // 
            // controlLineNumberTextBox
            // 
            this.controlLineNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlLineNumberTextBox.Location = new System.Drawing.Point(12, 25);
            this.controlLineNumberTextBox.Name = "controlLineNumberTextBox";
            this.controlLineNumberTextBox.Size = new System.Drawing.Size(216, 20);
            this.controlLineNumberTextBox.TabIndex = 1;
            this.controlLineNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.controlLineNumberTextBox_KeyPress);
            // 
            // buttonGoTo
            // 
            this.buttonGoTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoTo.Location = new System.Drawing.Point(72, 56);
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.Size = new System.Drawing.Size(75, 23);
            this.buttonGoTo.TabIndex = 2;
            this.buttonGoTo.Text = "Go To";
            this.buttonGoTo.UseVisualStyleBackColor = true;
            this.buttonGoTo.Click += new System.EventHandler(this.buttonGoTo_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(153, 56);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // GoToLinePrompt
            // 
            this.AcceptButton = this.buttonGoTo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(240, 91);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonGoTo);
            this.Controls.Add(this.controlLineNumberTextBox);
            this.Controls.Add(this.labelLineNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToLinePrompt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Go To Line";
            this.Load += new System.EventHandler(this.GoToLinePrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLineNumber;
        private System.Windows.Forms.TextBox controlLineNumberTextBox;
        private System.Windows.Forms.Button buttonGoTo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolTip controlToolTip;
    }
}