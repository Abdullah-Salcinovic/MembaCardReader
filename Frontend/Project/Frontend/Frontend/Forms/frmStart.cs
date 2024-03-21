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
using Frontend.CodeReader;
using Frontend.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http;

namespace Frontend.Forms
{

    //Panel Location : 248;12;

    public partial class frmStart : Form
    {
        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("http://10.100.30.41:5174")
        };

        private string slctdID;
        private string slctdName;
        private string scndID;

        private List<string> PortNames;

        private List<COM_Scanner> ValidPorts;

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

            this.dgvData.AutoGenerateColumns = false;

            this.BaudIdeal = new List<int>();





            this.Sexes = new List<string>()
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

            this.slctdID = "";
            this.scndID = "";
            this.slctdName = "";
            this.PortNames = new List<string>();
            this.ValidPorts = new List<COM_Scanner>();
            this.Connected = false;
            this.CurrentPanel = this.pnlConnection;
            Panel_Switch(this.CurrentPanel);

        }

        private void frmStart_Load(object sender, EventArgs e)
        {


            ConnectionStatusLock();
            this.cmbSex.DataSource = this.Sexes;
            this.cmbSubscription.DataSource = this.Subscriptions;
            this.cmbValue.DataSource = this.SearchFilters;
            HandleEdit();
            this.grpQual.Enabled = false;

            ScanPorts();
        }

        private void ScanPorts()
        {
            this.btnScanPort.Enabled = false;
            this.cmbPort.DataSource = null;

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


                        tempSerialPort.BaudRate = baud;


                        tempSerialPort.Open();


                        tempSerialPort.WriteLine(SCN.ID);


                        Wait(SCN.ID_DELAY);


                        string msg = tempSerialPort.ReadExisting();

                        tempSerialPort.DiscardInBuffer();
                        tempSerialPort.DiscardOutBuffer();

                        if (msg == SCN.RESPONSE)
                        {
                            tempSerialPort.WriteLine(SCN.TYPE);

                            Wait(SCN.TYPE_DELAY);

                            string typ = tempSerialPort.ReadExisting();

                            COM_Scanner com = new COM_Scanner(typ, portName);



                            this.ValidPorts.Add(com);
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


            if (this.ValidPorts.Count > 0)
            {
                this.cmbPort.Enabled = true;

                this.cmbPort.DataSource = this.ValidPorts;

            }

            else
            {
                this.cmbPort.Enabled = false;
                MessageBox.Show("Please ensure your device can see a valid scanner.", "No scanners found.");
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
                if (this.OpenPort != null)
                {
                    this.OpenPort.Dispose();

                }

                COM_Scanner? tmp = this.cmbPort.SelectedItem as COM_Scanner;


                this.OpenPort = new SerialPort(tmp!.COM);

                this.OpenPort.BaudRate = BaudIdeal[cmbPort.SelectedIndex];

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
                        this.btnConnect.Text = "Disconnect";
                        this.lblConnectionStatus.Text = "Connected";

                        this.cmbPort.Enabled = false;
                        this.btnScanPort.Enabled = false;
                        this.pbConnection.Image = Resources.SharedResources.Green;
                        this.Connected = true;
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

                if (this.OpenPort != null)
                {
                    this.OpenPort.Dispose();
                }

                this.btnConnect.Text = "Connect";
                this.lblConnectionStatus.Text = "Disconnected";
                this.Connected = false;
                this.CurrentPanel = pnlConnection;
                Panel_Switch(this.CurrentPanel);

                this.cmbPort.Enabled = true;
                this.btnScanPort.Enabled = true;
                ConnectionStatusLock();
                this.pbConnection.Image = Resources.SharedResources.Red;
            }

        }

        private void ConnectionStatusLock()
        {
            this.btnConnection.Enabled = this.Connected;
            this.btnRegistrations.Enabled = this.Connected;
            this.btnViewUsers.Enabled = this.Connected;

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            this.CurrentPanel = pnlConnection;
            Panel_Switch(this.CurrentPanel);
        }

        private void btnScanCard_Click(object sender, EventArgs e)
        {
            this.CurrentPanel = this.pnlScan;
            Panel_Switch(this.CurrentPanel);
        }

        private async void btnViewUsers_Click(object sender, EventArgs e)
        {
            this.CurrentPanel = this.pnlPerms;
            Panel_Switch(this.CurrentPanel);

            await GetAllAsync("/customers", sharedClient);
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
                    pnl.Visible = true;
                }

                else
                {
                    pnl.Visible = false;
                }

            }




        }





        private void Verify_Selection()
        {
            if (this.cmbPort.SelectedItem != null)
            {
                this.btnConnect.Enabled = true;
            }

            else
            {
                this.btnConnect.Enabled = false;
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
                this.grpScan.Enabled = true;
                this.grpInfo.Enabled = false;
            }

            this.cmbSex.SelectedItem = null;
            this.cmbSubscription.SelectedItem = null;
            this.pbSubscription.Image = null;
            this.pbValid.Image = null;


        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            ScanCode();
            if (txtId.Text != System.String.Empty && txtId.Text != null)
            {
                await GetAsync($"/customer?id={txtId.Text}", sharedClient);
            }



        }


        private async Task GetAsync(string endpoint, HttpClient httpClient)
        {
            try
            {
                using HttpResponseMessage response = await httpClient.GetAsync($"/api{endpoint}");

                var jsonResponse = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<CustomerGetRes>(jsonResponse);

                if (response.IsSuccessStatusCode)
                {
                    this.scndID = data?.Id!;
                    this.txtName.Text = data?.Name;
                    this.cmbSex.SelectedItem = data?.Sex;
                    this.dtpDoB.Value = data!.DateOfBirth;
                    this.txtNumber.Text = data?.Phone;
                    this.txtEmail.Text = data?.Email;
                    this.cmbSubscription.SelectedItem = data?.Subscription;
                    this.dtpValid.Value = data!.ExpirationDate;
                    ChangeBanner();
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection to database cannot be formed. Check if the server is up!","Error");
            }
            
        }

        private async Task GetAllAsync(string endpoint, HttpClient httpClient)
        {
            try
            {
                using HttpResponseMessage response = await httpClient.GetAsync($"/api{endpoint}");

                var jsonResponse = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<CustomerGetAllResponse>(jsonResponse);

                if (response.IsSuccessStatusCode)
                {
                    dgvData.DataSource = data?.Customers;
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "Database error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The server appears to be unresponsive.","Error");
            }
           
        }

        private async Task PutAsync(string endpoint, HttpClient httpClient, CustomerPutRes requestData)
        {
            var jsonContent = JsonConvert.SerializeObject(requestData);

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            using HttpResponseMessage response = await httpClient.PutAsync($"/api{endpoint}", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("User updated successfully");
            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }

        private async Task Put2Async(string endpoint, HttpClient httpClient, CustomerGetAll requestData)
        {
            var jsonContent = JsonConvert.SerializeObject(requestData);

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            using HttpResponseMessage response = await httpClient.PutAsync($"/api{endpoint}", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("User updated successfully");
            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }   


        private void ScanCode()
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


                    if (rez != System.String.Empty)
                    {

                        this.txtId.Text = rez;
                    }


                    else
                    {
                        MessageBox.Show($"The device at port {cmbPort.SelectedItem} was unable to scan a code.", "Timeout");
                    }

                }


            }


            catch (Exception)
            {
                MessageBox.Show($"Device communication error. Please check your connection at {this.cmbPort.SelectedItem}", "Error");
                ManageConnection();
            }


            this.btnScan.Enabled = true;
        }

        private void dtpValid_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpValid.Value <= DateTime.Now)
            {
                this.pbValid.Image = (Image)Resources.SharedResources.Invalid;
            }
            else
            {
                this.pbValid.Image = (Image)Resources.SharedResources.Valid;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();


        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var customer = new CustomerPutRes()
                {
                    Id = this.scndID,
                    Name = this.txtName.Text,
                    DateOfBirth = this.dtpDoB.Value,
                    Email = this.txtEmail.Text,
                    ExpirationDate = this.dtpValid.Value,
                    Phone = this.txtNumber.Text,
                    Sex = this.cmbSex.Text,
                    Subscription = this.cmbSubscription.Text
                };

                await PutAsync($"/customera/{customer.Id}", sharedClient, customer);

                SaveChanges();
            }

        }

        private void Clear()
        {
            this.cbEdit.Checked = false;


            this.pbSubscription.Image = null;

            this.txtId.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.cmbSex.SelectedItem = null;
            this.dtpDoB.Value = DateTime.Now;
            this.txtNumber.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.cmbSubscription.SelectedItem = null;
            this.dtpValid.Value = DateTime.Now;

            this.pbValid.Image = null;




            HandleEdit();
        }
        private void SaveChanges()
        {
            Clear();
        }

        private bool ValidateInput()
        {
            this.err.Clear();


            if (this.txtId.Text == null || this.txtId.Text == System.String.Empty)
            {
                this.err.SetError(this.txtId, "A code needs to be scanned to continue.");
                return false;
            }
            else if (this.txtName.Text == null || this.txtName.Text == System.String.Empty)
            {
                this.err.SetError(this.txtName, "The user entry requires a name.");
                return false;
            }
            else if (this.cmbSex.SelectedItem == null)
            {
                this.err.SetError(this.cmbSex, "The user entry requires a sex.");
                return false;
            }

            else if (DateTime.Now.Year - this.dtpDoB.Value.Year < 18 ||
                (DateTime.Now.Year - this.dtpDoB.Value.Year == 18 && DateTime.Now.Month < this.dtpDoB.Value.Month) ||
                (DateTime.Now.Year - this.dtpDoB.Value.Year == 18 && DateTime.Now.Month == this.dtpDoB.Value.Month && DateTime.Now.Day < this.dtpDoB.Value.Day)


                )
            {
                this.err.SetError(this.dtpDoB, "The user needs to be a person of age.");
                return false;
            }
            else if (this.txtNumber.Text == null || this.txtNumber.Text == System.String.Empty)
            {
                this.err.SetError(this.txtNumber, "The user needs to have a phone number.");
                return false;
            }
            else if (this.txtEmail.Text == null || this.txtEmail.Text == System.String.Empty)
            {
                this.err.SetError(this.txtEmail, "The user needs to have an E-Mail address.");
                return false;
            }
            else if (this.cmbSubscription.SelectedItem == null)
            {
                this.err.SetError(this.cmbSubscription, "Invalid subscription type.");
                return false;
            }
            else if (this.dtpValid.Value <= DateTime.Now)
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
            if (this.Connected == false)
            {
                if (this.pbConnection.Visible == true)
                {
                    this.pbConnection.Visible = false;
                }
                else
                {
                    this.pbConnection.Visible = true;
                }
            }

            else
            {
                if (this.pbConnection.Visible == false)
                {
                    this.pbConnection.Visible = true;
                }
            }
        }

        private void cbPermEdit_CheckedChanged(object sender, EventArgs e)
        {
            this.btnSavePerms.Enabled = this.cbPermEdit.Checked;
            this.grpPermissions.Enabled = this.cbPermEdit.Checked;

            this.grpQual.Enabled = false;
        }

        private async void btnSavePerms_Click(object sender, EventArgs e)
        {
            if (cbPermEdit.Checked == true)
            {
                var data = new CustomerGetAll()
                {
                    Id = this.slctdID,
                    Name = this.slctdName,
                    Filament = this.numStdFil.Value.ToString(),
                    Resin = this.numResin.Value.ToString(),
                    Cncmill = this.numCNCMill.Value.ToString(),
                    LaserCutter = this.numLsrCut.Value.ToString(),
                    PremiumFilament = this.numPremFil.Value.ToString(),
                    CrealityPrinters = this.cbCrealityPrinters.Checked,
                    Raise3D = this.cbRaise3D.Checked,
                    Lcdprinters = this.cbLCDPrinters.Checked,
                    Tools = this.cbTools.Checked,
                    Computers = this.cbComputers.Checked,
                    Electronics = this.cbElectronics.Checked
                };

                await Put2Async($"/customer/{data.Id}", sharedClient, data);
            }

            this.cbPermEdit.Checked = false;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvData.RowCount && e.ColumnIndex >= 0 && e.ColumnIndex <= 1)
            {
                var data = dgvData.SelectedRows[0].DataBoundItem as CustomerGetAll;
                this.slctdID = data!.Id!;
                this.slctdName = data!.Name!;
                this.txtSelect.Text = $"{data?.Name} ({data!.Id!})";
                this.numStdFil.Value = decimal.Parse(data!.Filament!);
                this.numResin.Value = decimal.Parse(data!.Resin!);
                this.numCNCMill.Value = decimal.Parse(data!.Cncmill!);
                this.numLsrCut.Value = decimal.Parse(data!.LaserCutter!);
                this.numPremFil.Value = decimal.Parse(data!.PremiumFilament!);

                this.cbCrealityPrinters.Checked = data.CrealityPrinters;
                this.cbRaise3D.Checked = data.Raise3D;
                this.cbLCDPrinters.Checked = data.Lcdprinters;
                this.cbTools.Checked = data.Tools;
                this.cbComputers.Checked = data.Computers;
                this.cbElectronics.Checked = data.Electronics;

            }
            
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }



        private void ChangeBanner()
        {
            if (this.cmbSubscription.SelectedItem as System.String == "Basic")
            {
                this.pbSubscription.Image = Resources.SharedResources.Basic;
            }
            else if (this.cmbSubscription.SelectedItem as System.String == "Student")
            {
                this.pbSubscription.Image = Resources.SharedResources.Student;
            }
            else if (this.cmbSubscription.SelectedItem as System.String == "Premium")
            {
                this.pbSubscription.Image = Resources.SharedResources.Premium;
            }
            else
            {
                this.pbSubscription.Image = Resources.SharedResources.Invalid;
            }
        }

        private void cmbSubscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBanner();
        }

        private void Wait(int time)
        {
            Thread.Sleep(time);
        }
    }
}
