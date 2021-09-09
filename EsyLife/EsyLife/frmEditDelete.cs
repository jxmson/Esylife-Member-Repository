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
    public partial class frmEditDelete : Form
    {
        Members member = new Members();
        frmMembers frmMembers;
        public frmEditDelete()
        {
            InitializeComponent();
        }

        private void txtAddBM_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEditID.Text) && String.IsNullOrEmpty(txtEditBM.Text))
                MessageBox.Show("Please select a member to edit.\nDouble click on a record to auto-fill the members information.", "Nothing to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);          
            else
            {
                member.ID_Number = txtEditID.Text;
                member.Name = txtEditName.Text;
                member.Surname = txtEditSurname.Text;
                member.ContactNum = int.Parse(txtEditContact.Text);
                member.Sponsor = txtEditSponsor.Text;
                member.BM_Number = txtEditBM.Text;

                bool updatesuccess = member.UpdateData(member);
                if (updatesuccess)
                {
                    frmMembers = new frmMembers();
                    MessageBox.Show("Member edited successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    DataTable dt = member.SelectData();
                    frmMembers.dgvRegisteredMembers.DataSource = dt;
                    this.Hide();
                    frmMembers.ShowDialog();
                }
                else
                    MessageBox.Show("Failed to edit member. \nTry again. If the problem persists, contact your administrator.", "Failed to edit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEditBM.Text))
            {                 
                MessageBox.Show("Please select a member to delete.\n Click once on a record to auto-fill the members information.", "Nothing to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMembers = new frmMembers();
                frmMembers.ShowDialog();
            }
            else
            {
                member.ID_Number = txtEditID.Text;
                member.Name = txtEditName.Text;
                member.Surname = txtEditSurname.Text;
                member.ContactNum = int.Parse(txtEditContact.Text);
                member.Sponsor = txtEditSponsor.Text;
                member.BM_Number = txtEditBM.Text;

                bool deletesuccess;
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this member?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    deletesuccess = member.DeleteData(member);

                    if (deletesuccess)
                    {
                        MessageBox.Show("Member deleted successfully", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DataTable dt = member.SelectData();
                        frmMembers = new frmMembers();
                        frmMembers.dgvRegisteredMembers.DataSource = dt;
                        frmMembers.ShowDialog();
                    }
                    else
                        MessageBox.Show("Failed to delete member. \nTry again. If the problem persists, contact your administrator.", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }               
            }
        }
    }
}
