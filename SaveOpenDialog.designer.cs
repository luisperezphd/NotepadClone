using System.ComponentModel;
namespace MyNotepad
{
    partial class SaveOpenDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.controlEncodingComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encoding:";
            // 
            // controlEncodingComboBox
            // 
            this.controlEncodingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlEncodingComboBox.DisplayMember = "Display";
            this.controlEncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlEncodingComboBox.FormattingEnabled = true;
            this.controlEncodingComboBox.Location = new System.Drawing.Point(87, 8);
            this.controlEncodingComboBox.Name = "controlEncodingComboBox";
            this.controlEncodingComboBox.Size = new System.Drawing.Size(178, 21);
            this.controlEncodingComboBox.TabIndex = 1;
            this.controlEncodingComboBox.ValueMember = "Value";
            // 
            // SaveOpenDialog
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.controlEncodingComboBox);
            this.Controls.Add(this.label1);
            this.FileDlgCaption = "";
            this.FileDlgCheckFileExists = false;
            this.FileDlgDefaultExt = "";
            this.FileDlgDefaultViewMode = Win32Types.FolderViewMode.List;
            this.FileDlgFilter = "";
            this.FileDlgOkCaption = "";
            this.FileDlgStartLocation = FileDialogExtenders.AddonWindowLocation.Bottom;
            this.Name = "SaveOpenDialog";
            this.Size = new System.Drawing.Size(422, 38);
            this.EventFileNameChanged += new FileDialogExtenders.FileDialogControlBase.PathChangedEventHandler(this.SaveOpenDialog_EventFileNameChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox controlEncodingComboBox;

    }
}
