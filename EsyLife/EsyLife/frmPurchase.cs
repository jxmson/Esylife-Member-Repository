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
    public partial class frmPurchase : Form
    {
        Product p = new Product();
        public frmPurchase()
        {
            InitializeComponent();
            lblPurchasefor.Text = "trdrdjdk";
            //nudBulkXiang.Maximum = p.GetBulkQuantity.;
        }

        
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (radCash.Checked = radDeposit.Checked = radEcocash.Checked = radEFT.Checked = radMpesa.Checked = false)
                MessageBox.Show("Please selct method of payment.", "Select payment method");
            else
            {
                decimal moneyDue = (p.GetMemberPrice(lblCoffee.Text) * nudBulkCoffee.Value) + (p.GetMemberPrice(lblDay.Text) * nudBulkDay.Value) + (p.GetMemberPrice(lblEsyplum.Text) * nudBulkEsyplum.Value) + (p.GetMemberPrice(lblHazelnut.Text) * nudBulkHazelnut.Value) + (p.GetMemberPrice(lblLiners.Text) * nudBulkLiners.Value) + (p.GetMemberPrice(lblMoringa.Text) * nudBulkMoringa.Value) + (p.GetMemberPrice(lblNight.Text) * nudBulkNight.Value) + (nudBulkPlum.Value) + (p.GetMemberPrice(lblStem.Text) * nudBulkStem.Value) + (p.GetMemberPrice(lblWater.Text) * nudBulkWater.Value) + (p.GetMemberPrice(lblXiang.Text) * nudBulkXiang.Value);

                MessageBox.Show("Products successfully purchased: Money due is " + moneyDue.ToString("C"), "Payment due", MessageBoxButtons.OKCancel);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMembers frm = new frmMembers();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
