namespace Windows_Task_Dialog_Generator
{
    partial class AboutForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            panel1 = new Panel();
            btnGithub = new Button();
            lblVersion = new Label();
            btnClose = new Button();
            lblTitle = new Label();
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            tbCredits = new TabPage();
            lbCredits = new ListBox();
            tbLicense = new TabPage();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tbCredits.SuspendLayout();
            tbLicense.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(btnGithub);
            panel1.Controls.Add(lblVersion);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(-5, 337);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 47);
            panel1.TabIndex = 0;
            // 
            // btnGithub
            // 
            btnGithub.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGithub.Image = Properties.Resources.github_black_16x16;
            btnGithub.Location = new Point(371, 10);
            btnGithub.Name = "btnGithub";
            btnGithub.Size = new Size(35, 27);
            btnGithub.TabIndex = 2;
            toolTip1.SetToolTip(btnGithub, "Click to visit the GitHub page of this project");
            btnGithub.UseVisualStyleBackColor = true;
            btnGithub.Click += btnGithub_Click;
            // 
            // lblVersion
            // 
            lblVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(17, 16);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(118, 15);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Error getting version";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(412, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 27);
            btnClose.TabIndex = 1;
            btnClose.Text = "&Close";
            toolTip1.SetToolTip(btnClose, "Close this window");
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(59, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(386, 47);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Task Dialog Generator";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tbCredits);
            tabControl1.Controls.Add(tbLicense);
            tabControl1.Location = new Point(12, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(473, 270);
            tabControl1.TabIndex = 2;
            // 
            // tbCredits
            // 
            tbCredits.Controls.Add(lbCredits);
            tbCredits.Location = new Point(4, 24);
            tbCredits.Name = "tbCredits";
            tbCredits.Padding = new Padding(3);
            tbCredits.Size = new Size(465, 242);
            tbCredits.TabIndex = 0;
            tbCredits.Text = "Credits";
            tbCredits.UseVisualStyleBackColor = true;
            // 
            // lbCredits
            // 
            lbCredits.Dock = DockStyle.Fill;
            lbCredits.FormattingEnabled = true;
            lbCredits.Location = new Point(3, 3);
            lbCredits.Name = "lbCredits";
            lbCredits.Size = new Size(459, 236);
            lbCredits.TabIndex = 0;
            // 
            // tbLicense
            // 
            tbLicense.Controls.Add(richTextBox1);
            tbLicense.Location = new Point(4, 24);
            tbLicense.Name = "tbLicense";
            tbLicense.Padding = new Padding(3);
            tbLicense.Size = new Size(435, 200);
            tbLicense.TabIndex = 1;
            tbLicense.Text = "License";
            tbLicense.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(429, 194);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.WordWrap = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 382);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tbCredits.ResumeLayout(false);
            tbLicense.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Label lblTitle;
        private Label lblVersion;
        private Button btnGithub;
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tbCredits;
        private TabPage tbLicense;
        private RichTextBox richTextBox1;
        private ListBox lbCredits;
    }
}