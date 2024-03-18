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
using Frontend.CardReader;

namespace Frontend.Forms
{

    //Panel Location : 248;12;

    public partial class frmStart : Form
    {


        private List<string> PortNames;

        private List<string> ValidPorts;

        private SerialPort? OpenPort;

        private List<int> BaudIdeal;

        private bool Connected;

        private Panel CurrentPanel;

        private List<string> SearchFilters;


        private List<string> Sexes;

        private List<string> Subscriptions;

        public frmStart()
        {
            InitializeComponent();

            this.BaudIdeal=new List<int>();





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

            this.SearchFilters = new List<string>()
            {
                "Filter by Id",
                "Filter by Name"
            };

            this.PortNames = new List<string>();
            this.ValidPorts = new List<string>();
            this.Connected = false;
            this.CurrentPanel=this.pnlConnection;
            Panel_Switch(this.CurrentPanel);

        }

        private void frmStart_Load(object sender, EventArgs e)
        {


            ConnectionStatusLock();
            this.cmbSex.DataSource=this.Sexes;
            this.cmbSubscription.DataSource=this.Subscriptions;
            this.cmbValue.DataSource=this.SearchFilters;
            HandleEdit();


            ScanPorts();
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



                try
                {

                    foreach (int baud in SCN.BaudRates)
                    {
                        if (tempSerialPort.IsOpen)
                        {
                            tempSerialPort.Close();
                        }




                        tempSerialPort.BaudRate=baud;


                        tempSerialPort.Open();


                        tempSerialPort.WriteLine(SCN.ID);


                        Wait(SCN.ID_DELAY);


                        string msg = tempSerialPort.ReadExisting();

                        tempSerialPort.DiscardOutBuffer();
                        tempSerialPort.DiscardInBuffer();

                        if (msg == SCN.RESPONSE)
                        {


                            this.ValidPorts.Add(portName);
                            this.BaudIdeal.Add(baud);
                            break;

                        }



                        tempSerialPort.Close();



                    }


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

            ManageConnection();


        }

        private void ManageConnection()
        {
            if (!Connected)
            {
                if (this.OpenPort!=null)
                {
                    this.OpenPort.Dispose();
                }
                this.OpenPort = new SerialPort(cmbPort.SelectedItem!.ToString());

                this.OpenPort.BaudRate=BaudIdeal[cmbPort.SelectedIndex];

                try
                {
                    this.OpenPort.Open();

                    this.OpenPort.WriteLine(SCN.ID);


                    Wait(SCN.ID_DELAY);


                    string msg = this.OpenPort!.ReadExisting();



                    if (msg != SCN.RESPONSE)
                    {
                        MessageBox.Show($"The device at port {this.cmbPort.SelectedItem} may be unresponsive or not valid.", "Timeout");
                    }

                    else
                    {
                        this.btnConnect.Text="Disconnect";
                        this.lblConnectionStatus.Text="Connected";

                        this.cmbPort.Enabled=false;
                        this.btnScanPort.Enabled=false;
                        this.pbConnection.Image= Resources.SharedResources.Green;
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
                this.CurrentPanel=pnlConnection;
                Panel_Switch(this.CurrentPanel);

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
            this.CurrentPanel=this.pnlPerms;
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
            foreach (Control pnl in this.Controls)
            {
                if (pnl.GetType()==typeof(Panel))
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




        }





        private void Verify_Selection()
        {
            if (this.cmbPort.SelectedItem!=null)
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

            try
            {


                this.OpenPort!.WriteLine(SCN.ID);


                Wait(SCN.ID_DELAY);


                string msg = this.OpenPort!.ReadExisting();




                if (msg != SCN.RESPONSE)
                {
                    MessageBox.Show($"The device at port {this.cmbPort.SelectedItem} may be unresponsive or not valid.", "Timeout");
                    ManageConnection();
                }


                else
                {


                    this.OpenPort!.WriteLine(SCN.SCAN);

                    Wait(SCN.SCAN_DELAY); 

                    string rez = this.OpenPort!.ReadExisting();


                    if (rez!=String.Empty)
                    {

                        this.txtId.Text = rez;
                    }


                    else
                    {
                        MessageBox.Show($"The device at port {cmbPort.SelectedItem} was unable to scan a card.", "Timeout");
                    }

                }


            }


            catch (Exception)
            {
                MessageBox.Show($"Device communication error. Please check your connection at {this.cmbPort.SelectedItem}", "Error");
                ManageConnection();
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
            this.err.Clear();


            if (this.txtId.Text==null||this.txtId.Text==String.Empty)
            {
                this.err.SetError(this.txtId, "A card needs to be scanned to continue.");
                return false;
            }
            else if (this.txtName.Text==null||this.txtName.Text==String.Empty)
            {
                this.err.SetError(this.txtName, "The user entry requires a name.");
                return false;
            }
            else if (this.cmbSex.SelectedItem==null)
            {
                this.err.SetError(this.cmbSex, "The user entry requires a sex.");
                return false;
            }

            else if (this.dtpDoB.Value.AddYears(DateTime.Now.Year-this.dtpDoB.Value.Year)<DateTime.Now && DateTime.Now.Year -this.dtpDoB.Value.Year<=18)
            {
                this.err.SetError(this.dtpDoB, "The user needs to be a person born prior to this moment.");
                return false;
            }
            else if (this.txtNumber.Text==null||this.txtNumber.Text==String.Empty)
            {
                this.err.SetError(this.txtNumber, "The user needs to have a phone number.");
                return false;
            }
            else if (this.txtEmail.Text==null||this.txtEmail.Text==String.Empty)
            {
                this.err.SetError(this.txtEmail, "The user needs to have an E-Mail address.");
                return false;
            }
            else if (this.cmbSubscription.SelectedItem==null)
            {
                this.err.SetError(this.cmbSubscription, "Invalid subscription type.");
                return false;
            }
            else if (this.dtpValid.Value<=DateTime.Now)
            {
                this.err.SetError(this.dtpValid, "User cannot have an expired membership.");
                return false;
            }
            else
            {
                return true;
            }


        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (this.Connected==false)
            {
                if (this.pbConnection.Visible==true)
                {
                    this.pbConnection.Visible = false;
                }
                else
                {
                    this.pbConnection.Visible=true;
                }
            }

            else
            {
                if (this.pbConnection.Visible==false)
                {
                    this.pbConnection.Visible=true;
                }
            }
        }

        private void cbPermEdit_CheckedChanged(object sender, EventArgs e)
        {
            this.btnSavePerms.Enabled=this.cbPermEdit.Checked;
            this.grpPermissions.Enabled=this.cbPermEdit.Checked;
        }

        private void btnSavePerms_Click(object sender, EventArgs e)
        {
            this.cbPermEdit.Checked=false;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.RowIndex<dgvData.RowCount && e.ColumnIndex>=0 && e.ColumnIndex<=1)
            {

            }

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSubscription.Text=="Basic")
            {
                this.pbSubscription.Image=Resources.SharedResources.Basic;
            }

            else if (this.cmbSubscription.Text=="Student")
            {

                this.pbSubscription.Image= Resources.SharedResources.Student;
            }
            else if (this.cmbSubscription.Text=="Premium")
            {
                this.pbSubscription.Image = Resources.SharedResources.Premium;
            }
            else
            {
                this.pbSubscription.Image = Resources.SharedResources.Hand;
            }
        }    


        private void Wait(int time)
        {
           



            Thread.Sleep(time);


        }


    }
}
