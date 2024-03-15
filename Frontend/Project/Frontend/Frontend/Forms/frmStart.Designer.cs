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
            btnScanCard = new Button();
            btnConnection = new Button();
            pbLogo = new PictureBox();
            pnlConnection = new Panel();
            pnlScan = new Panel();
            grpScan = new GroupBox();
            cbEdit = new CheckBox();
            lblId = new Label();
            txtId = new TextBox();
            pbSubscription = new PictureBox();
            btnScan = new Button();
            grpInfo = new GroupBox();
            pbValid = new PictureBox();
            btnClear = new Button();
            btnSaveChanges = new Button();
            lblValid = new Label();
            lblSubscription = new Label();
            lblEMail = new Label();
            lblPhone = new Label();
            lblDoB = new Label();
            lblSex = new Label();
            dtpValid = new DateTimePicker();
            cmbSubscription = new ComboBox();
            txtEmail = new TextBox();
            txtNumber = new TextBox();
            dtpDoB = new DateTimePicker();
            cmbSex = new ComboBox();
            txtName = new TextBox();
            lblName = new Label();
            cmbPort = new ComboBox();
            btnConnect = new Button();
            btnScanPort = new Button();
            err = new ErrorProvider(components);
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConnection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlConnection.SuspendLayout();
            pnlScan.SuspendLayout();
            grpScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSubscription).BeginInit();
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbValid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
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
            pnlConnection.Controls.Add(cmbPort);
            pnlConnection.Controls.Add(btnConnect);
            pnlConnection.Controls.Add(btnScanPort);
            pnlConnection.Location = new Point(248, 12);
            pnlConnection.Name = "pnlConnection";
            pnlConnection.Size = new Size(540, 426);
            pnlConnection.TabIndex = 1;
            pnlConnection.Tag = "";
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
            grpScan.Controls.Add(txtId);
            grpScan.Controls.Add(pbSubscription);
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
            cbEdit.Size = new Size(80, 19);
            cbEdit.TabIndex = 19;
            cbEdit.Text = "Edit Mode";
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
            // txtId
            // 
            txtId.Location = new Point(6, 140);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(113, 23);
            txtId.TabIndex = 17;
            // 
            // pbSubscription
            // 
            pbSubscription.BackColor = Color.DarkGray;
            pbSubscription.Location = new Point(125, 22);
            pbSubscription.Name = "pbSubscription";
            pbSubscription.Size = new Size(403, 152);
            pbSubscription.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSubscription.TabIndex = 16;
            pbSubscription.TabStop = false;
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
            grpInfo.Controls.Add(pbValid);
            grpInfo.Controls.Add(btnClear);
            grpInfo.Controls.Add(btnSaveChanges);
            grpInfo.Controls.Add(lblValid);
            grpInfo.Controls.Add(lblSubscription);
            grpInfo.Controls.Add(lblEMail);
            grpInfo.Controls.Add(lblPhone);
            grpInfo.Controls.Add(lblDoB);
            grpInfo.Controls.Add(lblSex);
            grpInfo.Controls.Add(dtpValid);
            grpInfo.Controls.Add(cmbSubscription);
            grpInfo.Controls.Add(txtEmail);
            grpInfo.Controls.Add(txtNumber);
            grpInfo.Controls.Add(dtpDoB);
            grpInfo.Controls.Add(cmbSex);
            grpInfo.Controls.Add(txtName);
            grpInfo.Controls.Add(lblName);
            grpInfo.Location = new Point(3, 194);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(534, 229);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "Info";
            // 
            // pbValid
            // 
            pbValid.BackColor = Color.Silver;
            pbValid.Location = new Point(406, 126);
            pbValid.Name = "pbValid";
            pbValid.Size = new Size(111, 89);
            pbValid.SizeMode = PictureBoxSizeMode.StretchImage;
            pbValid.TabIndex = 16;
            pbValid.TabStop = false;
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
            btnClear.Click += btnClear_Click;
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
            btnSaveChanges.Click += btnSaveChanges_Click;
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
            // dtpValid
            // 
            dtpValid.Location = new Point(144, 194);
            dtpValid.Name = "dtpValid";
            dtpValid.Size = new Size(200, 23);
            dtpValid.TabIndex = 7;
            dtpValid.ValueChanged += dtpValid_ValueChanged;
            // 
            // cmbSubscription
            // 
            cmbSubscription.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubscription.FormattingEnabled = true;
            cmbSubscription.Location = new Point(144, 165);
            cmbSubscription.Name = "cmbSubscription";
            cmbSubscription.Size = new Size(200, 23);
            cmbSubscription.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(144, 107);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(200, 23);
            txtNumber.TabIndex = 4;
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(144, 78);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(200, 23);
            dtpDoB.TabIndex = 3;
            // 
            // cmbSex
            // 
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.FormattingEnabled = true;
            cmbSex.Location = new Point(144, 49);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(200, 23);
            cmbSex.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
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
            // err
            // 
            err.ContainerControl = this;
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
            pnlScan.ResumeLayout(false);
            grpScan.ResumeLayout(false);
            grpScan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSubscription).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbValid).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
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
    }
}