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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblConnectionStatus = new Label();
            lblConnectionText = new Label();
            btnUpdateUserResources = new Button();
            btnViewUsers = new Button();
            btnRegistration = new Button();
            btnScanCard = new Button();
            btnConnection = new Button();
            pbLogo = new PictureBox();
            tabCtrl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            tabCtrl.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblConnectionStatus);
            panel1.Controls.Add(lblConnectionText);
            panel1.Controls.Add(btnUpdateUserResources);
            panel1.Controls.Add(btnViewUsers);
            panel1.Controls.Add(btnRegistration);
            panel1.Controls.Add(btnScanCard);
            panel1.Controls.Add(btnConnection);
            panel1.Controls.Add(pbLogo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 426);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Resources.SharedResources.Red;
            pictureBox1.Location = new Point(201, 388);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            // btnUpdateUserResources
            // 
            btnUpdateUserResources.BackColor = Color.Gold;
            btnUpdateUserResources.FlatStyle = FlatStyle.Flat;
            btnUpdateUserResources.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateUserResources.Location = new Point(25, 332);
            btnUpdateUserResources.Name = "btnUpdateUserResources";
            btnUpdateUserResources.Size = new Size(176, 28);
            btnUpdateUserResources.TabIndex = 5;
            btnUpdateUserResources.Text = "Update User Resources";
            btnUpdateUserResources.UseVisualStyleBackColor = false;
            // 
            // btnViewUsers
            // 
            btnViewUsers.BackColor = Color.Gold;
            btnViewUsers.FlatStyle = FlatStyle.Flat;
            btnViewUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewUsers.Location = new Point(25, 298);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(176, 28);
            btnViewUsers.TabIndex = 4;
            btnViewUsers.Text = "View Users";
            btnViewUsers.UseVisualStyleBackColor = false;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.Gold;
            btnRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistration.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistration.Location = new Point(25, 264);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(176, 28);
            btnRegistration.TabIndex = 3;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = false;
            // 
            // btnScanCard
            // 
            btnScanCard.BackColor = Color.Gold;
            btnScanCard.FlatStyle = FlatStyle.Flat;
            btnScanCard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScanCard.Location = new Point(25, 230);
            btnScanCard.Name = "btnScanCard";
            btnScanCard.Size = new Size(176, 28);
            btnScanCard.TabIndex = 2;
            btnScanCard.Text = "Scan Card";
            btnScanCard.UseVisualStyleBackColor = false;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.Gold;
            btnConnection.FlatStyle = FlatStyle.Flat;
            btnConnection.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnection.Location = new Point(25, 196);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(176, 28);
            btnConnection.TabIndex = 1;
            btnConnection.Text = "Connection";
            btnConnection.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = Resources.SharedResources.Logo;
            pbLogo.Location = new Point(25, 16);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(176, 174);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // tabCtrl
            // 
            tabCtrl.Controls.Add(tabPage1);
            tabCtrl.Controls.Add(tabPage2);
            tabCtrl.Location = new Point(248, 12);
            tabCtrl.Name = "tabCtrl";
            tabCtrl.SelectedIndex = 0;
            tabCtrl.Size = new Size(540, 426);
            tabCtrl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(532, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(tabCtrl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Garaža Makerspace";
            Load += frmStart_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            tabCtrl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbLogo;
        private Button btnConnection;
        private Button btnUpdateUserResources;
        private Button btnViewUsers;
        private Button btnRegistration;
        private Button btnScanCard;
        private Label lblConnectionText;
        private Label lblConnectionStatus;
        private PictureBox pictureBox1;
        private TabControl tabCtrl;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}