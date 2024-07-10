using System.Runtime.Versioning;
using System.Resources;


namespace Frontend.Forms
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            pnlButtons = new Panel();
            pbConnection = new PictureBox();
            lblConnectionStatus = new Label();
            lblConnectionText = new Label();
            btnConnect = new Button();
            cmbPort = new ComboBox();
            pbLogo = new PictureBox();
            btnScanPort = new Button();
            pnlConnection = new Panel();
            grpPermissions = new GroupBox();
            grpScan = new GroupBox();
            grpInfo = new GroupBox();
            tblInfo = new TableLayoutPanel();
            lblName = new Label();
            lblSex = new Label();
            lblDoB = new Label();
            lblPhone = new Label();
            dtpValid = new DateTimePicker();
            lblValid = new Label();
            cmbSubscription = new ComboBox();
            lblEMail = new Label();
            txtEmail = new TextBox();
            lblSubscription = new Label();
            txtNumber = new TextBox();
            txtName = new TextBox();
            dtpDoB = new DateTimePicker();
            cmbSex = new ComboBox();
            lblId = new Label();
            txtId = new TextBox();
            btnScan = new Button();
            grpQual = new GroupBox();
            pbElectronics = new PictureBox();
            pbComputers = new PictureBox();
            pbTools = new PictureBox();
            pbLCD = new PictureBox();
            pbRaise3D = new PictureBox();
            pbCreality = new PictureBox();
            lblElectronics = new Label();
            lblComputers = new Label();
            lblTools = new Label();
            lblLCD = new Label();
            lblRaise3D = new Label();
            lblCreality = new Label();
            lblPremFilCurrent = new Label();
            lblLaserCutterCurrent = new Label();
            lblCNCMillCurrent = new Label();
            lblResinCurrent = new Label();
            lblStdFilCurrent = new Label();
            lblSelection = new Label();
            numResin = new NumericUpDown();
            numPremFil = new NumericUpDown();
            numLsrCut = new NumericUpDown();
            numCNCMill = new NumericUpDown();
            numStdFil = new NumericUpDown();
            txtSelect = new TextBox();
            lblPremFil = new Label();
            lblLsrCut = new Label();
            lblCNCMill = new Label();
            lblRes = new Label();
            lblStdFil = new Label();
            grpdgv = new GroupBox();
            cbEdit = new CheckBox();
            btnClear = new Button();
            txtValue = new TextBox();
            dgvData = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            btnSavePerms = new Button();
            cmbValue = new ComboBox();
            err = new ErrorProvider(components);
            tmr = new System.Windows.Forms.Timer(components);
            anim = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConnection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlConnection.SuspendLayout();
            grpPermissions.SuspendLayout();
            grpScan.SuspendLayout();
            grpInfo.SuspendLayout();
            tblInfo.SuspendLayout();
            grpQual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbElectronics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbComputers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTools).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLCD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRaise3D).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCreality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numResin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPremFil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLsrCut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCNCMill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStdFil).BeginInit();
            grpdgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(84, 84, 108);
            pnlButtons.BackgroundImage = (Image)resources.GetObject("pnlButtons.BackgroundImage");
            pnlButtons.BackgroundImageLayout = ImageLayout.Zoom;
            pnlButtons.Controls.Add(pbConnection);
            pnlButtons.Controls.Add(lblConnectionStatus);
            pnlButtons.Controls.Add(lblConnectionText);
            pnlButtons.Controls.Add(btnConnect);
            pnlButtons.Controls.Add(cmbPort);
            pnlButtons.Controls.Add(pbLogo);
            pnlButtons.Controls.Add(btnScanPort);
            pnlButtons.Dock = DockStyle.Left;
            pnlButtons.Location = new Point(0, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(230, 569);
            pnlButtons.TabIndex = 0;
            pnlButtons.Tag = "";
            // 
            // pbConnection
            // 
            pbConnection.BackColor = Color.Transparent;
            pbConnection.Image = (Image)resources.GetObject("pbConnection.Image");
            pbConnection.Location = new Point(201, 210);
            pbConnection.Name = "pbConnection";
            pbConnection.Size = new Size(15, 15);
            pbConnection.SizeMode = PictureBoxSizeMode.StretchImage;
            pbConnection.TabIndex = 8;
            pbConnection.TabStop = false;
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.AutoSize = true;
            lblConnectionStatus.BackColor = Color.Transparent;
            lblConnectionStatus.ForeColor = Color.Gold;
            lblConnectionStatus.Location = new Point(116, 210);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(79, 15);
            lblConnectionStatus.TabIndex = 7;
            lblConnectionStatus.Text = "Disconnected";
            // 
            // lblConnectionText
            // 
            lblConnectionText.AutoSize = true;
            lblConnectionText.BackColor = Color.Transparent;
            lblConnectionText.ForeColor = Color.Gold;
            lblConnectionText.Location = new Point(3, 210);
            lblConnectionText.Name = "lblConnectionText";
            lblConnectionText.Size = new Size(107, 15);
            lblConnectionText.TabIndex = 6;
            lblConnectionText.Text = "Connection Status:";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Gold;
            btnConnect.Enabled = false;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.Black;
            btnConnect.Location = new Point(25, 345);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(176, 28);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // cmbPort
            // 
            cmbPort.BackColor = Color.FromArgb(100, 100, 120);
            cmbPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort.Enabled = false;
            cmbPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPort.FormattingEnabled = true;
            cmbPort.Location = new Point(25, 297);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(176, 25);
            cmbPort.TabIndex = 5;
            cmbPort.SelectedIndexChanged += cmbPort_SelectedIndexChanged;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(25, 15);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(176, 174);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnScanPort
            // 
            btnScanPort.BackColor = Color.Gold;
            btnScanPort.FlatStyle = FlatStyle.Flat;
            btnScanPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScanPort.ForeColor = Color.Black;
            btnScanPort.Location = new Point(25, 246);
            btnScanPort.Name = "btnScanPort";
            btnScanPort.Size = new Size(176, 28);
            btnScanPort.TabIndex = 2;
            btnScanPort.Text = "Scan Ports";
            btnScanPort.UseVisualStyleBackColor = false;
            btnScanPort.Click += btnScanPort_Click;
            // 
            // pnlConnection
            // 
            pnlConnection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlConnection.AutoSize = true;
            pnlConnection.BackColor = Color.FromArgb(66, 66, 86);
            pnlConnection.Controls.Add(grpPermissions);
            pnlConnection.Controls.Add(grpdgv);
            pnlConnection.Location = new Point(236, 12);
            pnlConnection.Name = "pnlConnection";
            pnlConnection.Size = new Size(931, 551);
            pnlConnection.TabIndex = 1;
            pnlConnection.Tag = "";
            // 
            // grpPermissions
            // 
            grpPermissions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpPermissions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpPermissions.Controls.Add(grpScan);
            grpPermissions.Controls.Add(grpQual);
            grpPermissions.Controls.Add(lblPremFilCurrent);
            grpPermissions.Controls.Add(lblLaserCutterCurrent);
            grpPermissions.Controls.Add(lblCNCMillCurrent);
            grpPermissions.Controls.Add(lblResinCurrent);
            grpPermissions.Controls.Add(lblStdFilCurrent);
            grpPermissions.Controls.Add(lblSelection);
            grpPermissions.Controls.Add(numResin);
            grpPermissions.Controls.Add(numPremFil);
            grpPermissions.Controls.Add(numLsrCut);
            grpPermissions.Controls.Add(numCNCMill);
            grpPermissions.Controls.Add(numStdFil);
            grpPermissions.Controls.Add(txtSelect);
            grpPermissions.Controls.Add(lblPremFil);
            grpPermissions.Controls.Add(lblLsrCut);
            grpPermissions.Controls.Add(lblCNCMill);
            grpPermissions.Controls.Add(lblRes);
            grpPermissions.Controls.Add(lblStdFil);
            grpPermissions.ForeColor = Color.WhiteSmoke;
            grpPermissions.Location = new Point(308, 6);
            grpPermissions.Name = "grpPermissions";
            grpPermissions.Size = new Size(612, 540);
            grpPermissions.TabIndex = 0;
            grpPermissions.TabStop = false;
            grpPermissions.Text = "Info";
            // 
            // grpScan
            // 
            grpScan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpScan.Controls.Add(grpInfo);
            grpScan.Controls.Add(lblId);
            grpScan.Controls.Add(txtId);
            grpScan.Controls.Add(btnScan);
            grpScan.ForeColor = Color.WhiteSmoke;
            grpScan.Location = new Point(6, 239);
            grpScan.Name = "grpScan";
            grpScan.Size = new Size(600, 295);
            grpScan.TabIndex = 1;
            grpScan.TabStop = false;
            grpScan.Text = "Scan";
            // 
            // grpInfo
            // 
            grpInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpInfo.Controls.Add(tblInfo);
            grpInfo.ForeColor = Color.WhiteSmoke;
            grpInfo.Location = new Point(125, 10);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(469, 279);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "Info";
            // 
            // tblInfo
            // 
            tblInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblInfo.ColumnCount = 2;
            tblInfo.ColumnStyles.Add(new ColumnStyle());
            tblInfo.ColumnStyles.Add(new ColumnStyle());
            tblInfo.Controls.Add(lblName, 0, 0);
            tblInfo.Controls.Add(lblSex, 0, 1);
            tblInfo.Controls.Add(lblDoB, 0, 2);
            tblInfo.Controls.Add(lblPhone, 0, 3);
            tblInfo.Controls.Add(dtpValid, 1, 6);
            tblInfo.Controls.Add(lblValid, 0, 6);
            tblInfo.Controls.Add(cmbSubscription, 1, 5);
            tblInfo.Controls.Add(lblEMail, 0, 4);
            tblInfo.Controls.Add(txtEmail, 1, 4);
            tblInfo.Controls.Add(lblSubscription, 0, 5);
            tblInfo.Controls.Add(txtNumber, 1, 3);
            tblInfo.Controls.Add(txtName, 1, 0);
            tblInfo.Controls.Add(dtpDoB, 1, 2);
            tblInfo.Controls.Add(cmbSex, 1, 1);
            tblInfo.Location = new Point(8, 31);
            tblInfo.Name = "tblInfo";
            tblInfo.RowCount = 7;
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tblInfo.Size = new Size(455, 233);
            tblInfo.TabIndex = 17;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.WhiteSmoke;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.ForeColor = Color.WhiteSmoke;
            lblSex.Location = new Point(3, 33);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(28, 15);
            lblSex.TabIndex = 8;
            lblSex.Text = "Sex:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.ForeColor = Color.WhiteSmoke;
            lblDoB.Location = new Point(3, 66);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(76, 15);
            lblDoB.TabIndex = 9;
            lblDoB.Text = "Date of birth:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = Color.WhiteSmoke;
            lblPhone.Location = new Point(3, 99);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(89, 15);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone number:";
            // 
            // dtpValid
            // 
            dtpValid.Location = new Point(111, 201);
            dtpValid.Name = "dtpValid";
            dtpValid.Size = new Size(342, 23);
            dtpValid.TabIndex = 7;
            // 
            // lblValid
            // 
            lblValid.AutoSize = true;
            lblValid.ForeColor = Color.WhiteSmoke;
            lblValid.Location = new Point(3, 198);
            lblValid.Name = "lblValid";
            lblValid.Size = new Size(62, 15);
            lblValid.TabIndex = 13;
            lblValid.Text = "Valid until:";
            // 
            // cmbSubscription
            // 
            cmbSubscription.BackColor = Color.WhiteSmoke;
            cmbSubscription.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubscription.ForeColor = Color.Black;
            cmbSubscription.FormattingEnabled = true;
            cmbSubscription.Location = new Point(111, 168);
            cmbSubscription.Name = "cmbSubscription";
            cmbSubscription.Size = new Size(342, 23);
            cmbSubscription.TabIndex = 6;
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.ForeColor = Color.WhiteSmoke;
            lblEMail.Location = new Point(3, 132);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(41, 15);
            lblEMail.TabIndex = 11;
            lblEMail.Text = "E-Mail";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(111, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(342, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblSubscription
            // 
            lblSubscription.AutoSize = true;
            lblSubscription.ForeColor = Color.WhiteSmoke;
            lblSubscription.Location = new Point(3, 165);
            lblSubscription.Name = "lblSubscription";
            lblSubscription.Size = new Size(102, 15);
            lblSubscription.TabIndex = 12;
            lblSubscription.Text = "Subscription type:";
            // 
            // txtNumber
            // 
            txtNumber.BackColor = Color.WhiteSmoke;
            txtNumber.ForeColor = Color.Black;
            txtNumber.Location = new Point(111, 102);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(342, 23);
            txtNumber.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(111, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(342, 23);
            txtName.TabIndex = 1;
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(111, 69);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(342, 23);
            dtpDoB.TabIndex = 3;
            // 
            // cmbSex
            // 
            cmbSex.BackColor = Color.WhiteSmoke;
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.DropDownWidth = 96;
            cmbSex.ForeColor = Color.Black;
            cmbSex.FormattingEnabled = true;
            cmbSex.Location = new Point(111, 36);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(342, 23);
            cmbSex.TabIndex = 2;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.WhiteSmoke;
            lblId.Location = new Point(6, 52);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 18;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.WhiteSmoke;
            txtId.ForeColor = Color.Black;
            txtId.Location = new Point(8, 82);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(113, 23);
            txtId.TabIndex = 17;
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.Gold;
            btnScan.Enabled = false;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScan.ForeColor = Color.Black;
            btnScan.Location = new Point(8, 22);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(111, 23);
            btnScan.TabIndex = 15;
            btnScan.Text = "Scan Code";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // grpQual
            // 
            grpQual.BackColor = Color.FromArgb(202, 202, 222);
            grpQual.Controls.Add(pbElectronics);
            grpQual.Controls.Add(pbComputers);
            grpQual.Controls.Add(pbTools);
            grpQual.Controls.Add(pbLCD);
            grpQual.Controls.Add(pbRaise3D);
            grpQual.Controls.Add(pbCreality);
            grpQual.Controls.Add(lblElectronics);
            grpQual.Controls.Add(lblComputers);
            grpQual.Controls.Add(lblTools);
            grpQual.Controls.Add(lblLCD);
            grpQual.Controls.Add(lblRaise3D);
            grpQual.Controls.Add(lblCreality);
            grpQual.ForeColor = SystemColors.GrayText;
            grpQual.Location = new Point(329, 67);
            grpQual.Name = "grpQual";
            grpQual.Size = new Size(278, 168);
            grpQual.TabIndex = 41;
            grpQual.TabStop = false;
            grpQual.Text = "Qualified for:";
            // 
            // pbElectronics
            // 
            pbElectronics.BackColor = Color.Transparent;
            pbElectronics.Image = (Image)resources.GetObject("pbElectronics.Image");
            pbElectronics.Location = new Point(153, 68);
            pbElectronics.Name = "pbElectronics";
            pbElectronics.Size = new Size(15, 15);
            pbElectronics.SizeMode = PictureBoxSizeMode.StretchImage;
            pbElectronics.TabIndex = 14;
            pbElectronics.TabStop = false;
            // 
            // pbComputers
            // 
            pbComputers.BackColor = Color.Transparent;
            pbComputers.Image = (Image)resources.GetObject("pbComputers.Image");
            pbComputers.Location = new Point(153, 49);
            pbComputers.Name = "pbComputers";
            pbComputers.Size = new Size(15, 15);
            pbComputers.SizeMode = PictureBoxSizeMode.StretchImage;
            pbComputers.TabIndex = 13;
            pbComputers.TabStop = false;
            // 
            // pbTools
            // 
            pbTools.BackColor = Color.Transparent;
            pbTools.Image = (Image)resources.GetObject("pbTools.Image");
            pbTools.Location = new Point(153, 31);
            pbTools.Name = "pbTools";
            pbTools.Size = new Size(15, 15);
            pbTools.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTools.TabIndex = 12;
            pbTools.TabStop = false;
            // 
            // pbLCD
            // 
            pbLCD.BackColor = Color.Transparent;
            pbLCD.Image = (Image)resources.GetObject("pbLCD.Image");
            pbLCD.Location = new Point(28, 68);
            pbLCD.Name = "pbLCD";
            pbLCD.Size = new Size(15, 15);
            pbLCD.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLCD.TabIndex = 11;
            pbLCD.TabStop = false;
            // 
            // pbRaise3D
            // 
            pbRaise3D.BackColor = Color.Transparent;
            pbRaise3D.Image = (Image)resources.GetObject("pbRaise3D.Image");
            pbRaise3D.Location = new Point(28, 49);
            pbRaise3D.Name = "pbRaise3D";
            pbRaise3D.Size = new Size(15, 15);
            pbRaise3D.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRaise3D.TabIndex = 10;
            pbRaise3D.TabStop = false;
            // 
            // pbCreality
            // 
            pbCreality.BackColor = Color.Transparent;
            pbCreality.Image = (Image)resources.GetObject("pbCreality.Image");
            pbCreality.Location = new Point(28, 31);
            pbCreality.Name = "pbCreality";
            pbCreality.Size = new Size(15, 15);
            pbCreality.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCreality.TabIndex = 9;
            pbCreality.TabStop = false;
            // 
            // lblElectronics
            // 
            lblElectronics.AutoSize = true;
            lblElectronics.Location = new Point(174, 68);
            lblElectronics.Name = "lblElectronics";
            lblElectronics.Size = new Size(64, 15);
            lblElectronics.TabIndex = 5;
            lblElectronics.Text = "Electronics";
            // 
            // lblComputers
            // 
            lblComputers.AutoSize = true;
            lblComputers.Location = new Point(174, 49);
            lblComputers.Name = "lblComputers";
            lblComputers.Size = new Size(66, 15);
            lblComputers.TabIndex = 4;
            lblComputers.Text = "Computers";
            // 
            // lblTools
            // 
            lblTools.AutoSize = true;
            lblTools.Location = new Point(174, 31);
            lblTools.Name = "lblTools";
            lblTools.Size = new Size(34, 15);
            lblTools.TabIndex = 3;
            lblTools.Text = "Tools";
            // 
            // lblLCD
            // 
            lblLCD.AutoSize = true;
            lblLCD.Location = new Point(49, 68);
            lblLCD.Name = "lblLCD";
            lblLCD.Size = new Size(72, 15);
            lblLCD.TabIndex = 2;
            lblLCD.Text = "LCD Printers";
            // 
            // lblRaise3D
            // 
            lblRaise3D.AutoSize = true;
            lblRaise3D.Location = new Point(49, 49);
            lblRaise3D.Name = "lblRaise3D";
            lblRaise3D.Size = new Size(51, 15);
            lblRaise3D.TabIndex = 1;
            lblRaise3D.Text = "Raise 3D";
            // 
            // lblCreality
            // 
            lblCreality.AutoSize = true;
            lblCreality.Location = new Point(49, 31);
            lblCreality.Name = "lblCreality";
            lblCreality.Size = new Size(90, 15);
            lblCreality.TabIndex = 0;
            lblCreality.Text = "Creality Printers";
            // 
            // lblPremFilCurrent
            // 
            lblPremFilCurrent.AutoSize = true;
            lblPremFilCurrent.ForeColor = Color.WhiteSmoke;
            lblPremFilCurrent.Location = new Point(264, 214);
            lblPremFilCurrent.Name = "lblPremFilCurrent";
            lblPremFilCurrent.Size = new Size(59, 15);
            lblPremFilCurrent.TabIndex = 40;
            lblPremFilCurrent.Text = "Currently:";
            // 
            // lblLaserCutterCurrent
            // 
            lblLaserCutterCurrent.AutoSize = true;
            lblLaserCutterCurrent.ForeColor = Color.WhiteSmoke;
            lblLaserCutterCurrent.Location = new Point(264, 176);
            lblLaserCutterCurrent.Name = "lblLaserCutterCurrent";
            lblLaserCutterCurrent.Size = new Size(59, 15);
            lblLaserCutterCurrent.TabIndex = 39;
            lblLaserCutterCurrent.Text = "Currently:";
            // 
            // lblCNCMillCurrent
            // 
            lblCNCMillCurrent.AutoSize = true;
            lblCNCMillCurrent.ForeColor = Color.WhiteSmoke;
            lblCNCMillCurrent.Location = new Point(264, 142);
            lblCNCMillCurrent.Name = "lblCNCMillCurrent";
            lblCNCMillCurrent.Size = new Size(59, 15);
            lblCNCMillCurrent.TabIndex = 38;
            lblCNCMillCurrent.Text = "Currently:";
            // 
            // lblResinCurrent
            // 
            lblResinCurrent.AutoSize = true;
            lblResinCurrent.ForeColor = Color.WhiteSmoke;
            lblResinCurrent.Location = new Point(264, 103);
            lblResinCurrent.Name = "lblResinCurrent";
            lblResinCurrent.Size = new Size(59, 15);
            lblResinCurrent.TabIndex = 37;
            lblResinCurrent.Text = "Currently:";
            // 
            // lblStdFilCurrent
            // 
            lblStdFilCurrent.AutoSize = true;
            lblStdFilCurrent.ForeColor = Color.WhiteSmoke;
            lblStdFilCurrent.Location = new Point(264, 69);
            lblStdFilCurrent.Name = "lblStdFilCurrent";
            lblStdFilCurrent.Size = new Size(59, 15);
            lblStdFilCurrent.TabIndex = 36;
            lblStdFilCurrent.Text = "Currently:";
            // 
            // lblSelection
            // 
            lblSelection.AutoSize = true;
            lblSelection.ForeColor = Color.WhiteSmoke;
            lblSelection.Location = new Point(9, 25);
            lblSelection.Name = "lblSelection";
            lblSelection.Size = new Size(58, 15);
            lblSelection.TabIndex = 35;
            lblSelection.Text = "Selection:";
            // 
            // numResin
            // 
            numResin.BackColor = Color.WhiteSmoke;
            numResin.ForeColor = Color.Black;
            numResin.Location = new Point(138, 101);
            numResin.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numResin.Name = "numResin";
            numResin.Size = new Size(120, 23);
            numResin.TabIndex = 28;
            // 
            // numPremFil
            // 
            numPremFil.BackColor = Color.WhiteSmoke;
            numPremFil.ForeColor = Color.Black;
            numPremFil.Location = new Point(138, 212);
            numPremFil.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPremFil.Name = "numPremFil";
            numPremFil.Size = new Size(120, 23);
            numPremFil.TabIndex = 27;
            // 
            // numLsrCut
            // 
            numLsrCut.BackColor = Color.WhiteSmoke;
            numLsrCut.DecimalPlaces = 2;
            numLsrCut.ForeColor = Color.Black;
            numLsrCut.Location = new Point(138, 174);
            numLsrCut.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numLsrCut.Name = "numLsrCut";
            numLsrCut.Size = new Size(120, 23);
            numLsrCut.TabIndex = 26;
            // 
            // numCNCMill
            // 
            numCNCMill.BackColor = Color.WhiteSmoke;
            numCNCMill.DecimalPlaces = 2;
            numCNCMill.ForeColor = Color.Black;
            numCNCMill.Location = new Point(138, 138);
            numCNCMill.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCNCMill.Name = "numCNCMill";
            numCNCMill.Size = new Size(120, 23);
            numCNCMill.TabIndex = 25;
            // 
            // numStdFil
            // 
            numStdFil.BackColor = Color.WhiteSmoke;
            numStdFil.ForeColor = Color.Black;
            numStdFil.Location = new Point(138, 67);
            numStdFil.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStdFil.Name = "numStdFil";
            numStdFil.Size = new Size(120, 23);
            numStdFil.TabIndex = 24;
            // 
            // txtSelect
            // 
            txtSelect.BackColor = Color.WhiteSmoke;
            txtSelect.ForeColor = Color.Black;
            txtSelect.Location = new Point(73, 22);
            txtSelect.Name = "txtSelect";
            txtSelect.ReadOnly = true;
            txtSelect.Size = new Size(534, 23);
            txtSelect.TabIndex = 23;
            // 
            // lblPremFil
            // 
            lblPremFil.AutoSize = true;
            lblPremFil.ForeColor = Color.WhiteSmoke;
            lblPremFil.Location = new Point(6, 214);
            lblPremFil.Name = "lblPremFil";
            lblPremFil.Size = new Size(126, 15);
            lblPremFil.TabIndex = 22;
            lblPremFil.Text = "Premium Filament (g):";
            // 
            // lblLsrCut
            // 
            lblLsrCut.AutoSize = true;
            lblLsrCut.ForeColor = Color.WhiteSmoke;
            lblLsrCut.Location = new Point(6, 176);
            lblLsrCut.Name = "lblLsrCut";
            lblLsrCut.Size = new Size(91, 15);
            lblLsrCut.TabIndex = 21;
            lblLsrCut.Text = "Laser Cutter (h):";
            // 
            // lblCNCMill
            // 
            lblCNCMill.AutoSize = true;
            lblCNCMill.ForeColor = Color.WhiteSmoke;
            lblCNCMill.Location = new Point(6, 140);
            lblCNCMill.Name = "lblCNCMill";
            lblCNCMill.Size = new Size(76, 15);
            lblCNCMill.TabIndex = 20;
            lblCNCMill.Text = "CNC Mill (h):";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.ForeColor = Color.WhiteSmoke;
            lblRes.Location = new Point(6, 103);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(56, 15);
            lblRes.TabIndex = 19;
            lblRes.Text = "Resin (g):";
            // 
            // lblStdFil
            // 
            lblStdFil.AutoSize = true;
            lblStdFil.ForeColor = Color.WhiteSmoke;
            lblStdFil.Location = new Point(6, 69);
            lblStdFil.Name = "lblStdFil";
            lblStdFil.Size = new Size(124, 15);
            lblStdFil.TabIndex = 18;
            lblStdFil.Text = "Standard Filament (g):";
            // 
            // grpdgv
            // 
            grpdgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpdgv.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpdgv.Controls.Add(cbEdit);
            grpdgv.Controls.Add(btnClear);
            grpdgv.Controls.Add(txtValue);
            grpdgv.Controls.Add(dgvData);
            grpdgv.Controls.Add(btnSavePerms);
            grpdgv.Controls.Add(cmbValue);
            grpdgv.ForeColor = Color.WhiteSmoke;
            grpdgv.Location = new Point(3, 6);
            grpdgv.Name = "grpdgv";
            grpdgv.Size = new Size(299, 540);
            grpdgv.TabIndex = 4;
            grpdgv.TabStop = false;
            grpdgv.Text = "Users";
            // 
            // cbEdit
            // 
            cbEdit.AutoSize = true;
            cbEdit.ForeColor = Color.WhiteSmoke;
            cbEdit.Location = new Point(6, 22);
            cbEdit.Name = "cbEdit";
            cbEdit.Size = new Size(80, 19);
            cbEdit.TabIndex = 19;
            cbEdit.Text = "Edit Mode";
            cbEdit.UseVisualStyleBackColor = true;
            cbEdit.CheckedChanged += cbEdit_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(189, 48);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtValue
            // 
            txtValue.BackColor = Color.WhiteSmoke;
            txtValue.ForeColor = Color.Black;
            txtValue.Location = new Point(6, 106);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(287, 23);
            txtValue.TabIndex = 2;
            txtValue.TextChanged += txtValue_TextChanged;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvData.BackgroundColor = Color.FromArgb(100, 100, 120);
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Id, Username });
            dgvData.Location = new Point(6, 142);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(287, 392);
            dgvData.TabIndex = 1;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Username.DataPropertyName = "Name";
            Username.HeaderText = "Name";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // btnSavePerms
            // 
            btnSavePerms.BackColor = Color.Gold;
            btnSavePerms.Enabled = false;
            btnSavePerms.FlatStyle = FlatStyle.Flat;
            btnSavePerms.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSavePerms.ForeColor = Color.Black;
            btnSavePerms.Location = new Point(189, 19);
            btnSavePerms.Name = "btnSavePerms";
            btnSavePerms.Size = new Size(104, 23);
            btnSavePerms.TabIndex = 16;
            btnSavePerms.Text = "Save Changes";
            btnSavePerms.UseVisualStyleBackColor = false;
            btnSavePerms.Click += btnSavePerms_Click;
            // 
            // cmbValue
            // 
            cmbValue.BackColor = Color.WhiteSmoke;
            cmbValue.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbValue.ForeColor = Color.Black;
            cmbValue.FormattingEnabled = true;
            cmbValue.Location = new Point(6, 77);
            cmbValue.Name = "cmbValue";
            cmbValue.Size = new Size(287, 23);
            cmbValue.TabIndex = 3;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // tmr
            // 
            tmr.Enabled = true;
            tmr.Interval = 350;
            tmr.Tick += tmr_Tick;
            // 
            // anim
            // 
            anim.Enabled = true;
            anim.Interval = 35;
            anim.Tick += anim_Tick;
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1179, 569);
            Controls.Add(pnlConnection);
            Controls.Add(pnlButtons);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 490);
            Name = "frmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Garaža Makerspace";
            Load += frmStart_Load;
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbConnection).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlConnection.ResumeLayout(false);
            grpPermissions.ResumeLayout(false);
            grpPermissions.PerformLayout();
            grpScan.ResumeLayout(false);
            grpScan.PerformLayout();
            grpInfo.ResumeLayout(false);
            tblInfo.ResumeLayout(false);
            tblInfo.PerformLayout();
            grpQual.ResumeLayout(false);
            grpQual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbElectronics).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbComputers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTools).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLCD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRaise3D).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCreality).EndInit();
            ((System.ComponentModel.ISupportInitialize)numResin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPremFil).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLsrCut).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCNCMill).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStdFil).EndInit();
            grpdgv.ResumeLayout(false);
            grpdgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlButtons;
        private PictureBox pbLogo;
        private Label lblConnectionText;
        private Label lblConnectionStatus;
        private PictureBox pbConnection;
        private Panel pnlConnection;
        private Button btnScanPort;
        private Button btnConnect;
        private ComboBox cmbPort;
        private GroupBox grpInfo;
        private TextBox txtName;
        private Label lblName;
        private ComboBox cmbSex;
        private DateTimePicker dtpValid;
        private ComboBox cmbSubscription;
        private TextBox txtEmail;
        private TextBox txtNumber;
        private DateTimePicker dtpDoB;
        private Label lblValid;
        private Label lblSubscription;
        private Label lblEMail;
        private Label lblPhone;
        private Label lblDoB;
        private Label lblSex;
        private Button btnClear;
        private GroupBox grpScan;
        private Button btnScan;
        private TextBox txtId;
        private Label lblId;
        private CheckBox cbEdit;
        private ErrorProvider err;
        private System.Windows.Forms.Timer tmr;
        private DataGridView dgvData;
        private GroupBox grpPermissions;
        private ComboBox cmbValue;
        private TextBox txtValue;
        private Button btnSavePerms;
        private Label lblRes;
        private Label lblStdFil;
        private Label lblPremFil;
        private Label lblLsrCut;
        private Label lblCNCMill;
        private TextBox txtSelect;
        private NumericUpDown numStdFil;
        private NumericUpDown numResin;
        private NumericUpDown numPremFil;
        private NumericUpDown numLsrCut;
        private NumericUpDown numCNCMill;
        private Label lblSelection;
        private Label lblPremFilCurrent;
        private Label lblLaserCutterCurrent;
        private Label lblCNCMillCurrent;
        private Label lblResinCurrent;
        private Label lblStdFilCurrent;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Username;
        private GroupBox grpQual;
        private Label lblElectronics;
        private Label lblComputers;
        private Label lblTools;
        private Label lblLCD;
        private Label lblRaise3D;
        private Label lblCreality;
        private PictureBox pbElectronics;
        private PictureBox pbComputers;
        private PictureBox pbTools;
        private PictureBox pbLCD;
        private PictureBox pbRaise3D;
        private PictureBox pbCreality;
        private System.Windows.Forms.Timer anim;
        private GroupBox grpdgv;
        private TableLayoutPanel tblInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}