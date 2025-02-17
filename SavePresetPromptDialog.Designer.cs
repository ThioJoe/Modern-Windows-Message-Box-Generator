namespace Windows_Task_Dialog_Generator
{
    partial class SavePresetPromptDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbPresetName = new TextBox();
            panelBottom = new Panel();
            btnCancel = new Button();
            btnOk = new Button();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tbPresetName
            // 
            tbPresetName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPresetName.Location = new Point(12, 12);
            tbPresetName.Name = "tbPresetName";
            tbPresetName.PlaceholderText = "Enter preset name...";
            tbPresetName.Size = new Size(337, 23);
            tbPresetName.TabIndex = 1;
            tbPresetName.KeyPress += tbPresetName_KeyPress;
            // 
            // panelBottom
            // 
            panelBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBottom.BackColor = SystemColors.Window;
            panelBottom.Controls.Add(btnCancel);
            panelBottom.Controls.Add(btnOk);
            panelBottom.Location = new Point(-1, 50);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(365, 39);
            panelBottom.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(194, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(275, 8);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Save";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // SavePresetPromptDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 87);
            Controls.Add(panelBottom);
            Controls.Add(tbPresetName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SavePresetPromptDialog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Save preset as...";
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPresetName;
        private Panel panelBottom;
        private Button btnCancel;
        private Button btnOk;
    }
}