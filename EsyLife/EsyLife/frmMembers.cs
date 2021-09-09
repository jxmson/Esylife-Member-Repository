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
    public partial class frmMembers : Form
    {
        Members member = new Members();
        frmEditDelete editdelete = new frmEditDelete();
        public frmMembers()
        {
            InitializeComponent();

            DataTable dt = member.SelectData();
            dgvRegisteredMembers.DataSource = dt;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvRegisteredMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUn_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.lblAdd.Text = "Add member information";
            this.Hide();
            add.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
                MessageBox.Show("Please enter a keyword to search for", "Empty search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dt = member.Search(txtSearch.Text);
                dgvRegisteredMembers.DataSource = dt;
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataTable dt = member.SelectData();
            dgvRegisteredMembers.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEditRegistered_Click(object sender, EventArgs e)
        {
            if (dgvRegisteredMembers.SelectedRows.Count == 0)
                MessageBox.Show("Select a member first", "No member selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                editdelete.ShowDialog();
        }
        private void dgvRegisteredMembers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            editdelete.txtEditBM.Text = dgvRegisteredMembers.Rows[rowIndex].Cells[0].Value.ToString();
            editdelete.txtEditName.Text = dgvRegisteredMembers.Rows[rowIndex].Cells[1].Value.ToString();
            editdelete.txtEditSurname.Text = dgvRegisteredMembers.Rows[rowIndex].Cells[2].Value.ToString();
            editdelete.txtEditID.Text = dgvRegisteredMembers.Rows[rowIndex].Cells[3].Value.ToString();
            editdelete.txtEditContact.Text = dgvRegisteredMembers.Rows[rowIndex].Cells[4].Value.ToString();
            editdelete.txtEditSponsor.Text = dgvRegisteredMembers.Rows[rowIndex].Cells[5].Value.ToString();
        }
    }
}
