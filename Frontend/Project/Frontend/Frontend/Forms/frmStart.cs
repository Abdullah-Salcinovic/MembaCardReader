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
using System.Drawing.Drawing2D;
using System.Reflection.Metadata;

namespace Frontend.Forms
{



    public partial class frmStart : Form
    {
        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("http://192.168.1.138:5974")
        };

        private string slctdID;
        private string slctdName;
        private string scndID;

        private int Loading;

        private const float Rotating_Angle = 10.0f;

        private readonly Point PanelLoc = new Point(248, 12);


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



            this.CurrentPanel = this.pnlConnection;



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


        }

        private void frmStart_Load(object sender, EventArgs e)
        {



            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(Panel) && item != this.pnlButtons)
                {
                    item.Location = this.PanelLoc;
                }
            }


            this.cmbSex.DataSource = this.Sexes;
            this.cmbSubscription.DataSource = this.Subscriptions;
            this.cmbValue.DataSource = this.SearchFilters;

            HandleEdit();
            
          

            this.CurrentPanel = this.pnlConnection;


            ScanPorts();
        }

        private async void ScanPorts()
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

                        ChangeFormText("Please wait...");


                       



                        await Task.Run(() =>
                        {

                            Delay(SCN.ID_DELAY);

                        });

                        ChangeFormText();


                        string msg = tempSerialPort.ReadExisting();



                        tempSerialPort.DiscardInBuffer();
                        tempSerialPort.DiscardOutBuffer();

                        if (msg == SCN.RESPONSE)
                        {

                            try
                            {
                                tempSerialPort.WriteLine(SCN.TYPE);

                                ChangeFormText("Please wait...");

                                await Task.Run(() =>
                                {

                                    Delay(SCN.TYPE_DELAY);

                                });



                                ChangeFormText();

                                string typ = tempSerialPort.ReadExisting();

                                COM_Scanner com = new COM_Scanner(typ, portName);



                                this.ValidPorts.Add(com);
                                this.BaudIdeal.Add(baud);

                                break;

                            }
                            catch (Exception)
                            {

                                MessageBox.Show($"Unexpected disconnection. Please make sure your connection with the device at port {portName} is secure.", "Error");
                            }


                        }



                        tempSerialPort.Close();



                    }


                    tempSerialPort.Dispose();

                }

                catch (Exception)
                {
                    MessageBox.Show($"Device port not opening. Please check your connection with {portName}", "Error");

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

        private async void ManageConnection()
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
                    if (this.OpenPort.IsOpen)
                    {
                        this.OpenPort.Close();
                    }

                    this.OpenPort.Open();

                    this.OpenPort.WriteLine(SCN.ID);

                    ChangeFormText("Please wait...");

                   
                    await Task.Run(() =>
                    {

                        Delay(SCN.ID_DELAY);

                    });

                    ChangeFormText();

                    string msg = this.OpenPort!.ReadExisting();


                    if (msg != SCN.RESPONSE)
                    {
                        MessageBox.Show($"The device {this.cmbPort.SelectedItem} may be unresponsive or not valid.", "Timeout");
                    }

                    else
                    {
                        this.btnConnect.Text = "Disconnect";
                        this.lblConnectionStatus.Text = "Connected";

                    
                        this.cmbPort.Enabled = false;
                        this.btnScanPort.Enabled = false;
                        this.pbConnection.Image = Resources.SharedResources.Green;
                        this.Connected = true;

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"Device port not opening. Please check your connection with {this.cmbPort.SelectedItem}", "Error");

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

                this.cmbPort.Enabled = true;
                this.btnScanPort.Enabled = true;

                this.pbConnection.Image = Resources.SharedResources.Red;


                ScanPorts();
            }

        }



        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verify_Selection();
        }

        private void cmbBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verify_Selection();
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

                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection to database cannot be formed. Check if the server is up!", "Error");
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
                MessageBox.Show("The server appears to be unresponsive.", "Error");
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


        private async void ScanCode()
        {
            this.btnScan.Enabled = false;

            Clear();


            try
            {



                this.OpenPort!.WriteLine(SCN.ID);


                ChangeFormText("Please wait...");

                await Task.Run(() =>
                {

                    Delay(SCN.ID_DELAY);

                });

                ChangeFormText();

                string msg = this.OpenPort!.ReadExisting();

                this.OpenPort!.DiscardInBuffer();
                this.OpenPort!.DiscardOutBuffer();



                if (msg != SCN.RESPONSE)
                {


                    MessageBox.Show($"The device {this.cmbPort.SelectedItem} may be unresponsive or not valid.", "Timeout");
                    ManageConnection();
                }


                else
                {


                    this.OpenPort!.WriteLine(SCN.SCAN);

                    ChangeFormText("Scanning...");

                    await Task.Run(() =>
                    {

                        Delay(SCN.SCAN_DELAY);

                    });

                    ChangeFormText();

                    string rez = this.OpenPort!.ReadExisting();


                    if (rez != System.String.Empty)
                    {

                        this.txtId.Text = rez;
                    }


                    else
                    {
                        MessageBox.Show($"The device {cmbPort.SelectedItem} was unable to scan a code.", "Timeout");
                    }

                }


            }


            catch (Exception)
            {

                MessageBox.Show($"Device communication error. Please check your connection with {this.cmbPort.SelectedItem}", "Error");
                ManageConnection();
            }


            this.btnScan.Enabled = true;
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




            this.txtId.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.cmbSex.SelectedItem = null;
            this.dtpDoB.Value = DateTime.Now;
            this.txtNumber.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.cmbSubscription.SelectedItem = null;
            this.dtpValid.Value = DateTime.Now;


            this.err.Clear();


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

       
        private async void btnSavePerms_Click(object sender, EventArgs e)
        {
            if (cbEdit.Checked == true)
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
                    CrealityPrinters = this.pbCreality.Image == Resources.SharedResources.Green,
                    Raise3D = this.pbRaise3D.Image == Resources.SharedResources.Green,
                    Lcdprinters = this.pbLCD.Image == Resources.SharedResources.Green,
                    Tools = this.pbTools.Image == Resources.SharedResources.Green,
                    Computers = this.pbComputers.Image == Resources.SharedResources.Green,
                    Electronics = this.pbElectronics.Image == Resources.SharedResources.Green
                };

                await Put2Async($"/customer/{data.Id}", sharedClient, data);
            }

            this.cbEdit.Checked = false;
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

                this.pbCreality.Image = (data.CrealityPrinters) ? Resources.SharedResources.Green : Resources.SharedResources.Red;
                this.pbRaise3D.Image = (data.Raise3D) ? Resources.SharedResources.Green : Resources.SharedResources.Red;
                this.pbLCD.Image = (data.Lcdprinters) ? Resources.SharedResources.Green : Resources.SharedResources.Red;
                this.pbTools.Image = (data.Tools) ? Resources.SharedResources.Green : Resources.SharedResources.Red;
                this.pbComputers.Image = (data.Computers) ? Resources.SharedResources.Green : Resources.SharedResources.Red;
                this.pbElectronics.Image = (data.Electronics) ? Resources.SharedResources.Green : Resources.SharedResources.Red;

            }

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }


        private void Delay(int time)
        {




            this.Loading = time;

            Thread.Sleep(time);

            this.Loading = 0;

            this.pbLogo.Image = Resources.SharedResources.Logo;



        }

        private void ChangeFormText(string text = "Garaža Makerspace")
        {
            this.Text = text;
        }

        private void anim_Tick(object sender, EventArgs e)
        {

            if (this.Loading >= 1000)
            {
                Bitmap newimg = new Bitmap(this.pbLogo.Width, this.pbLogo.Height);


                using (Graphics gfx = Graphics.FromImage(newimg))
                {

                    gfx.Clear(Color.Transparent);

                    gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    gfx.TranslateTransform((float)this.pbLogo.Width / 2, (float)this.pbLogo.Height / 2);

                    gfx.RotateTransform(Rotating_Angle);

                    gfx.TranslateTransform(-(float)this.pbLogo.Width / 2, -(float)this.pbLogo.Height / 2);


                    gfx.DrawImage(this.pbLogo.Image, 0, 0, this.pbLogo.Width, this.pbLogo.Height);

                    gfx.Dispose();

                }

                this.pbLogo.Image = newimg;

            }


        }

       
    }




}
