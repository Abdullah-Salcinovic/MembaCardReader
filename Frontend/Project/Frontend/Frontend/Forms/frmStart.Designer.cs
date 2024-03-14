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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            pnlButtons = new Panel();
            pbConnection = new PictureBox();
            lblConnectionStatus = new Label();
            lblConnectionText = new Label();
            btnViewUsers = new Button();
            btnScanCard = new Button();
            btnConnection = new Button();
            pbLogo = new PictureBox();
            pnlConnection = new Panel();
            cmbBaud = new ComboBox();
            cmbPort = new ComboBox();
            btnConnect = new Button();
            lblBaud = new Label();
            btnScanPort = new Button();
            pnlScan = new Panel();
            grpScan = new GroupBox();
            cbEdit = new CheckBox();
            lblId = new Label();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            btnScan = new Button();
            grpInfo = new GroupBox();
            btnClear = new Button();
            btnSaveChanges = new Button();
            lblValid = new Label();
            lblSubscription = new Label();
            lblEMail = new Label();
            lblPhone = new Label();
            lblDoB = new Label();
            lblSex = new Label();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            lblName = new Label();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConnection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlConnection.SuspendLayout();
            pnlScan.SuspendLayout();
            grpScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(pbConnection);
            pnlButtons.Controls.Add(lblConnectionStatus);
            pnlButtons.Controls.Add(lblConnectionText);
            pnlButtons.Controls.Add(btnViewUsers);
            pnlButtons.Controls.Add(btnScanCard);
            pnlButtons.Controls.Add(btnConnection);
            pnlButtons.Controls.Add(pbLogo);
            pnlButtons.Location = new Point(12, 12);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(230, 426);
            pnlButtons.TabIndex = 0;
            pnlButtons.Tag = "";
            // 
            // pbConnection
            // 
            pbConnection.BackColor = Color.Transparent;
            pbConnection.Image = (Image)resources.GetObject("pbConnection.Image");
            pbConnection.Location = new Point(201, 388);
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
            lblConnectionStatus.Location = new Point(116, 388);
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
            lblConnectionText.Location = new Point(3, 388);
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
            btnViewUsers.Location = new Point(25, 320);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(176, 28);
            btnViewUsers.TabIndex = 4;
            btnViewUsers.Text = "User Details";
            btnViewUsers.UseVisualStyleBackColor = false;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // btnScanCard
            // 
            btnScanCard.BackColor = Color.Gold;
            btnScanCard.FlatStyle = FlatStyle.Flat;
            btnScanCard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScanCard.Location = new Point(25, 286);
            btnScanCard.Name = "btnScanCard";
            btnScanCard.Size = new Size(176, 28);
            btnScanCard.TabIndex = 2;
            btnScanCard.Text = "Registrations";
            btnScanCard.UseVisualStyleBackColor = false;
            btnScanCard.Click += btnScanCard_Click;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.Gold;
            btnConnection.FlatStyle = FlatStyle.Flat;
            btnConnection.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnection.Location = new Point(25, 252);
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
            pnlConnection.BackColor = Color.Silver;
            pnlConnection.Controls.Add(cmbBaud);
            pnlConnection.Controls.Add(cmbPort);
            pnlConnection.Controls.Add(btnConnect);
            pnlConnection.Controls.Add(lblBaud);
            pnlConnection.Controls.Add(btnScanPort);
            pnlConnection.Location = new Point(248, 12);
            pnlConnection.Name = "pnlConnection";
            pnlConnection.Size = new Size(540, 426);
            pnlConnection.TabIndex = 1;
            pnlConnection.Tag = "";
            // 
            // cmbBaud
            // 
            cmbBaud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBaud.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBaud.FormattingEnabled = true;
            cmbBaud.Location = new Point(269, 62);
            cmbBaud.Name = "cmbBaud";
            cmbBaud.Size = new Size(156, 25);
            cmbBaud.TabIndex = 6;
            cmbBaud.SelectedIndexChanged += cmbBaud_SelectedIndexChanged;
            // 
            // cmbPort
            // 
            cmbPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort.Enabled = false;
            cmbPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPort.FormattingEnabled = true;
            cmbPort.Location = new Point(269, 18);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(156, 25);
            cmbPort.TabIndex = 5;
            cmbPort.SelectedIndexChanged += cmbPort_SelectedIndexChanged;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Gold;
            btnConnect.Enabled = false;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.Location = new Point(20, 115);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(176, 28);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblBaud
            // 
            lblBaud.AutoSize = true;
            lblBaud.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaud.Location = new Point(20, 65);
            lblBaud.Name = "lblBaud";
            lblBaud.Size = new Size(74, 17);
            lblBaud.TabIndex = 3;
            lblBaud.Text = "Baud Rate:";
            // 
            // btnScanPort
            // 
            btnScanPort.BackColor = Color.Gold;
            btnScanPort.FlatStyle = FlatStyle.Flat;
            btnScanPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            pnlScan.BackColor = Color.Silver;
            pnlScan.Controls.Add(grpScan);
            pnlScan.Controls.Add(grpInfo);
            pnlScan.Location = new Point(248, 12);
            pnlScan.Name = "pnlScan";
            pnlScan.Size = new Size(540, 426);
            pnlScan.TabIndex = 2;
            // 
            // grpScan
            // 
            grpScan.Controls.Add(cbEdit);
            grpScan.Controls.Add(lblId);
            grpScan.Controls.Add(textBox4);
            grpScan.Controls.Add(pictureBox1);
            grpScan.Controls.Add(btnScan);
            grpScan.Location = new Point(3, 9);
            grpScan.Name = "grpScan";
            grpScan.Size = new Size(534, 180);
            grpScan.TabIndex = 1;
            grpScan.TabStop = false;
            grpScan.Text = "Scan";
            // 
            // cbEdit
            // 
            cbEdit.AutoSize = true;
            cbEdit.Location = new Point(8, 59);
            cbEdit.Name = "cbEdit";
            cbEdit.Size = new Size(93, 19);
            cbEdit.TabIndex = 19;
            cbEdit.Text = "Existing User";
            cbEdit.UseVisualStyleBackColor = true;
            cbEdit.CheckedChanged += cbEdit_CheckedChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(6, 114);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 18;
            lblId.Text = "Id:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 140);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(113, 23);
            textBox4.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.Location = new Point(125, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.Gold;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScan.Location = new Point(8, 22);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(111, 23);
            btnScan.TabIndex = 15;
            btnScan.Text = "Scan Card";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(btnClear);
            grpInfo.Controls.Add(btnSaveChanges);
            grpInfo.Controls.Add(lblValid);
            grpInfo.Controls.Add(lblSubscription);
            grpInfo.Controls.Add(lblEMail);
            grpInfo.Controls.Add(lblPhone);
            grpInfo.Controls.Add(lblDoB);
            grpInfo.Controls.Add(lblSex);
            grpInfo.Controls.Add(dateTimePicker2);
            grpInfo.Controls.Add(comboBox2);
            grpInfo.Controls.Add(textBox3);
            grpInfo.Controls.Add(textBox2);
            grpInfo.Controls.Add(dateTimePicker1);
            grpInfo.Controls.Add(comboBox1);
            grpInfo.Controls.Add(textBox1);
            grpInfo.Controls.Add(lblName);
            grpInfo.Location = new Point(3, 194);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(534, 229);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "Info";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(406, 52);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.Gold;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveChanges.Location = new Point(406, 18);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(111, 23);
            btnSaveChanges.TabIndex = 14;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // lblValid
            // 
            lblValid.AutoSize = true;
            lblValid.Location = new Point(17, 200);
            lblValid.Name = "lblValid";
            lblValid.Size = new Size(62, 15);
            lblValid.TabIndex = 13;
            lblValid.Text = "Valid until:";
            // 
            // lblSubscription
            // 
            lblSubscription.AutoSize = true;
            lblSubscription.Location = new Point(17, 168);
            lblSubscription.Name = "lblSubscription";
            lblSubscription.Size = new Size(102, 15);
            lblSubscription.TabIndex = 12;
            lblSubscription.Text = "Subscription type:";
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.Location = new Point(17, 139);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(41, 15);
            lblEMail.TabIndex = 11;
            lblEMail.Text = "E-Mail";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(17, 110);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(89, 15);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone number:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Location = new Point(17, 84);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(76, 15);
            lblDoB.TabIndex = 9;
            lblDoB.Text = "Date of birth:";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(17, 52);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(28, 15);
            lblSex.TabIndex = 8;
            lblSex.Text = "Sex:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(176, 192);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(176, 163);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(176, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(176, 76);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlScan);
            Controls.Add(pnlConnection);
            Controls.Add(pnlButtons);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlButtons;
        private PictureBox pbLogo;
        private Button btnConnection;
        private Button btnViewUsers;
        private Button btnScanCard;
        private Label lblConnectionText;
        private Label lblConnectionStatus;
        private PictureBox pbConnection;
        private Panel pnlConnection;
        private Label lblBaud;
        private Button btnScanPort;
        private Button btnConnect;
        private ComboBox cmbPort;
        private ComboBox cmbBaud;
        private Panel pnlScan;
        private GroupBox grpInfo;
        private TextBox textBox1;
        private Label lblName;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
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
        private PictureBox pictureBox1;
        private TextBox textBox4;
        private Label lblId;
        private CheckBox cbEdit;
    }
}