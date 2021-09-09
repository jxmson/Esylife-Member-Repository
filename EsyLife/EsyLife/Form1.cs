using System;
using System.Data;
using System.Windows.Forms;

namespace EsyLife
{
    public partial class Form1 : Form
    {
        NewMembers newmember = new NewMembers();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;



            DataTable dt = newmember.SelectData();
            dgvMembers.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = newmember.Search(txtSearch.Text);
            dgvMembers.DataSource = dt;
           
            txtSearch.Clear();
        }
         private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvMembers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtMemberID.Text = dgvMembers.Rows[rowIndex].Cells[0].Value.ToString();
            txtAddName1.Text = dgvMembers.Rows[rowIndex].Cells[1].Value.ToString();
            txtAddSurname1.Text = dgvMembers.Rows[rowIndex].Cells[2].Value.ToString();
            txtAddContact1.Text = dgvMembers.Rows[rowIndex].Cells[3].Value.ToString();
            txtMemberSponsor.Text = dgvMembers.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void grpSearch_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegMembers_Click(object sender, EventArgs e)
        {
            frmMembers members = new frmMembers();
            this.Hide();
            members.ShowDialog();
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAssignBM_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberID.Text))
                MessageBox.Show("Please select a member to assign a BM. Double click on a member from the list to select the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                frmAdd add = new frmAdd();               
                add.txtAddContact.Text = txtAddContact1.Text;
                add.txtAddID.Text = txtMemberID.Text;
                add.txtAddName.Text = txtAddName1.Text;
                add.txtAddSponsor.Text = txtMemberSponsor.Text;
                add.txtAddSurname.Text = txtAddSurname1.Text;
                add.lblAdd.Text = "Assign member BM Number";
                this.Hide();
                add.ShowDialog();
                
            }
        }

        private void btnAddUn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberID.Text))
                MessageBox.Show("Please add an ID Number for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddName1.Text))
                MessageBox.Show("Please add a Name for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddSurname1.Text))
                MessageBox.Show("Please add a Surname for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddContact1.Text))
                MessageBox.Show("Please add a Contact for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtMemberSponsor.Text))
                MessageBox.Show("Please add a Sponsor for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if(txtMemberSponsor.Text.Substring(0, 2) == "BM" || txtMemberSponsor.Text.Substring(0, 2) == "NF" || txtMemberSponsor.Text.Substring(0, 2) == "bm" || txtMemberSponsor.Text.Substring(0, 2) == "nf")
            {
                try
                {
                    newmember = new NewMembers(txtMemberID.Text.ToUpper(), txtAddName1.Text, txtAddSurname1.Text, int.Parse(txtAddContact1.Text), txtMemberSponsor.Text.ToUpper());

                    bool insertsuccess = newmember.InsertData(newmember);
                    if (insertsuccess)
                        MessageBox.Show("New member added successfully. Don't forget assign them a BM Number.", "Successfully added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to add new member. \nTry again. If the problem persists, contact your administrator.", "Not added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    DataTable dt = newmember.SelectData();
                    dgvMembers.DataSource = dt;

                    txtMemberID.Clear(); txtAddName1.Clear(); txtAddSurname1.Clear(); txtAddContact1.Clear(); txtMemberSponsor.Clear();
                }
                catch
                {
                    MessageBox.Show("Please make sure the format of each entry field is correct. \nContact number may not contain any letters", "Incorrect format detected.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Please enter a valid BM or NF number for the sponsor. A valid BM number is prefixed by 'BM' and an NF Number by 'NF' ", "Invalid sponsor BM Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberID.Text) && String.IsNullOrEmpty(txtAddName1.Text))
            {
                MessageBox.Show("Please select a member to edit.\nDouble click on a record to auto-fill the members information.", "Nothing to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                newmember.ID_Number = txtMemberID.Text;
                newmember.Name = txtAddName1.Text;
                newmember.Surname = txtAddSurname1.Text;
                newmember.ContactNum = int.Parse(txtAddContact1.Text);
                newmember.Sponsor = txtMemberSponsor.Text;

                bool updatesuccess =  newmember.UpdateData(newmember);
                if (updatesuccess)
                    MessageBox.Show("Member edited successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("Failed to edit member. \nTry again. If the problem persists, contact your administrator.", "Failed to edit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                DataTable dt = newmember.SelectData();
                dgvMembers.DataSource = dt;

                txtMemberID.Clear(); txtAddName1.Clear(); txtAddSurname1.Clear(); txtAddContact1.Clear(); txtMemberSponsor.Clear();
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberID.Text))
            {
                MessageBox.Show("Please select a member to delete.\nDouble click on a record to auto-fill the members information.", "Nothing to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                newmember.ID_Number = txtMemberID.Text;
                newmember.Name = txtAddName1.Text;
                newmember.Surname = txtAddSurname1.Text;
                newmember.ContactNum = int.Parse(txtAddContact1.Text);
                newmember.Sponsor = txtMemberSponsor.Text;

                bool deletesuccess;
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this member?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    deletesuccess = newmember.DeleteData(newmember);

                    if (deletesuccess)
                        MessageBox.Show("Member deleted successfully", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to delete member. \nTry again. If the problem persists, contact your administrator.", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                DataTable dt = newmember.SelectData();
                dgvMembers.DataSource = dt;

                txtMemberID.Clear(); txtAddName1.Clear(); txtAddSurname1.Clear(); txtAddContact1.Clear(); txtMemberSponsor.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMemberID.Clear(); txtAddName1.Clear(); txtAddSurname1.Clear(); txtAddContact1.Clear(); txtMemberSponsor.Clear();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
                MessageBox.Show("Please enter a keyword to search for", "Empty search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dt = newmember.Search(txtSearch.Text);
                dgvMembers.DataSource = dt;
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataTable dt = newmember.SelectData();
            dgvMembers.DataSource = dt;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

        }
    }
}
