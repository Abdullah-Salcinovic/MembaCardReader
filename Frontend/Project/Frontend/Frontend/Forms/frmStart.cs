using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace Frontend.Forms
{

    //Panel Location : 248;12;

    public partial class frmStart : Form
    {
        private List<Int32> BaudRates;

        private List<string> PortNames;

        private List<string> ValidPorts;

        private SerialPort? OpenPort;

        private bool Connected;

        private Panel CurrentPanel;

      

        private List<string> Sexes;

        private List<string> Subscriptions;

        public frmStart()
        {
            InitializeComponent();


            this.BaudRates  = new List<Int32>() {
             1200,
             2400,
             4800,
             9600,
             14400,
             19200,
             38400,
             57600,
             115200};

            this.Sexes= new List<string>()
            {
                "Male",
                "Female"
            };

            this.Subscriptions = new List<string>()
            {
                "Basic",
                "Student",
                "Premium"

            };

            this.PortNames = new List<string>();
            this.ValidPorts = new List<string>();
            this.Connected = false;
            this.CurrentPanel=this.pnlConnection;
            Panel_Switch(this.CurrentPanel);
           
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            this.cmbBaud.DataSource = BaudRates;
            this.cmbBaud.SelectedIndex = 3;
            ScanPorts();
            ConnectionStatusLock();
            this.cmbSex.DataSource= Sexes;
            this.cmbSubscription.DataSource=Subscriptions;
            HandleEdit();
        }

        private void ScanPorts()
        {
            this.btnScanPort.Enabled = false;
            this.cmbPort.DataSource=null;

            this.PortNames.Clear();
            this.ValidPorts.Clear();

            this.PortNames = SerialPort.GetPortNames().ToList();

            foreach (string portName in this.PortNames)
            {
                SerialPort tempSerialPort = new SerialPort(portName);

                if (cmbBaud.SelectedItem!=null)
                {
                    tempSerialPort.BaudRate=(int)this.cmbBaud.SelectedItem;
                }

                else
                {
                    tempSerialPort.BaudRate = 9600;
                }

                try
                {
                    tempSerialPort.Open();



                    tempSerialPort.WriteLine("Emrah\n");


                    Thread.Sleep(100);


                    string msg = tempSerialPort.ReadExisting();

                    if (msg=="Abdullah\n")
                    {

                        ValidPorts.Add(portName);

                    }

                    MessageBox.Show(msg.ToString());

                    tempSerialPort.Close();

                    tempSerialPort.Dispose();

                }
                catch (Exception)
                {
                    MessageBox.Show($"Device port not opening. Please check your connection at {portName}", "Error");

                }


            }


            if (this.ValidPorts.Count>0)
            {
                this.cmbPort.Enabled = true;

                this.cmbPort.DataSource=this.ValidPorts;

            }

            else
            {
                this.cmbPort.Enabled=false;
                MessageBox.Show("Please ensure your device can see a valid card reader.", "No card readers found.");
            }
            this.btnScanPort.Enabled = true;
        }


        private void btnScanPort_Click(object sender, EventArgs e)
        {
            ScanPorts();


            Verify_Selection();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            if (!Connected)
            {
                if (this.OpenPort!=null)
                {
                    this.OpenPort.Dispose();
                }
                this.OpenPort = new SerialPort(cmbPort.SelectedItem!.ToString());


                if (cmbBaud.SelectedItem!=null)
                {
                    OpenPort.BaudRate=(int)this.cmbBaud.SelectedItem;
                }

                else
                {
                    OpenPort.BaudRate = 9600;
                }

                try
                {
                    this.OpenPort.Open();

                    this.OpenPort.WriteLine("Emrah\n");


                    Thread.Sleep(100);


                    string msg = this.OpenPort.ReadExisting();



                    if (msg!="Abdullah\n")
                    {
                        MessageBox.Show($"The device at port {this.cmbPort.SelectedItem} may be unresponsive or not valid.", "Timeout");
                    }

                    else
                    {
                        this.btnConnect.Text="Disconnect";
                        this.lblConnectionStatus.Text="Connected";
                        this.cmbBaud.Enabled=false;
                        this.cmbPort.Enabled=false;
                        this.btnScanPort.Enabled=false;
                        this.pbConnection.Image=Resources.SharedResources.Green;
                        this.Connected=true;
                        ConnectionStatusLock();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"Device port not opening. Please check your connection at {this.cmbPort.SelectedItem}", "Error");

                }


            }




            else
            {
                this.OpenPort!.Close();

                if (this.OpenPort!=null)
                {
                    this.OpenPort.Dispose();
                }

                this.btnConnect.Text="Connect";
                this.lblConnectionStatus.Text="Disconnected";
                this.Connected =false;
                this.cmbBaud.Enabled=true;
                this.cmbPort.Enabled=true;
                this.btnScanPort.Enabled =true;
                ConnectionStatusLock();
                this.pbConnection.Image=Resources.SharedResources.Red;
            }



        }

        private void ConnectionStatusLock()
        {
            this.btnConnection.Enabled=this.Connected;
            this.btnScanCard.Enabled=this.Connected;
            this.btnViewUsers.Enabled=this.Connected;

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            this.CurrentPanel=pnlConnection;
            Panel_Switch(this.CurrentPanel);
        }

        private void btnScanCard_Click(object sender, EventArgs e)
        {
            this.CurrentPanel=this.pnlScan;
            Panel_Switch(this.CurrentPanel);
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            //this.CurrentPanel=4;
            Panel_Switch(this.CurrentPanel);
        }



        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verify_Selection();
        }

        private void cmbBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verify_Selection();
        }


        private void Panel_Switch(Panel Selection)
        {
            foreach (Panel pnl in this.Controls)
            {
                if (pnl == Selection || pnl == this.pnlButtons)
                {
                    pnl.Visible =true;
                }

                else
                {
                    pnl.Visible=false;
                }

            }




        }





        private void Verify_Selection()
        {
            if (this.cmbBaud.SelectedItem!=null && this.cmbPort.SelectedItem!=null)
            {
                this.btnConnect.Enabled = true;
            }

            else
            {
                this.btnConnect.Enabled=false;
            }
        }

        private void cbEdit_CheckedChanged(object sender, EventArgs e)
        {
            HandleEdit();
            
        }

        private void HandleEdit()
        {

            if (this.cbEdit.Checked)
            {
                this.grpScan.Enabled = false;
                this.grpInfo.Enabled = true;
            }
            else
            {
                this.grpScan.Enabled=true;
                this.grpInfo.Enabled=false;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanCard();
            
           


        }

        private void ScanCard()
        {
            this.btnScan.Enabled = false;

            try{

                this.OpenPort!.WriteLine("Emrah\n");


                Thread.Sleep(100);


                string msg = OpenPort.ReadExisting();



                if (msg!="Abdullah\n")
                {
                    MessageBox.Show($"The device at port {this.cmbPort.SelectedItem} may be unresponsive or not valid.", "Timeout");
                }

                else
                {
                    this.OpenPort!.WriteLine("SCN_CRD\n");

                    Thread.Sleep(5000);

                    string rez = OpenPort.ReadExisting();

                    

                    this.txtId.Text = rez;

                }


            }


            catch (Exception){
                MessageBox.Show($"Device port not opening. Please check your connection at {this.cmbPort.SelectedItem}", "Error");

            }


            this.btnScan.Enabled=true;
        }

        private void dtpValid_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpValid.Value<=DateTime.Now)
            {
                this.pbValid.Image=(Image)Resources.SharedResources.Invalid;
            }
            else
            {
                this.pbValid.Image=(Image)Resources.SharedResources.Valid;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                SaveChanges();
            }
            
        }

        private void Clear()
        {
            this.cbEdit.Checked=false;
           
           
            this.pbSubscription.Image=null;

            this.txtId.Text=string.Empty;
            this.txtName.Text=string.Empty;
            this.cmbSex.SelectedItem=null;
            this.dtpDoB.Value=DateTime.Now;
            this.txtNumber.Text=string.Empty;
            this.txtEmail.Text=string.Empty;
            this.cmbSubscription.SelectedItem=null;
            this.dtpValid.Value=DateTime.Now;

            this.pbValid.Image=null;

            HandleEdit();
        }
        private void SaveChanges()
        {

            Clear();
        }

        private bool ValidateInput()
        {

            
            return (
                    
                !this.txtId.Text.Equals(string.Empty) &&
                this.cmbSex.SelectedItem!=null &&
                this.dtpDoB.Value<DateTime.Now &&
                !this.txtNumber.Text.Equals(string.Empty) &&
                !this.txtEmail.Text.Equals(string.Empty) &&
                this.cmbSubscription.SelectedItem!=null

                );
        }
    }
}
