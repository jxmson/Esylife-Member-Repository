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
                    product = new Product(txtProductName.Text, decimal.Parse(txtPrice.Text), decimal.Parse(txtMemberPrice.Text), (int)nudQuantity.Value);

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
                MessageBox.Show("Make sure that the price is in the correct format. Cents must be separated by a comma (,)");
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtProductName.Text) && String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please select a product to edit. \nDouble click on a record to auto-fill the product's information.", "Nothing to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                product = new Product(txtProductName.Text,decimal.Parse(txtPrice.Text), decimal.Parse(txtMemberPrice.Text), (int)nudQuantity.Value);

                bool updatesuccess = product.Update(product);
                if (updatesuccess)
                    MessageBox.Show("Product edited successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("Failed to edit member. \nTry again. If the probloem persists, contact our administrator.", "Failed to edit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                DataTable dt = product.SelectData();
                dgvProducts.DataSource = dt;

                txtPrice.Clear(); txtProductName.Clear(); nudQuantity.Value = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Clear(); txtProductName.Clear(); nudQuantity.Value = 0;
        }

        private void dgvProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtProductName.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            txtMemberPrice.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            nudQuantity.Value = decimal.Parse(dgvProducts.Rows[rowIndex].Cells[3].Value.ToString());
        }

        private void btnBackk_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please select a product to delete.\nDouble click on a record to auto-fill the members information.", "Nothing to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                product.regbulkPrice = decimal.Parse(txtMemberPrice.Text);
                product.bulkPrice = decimal.Parse(txtPrice.Text);
                product.Name = txtProductName.Text;
                product.Quantity = (int)nudQuantity.Value;

                bool deletesuccess;
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this member?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    deletesuccess = product.Delete(product);

                    if (deletesuccess)
                        MessageBox.Show("Member deleted successfully", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to delete member. \nTry again. If the problem persists, contact your administrator.", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                DataTable dt = product.SelectData();
                dgvProducts.DataSource = dt;

                txtPrice.Clear(); txtProductName.Clear(); nudQuantity.Value = 0;
            }
        }
    }
}
