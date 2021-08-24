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
    public partial class Form1 : Form
    {
        Members member = new Members();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            DataTable dt = member.SelectData();
            dgvMembers.DataSource = dt;

            txtSearchName.Enabled = txtSearchSurname.Enabled = txtSearchBM.Enabled = false;
            lblName.Enabled = lblSurname.Enabled = lblBM.Enabled = false;


        }

        private void radBM_CheckedChanged(object sender, EventArgs e)
        {

            txtSearchBM.Enabled = true;
            lblBM.Enabled = true;
        }
        private void radName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchName.Enabled =  true;
            lblName.Enabled =  true;
        }

        private void radSurname_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchSurname.Enabled = true;
            lblSurname.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radBM.Checked)
            {
                DataTable dt = member.SelectBM(txtSearchBM.Text);
                dgvMembers.DataSource = dt;
                radName.Checked = radSurname.Checked = false;

            }
            else if (radName.Checked)
            {
                DataTable dt = member.SelectName(txtSearchName.Text);
                dgvMembers.DataSource = dt;
                radBM.Checked = radSurname.Checked = false;
            }
            else if (radSurname.Checked)
            {
                DataTable dt = member.SelectSurname(txtSearchSurname.Text);
                dgvMembers.DataSource = dt;
                radBM.Checked = radName.Checked = false;
            }
            txtSearchBM.Clear(); txtSearchName.Clear(); txtSearchSurname.Clear();
             radBM.Checked = radName.Checked = radSurname.Checked = false;
            txtSearchName.Enabled = txtSearchSurname.Enabled = txtSearchBM.Enabled = false;
            lblName.Enabled = lblSurname.Enabled = lblBM.Enabled = false;
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddBM.Text))
                MessageBox.Show("Please add a BM Number for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddName.Text))
                MessageBox.Show("Please add a Name for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddSurname.Text))
                MessageBox.Show("Please add a Surname for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddContact.Text))
                MessageBox.Show("Please add a Contact for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtAddBM.Text.Substring(0, 2) == "BM" || txtAddBM.Text.Substring(0, 2) == "NF")
            {
                try
                {
                    member = new Members(txtAddBM.Text.ToUpper(), txtAddName.Text, txtAddSurname.Text, int.Parse(txtAddContact.Text));

                    bool insertsuccess = member.InsertData(member);
                    if (insertsuccess)
                        MessageBox.Show("Member added successfully", "Successfully added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to add member. \nTry again. If the problem persists, contact your administrator.", "Not added!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    DataTable dt = member.SelectData();
                    dgvMembers.DataSource = dt;

                    txtAddBM.Clear(); txtAddName.Clear(); txtAddSurname.Clear(); txtAddContact.Clear();
                }
                catch
                {
                    MessageBox.Show("Please enter a valid contact number. A contact number must be all numerics.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               

            }
            else
                MessageBox.Show("Please enter a valid BM or NF number. A valid BM number is prefixed by 'BM' and an NF Number by 'NF' ", "Invalid BM Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtAddBM.Text))
            {
                MessageBox.Show("Please select a member to delete.\nDouble click on a record to auto-fill the members information.", "Nothing to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                member.BM_Number = txtAddBM.Text;
                bool deletesuccess;
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this member?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    deletesuccess = member.DeleteData(member);

                    if (deletesuccess)
                        MessageBox.Show("Member deleted successfully", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to delete member. \nTry again. If the problem persists, contact your administrator.", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                DataTable dt = member.SelectData();
                dgvMembers.DataSource = dt;

                txtAddBM.Clear(); txtAddName.Clear(); txtAddSurname.Clear(); txtAddContact.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddBM.Text))
            {
                MessageBox.Show("Please select a member to edit.\nDouble click on a record to auto-fill the members information.", "Nothing to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                member.BM_Number = txtAddBM.Text;
                member.Name = txtAddName.Text;
                member.Surname = txtAddSurname.Text;
                member.ContactNum = int.Parse(txtAddContact.Text);

                bool updatesuccess = member.UpdateData(member);
                if (updatesuccess)
                    MessageBox.Show("Member edited successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("Failed to edit member. \nTry again. If the problem persists, contact your administrator.", "Failed to edit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                DataTable dt = member.SelectData();
                dgvMembers.DataSource = dt;

                txtAddBM.Clear(); txtAddName.Clear(); txtAddSurname.Clear(); txtAddContact.Clear();
            }
        }

        private void dgvMembers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtAddBM.Text = dgvMembers.Rows[rowIndex].Cells[0].Value.ToString();
            txtAddName.Text = dgvMembers.Rows[rowIndex].Cells[1].Value.ToString();
            txtAddSurname.Text = dgvMembers.Rows[rowIndex].Cells[2].Value.ToString();
            txtAddContact.Text = dgvMembers.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void grpSearch_Enter(object sender, EventArgs e)
        {

        }
    }
}
