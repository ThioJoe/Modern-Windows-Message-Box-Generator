namespace Windows_Task_Dialog_Generator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtTitle = new TextBox();
            txtHeading = new TextBox();
            lblTitle = new Label();
            lblHeading = new Label();
            gbButtons = new GroupBox();
            rbRetryCancel = new RadioButton();
            rbAbortRetryIgnore = new RadioButton();
            rbYesNoCancel = new RadioButton();
            rbYesNo = new RadioButton();
            rbOkCancel = new RadioButton();
            rbOk = new RadioButton();
            gbIconMain = new GroupBox();
            labelSelectTitleIcon = new Label();
            labelSelectMainIcon = new Label();
            splitContainer1 = new SplitContainer();
            tableLayoutTitleIconSelect = new TableLayoutPanel();
            rbIconTitleShieldSuccess = new RadioButton();
            rbIconTitleError = new RadioButton();
            rbIconTitleShieldWarning = new RadioButton();
            rbIconTitleShieldBlueBar = new RadioButton();
            rbIconTitleShieldError = new RadioButton();
            rbIconTitleShieldGrayBar = new RadioButton();
            rbIconTitleInformation = new RadioButton();
            rbIconTitleCustomID = new RadioButton();
            rbIconTitleCustomFile = new RadioButton();
            rbIconTitleShield = new RadioButton();
            rbIconTitleWarning = new RadioButton();
            rbIconTitleNone = new RadioButton();
            rbIconTitleSame = new RadioButton();
            tableLayoutMainIconSelect = new TableLayoutPanel();
            rbIconMainShieldSuccessGreenBar = new RadioButton();
            rbIconMainError = new RadioButton();
            rbIconMainShieldWarningYellowBar = new RadioButton();
            rbIconMainShieldBlueBar = new RadioButton();
            rbIconMainShieldErrorRedBar = new RadioButton();
            rbIconMainShieldGrayBar = new RadioButton();
            rbIconMainInformation = new RadioButton();
            rbIconMainCustomID = new RadioButton();
            rbIconMainCustomFile = new RadioButton();
            rbIconMainShield = new RadioButton();
            rbIconMainWarning = new RadioButton();
            rbIconMainNone = new RadioButton();
            labelSame = new Label();
            btnShowDialog = new Button();
            lblFooter = new Label();
            txtFooter = new TextBox();
            chkVerification = new CheckBox();
            lblExpandedInfo = new Label();
            txtExpandedInfo = new TextBox();
            textBoxCustomIconMainPath = new TextBox();
            buttonBrowseCustomIconMain = new Button();
            groupBoxCustomIconMainFile = new GroupBox();
            buttonTest = new Button();
            groupBoxBarColor = new GroupBox();
            rbBarColorNone = new RadioButton();
            rbBarColorDefault = new RadioButton();
            rbBarColorGreen = new RadioButton();
            rbBarColorRed = new RadioButton();
            rbBarColorYellow = new RadioButton();
            rbBarColorGray = new RadioButton();
            rbBarColorBlue = new RadioButton();
            groupBoxCustomIconMainID = new GroupBox();
            textBoxCustomIconMainID = new TextBox();
            lblMessage = new Label();
            txtMessage = new TextBox();
            textBoxVerification = new TextBox();
            buttonImageResIcons = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanelVerification = new FlowLayoutPanel();
            labelVersion = new Label();
            groupBoxCustomIconTitleID = new GroupBox();
            textBoxCustomIconTitleID = new TextBox();
            groupBoxCustomIconTitleFile = new GroupBox();
            textBoxCustomIconTitlePath = new TextBox();
            buttonBrowseCustomIconTitle = new Button();
            gbButtons.SuspendLayout();
            gbIconMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutTitleIconSelect.SuspendLayout();
            tableLayoutMainIconSelect.SuspendLayout();
            groupBoxCustomIconMainFile.SuspendLayout();
            groupBoxBarColor.SuspendLayout();
            groupBoxCustomIconMainID.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanelVerification.SuspendLayout();
            groupBoxCustomIconTitleID.SuspendLayout();
            groupBoxCustomIconTitleFile.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(5, 24);
            txtTitle.Margin = new Padding(5, 2, 5, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(304, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtHeading
            // 
            txtHeading.Location = new Point(5, 76);
            txtHeading.Margin = new Padding(5, 2, 5, 5);
            txtHeading.Name = "txtHeading";
            txtHeading.Size = new Size(304, 23);
            txtHeading.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(5, 5);
            lblTitle.Margin = new Padding(5, 5, 5, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(5, 57);
            lblHeading.Margin = new Padding(5, 5, 5, 2);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(55, 15);
            lblHeading.TabIndex = 2;
            lblHeading.Text = "Heading:";
            // 
            // gbButtons
            // 
            gbButtons.Controls.Add(rbRetryCancel);
            gbButtons.Controls.Add(rbAbortRetryIgnore);
            gbButtons.Controls.Add(rbYesNoCancel);
            gbButtons.Controls.Add(rbYesNo);
            gbButtons.Controls.Add(rbOkCancel);
            gbButtons.Controls.Add(rbOk);
            gbButtons.Location = new Point(333, 13);
            gbButtons.Name = "gbButtons";
            gbButtons.Size = new Size(223, 175);
            gbButtons.TabIndex = 6;
            gbButtons.TabStop = false;
            gbButtons.Text = "Buttons";
            // 
            // rbRetryCancel
            // 
            rbRetryCancel.AutoSize = true;
            rbRetryCancel.Location = new Point(15, 142);
            rbRetryCancel.Name = "rbRetryCancel";
            rbRetryCancel.Size = new Size(93, 19);
            rbRetryCancel.TabIndex = 5;
            rbRetryCancel.TabStop = true;
            rbRetryCancel.Text = "Retry/Cancel";
            rbRetryCancel.UseVisualStyleBackColor = true;
            // 
            // rbAbortRetryIgnore
            // 
            rbAbortRetryIgnore.AutoSize = true;
            rbAbortRetryIgnore.Location = new Point(15, 117);
            rbAbortRetryIgnore.Name = "rbAbortRetryIgnore";
            rbAbortRetryIgnore.Size = new Size(126, 19);
            rbAbortRetryIgnore.TabIndex = 4;
            rbAbortRetryIgnore.TabStop = true;
            rbAbortRetryIgnore.Text = "Abort/Retry/Ignore";
            rbAbortRetryIgnore.UseVisualStyleBackColor = true;
            // 
            // rbYesNoCancel
            // 
            rbYesNoCancel.AutoSize = true;
            rbYesNoCancel.Location = new Point(15, 92);
            rbYesNoCancel.Name = "rbYesNoCancel";
            rbYesNoCancel.Size = new Size(104, 19);
            rbYesNoCancel.TabIndex = 3;
            rbYesNoCancel.TabStop = true;
            rbYesNoCancel.Text = "Yes/No/Cancel";
            rbYesNoCancel.UseVisualStyleBackColor = true;
            // 
            // rbYesNo
            // 
            rbYesNo.AutoSize = true;
            rbYesNo.Location = new Point(15, 67);
            rbYesNo.Name = "rbYesNo";
            rbYesNo.Size = new Size(63, 19);
            rbYesNo.TabIndex = 2;
            rbYesNo.TabStop = true;
            rbYesNo.Text = "Yes/No";
            rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbOkCancel
            // 
            rbOkCancel.AutoSize = true;
            rbOkCancel.Location = new Point(15, 42);
            rbOkCancel.Name = "rbOkCancel";
            rbOkCancel.Size = new Size(82, 19);
            rbOkCancel.TabIndex = 1;
            rbOkCancel.TabStop = true;
            rbOkCancel.Text = "OK/Cancel";
            rbOkCancel.UseVisualStyleBackColor = true;
            // 
            // rbOk
            // 
            rbOk.AutoSize = true;
            rbOk.Checked = true;
            rbOk.Location = new Point(15, 17);
            rbOk.Name = "rbOk";
            rbOk.Size = new Size(41, 19);
            rbOk.TabIndex = 0;
            rbOk.TabStop = true;
            rbOk.Text = "OK";
            rbOk.UseVisualStyleBackColor = true;
            // 
            // gbIconMain
            // 
            gbIconMain.Controls.Add(labelSelectTitleIcon);
            gbIconMain.Controls.Add(labelSelectMainIcon);
            gbIconMain.Controls.Add(splitContainer1);
            gbIconMain.Location = new Point(576, 13);
            gbIconMain.Name = "gbIconMain";
            gbIconMain.Size = new Size(225, 376);
            gbIconMain.TabIndex = 7;
            gbIconMain.TabStop = false;
            gbIconMain.Text = "Icons";
            // 
            // labelSelectTitleIcon
            // 
            labelSelectTitleIcon.AutoSize = true;
            labelSelectTitleIcon.Location = new Point(6, 21);
            labelSelectTitleIcon.Name = "labelSelectTitleIcon";
            labelSelectTitleIcon.Size = new Size(50, 15);
            labelSelectTitleIcon.TabIndex = 26;
            labelSelectTitleIcon.Text = "Title Bar";
            // 
            // labelSelectMainIcon
            // 
            labelSelectMainIcon.AutoSize = true;
            labelSelectMainIcon.Location = new Point(62, 21);
            labelSelectMainIcon.Name = "labelSelectMainIcon";
            labelSelectMainIcon.Size = new Size(34, 15);
            labelSelectMainIcon.TabIndex = 25;
            labelSelectMainIcon.Text = "Main";
            // 
            // splitContainer1
            // 
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(3, 39);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutTitleIconSelect);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutMainIconSelect);
            splitContainer1.Size = new Size(219, 331);
            splitContainer1.SplitterDistance = 56;
            splitContainer1.TabIndex = 24;
            // 
            // tableLayoutTitleIconSelect
            // 
            tableLayoutTitleIconSelect.ColumnCount = 1;
            tableLayoutTitleIconSelect.ColumnStyles.Add(new ColumnStyle());
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleShieldSuccess, 0, 8);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleError, 0, 3);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleShieldWarning, 0, 9);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleShieldBlueBar, 0, 6);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleShieldError, 0, 10);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleShieldGrayBar, 0, 7);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleInformation, 0, 1);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleCustomID, 0, 13);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleCustomFile, 0, 12);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleShield, 0, 5);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleWarning, 0, 2);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleNone, 0, 0);
            tableLayoutTitleIconSelect.Controls.Add(rbIconTitleSame, 0, 14);
            tableLayoutTitleIconSelect.Dock = DockStyle.Fill;
            tableLayoutTitleIconSelect.Location = new Point(0, 0);
            tableLayoutTitleIconSelect.Name = "tableLayoutTitleIconSelect";
            tableLayoutTitleIconSelect.RowCount = 15;
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutTitleIconSelect.Size = new Size(56, 331);
            tableLayoutTitleIconSelect.TabIndex = 26;
            // 
            // rbIconTitleShieldSuccess
            // 
            rbIconTitleShieldSuccess.AutoSize = true;
            rbIconTitleShieldSuccess.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleShieldSuccess.Dock = DockStyle.Fill;
            rbIconTitleShieldSuccess.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleShieldSuccess.Location = new Point(0, 178);
            rbIconTitleShieldSuccess.Margin = new Padding(0);
            rbIconTitleShieldSuccess.Name = "rbIconTitleShieldSuccess";
            rbIconTitleShieldSuccess.Size = new Size(56, 24);
            rbIconTitleShieldSuccess.TabIndex = 9;
            rbIconTitleShieldSuccess.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleShieldSuccess.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleError
            // 
            rbIconTitleError.AutoSize = true;
            rbIconTitleError.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleError.Dock = DockStyle.Fill;
            rbIconTitleError.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleError.Location = new Point(0, 72);
            rbIconTitleError.Margin = new Padding(0);
            rbIconTitleError.Name = "rbIconTitleError";
            rbIconTitleError.Size = new Size(56, 24);
            rbIconTitleError.TabIndex = 4;
            rbIconTitleError.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleError.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleShieldWarning
            // 
            rbIconTitleShieldWarning.AutoSize = true;
            rbIconTitleShieldWarning.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleShieldWarning.Dock = DockStyle.Fill;
            rbIconTitleShieldWarning.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleShieldWarning.Location = new Point(0, 202);
            rbIconTitleShieldWarning.Margin = new Padding(0);
            rbIconTitleShieldWarning.Name = "rbIconTitleShieldWarning";
            rbIconTitleShieldWarning.Size = new Size(56, 24);
            rbIconTitleShieldWarning.TabIndex = 8;
            rbIconTitleShieldWarning.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleShieldWarning.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleShieldBlueBar
            // 
            rbIconTitleShieldBlueBar.AutoSize = true;
            rbIconTitleShieldBlueBar.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleShieldBlueBar.Dock = DockStyle.Fill;
            rbIconTitleShieldBlueBar.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleShieldBlueBar.Location = new Point(0, 130);
            rbIconTitleShieldBlueBar.Margin = new Padding(0);
            rbIconTitleShieldBlueBar.Name = "rbIconTitleShieldBlueBar";
            rbIconTitleShieldBlueBar.Size = new Size(56, 24);
            rbIconTitleShieldBlueBar.TabIndex = 5;
            rbIconTitleShieldBlueBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleShieldBlueBar.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleShieldError
            // 
            rbIconTitleShieldError.AutoSize = true;
            rbIconTitleShieldError.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleShieldError.Dock = DockStyle.Fill;
            rbIconTitleShieldError.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleShieldError.Location = new Point(0, 226);
            rbIconTitleShieldError.Margin = new Padding(0);
            rbIconTitleShieldError.Name = "rbIconTitleShieldError";
            rbIconTitleShieldError.Size = new Size(56, 24);
            rbIconTitleShieldError.TabIndex = 7;
            rbIconTitleShieldError.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleShieldError.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleShieldGrayBar
            // 
            rbIconTitleShieldGrayBar.AutoSize = true;
            rbIconTitleShieldGrayBar.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleShieldGrayBar.Dock = DockStyle.Fill;
            rbIconTitleShieldGrayBar.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleShieldGrayBar.Location = new Point(0, 154);
            rbIconTitleShieldGrayBar.Margin = new Padding(0);
            rbIconTitleShieldGrayBar.Name = "rbIconTitleShieldGrayBar";
            rbIconTitleShieldGrayBar.Size = new Size(56, 24);
            rbIconTitleShieldGrayBar.TabIndex = 6;
            rbIconTitleShieldGrayBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleShieldGrayBar.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleInformation
            // 
            rbIconTitleInformation.AutoSize = true;
            rbIconTitleInformation.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleInformation.Dock = DockStyle.Fill;
            rbIconTitleInformation.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleInformation.Location = new Point(0, 24);
            rbIconTitleInformation.Margin = new Padding(0);
            rbIconTitleInformation.Name = "rbIconTitleInformation";
            rbIconTitleInformation.Size = new Size(56, 24);
            rbIconTitleInformation.TabIndex = 1;
            rbIconTitleInformation.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleInformation.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleCustomID
            // 
            rbIconTitleCustomID.AutoSize = true;
            rbIconTitleCustomID.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleCustomID.Dock = DockStyle.Fill;
            rbIconTitleCustomID.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleCustomID.Location = new Point(0, 284);
            rbIconTitleCustomID.Margin = new Padding(0);
            rbIconTitleCustomID.Name = "rbIconTitleCustomID";
            rbIconTitleCustomID.Size = new Size(56, 24);
            rbIconTitleCustomID.TabIndex = 11;
            rbIconTitleCustomID.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleCustomID.UseVisualStyleBackColor = true;
            rbIconTitleCustomID.CheckedChanged += rbIconTitleCustomID_CheckedChanged;
            // 
            // rbIconTitleCustomFile
            // 
            rbIconTitleCustomFile.AutoSize = true;
            rbIconTitleCustomFile.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleCustomFile.Dock = DockStyle.Fill;
            rbIconTitleCustomFile.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleCustomFile.Location = new Point(0, 260);
            rbIconTitleCustomFile.Margin = new Padding(0);
            rbIconTitleCustomFile.Name = "rbIconTitleCustomFile";
            rbIconTitleCustomFile.Size = new Size(56, 24);
            rbIconTitleCustomFile.TabIndex = 10;
            rbIconTitleCustomFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleCustomFile.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleShield
            // 
            rbIconTitleShield.AutoSize = true;
            rbIconTitleShield.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleShield.Dock = DockStyle.Fill;
            rbIconTitleShield.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleShield.Location = new Point(0, 106);
            rbIconTitleShield.Margin = new Padding(0);
            rbIconTitleShield.Name = "rbIconTitleShield";
            rbIconTitleShield.Size = new Size(56, 24);
            rbIconTitleShield.TabIndex = 3;
            rbIconTitleShield.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleShield.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleWarning
            // 
            rbIconTitleWarning.AutoSize = true;
            rbIconTitleWarning.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleWarning.Dock = DockStyle.Fill;
            rbIconTitleWarning.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleWarning.Location = new Point(0, 48);
            rbIconTitleWarning.Margin = new Padding(0);
            rbIconTitleWarning.Name = "rbIconTitleWarning";
            rbIconTitleWarning.Size = new Size(56, 24);
            rbIconTitleWarning.TabIndex = 2;
            rbIconTitleWarning.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleWarning.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleNone
            // 
            rbIconTitleNone.AutoSize = true;
            rbIconTitleNone.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleNone.Dock = DockStyle.Fill;
            rbIconTitleNone.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconTitleNone.Location = new Point(0, 0);
            rbIconTitleNone.Margin = new Padding(0);
            rbIconTitleNone.Name = "rbIconTitleNone";
            rbIconTitleNone.Size = new Size(56, 24);
            rbIconTitleNone.TabIndex = 0;
            rbIconTitleNone.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconTitleNone.UseVisualStyleBackColor = true;
            // 
            // rbIconTitleSame
            // 
            rbIconTitleSame.AutoSize = true;
            rbIconTitleSame.CheckAlign = ContentAlignment.MiddleCenter;
            rbIconTitleSame.Checked = true;
            rbIconTitleSame.Dock = DockStyle.Fill;
            rbIconTitleSame.Location = new Point(3, 311);
            rbIconTitleSame.Name = "rbIconTitleSame";
            rbIconTitleSame.Size = new Size(50, 18);
            rbIconTitleSame.TabIndex = 12;
            rbIconTitleSame.TabStop = true;
            rbIconTitleSame.UseVisualStyleBackColor = true;
            // 
            // tableLayoutMainIconSelect
            // 
            tableLayoutMainIconSelect.ColumnCount = 1;
            tableLayoutMainIconSelect.ColumnStyles.Add(new ColumnStyle());
            tableLayoutMainIconSelect.Controls.Add(rbIconMainShieldSuccessGreenBar, 0, 8);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainError, 0, 3);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainShieldWarningYellowBar, 0, 9);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainShieldBlueBar, 0, 6);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainShieldErrorRedBar, 0, 10);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainShieldGrayBar, 0, 7);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainInformation, 0, 1);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainCustomID, 0, 13);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainCustomFile, 0, 12);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainShield, 0, 5);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainWarning, 0, 2);
            tableLayoutMainIconSelect.Controls.Add(rbIconMainNone, 0, 0);
            tableLayoutMainIconSelect.Controls.Add(labelSame, 0, 14);
            tableLayoutMainIconSelect.Dock = DockStyle.Fill;
            tableLayoutMainIconSelect.Location = new Point(0, 0);
            tableLayoutMainIconSelect.Name = "tableLayoutMainIconSelect";
            tableLayoutMainIconSelect.RowCount = 15;
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMainIconSelect.Size = new Size(159, 331);
            tableLayoutMainIconSelect.TabIndex = 25;
            // 
            // rbIconMainShieldSuccessGreenBar
            // 
            rbIconMainShieldSuccessGreenBar.AutoSize = true;
            rbIconMainShieldSuccessGreenBar.Dock = DockStyle.Fill;
            rbIconMainShieldSuccessGreenBar.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainShieldSuccessGreenBar.Location = new Point(0, 178);
            rbIconMainShieldSuccessGreenBar.Margin = new Padding(0);
            rbIconMainShieldSuccessGreenBar.Name = "rbIconMainShieldSuccessGreenBar";
            rbIconMainShieldSuccessGreenBar.Size = new Size(159, 24);
            rbIconMainShieldSuccessGreenBar.TabIndex = 9;
            rbIconMainShieldSuccessGreenBar.Text = "Shield Success";
            rbIconMainShieldSuccessGreenBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainShieldSuccessGreenBar.UseVisualStyleBackColor = true;
            // 
            // rbIconMainError
            // 
            rbIconMainError.AutoSize = true;
            rbIconMainError.Dock = DockStyle.Fill;
            rbIconMainError.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainError.Location = new Point(0, 72);
            rbIconMainError.Margin = new Padding(0);
            rbIconMainError.Name = "rbIconMainError";
            rbIconMainError.Size = new Size(159, 24);
            rbIconMainError.TabIndex = 4;
            rbIconMainError.Text = "Error";
            rbIconMainError.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainError.UseVisualStyleBackColor = true;
            // 
            // rbIconMainShieldWarningYellowBar
            // 
            rbIconMainShieldWarningYellowBar.AutoSize = true;
            rbIconMainShieldWarningYellowBar.Dock = DockStyle.Fill;
            rbIconMainShieldWarningYellowBar.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainShieldWarningYellowBar.Location = new Point(0, 202);
            rbIconMainShieldWarningYellowBar.Margin = new Padding(0);
            rbIconMainShieldWarningYellowBar.Name = "rbIconMainShieldWarningYellowBar";
            rbIconMainShieldWarningYellowBar.Size = new Size(159, 24);
            rbIconMainShieldWarningYellowBar.TabIndex = 8;
            rbIconMainShieldWarningYellowBar.Text = "Shield Warning";
            rbIconMainShieldWarningYellowBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainShieldWarningYellowBar.UseVisualStyleBackColor = true;
            // 
            // rbIconMainShieldBlueBar
            // 
            rbIconMainShieldBlueBar.AutoSize = true;
            rbIconMainShieldBlueBar.Dock = DockStyle.Fill;
            rbIconMainShieldBlueBar.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainShieldBlueBar.Location = new Point(0, 130);
            rbIconMainShieldBlueBar.Margin = new Padding(0);
            rbIconMainShieldBlueBar.Name = "rbIconMainShieldBlueBar";
            rbIconMainShieldBlueBar.Size = new Size(159, 24);
            rbIconMainShieldBlueBar.TabIndex = 5;
            rbIconMainShieldBlueBar.Text = "Shield - Blue Bar";
            rbIconMainShieldBlueBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainShieldBlueBar.UseVisualStyleBackColor = true;
            // 
            // rbIconMainShieldErrorRedBar
            // 
            rbIconMainShieldErrorRedBar.AutoSize = true;
            rbIconMainShieldErrorRedBar.Dock = DockStyle.Fill;
            rbIconMainShieldErrorRedBar.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainShieldErrorRedBar.Location = new Point(0, 226);
            rbIconMainShieldErrorRedBar.Margin = new Padding(0);
            rbIconMainShieldErrorRedBar.Name = "rbIconMainShieldErrorRedBar";
            rbIconMainShieldErrorRedBar.Size = new Size(159, 24);
            rbIconMainShieldErrorRedBar.TabIndex = 7;
            rbIconMainShieldErrorRedBar.Text = "Shield Error";
            rbIconMainShieldErrorRedBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainShieldErrorRedBar.UseVisualStyleBackColor = true;
            // 
            // rbIconMainShieldGrayBar
            // 
            rbIconMainShieldGrayBar.AutoSize = true;
            rbIconMainShieldGrayBar.Dock = DockStyle.Fill;
            rbIconMainShieldGrayBar.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainShieldGrayBar.Location = new Point(0, 154);
            rbIconMainShieldGrayBar.Margin = new Padding(0);
            rbIconMainShieldGrayBar.Name = "rbIconMainShieldGrayBar";
            rbIconMainShieldGrayBar.Size = new Size(159, 24);
            rbIconMainShieldGrayBar.TabIndex = 6;
            rbIconMainShieldGrayBar.Text = "Shield - Gray Bar";
            rbIconMainShieldGrayBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainShieldGrayBar.UseVisualStyleBackColor = true;
            // 
            // rbIconMainInformation
            // 
            rbIconMainInformation.AutoSize = true;
            rbIconMainInformation.Dock = DockStyle.Fill;
            rbIconMainInformation.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainInformation.Location = new Point(0, 24);
            rbIconMainInformation.Margin = new Padding(0);
            rbIconMainInformation.Name = "rbIconMainInformation";
            rbIconMainInformation.Size = new Size(159, 24);
            rbIconMainInformation.TabIndex = 1;
            rbIconMainInformation.Text = "Information";
            rbIconMainInformation.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainInformation.UseVisualStyleBackColor = true;
            // 
            // rbIconMainCustomID
            // 
            rbIconMainCustomID.AutoSize = true;
            rbIconMainCustomID.Dock = DockStyle.Fill;
            rbIconMainCustomID.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainCustomID.Location = new Point(0, 284);
            rbIconMainCustomID.Margin = new Padding(0);
            rbIconMainCustomID.Name = "rbIconMainCustomID";
            rbIconMainCustomID.Size = new Size(159, 24);
            rbIconMainCustomID.TabIndex = 11;
            rbIconMainCustomID.Text = "Custom (imageres.dll ID)";
            rbIconMainCustomID.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainCustomID.UseVisualStyleBackColor = true;
            rbIconMainCustomID.CheckedChanged += rbIconMainCustomID_CheckedChanged;
            // 
            // rbIconMainCustomFile
            // 
            rbIconMainCustomFile.AutoSize = true;
            rbIconMainCustomFile.Dock = DockStyle.Fill;
            rbIconMainCustomFile.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainCustomFile.Location = new Point(0, 260);
            rbIconMainCustomFile.Margin = new Padding(0);
            rbIconMainCustomFile.Name = "rbIconMainCustomFile";
            rbIconMainCustomFile.Size = new Size(159, 24);
            rbIconMainCustomFile.TabIndex = 10;
            rbIconMainCustomFile.Text = "Custom (File)";
            rbIconMainCustomFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainCustomFile.UseVisualStyleBackColor = true;
            // 
            // rbIconMainShield
            // 
            rbIconMainShield.AutoSize = true;
            rbIconMainShield.Dock = DockStyle.Fill;
            rbIconMainShield.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainShield.Location = new Point(0, 106);
            rbIconMainShield.Margin = new Padding(0);
            rbIconMainShield.Name = "rbIconMainShield";
            rbIconMainShield.Size = new Size(159, 24);
            rbIconMainShield.TabIndex = 3;
            rbIconMainShield.Text = "Shield";
            rbIconMainShield.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainShield.UseVisualStyleBackColor = true;
            // 
            // rbIconMainWarning
            // 
            rbIconMainWarning.AutoSize = true;
            rbIconMainWarning.Dock = DockStyle.Fill;
            rbIconMainWarning.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainWarning.Location = new Point(0, 48);
            rbIconMainWarning.Margin = new Padding(0);
            rbIconMainWarning.Name = "rbIconMainWarning";
            rbIconMainWarning.Size = new Size(159, 24);
            rbIconMainWarning.TabIndex = 2;
            rbIconMainWarning.Text = "Warning";
            rbIconMainWarning.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainWarning.UseVisualStyleBackColor = true;
            // 
            // rbIconMainNone
            // 
            rbIconMainNone.AutoSize = true;
            rbIconMainNone.Checked = true;
            rbIconMainNone.Dock = DockStyle.Fill;
            rbIconMainNone.ImageAlign = ContentAlignment.MiddleLeft;
            rbIconMainNone.Location = new Point(0, 0);
            rbIconMainNone.Margin = new Padding(0);
            rbIconMainNone.Name = "rbIconMainNone";
            rbIconMainNone.Size = new Size(159, 24);
            rbIconMainNone.TabIndex = 0;
            rbIconMainNone.TabStop = true;
            rbIconMainNone.Text = "None";
            rbIconMainNone.TextImageRelation = TextImageRelation.ImageBeforeText;
            rbIconMainNone.UseVisualStyleBackColor = true;
            // 
            // labelSame
            // 
            labelSame.Anchor = AnchorStyles.Left;
            labelSame.AutoSize = true;
            labelSame.Location = new Point(3, 312);
            labelSame.Name = "labelSame";
            labelSame.Size = new Size(36, 15);
            labelSame.TabIndex = 12;
            labelSame.Text = "Same";
            // 
            // btnShowDialog
            // 
            btnShowDialog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowDialog.Location = new Point(8, 464);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(140, 42);
            btnShowDialog.TabIndex = 11;
            btnShowDialog.Text = "Show Dialog";
            btnShowDialog.UseVisualStyleBackColor = true;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(5, 161);
            lblFooter.Margin = new Padding(5, 5, 5, 2);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(44, 15);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "Footer:";
            // 
            // txtFooter
            // 
            txtFooter.Location = new Point(5, 180);
            txtFooter.Margin = new Padding(5, 2, 5, 5);
            txtFooter.Name = "txtFooter";
            txtFooter.Size = new Size(304, 23);
            txtFooter.TabIndex = 5;
            // 
            // chkVerification
            // 
            chkVerification.AutoSize = true;
            chkVerification.Location = new Point(3, 3);
            chkVerification.Name = "chkVerification";
            chkVerification.Size = new Size(120, 19);
            chkVerification.TabIndex = 10;
            chkVerification.Text = "Show verification:";
            chkVerification.UseVisualStyleBackColor = true;
            // 
            // lblExpandedInfo
            // 
            lblExpandedInfo.AutoSize = true;
            lblExpandedInfo.Location = new Point(5, 213);
            lblExpandedInfo.Margin = new Padding(5, 5, 5, 2);
            lblExpandedInfo.Name = "lblExpandedInfo";
            lblExpandedInfo.Size = new Size(124, 15);
            lblExpandedInfo.TabIndex = 8;
            lblExpandedInfo.Text = "Expanded Information";
            // 
            // txtExpandedInfo
            // 
            txtExpandedInfo.Location = new Point(5, 232);
            txtExpandedInfo.Margin = new Padding(5, 2, 5, 5);
            txtExpandedInfo.Multiline = true;
            txtExpandedInfo.Name = "txtExpandedInfo";
            txtExpandedInfo.Size = new Size(304, 92);
            txtExpandedInfo.TabIndex = 9;
            // 
            // textBoxCustomIconMainPath
            // 
            textBoxCustomIconMainPath.Location = new Point(9, 23);
            textBoxCustomIconMainPath.Margin = new Padding(2);
            textBoxCustomIconMainPath.Name = "textBoxCustomIconMainPath";
            textBoxCustomIconMainPath.Size = new Size(225, 23);
            textBoxCustomIconMainPath.TabIndex = 12;
            // 
            // buttonBrowseCustomIconMain
            // 
            buttonBrowseCustomIconMain.Location = new Point(236, 20);
            buttonBrowseCustomIconMain.Margin = new Padding(2);
            buttonBrowseCustomIconMain.Name = "buttonBrowseCustomIconMain";
            buttonBrowseCustomIconMain.Size = new Size(78, 26);
            buttonBrowseCustomIconMain.TabIndex = 13;
            buttonBrowseCustomIconMain.Text = "Browse";
            buttonBrowseCustomIconMain.UseVisualStyleBackColor = true;
            buttonBrowseCustomIconMain.Click += buttonBrowseCustomIcon_Click;
            // 
            // groupBoxCustomIconMainFile
            // 
            groupBoxCustomIconMainFile.Controls.Add(textBoxCustomIconMainPath);
            groupBoxCustomIconMainFile.Controls.Add(buttonBrowseCustomIconMain);
            groupBoxCustomIconMainFile.Enabled = false;
            groupBoxCustomIconMainFile.Location = new Point(483, 394);
            groupBoxCustomIconMainFile.Margin = new Padding(2);
            groupBoxCustomIconMainFile.Name = "groupBoxCustomIconMainFile";
            groupBoxCustomIconMainFile.Padding = new Padding(2);
            groupBoxCustomIconMainFile.Size = new Size(318, 55);
            groupBoxCustomIconMainFile.TabIndex = 14;
            groupBoxCustomIconMainFile.TabStop = false;
            groupBoxCustomIconMainFile.Text = "Custom Main Icon (File)";
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(186, 424);
            buttonTest.Margin = new Padding(2);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(78, 25);
            buttonTest.TabIndex = 15;
            buttonTest.Text = "Test";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Visible = false;
            buttonTest.Click += buttonTest_Click;
            // 
            // groupBoxBarColor
            // 
            groupBoxBarColor.Controls.Add(rbBarColorNone);
            groupBoxBarColor.Controls.Add(rbBarColorDefault);
            groupBoxBarColor.Controls.Add(rbBarColorGreen);
            groupBoxBarColor.Controls.Add(rbBarColorRed);
            groupBoxBarColor.Controls.Add(rbBarColorYellow);
            groupBoxBarColor.Controls.Add(rbBarColorGray);
            groupBoxBarColor.Controls.Add(rbBarColorBlue);
            groupBoxBarColor.Location = new Point(334, 198);
            groupBoxBarColor.Margin = new Padding(2);
            groupBoxBarColor.Name = "groupBoxBarColor";
            groupBoxBarColor.Padding = new Padding(2);
            groupBoxBarColor.Size = new Size(222, 116);
            groupBoxBarColor.TabIndex = 16;
            groupBoxBarColor.TabStop = false;
            groupBoxBarColor.Text = "Bar Color";
            // 
            // rbBarColorNone
            // 
            rbBarColorNone.AutoSize = true;
            rbBarColorNone.Location = new Point(27, 87);
            rbBarColorNone.Margin = new Padding(2);
            rbBarColorNone.Name = "rbBarColorNone";
            rbBarColorNone.Size = new Size(86, 19);
            rbBarColorNone.TabIndex = 6;
            rbBarColorNone.Text = "Force None";
            rbBarColorNone.UseVisualStyleBackColor = true;
            // 
            // rbBarColorDefault
            // 
            rbBarColorDefault.AutoSize = true;
            rbBarColorDefault.Checked = true;
            rbBarColorDefault.Location = new Point(27, 27);
            rbBarColorDefault.Margin = new Padding(2);
            rbBarColorDefault.Name = "rbBarColorDefault";
            rbBarColorDefault.Size = new Size(63, 19);
            rbBarColorDefault.TabIndex = 5;
            rbBarColorDefault.TabStop = true;
            rbBarColorDefault.Text = "Default";
            rbBarColorDefault.UseVisualStyleBackColor = true;
            // 
            // rbBarColorGreen
            // 
            rbBarColorGreen.AutoSize = true;
            rbBarColorGreen.Location = new Point(97, 27);
            rbBarColorGreen.Margin = new Padding(2);
            rbBarColorGreen.Name = "rbBarColorGreen";
            rbBarColorGreen.Size = new Size(56, 19);
            rbBarColorGreen.TabIndex = 4;
            rbBarColorGreen.Text = "Green";
            rbBarColorGreen.UseVisualStyleBackColor = true;
            // 
            // rbBarColorRed
            // 
            rbBarColorRed.AutoSize = true;
            rbBarColorRed.Location = new Point(27, 67);
            rbBarColorRed.Margin = new Padding(2);
            rbBarColorRed.Name = "rbBarColorRed";
            rbBarColorRed.Size = new Size(45, 19);
            rbBarColorRed.TabIndex = 3;
            rbBarColorRed.Text = "Red";
            rbBarColorRed.UseVisualStyleBackColor = true;
            // 
            // rbBarColorYellow
            // 
            rbBarColorYellow.AutoSize = true;
            rbBarColorYellow.Location = new Point(97, 47);
            rbBarColorYellow.Margin = new Padding(2);
            rbBarColorYellow.Name = "rbBarColorYellow";
            rbBarColorYellow.Size = new Size(59, 19);
            rbBarColorYellow.TabIndex = 2;
            rbBarColorYellow.Text = "Yellow";
            rbBarColorYellow.UseVisualStyleBackColor = true;
            // 
            // rbBarColorGray
            // 
            rbBarColorGray.AutoSize = true;
            rbBarColorGray.Location = new Point(27, 47);
            rbBarColorGray.Margin = new Padding(2);
            rbBarColorGray.Name = "rbBarColorGray";
            rbBarColorGray.Size = new Size(49, 19);
            rbBarColorGray.TabIndex = 1;
            rbBarColorGray.Text = "Gray";
            rbBarColorGray.UseVisualStyleBackColor = true;
            // 
            // rbBarColorBlue
            // 
            rbBarColorBlue.AutoSize = true;
            rbBarColorBlue.Location = new Point(97, 67);
            rbBarColorBlue.Margin = new Padding(2);
            rbBarColorBlue.Name = "rbBarColorBlue";
            rbBarColorBlue.Size = new Size(48, 19);
            rbBarColorBlue.TabIndex = 0;
            rbBarColorBlue.Text = "Blue";
            rbBarColorBlue.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustomIconMainID
            // 
            groupBoxCustomIconMainID.Controls.Add(textBoxCustomIconMainID);
            groupBoxCustomIconMainID.Enabled = false;
            groupBoxCustomIconMainID.Location = new Point(334, 394);
            groupBoxCustomIconMainID.Margin = new Padding(2);
            groupBoxCustomIconMainID.Name = "groupBoxCustomIconMainID";
            groupBoxCustomIconMainID.Padding = new Padding(2);
            groupBoxCustomIconMainID.Size = new Size(145, 55);
            groupBoxCustomIconMainID.TabIndex = 17;
            groupBoxCustomIconMainID.TabStop = false;
            groupBoxCustomIconMainID.Text = "Custom Main Icon (ID)";
            // 
            // textBoxCustomIconMainID
            // 
            textBoxCustomIconMainID.Location = new Point(15, 23);
            textBoxCustomIconMainID.Margin = new Padding(2);
            textBoxCustomIconMainID.Name = "textBoxCustomIconMainID";
            textBoxCustomIconMainID.Size = new Size(125, 23);
            textBoxCustomIconMainID.TabIndex = 14;
            textBoxCustomIconMainID.Enter += textBoxCustomIconMainID_Enter;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(5, 109);
            lblMessage.Margin = new Padding(5, 5, 5, 2);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(56, 15);
            lblMessage.TabIndex = 18;
            lblMessage.Text = "Message:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(5, 128);
            txtMessage.Margin = new Padding(5, 2, 5, 5);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(304, 23);
            txtMessage.TabIndex = 19;
            // 
            // textBoxVerification
            // 
            textBoxVerification.Location = new Point(128, 2);
            textBoxVerification.Margin = new Padding(2);
            textBoxVerification.Name = "textBoxVerification";
            textBoxVerification.PlaceholderText = " Don't ask again";
            textBoxVerification.Size = new Size(176, 23);
            textBoxVerification.TabIndex = 20;
            // 
            // buttonImageResIcons
            // 
            buttonImageResIcons.Location = new Point(165, 474);
            buttonImageResIcons.Margin = new Padding(2);
            buttonImageResIcons.Name = "buttonImageResIcons";
            buttonImageResIcons.Size = new Size(120, 27);
            buttonImageResIcons.TabIndex = 21;
            buttonImageResIcons.Text = "View Icon IDs";
            buttonImageResIcons.UseVisualStyleBackColor = true;
            buttonImageResIcons.Click += buttonImageResIcons_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblTitle);
            flowLayoutPanel1.Controls.Add(txtTitle);
            flowLayoutPanel1.Controls.Add(lblHeading);
            flowLayoutPanel1.Controls.Add(txtHeading);
            flowLayoutPanel1.Controls.Add(lblMessage);
            flowLayoutPanel1.Controls.Add(txtMessage);
            flowLayoutPanel1.Controls.Add(lblFooter);
            flowLayoutPanel1.Controls.Add(txtFooter);
            flowLayoutPanel1.Controls.Add(lblExpandedInfo);
            flowLayoutPanel1.Controls.Add(txtExpandedInfo);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelVerification);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(317, 374);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // flowLayoutPanelVerification
            // 
            flowLayoutPanelVerification.AutoSize = true;
            flowLayoutPanelVerification.Controls.Add(chkVerification);
            flowLayoutPanelVerification.Controls.Add(textBoxVerification);
            flowLayoutPanelVerification.Location = new Point(3, 334);
            flowLayoutPanelVerification.Margin = new Padding(3, 5, 3, 3);
            flowLayoutPanelVerification.Name = "flowLayoutPanelVerification";
            flowLayoutPanelVerification.Size = new Size(306, 27);
            flowLayoutPanelVerification.TabIndex = 24;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.ForeColor = SystemColors.WindowFrame;
            labelVersion.Location = new Point(12, 443);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(51, 15);
            labelVersion.TabIndex = 23;
            labelVersion.Text = "Version: ";
            // 
            // groupBoxCustomIconTitleID
            // 
            groupBoxCustomIconTitleID.Controls.Add(textBoxCustomIconTitleID);
            groupBoxCustomIconTitleID.Enabled = false;
            groupBoxCustomIconTitleID.Location = new Point(334, 453);
            groupBoxCustomIconTitleID.Margin = new Padding(2);
            groupBoxCustomIconTitleID.Name = "groupBoxCustomIconTitleID";
            groupBoxCustomIconTitleID.Padding = new Padding(2);
            groupBoxCustomIconTitleID.Size = new Size(145, 55);
            groupBoxCustomIconTitleID.TabIndex = 19;
            groupBoxCustomIconTitleID.TabStop = false;
            groupBoxCustomIconTitleID.Text = "Custom Title Icon (ID)";
            // 
            // textBoxCustomIconTitleID
            // 
            textBoxCustomIconTitleID.Location = new Point(15, 23);
            textBoxCustomIconTitleID.Margin = new Padding(2);
            textBoxCustomIconTitleID.Name = "textBoxCustomIconTitleID";
            textBoxCustomIconTitleID.Size = new Size(125, 23);
            textBoxCustomIconTitleID.TabIndex = 14;
            textBoxCustomIconTitleID.Enter += textBoxCustomIconTitleID_Enter;
            // 
            // groupBoxCustomIconTitleFile
            // 
            groupBoxCustomIconTitleFile.Controls.Add(textBoxCustomIconTitlePath);
            groupBoxCustomIconTitleFile.Controls.Add(buttonBrowseCustomIconTitle);
            groupBoxCustomIconTitleFile.Enabled = false;
            groupBoxCustomIconTitleFile.Location = new Point(483, 453);
            groupBoxCustomIconTitleFile.Margin = new Padding(2);
            groupBoxCustomIconTitleFile.Name = "groupBoxCustomIconTitleFile";
            groupBoxCustomIconTitleFile.Padding = new Padding(2);
            groupBoxCustomIconTitleFile.Size = new Size(318, 55);
            groupBoxCustomIconTitleFile.TabIndex = 18;
            groupBoxCustomIconTitleFile.TabStop = false;
            groupBoxCustomIconTitleFile.Text = "Custom Title Icon (File)";
            // 
            // textBoxCustomIconTitlePath
            // 
            textBoxCustomIconTitlePath.Location = new Point(9, 23);
            textBoxCustomIconTitlePath.Margin = new Padding(2);
            textBoxCustomIconTitlePath.Name = "textBoxCustomIconTitlePath";
            textBoxCustomIconTitlePath.Size = new Size(225, 23);
            textBoxCustomIconTitlePath.TabIndex = 12;
            // 
            // buttonBrowseCustomIconTitle
            // 
            buttonBrowseCustomIconTitle.Location = new Point(236, 20);
            buttonBrowseCustomIconTitle.Margin = new Padding(2);
            buttonBrowseCustomIconTitle.Name = "buttonBrowseCustomIconTitle";
            buttonBrowseCustomIconTitle.Size = new Size(78, 26);
            buttonBrowseCustomIconTitle.TabIndex = 13;
            buttonBrowseCustomIconTitle.Text = "Browse";
            buttonBrowseCustomIconTitle.UseVisualStyleBackColor = true;
            buttonBrowseCustomIconTitle.Click += buttonBrowseCustomIconTitle_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 517);
            Controls.Add(groupBoxCustomIconTitleID);
            Controls.Add(groupBoxCustomIconTitleFile);
            Controls.Add(labelVersion);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonImageResIcons);
            Controls.Add(groupBoxCustomIconMainID);
            Controls.Add(groupBoxBarColor);
            Controls.Add(buttonTest);
            Controls.Add(groupBoxCustomIconMainFile);
            Controls.Add(btnShowDialog);
            Controls.Add(gbIconMain);
            Controls.Add(gbButtons);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Task Dialog Generator";
            Load += MainForm_Load;
            gbButtons.ResumeLayout(false);
            gbButtons.PerformLayout();
            gbIconMain.ResumeLayout(false);
            gbIconMain.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutTitleIconSelect.ResumeLayout(false);
            tableLayoutTitleIconSelect.PerformLayout();
            tableLayoutMainIconSelect.ResumeLayout(false);
            tableLayoutMainIconSelect.PerformLayout();
            groupBoxCustomIconMainFile.ResumeLayout(false);
            groupBoxCustomIconMainFile.PerformLayout();
            groupBoxBarColor.ResumeLayout(false);
            groupBoxBarColor.PerformLayout();
            groupBoxCustomIconMainID.ResumeLayout(false);
            groupBoxCustomIconMainID.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanelVerification.ResumeLayout(false);
            flowLayoutPanelVerification.PerformLayout();
            groupBoxCustomIconTitleID.ResumeLayout(false);
            groupBoxCustomIconTitleID.PerformLayout();
            groupBoxCustomIconTitleFile.ResumeLayout(false);
            groupBoxCustomIconTitleFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtHeading;
        private Label lblTitle;
        private Label lblHeading;
        private GroupBox gbButtons;
        private RadioButton rbRetryCancel;
        private RadioButton rbAbortRetryIgnore;
        private RadioButton rbYesNoCancel;
        private RadioButton rbYesNo;
        private RadioButton rbOkCancel;
        private RadioButton rbOk;
        private GroupBox gbIconMain;
        private RadioButton rbIconMainError;
        private RadioButton rbIconMainShield;
        private RadioButton rbIconMainWarning;
        private RadioButton rbIconMainInformation;
        private RadioButton rbIconMainNone;
        private Button btnShowDialog;
        private Label lblFooter;
        private TextBox txtFooter;
        private CheckBox chkVerification;
        private Label lblExpandedInfo;
        private TextBox txtExpandedInfo;
        private RadioButton rbIconMainShieldSuccessGreenBar;
        private RadioButton rbIconMainShieldWarningYellowBar;
        private RadioButton rbIconMainShieldErrorRedBar;
        private RadioButton rbIconMainShieldGrayBar;
        private RadioButton rbIconMainShieldBlueBar;
        private RadioButton rbIconMainCustomFile;
        private TextBox textBoxCustomIconMainPath;
        private Button buttonBrowseCustomIconMain;
        private GroupBox groupBoxCustomIconMainFile;
        private Button buttonTest;
        private GroupBox groupBoxBarColor;
        private RadioButton rbBarColorRed;
        private RadioButton rbBarColorYellow;
        private RadioButton rbBarColorGray;
        private RadioButton rbBarColorBlue;
        private RadioButton rbBarColorDefault;
        private RadioButton rbBarColorGreen;
        private RadioButton rbIconMainCustomID;
        private GroupBox groupBoxCustomIconMainID;
        private TextBox textBoxCustomIconMainID;
        private RadioButton rbBarColorNone;
        private Label lblMessage;
        private TextBox txtMessage;
        private TextBox textBoxVerification;
        private Button buttonImageResIcons;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelVersion;
        private FlowLayoutPanel flowLayoutPanelVerification;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutMainIconSelect;
        private TableLayoutPanel tableLayoutTitleIconSelect;
        private RadioButton rbIconTitleNone;
        private RadioButton rbIconTitleShieldSuccess;
        private RadioButton rbIconTitleError;
        private RadioButton rbIconTitleShieldWarning;
        private RadioButton rbIconTitleShieldBlueBar;
        private RadioButton rbIconTitleShieldError;
        private RadioButton rbIconTitleShieldGrayBar;
        private RadioButton rbIconTitleInformation;
        private RadioButton rbIconTitleCustomID;
        private RadioButton rbIconTitleCustomFile;
        private RadioButton rbIconTitleShield;
        private RadioButton rbIconTitleWarning;
        private Label labelSelectTitleIcon;
        private Label labelSelectMainIcon;
        private RadioButton rbIconTitleSame;
        private Label labelSame;
        private GroupBox groupBoxCustomIconTitleID;
        private TextBox textBoxCustomIconTitleID;
        private GroupBox groupBoxCustomIconTitleFile;
        private TextBox textBoxCustomIconTitlePath;
        private Button buttonBrowseCustomIconTitle;
    }
}