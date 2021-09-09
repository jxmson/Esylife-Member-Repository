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
    public partial class frmAdd : Form
    {
        Members member;
        NewMembers newmembers;
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddBM.Text))
                MessageBox.Show("Please add a BM Number for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddID.Text))
                MessageBox.Show("Please add an ID Number for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddName.Text))
                MessageBox.Show("Please add a Name for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddSurname.Text))
                MessageBox.Show("Please add a Surname for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddContact.Text))
                MessageBox.Show("Please add a Contact for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtAddSponsor.Text))
                MessageBox.Show("Please add a Sponsor for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtAddBM.Text.Substring(0,2) == "BM" || txtAddBM.Text.Substring(0, 2) == "NF" || txtAddBM.Text.Substring(0, 2) == "bm" || txtAddBM.Text.Substring(0, 2) == "nf" )
            {
                if (txtAddSponsor.Text.Substring(0, 2) == "BM" || txtAddSponsor.Text.Substring(0, 2) == "NF" || txtAddSponsor.Text.Substring(0, 2) == "bm" || txtAddSponsor.Text.Substring(0, 2) == "nf")
                {
                    try
                    {
                        member = new Members(txtAddBM.Text.ToUpper(), txtAddID.Text, txtAddName.Text, txtAddSurname.Text, int.Parse(txtAddContact.Text), txtAddSponsor.Text.ToUpper());
                        newmembers = new NewMembers(txtAddID.Text, txtAddName.Text, txtAddSurname.Text, int.Parse(txtAddContact.Text), txtAddSponsor.Text);

                        bool insertsuccess = member.InsertData(member);
                        if (insertsuccess)
                        {
                            MessageBox.Show("Member added successfully.", "Successfully added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            newmembers.DeleteData(newmembers);

                            Form1 f = new Form1();
                            DataTable dt = newmembers.SelectData();
                            f.dgvMembers.DataSource = dt;

                            frmMembers m = new frmMembers();
                            DataTable data = member.SelectData();
                            m.dgvRegisteredMembers.DataSource = data;
                            this.Hide();

                            if (lblAdd.Text == "Assign member BM Number")
                                f.ShowDialog();
                            else
                                m.ShowDialog();                                                                          
                        }
                        else
                            MessageBox.Show("Failed to add new member. \nTry again. If the problem persists, contact your administrator.", "Not added!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        txtAddID.Clear(); txtAddName.Clear(); txtAddSurname.Clear(); txtAddContact.Clear(); txtAddSponsor.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Please make sure the format of each entry field is correct. \nContact number may not contain any letters", "Incorrect format detected.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure that the Sponsor's BM or NF number is valid. A valid BM number is prefixed by 'BM' and an NF Number by 'NF' ", "Invalid sponsor BM Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
                MessageBox.Show("Please make sure that the Member's BM or NF number is valid. A valid BM number is prefixed by 'BM' and an NF Number by 'NF' ", "Invalid sponsor BM Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
