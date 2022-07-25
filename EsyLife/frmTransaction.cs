using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esylife_POS
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
            tmrTime.Start();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
        }
        public string GetTransactionNumber()
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            int increment = 1001;
            string transnum = date + increment.ToString();
            increment++;              

            return transnum;
        }
    }
}
