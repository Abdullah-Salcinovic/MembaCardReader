using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Forms
{
    public partial class frmStart : Form
    {
        private List<UInt32> BaudRates = new List<UInt32>() {
           1200,
           2400,
           4800,
           9600,
           14400,
           19200,
           38400,
           57600,
           115200
        };


        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            this.cmbBaud.DataSource= BaudRates;
            this.cmbBaud.SelectedIndex = 3;

            
        }

        private void btnScanPort_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
