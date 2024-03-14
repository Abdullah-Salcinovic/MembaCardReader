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

        private bool EditMode;

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
                    OpenPort.Open();

                    OpenPort.WriteLine("Emrah\n");


                    Thread.Sleep(100);


                    string msg = OpenPort.ReadExisting();



                    if (msg!="Abdullah\n")
                    {
                        MessageBox.Show($"The device at port {cmbPort.SelectedItem} may be unresponsive or not valid.", "Timeout");
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
                    MessageBox.Show($"Device port not opening. Please check your connection at {cmbPort.SelectedItem}", "Error");

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

        }



        private void btnScan_Click(object sender, EventArgs e)
        {

        
        
        }

        private void ScanCard()
        {

        }

    }
}
