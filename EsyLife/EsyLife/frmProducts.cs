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
    public partial class frmProducts : Form
    {
        Product product;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            decimal result;

            if (String.IsNullOrEmpty(txtProductName.Text))
                MessageBox.Show("Please add a product name", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtPrice.Text))
                MessageBox.Show("Please add a product price", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (decimal.TryParse(txtPrice.Text, out result))
            {
                try
                {
                    product = new Product(txtProductName.Text, decimal.Parse(txtPrice.Text), (int)nudQuantity.Value);

                    bool insertsuccess = product.Insert(product);
                    if (insertsuccess)
                        MessageBox.Show("New product added successfully", "Successfully added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to add new member. \nTry again. If the problem persists, contact your administrator.", "Not added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    DataTable dt = product.SelectData();
                    dgvProducts.DataSource = dt;

                    txtProductName.Clear(); txtPrice.Clear(); nudQuantity.Value = 0;
                }
                catch
                {
                    MessageBox.Show("Please make sure the format of each entry field is correct.", "Incorrect format detected.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Make sure that price is in the correct format. Cents must be separated by a comma (,)");
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            //if(String.IsNullOrEmpty(txt))
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
