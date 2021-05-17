namespace EsyLife
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblBM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtSearchSurname = new System.Windows.Forms.TextBox();
            this.txtSearchBM = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.radName = new System.Windows.Forms.RadioButton();
            this.radBM = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.radSurname = new System.Windows.Forms.RadioButton();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtAddContact = new System.Windows.Forms.TextBox();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddBM = new System.Windows.Forms.Label();
            this.txtAddBM = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSearch.SuspendLayout();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            // 
            // lblBM
            // 
            this.lblBM.AutoSize = true;
            this.lblBM.Location = new System.Drawing.Point(7, 63);
            this.lblBM.Name = "lblBM";
            this.lblBM.Size = new System.Drawing.Size(63, 13);
            this.lblBM.TabIndex = 1;
            this.lblBM.Text = "BM Number";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(6, 136);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(85, 23);
            this.btnAddMember.TabIndex = 3;
            this.btnAddMember.Text = "Add ";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtSearchSurname
            // 
            this.txtSearchSurname.Location = new System.Drawing.Point(76, 112);
            this.txtSearchSurname.Name = "txtSearchSurname";
            this.txtSearchSurname.Size = new System.Drawing.Size(219, 20);
            this.txtSearchSurname.TabIndex = 6;
            // 
            // txtSearchBM
            // 
            this.txtSearchBM.Location = new System.Drawing.Point(76, 60);
            this.txtSearchBM.Name = "txtSearchBM";
            this.txtSearchBM.Size = new System.Drawing.Size(219, 20);
            this.txtSearchBM.TabIndex = 7;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(76, 86);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(219, 20);
            this.txtSearchName.TabIndex = 8;
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(101, 30);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(53, 17);
            this.radName.TabIndex = 12;
            this.radName.TabStop = true;
            this.radName.Text = "Name";
            this.radName.UseVisualStyleBackColor = true;
            this.radName.CheckedChanged += new System.EventHandler(this.radName_CheckedChanged);
            // 
            // radBM
            // 
            this.radBM.AutoSize = true;
            this.radBM.Location = new System.Drawing.Point(10, 30);
            this.radBM.Name = "radBM";
            this.radBM.Size = new System.Drawing.Size(81, 17);
            this.radBM.TabIndex = 13;
            this.radBM.TabStop = true;
            this.radBM.Text = "BM Number";
            this.radBM.UseVisualStyleBackColor = true;
            this.radBM.CheckedChanged += new System.EventHandler(this.radBM_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name ";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(7, 115);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Surname ";
            // 
            // radSurname
            // 
            this.radSurname.AutoSize = true;
            this.radSurname.Location = new System.Drawing.Point(192, 30);
            this.radSurname.Name = "radSurname";
            this.radSurname.Size = new System.Drawing.Size(67, 17);
            this.radSurname.TabIndex = 16;
            this.radSurname.TabStop = true;
            this.radSurname.Text = "Surname";
            this.radSurname.UseVisualStyleBackColor = true;
            this.radSurname.CheckedChanged += new System.EventHandler(this.radSurname_CheckedChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.radBM);
            this.grpSearch.Controls.Add(this.lblSurname);
            this.grpSearch.Controls.Add(this.txtSearchSurname);
            this.grpSearch.Controls.Add(this.radSurname);
            this.grpSearch.Controls.Add(this.lblName);
            this.grpSearch.Controls.Add(this.txtSearchName);
            this.grpSearch.Controls.Add(this.radName);
            this.grpSearch.Controls.Add(this.lblBM);
            this.grpSearch.Controls.Add(this.txtSearchBM);
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(301, 171);
            this.grpSearch.TabIndex = 17;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search member by:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(98, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnEdit);
            this.grpAdd.Controls.Add(this.lblContact);
            this.grpAdd.Controls.Add(this.txtAddContact);
            this.grpAdd.Controls.Add(this.lblAddSurname);
            this.grpAdd.Controls.Add(this.lblAddName);
            this.grpAdd.Controls.Add(this.lblAddBM);
            this.grpAdd.Controls.Add(this.txtAddBM);
            this.grpAdd.Controls.Add(this.btnDelete);
            this.grpAdd.Controls.Add(this.btnAddMember);
            this.grpAdd.Controls.Add(this.txtAddSurname);
            this.grpAdd.Controls.Add(this.txtAddName);
            this.grpAdd.Location = new System.Drawing.Point(12, 189);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(301, 182);
            this.grpAdd.TabIndex = 17;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Member details:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(113, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 23);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(8, 113);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 19;
            this.lblContact.Text = "Contact";
            // 
            // txtAddContact
            // 
            this.txtAddContact.Location = new System.Drawing.Point(76, 110);
            this.txtAddContact.Name = "txtAddContact";
            this.txtAddContact.Size = new System.Drawing.Size(219, 20);
            this.txtAddContact.TabIndex = 18;
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Location = new System.Drawing.Point(6, 84);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(52, 13);
            this.lblAddSurname.TabIndex = 17;
            this.lblAddSurname.Text = "Surname ";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(7, 58);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(38, 13);
            this.lblAddName.TabIndex = 17;
            this.lblAddName.Text = "Name ";
            // 
            // lblAddBM
            // 
            this.lblAddBM.AutoSize = true;
            this.lblAddBM.Location = new System.Drawing.Point(7, 32);
            this.lblAddBM.Name = "lblAddBM";
            this.lblAddBM.Size = new System.Drawing.Size(63, 13);
            this.lblAddBM.TabIndex = 17;
            this.lblAddBM.Text = "BM Number";
            // 
            // txtAddBM
            // 
            this.txtAddBM.Location = new System.Drawing.Point(76, 29);
            this.txtAddBM.Name = "txtAddBM";
            this.txtAddBM.Size = new System.Drawing.Size(219, 20);
            this.txtAddBM.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(220, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(76, 84);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(219, 20);
            this.txtAddSurname.TabIndex = 9;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(76, 55);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(219, 20);
            this.txtAddName.TabIndex = 8;
            // 
            // dgvMembers
            // 
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(343, 12);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(445, 359);
            this.dgvMembers.TabIndex = 21;
            this.dgvMembers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMembers_RowHeaderMouseDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(669, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Esylife members";
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtSearchSurname;
        private System.Windows.Forms.TextBox txtSearchBM;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.RadioButton radBM;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.RadioButton radSurname;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddBM;
        private System.Windows.Forms.TextBox txtAddBM;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtAddContact;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

