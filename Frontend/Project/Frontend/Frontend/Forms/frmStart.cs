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

namespace Frontend.Forms
{
    public partial class frmStart : Form
    {
        private List<UInt32> BaudRates;

        private List<string> PortNames;


        public frmStart()
        {
            InitializeComponent();


            this.BaudRates  = new List<UInt32>() {
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

        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            this.cmbBaud.DataSource= BaudRates;
            this.cmbBaud.SelectedIndex = 3;
            ScanPorts();

        }

        private void ScanPorts()
        {
            this.PortNames.Clear();

            this.PortNames = SerialPort.GetPortNames().ToList();

            MessageBox.Show($"{this.PortNames.Count()}");

            if (this.cmbPort.Enabled==false && this.PortNames.Count>0)
            {
                this.cmbPort.Enabled = true;
            }

            this.cmbPort.DataSource=this.PortNames;

        }


        private void btnScanPort_Click(object sender, EventArgs e)
        {
            ScanPorts();
            Verify_Selection();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }


        private void btnConnection_Click(object sender, EventArgs e)
        {

        }

        private void btnScanCard_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {

        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateUserResources_Click(object sender, EventArgs e)
        {

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
            if(this.cmbBaud.SelectedItem!=null && this.cmbPort.SelectedItem!=null)
            {
                this.btnConnect.Enabled = true;
            }

            else
            {
                this.btnConnect.Enabled=false; 
            }
        }
    }
}
