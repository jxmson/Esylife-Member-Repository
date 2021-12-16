using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsyLife
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnPurchaseReport_Click(object sender, EventArgs e)
        {

        }
    }
}
