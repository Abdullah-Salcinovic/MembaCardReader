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
            btnViewUsers = new Button();
            btnRegistrations = new Button();
            btnConnection = new Button();
            pbLogo = new PictureBox();
            pnlConnection = new Panel();
            txtConsole = new TextBox();
            cmbPort = new ComboBox();
            btnConnect = new Button();
            btnScanPort = new Button();
            pnlScan = new Panel();
            grpScan = new GroupBox();
            cbEdit = new CheckBox();
            lblId = new Label();
            txtId = new TextBox();
            pbSubscription = new PictureBox();
            btnScan = new Button();
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
            pbValid = new PictureBox();
            btnClear = new Button();
            btnSaveChanges = new Button();
            err = new ErrorProvider(components);
            tmr = new System.Windows.Forms.Timer(components);
            pnlPerms = new Panel();
            grpdgv = new GroupBox();
            txtValue = new TextBox();
            dgvData = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            cmbValue = new ComboBox();
            grpPermissions = new GroupBox();
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
            cbPermEdit = new CheckBox();
            lblResinCurrent = new Label();
            btnSavePerms = new Button();
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
            anim = new System.Windows.Forms.Timer(components);
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConnection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlConnection.SuspendLayout();
            pnlScan.SuspendLayout();
            grpScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSubscription).BeginInit();
            grpInfo.SuspendLayout();
            tblInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbValid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            pnlPerms.SuspendLayout();
            grpdgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            grpPermissions.SuspendLayout();
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
            pnlButtons.Controls.Add(btnViewUsers);
            pnlButtons.Controls.Add(btnRegistrations);
            pnlButtons.Controls.Add(btnConnection);
            pnlButtons.Controls.Add(pbLogo);
            pnlButtons.Dock = DockStyle.Left;
            pnlButtons.Location = new Point(0, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(230, 451);
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
            // btnViewUsers
            // 
            btnViewUsers.BackColor = Color.Gold;
            btnViewUsers.FlatStyle = FlatStyle.Flat;
            btnViewUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewUsers.ForeColor = Color.Black;
            btnViewUsers.Location = new Point(25, 306);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(176, 28);
            btnViewUsers.TabIndex = 4;
            btnViewUsers.Text = "User Details";
            btnViewUsers.UseVisualStyleBackColor = false;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // btnRegistrations
            // 
            btnRegistrations.BackColor = Color.Gold;
            btnRegistrations.FlatStyle = FlatStyle.Flat;
            btnRegistrations.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrations.ForeColor = Color.Black;
            btnRegistrations.Location = new Point(25, 272);
            btnRegistrations.Name = "btnRegistrations";
            btnRegistrations.Size = new Size(176, 28);
            btnRegistrations.TabIndex = 2;
            btnRegistrations.Text = "Registrations";
            btnRegistrations.UseVisualStyleBackColor = false;
            btnRegistrations.Click += btnScanCard_Click;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.Gold;
            btnConnection.FlatStyle = FlatStyle.Flat;
            btnConnection.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnection.ForeColor = Color.Black;
            btnConnection.Location = new Point(25, 238);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(176, 28);
            btnConnection.TabIndex = 1;
            btnConnection.Text = "Connection";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
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
            // pnlConnection
            // 
            pnlConnection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlConnection.BackColor = Color.FromArgb(66, 66, 86);
            pnlConnection.Controls.Add(txtConsole);
            pnlConnection.Controls.Add(cmbPort);
            pnlConnection.Controls.Add(btnConnect);
            pnlConnection.Controls.Add(btnScanPort);
            pnlConnection.Location = new Point(248, 12);
            pnlConnection.Name = "pnlConnection";
            pnlConnection.Size = new Size(540, 426);
            pnlConnection.TabIndex = 1;
            pnlConnection.Tag = "";
            // 
            // txtConsole
            // 
            txtConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConsole.BackColor = Color.Black;
            txtConsole.ForeColor = Color.WhiteSmoke;
            txtConsole.Location = new Point(20, 177);
            txtConsole.Multiline = true;
            txtConsole.Name = "txtConsole";
            txtConsole.ReadOnly = true;
            txtConsole.Size = new Size(500, 231);
            txtConsole.TabIndex = 6;
            txtConsole.TextChanged += txtConsole_TextChanged;
            // 
            // cmbPort
            // 
            cmbPort.BackColor = Color.FromArgb(100, 100, 120);
            cmbPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort.Enabled = false;
            cmbPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPort.FormattingEnabled = true;
            cmbPort.Location = new Point(269, 18);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(251, 25);
            cmbPort.TabIndex = 5;
            cmbPort.SelectedIndexChanged += cmbPort_SelectedIndexChanged;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Gold;
            btnConnect.Enabled = false;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.Black;
            btnConnect.Location = new Point(20, 115);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(176, 28);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnScanPort
            // 
            btnScanPort.BackColor = Color.Gold;
            btnScanPort.FlatStyle = FlatStyle.Flat;
            btnScanPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScanPort.ForeColor = Color.Black;
            btnScanPort.Location = new Point(20, 15);
            btnScanPort.Name = "btnScanPort";
            btnScanPort.Size = new Size(176, 28);
            btnScanPort.TabIndex = 2;
            btnScanPort.Text = "Scan Ports";
            btnScanPort.UseVisualStyleBackColor = false;
            btnScanPort.Click += btnScanPort_Click;
            // 
            // pnlScan
            // 
            pnlScan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlScan.BackColor = Color.FromArgb(66, 66, 86);
            pnlScan.Controls.Add(grpScan);
            pnlScan.Controls.Add(grpInfo);
            pnlScan.Location = new Point(248, 12);
            pnlScan.Name = "pnlScan";
            pnlScan.Size = new Size(540, 426);
            pnlScan.TabIndex = 2;
            // 
            // grpScan
            // 
            grpScan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpScan.Controls.Add(cbEdit);
            grpScan.Controls.Add(lblId);
            grpScan.Controls.Add(txtId);
            grpScan.Controls.Add(pbSubscription);
            grpScan.Controls.Add(btnScan);
            grpScan.ForeColor = Color.WhiteSmoke;
            grpScan.Location = new Point(0, 0);
            grpScan.Name = "grpScan";
            grpScan.Size = new Size(537, 180);
            grpScan.TabIndex = 1;
            grpScan.TabStop = false;
            grpScan.Text = "Scan";
            // 
            // cbEdit
            // 
            cbEdit.AutoSize = true;
            cbEdit.ForeColor = Color.WhiteSmoke;
            cbEdit.Location = new Point(8, 59);
            cbEdit.Name = "cbEdit";
            cbEdit.Size = new Size(80, 19);
            cbEdit.TabIndex = 19;
            cbEdit.Text = "Edit Mode";
            cbEdit.UseVisualStyleBackColor = true;
            cbEdit.CheckedChanged += cbEdit_CheckedChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.WhiteSmoke;
            lblId.Location = new Point(6, 114);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 18;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.WhiteSmoke;
            txtId.ForeColor = Color.Black;
            txtId.Location = new Point(6, 140);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(113, 23);
            txtId.TabIndex = 17;
            // 
            // pbSubscription
            // 
            pbSubscription.BackColor = Color.FromArgb(100, 100, 120);
            pbSubscription.Location = new Point(125, 22);
            pbSubscription.Name = "pbSubscription";
            pbSubscription.Size = new Size(402, 152);
            pbSubscription.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSubscription.TabIndex = 16;
            pbSubscription.TabStop = false;
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.Gold;
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
            // grpInfo
            // 
            grpInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpInfo.Controls.Add(tblInfo);
            grpInfo.Controls.Add(pbValid);
            grpInfo.Controls.Add(btnClear);
            grpInfo.Controls.Add(btnSaveChanges);
            grpInfo.ForeColor = Color.WhiteSmoke;
            grpInfo.Location = new Point(0, 180);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(537, 243);
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
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857113F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblInfo.Size = new Size(392, 197);
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
            lblSex.Location = new Point(3, 28);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(28, 15);
            lblSex.TabIndex = 8;
            lblSex.Text = "Sex:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.ForeColor = Color.WhiteSmoke;
            lblDoB.Location = new Point(3, 56);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(76, 15);
            lblDoB.TabIndex = 9;
            lblDoB.Text = "Date of birth:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = Color.WhiteSmoke;
            lblPhone.Location = new Point(3, 84);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(89, 15);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone number:";
            // 
            // dtpValid
            // 
            dtpValid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpValid.Location = new Point(111, 171);
            dtpValid.Name = "dtpValid";
            dtpValid.Size = new Size(308, 23);
            dtpValid.TabIndex = 7;
            dtpValid.ValueChanged += dtpValid_ValueChanged;
            // 
            // lblValid
            // 
            lblValid.AutoSize = true;
            lblValid.ForeColor = Color.WhiteSmoke;
            lblValid.Location = new Point(3, 168);
            lblValid.Name = "lblValid";
            lblValid.Size = new Size(62, 15);
            lblValid.TabIndex = 13;
            lblValid.Text = "Valid until:";
            // 
            // cmbSubscription
            // 
            cmbSubscription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbSubscription.BackColor = Color.WhiteSmoke;
            cmbSubscription.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubscription.ForeColor = Color.Black;
            cmbSubscription.FormattingEnabled = true;
            cmbSubscription.Location = new Point(111, 143);
            cmbSubscription.Name = "cmbSubscription";
            cmbSubscription.Size = new Size(308, 23);
            cmbSubscription.TabIndex = 6;
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.ForeColor = Color.WhiteSmoke;
            lblEMail.Location = new Point(3, 112);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(41, 15);
            lblEMail.TabIndex = 11;
            lblEMail.Text = "E-Mail";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(111, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(308, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblSubscription
            // 
            lblSubscription.AutoSize = true;
            lblSubscription.ForeColor = Color.WhiteSmoke;
            lblSubscription.Location = new Point(3, 140);
            lblSubscription.Name = "lblSubscription";
            lblSubscription.Size = new Size(102, 15);
            lblSubscription.TabIndex = 12;
            lblSubscription.Text = "Subscription type:";
            // 
            // txtNumber
            // 
            txtNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNumber.BackColor = Color.WhiteSmoke;
            txtNumber.ForeColor = Color.Black;
            txtNumber.Location = new Point(111, 87);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(308, 23);
            txtNumber.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(111, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 23);
            txtName.TabIndex = 1;
            // 
            // dtpDoB
            // 
            dtpDoB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpDoB.Location = new Point(111, 59);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(308, 23);
            dtpDoB.TabIndex = 3;
            // 
            // cmbSex
            // 
            cmbSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbSex.BackColor = Color.WhiteSmoke;
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.ForeColor = Color.Black;
            cmbSex.FormattingEnabled = true;
            cmbSex.Location = new Point(111, 31);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(308, 23);
            cmbSex.TabIndex = 2;
            // 
            // pbValid
            // 
            pbValid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbValid.BackColor = Color.FromArgb(100, 100, 120);
            pbValid.Location = new Point(406, 123);
            pbValid.Name = "pbValid";
            pbValid.Size = new Size(111, 105);
            pbValid.SizeMode = PictureBoxSizeMode.StretchImage;
            pbValid.TabIndex = 16;
            pbValid.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.Gold;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(406, 65);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveChanges.BackColor = Color.Gold;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.Black;
            btnSaveChanges.Location = new Point(406, 31);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(111, 23);
            btnSaveChanges.TabIndex = 14;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
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
            // pnlPerms
            // 
            pnlPerms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPerms.BackColor = Color.FromArgb(66, 66, 86);
            pnlPerms.Controls.Add(grpdgv);
            pnlPerms.Controls.Add(grpPermissions);
            pnlPerms.Location = new Point(248, 12);
            pnlPerms.Name = "pnlPerms";
            pnlPerms.Size = new Size(540, 426);
            pnlPerms.TabIndex = 20;
            // 
            // grpdgv
            // 
            grpdgv.Controls.Add(txtValue);
            grpdgv.Controls.Add(dgvData);
            grpdgv.Controls.Add(cmbValue);
            grpdgv.Dock = DockStyle.Fill;
            grpdgv.ForeColor = Color.WhiteSmoke;
            grpdgv.Location = new Point(0, 0);
            grpdgv.Name = "grpdgv";
            grpdgv.Size = new Size(144, 426);
            grpdgv.TabIndex = 4;
            grpdgv.TabStop = false;
            grpdgv.Text = "Users";
            // 
            // txtValue
            // 
            txtValue.BackColor = Color.WhiteSmoke;
            txtValue.Dock = DockStyle.Top;
            txtValue.ForeColor = Color.Black;
            txtValue.Location = new Point(3, 42);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(138, 23);
            txtValue.TabIndex = 2;
            txtValue.TextChanged += txtValue_TextChanged;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.BackgroundColor = Color.FromArgb(100, 100, 120);
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Id, Username });
            dgvData.Location = new Point(6, 75);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(132, 336);
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
            // cmbValue
            // 
            cmbValue.BackColor = Color.WhiteSmoke;
            cmbValue.Dock = DockStyle.Top;
            cmbValue.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbValue.ForeColor = Color.Black;
            cmbValue.FormattingEnabled = true;
            cmbValue.Location = new Point(3, 19);
            cmbValue.Name = "cmbValue";
            cmbValue.Size = new Size(138, 23);
            cmbValue.TabIndex = 3;
            // 
            // grpPermissions
            // 
            grpPermissions.Controls.Add(grpQual);
            grpPermissions.Controls.Add(lblPremFilCurrent);
            grpPermissions.Controls.Add(lblLaserCutterCurrent);
            grpPermissions.Controls.Add(lblCNCMillCurrent);
            grpPermissions.Controls.Add(cbPermEdit);
            grpPermissions.Controls.Add(lblResinCurrent);
            grpPermissions.Controls.Add(btnSavePerms);
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
            grpPermissions.Dock = DockStyle.Right;
            grpPermissions.Enabled = false;
            grpPermissions.ForeColor = Color.WhiteSmoke;
            grpPermissions.Location = new Point(144, 0);
            grpPermissions.Name = "grpPermissions";
            grpPermissions.Size = new Size(396, 426);
            grpPermissions.TabIndex = 0;
            grpPermissions.TabStop = false;
            grpPermissions.Text = "Info";
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
            grpQual.Location = new Point(9, 251);
            grpQual.Name = "grpQual";
            grpQual.Size = new Size(375, 105);
            grpQual.TabIndex = 41;
            grpQual.TabStop = false;
            grpQual.Text = "Qualified for:";
            // 
            // pbElectronics
            // 
            pbElectronics.BackColor = Color.Transparent;
            pbElectronics.Image = (Image)resources.GetObject("pbElectronics.Image");
            pbElectronics.Location = new Point(264, 68);
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
            pbComputers.Location = new Point(264, 49);
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
            pbTools.Location = new Point(264, 31);
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
            lblElectronics.Location = new Point(285, 68);
            lblElectronics.Name = "lblElectronics";
            lblElectronics.Size = new Size(64, 15);
            lblElectronics.TabIndex = 5;
            lblElectronics.Text = "Electronics";
            // 
            // lblComputers
            // 
            lblComputers.AutoSize = true;
            lblComputers.Location = new Point(285, 49);
            lblComputers.Name = "lblComputers";
            lblComputers.Size = new Size(66, 15);
            lblComputers.TabIndex = 4;
            lblComputers.Text = "Computers";
            // 
            // lblTools
            // 
            lblTools.AutoSize = true;
            lblTools.Location = new Point(285, 31);
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
            lblPremFilCurrent.Location = new Point(273, 214);
            lblPremFilCurrent.Name = "lblPremFilCurrent";
            lblPremFilCurrent.Size = new Size(59, 15);
            lblPremFilCurrent.TabIndex = 40;
            lblPremFilCurrent.Text = "Currently:";
            // 
            // lblLaserCutterCurrent
            // 
            lblLaserCutterCurrent.AutoSize = true;
            lblLaserCutterCurrent.ForeColor = Color.WhiteSmoke;
            lblLaserCutterCurrent.Location = new Point(273, 176);
            lblLaserCutterCurrent.Name = "lblLaserCutterCurrent";
            lblLaserCutterCurrent.Size = new Size(59, 15);
            lblLaserCutterCurrent.TabIndex = 39;
            lblLaserCutterCurrent.Text = "Currently:";
            // 
            // lblCNCMillCurrent
            // 
            lblCNCMillCurrent.AutoSize = true;
            lblCNCMillCurrent.ForeColor = Color.WhiteSmoke;
            lblCNCMillCurrent.Location = new Point(273, 142);
            lblCNCMillCurrent.Name = "lblCNCMillCurrent";
            lblCNCMillCurrent.Size = new Size(59, 15);
            lblCNCMillCurrent.TabIndex = 38;
            lblCNCMillCurrent.Text = "Currently:";
            // 
            // cbPermEdit
            // 
            cbPermEdit.AutoSize = true;
            cbPermEdit.ForeColor = Color.WhiteSmoke;
            cbPermEdit.Location = new Point(9, 387);
            cbPermEdit.Name = "cbPermEdit";
            cbPermEdit.Size = new Size(83, 19);
            cbPermEdit.TabIndex = 17;
            cbPermEdit.Text = "Edit Mode:";
            cbPermEdit.UseVisualStyleBackColor = true;
            cbPermEdit.CheckedChanged += cbPermEdit_CheckedChanged;
            // 
            // lblResinCurrent
            // 
            lblResinCurrent.AutoSize = true;
            lblResinCurrent.ForeColor = Color.WhiteSmoke;
            lblResinCurrent.Location = new Point(273, 103);
            lblResinCurrent.Name = "lblResinCurrent";
            lblResinCurrent.Size = new Size(59, 15);
            lblResinCurrent.TabIndex = 37;
            lblResinCurrent.Text = "Currently:";
            // 
            // btnSavePerms
            // 
            btnSavePerms.BackColor = Color.Gold;
            btnSavePerms.Enabled = false;
            btnSavePerms.FlatStyle = FlatStyle.Flat;
            btnSavePerms.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSavePerms.ForeColor = Color.Black;
            btnSavePerms.Location = new Point(273, 383);
            btnSavePerms.Name = "btnSavePerms";
            btnSavePerms.Size = new Size(111, 23);
            btnSavePerms.TabIndex = 16;
            btnSavePerms.Text = "Save Changes";
            btnSavePerms.UseVisualStyleBackColor = false;
            btnSavePerms.Click += btnSavePerms_Click;
            // 
            // lblStdFilCurrent
            // 
            lblStdFilCurrent.AutoSize = true;
            lblStdFilCurrent.ForeColor = Color.WhiteSmoke;
            lblStdFilCurrent.Location = new Point(273, 69);
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
            numResin.Size = new Size(129, 23);
            numResin.TabIndex = 28;
            // 
            // numPremFil
            // 
            numPremFil.BackColor = Color.WhiteSmoke;
            numPremFil.ForeColor = Color.Black;
            numPremFil.Location = new Point(138, 212);
            numPremFil.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPremFil.Name = "numPremFil";
            numPremFil.Size = new Size(129, 23);
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
            numLsrCut.Size = new Size(129, 23);
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
            numCNCMill.Size = new Size(129, 23);
            numCNCMill.TabIndex = 25;
            // 
            // numStdFil
            // 
            numStdFil.BackColor = Color.WhiteSmoke;
            numStdFil.ForeColor = Color.Black;
            numStdFil.Location = new Point(138, 67);
            numStdFil.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStdFil.Name = "numStdFil";
            numStdFil.Size = new Size(129, 23);
            numStdFil.TabIndex = 24;
            // 
            // txtSelect
            // 
            txtSelect.BackColor = Color.WhiteSmoke;
            txtSelect.ForeColor = Color.Black;
            txtSelect.Location = new Point(73, 22);
            txtSelect.Name = "txtSelect";
            txtSelect.ReadOnly = true;
            txtSelect.Size = new Size(311, 23);
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
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 451);
            Controls.Add(pnlPerms);
            Controls.Add(pnlScan);
            Controls.Add(pnlConnection);
            Controls.Add(pnlButtons);
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
            pnlConnection.PerformLayout();
            pnlScan.ResumeLayout(false);
            grpScan.ResumeLayout(false);
            grpScan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSubscription).EndInit();
            grpInfo.ResumeLayout(false);
            tblInfo.ResumeLayout(false);
            tblInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbValid).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            pnlPerms.ResumeLayout(false);
            grpdgv.ResumeLayout(false);
            grpdgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            grpPermissions.ResumeLayout(false);
            grpPermissions.PerformLayout();
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlButtons;
        private PictureBox pbLogo;
        private Button btnConnection;
        private Button btnViewUsers;
        private Button btnRegistrations;
        private Label lblConnectionText;
        private Label lblConnectionStatus;
        private PictureBox pbConnection;
        private Panel pnlConnection;
        private Button btnScanPort;
        private Button btnConnect;
        private ComboBox cmbPort;
        private Panel pnlScan;
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
        private Button btnSaveChanges;
        private Button btnClear;
        private GroupBox grpScan;
        private Button btnScan;
        private PictureBox pbSubscription;
        private TextBox txtId;
        private Label lblId;
        private CheckBox cbEdit;
        private PictureBox pbValid;
        private ErrorProvider err;
        private System.Windows.Forms.Timer tmr;
        private Panel pnlPerms;
        private DataGridView dgvData;
        private GroupBox grpPermissions;
        private ComboBox cmbValue;
        private TextBox txtValue;
        private Button btnSavePerms;
        private CheckBox cbPermEdit;
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
        private TextBox txtConsole;
        private GroupBox grpdgv;
        private TableLayoutPanel tblInfo;
    }
}