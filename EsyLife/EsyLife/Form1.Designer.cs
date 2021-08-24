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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSearch.SuspendLayout();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 10;
            // 
            // lblBM
            // 
            this.lblBM.AutoSize = true;
            this.lblBM.Location = new System.Drawing.Point(17, 181);
            this.lblBM.Name = "lblBM";
            this.lblBM.Size = new System.Drawing.Size(70, 18);
            this.lblBM.TabIndex = 1;
            this.lblBM.Text = "BM Number";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 9;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(20, 234);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(99, 32);
            this.btnAddMember.TabIndex = 3;
            this.btnAddMember.Text = "Add ";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtSearchSurname
            // 
            this.txtSearchSurname.Location = new System.Drawing.Point(93, 174);
            this.txtSearchSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchSurname.Name = "txtSearchSurname";
            this.txtSearchSurname.Size = new System.Drawing.Size(332, 25);
            this.txtSearchSurname.TabIndex = 6;
            // 
            // txtSearchBM
            // 
            this.txtSearchBM.Location = new System.Drawing.Point(93, 124);
            this.txtSearchBM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBM.Name = "txtSearchBM";
            this.txtSearchBM.Size = new System.Drawing.Size(332, 25);
            this.txtSearchBM.TabIndex = 7;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(93, 73);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(333, 25);
            this.txtSearchName.TabIndex = 8;
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(188, 37);
            this.radName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(57, 22);
            this.radName.TabIndex = 12;
            this.radName.TabStop = true;
            this.radName.Text = "Name";
            this.radName.UseVisualStyleBackColor = true;
            this.radName.CheckedChanged += new System.EventHandler(this.radName_CheckedChanged);
            // 
            // radBM
            // 
            this.radBM.AutoSize = true;
            this.radBM.Location = new System.Drawing.Point(10, 37);
            this.radBM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radBM.Name = "radBM";
            this.radBM.Size = new System.Drawing.Size(88, 22);
            this.radBM.TabIndex = 13;
            this.radBM.TabStop = true;
            this.radBM.Text = "BM Number";
            this.radBM.UseVisualStyleBackColor = true;
            this.radBM.CheckedChanged += new System.EventHandler(this.radBM_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 18);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name ";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(17, 131);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 18);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Surname ";
            // 
            // radSurname
            // 
            this.radSurname.AutoSize = true;
            this.radSurname.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSurname.Location = new System.Drawing.Point(325, 37);
            this.radSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radSurname.Name = "radSurname";
            this.radSurname.Size = new System.Drawing.Size(73, 22);
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
            this.grpSearch.Controls.Add(this.lblBM);
            this.grpSearch.Controls.Add(this.lblName);
            this.grpSearch.Controls.Add(this.txtSearchName);
            this.grpSearch.Controls.Add(this.txtSearchBM);
            this.grpSearch.Controls.Add(this.radSurname);
            this.grpSearch.Controls.Add(this.radName);
            this.grpSearch.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpSearch.Location = new System.Drawing.Point(27, 98);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Size = new System.Drawing.Size(444, 252);
            this.grpSearch.TabIndex = 17;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search member by:";
            this.grpSearch.Enter += new System.EventHandler(this.grpSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(188, 207);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 32);
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
            this.grpAdd.Location = new System.Drawing.Point(27, 358);
            this.grpAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAdd.Size = new System.Drawing.Size(444, 274);
            this.grpAdd.TabIndex = 17;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Member details:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(171, 234);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 32);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(17, 197);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(49, 18);
            this.lblContact.TabIndex = 19;
            this.lblContact.Text = "Contact";
            // 
            // txtAddContact
            // 
            this.txtAddContact.Location = new System.Drawing.Point(93, 190);
            this.txtAddContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddContact.Name = "txtAddContact";
            this.txtAddContact.Size = new System.Drawing.Size(333, 25);
            this.txtAddContact.TabIndex = 18;
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Location = new System.Drawing.Point(17, 145);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(58, 18);
            this.lblAddSurname.TabIndex = 17;
            this.lblAddSurname.Text = "Surname ";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(17, 99);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(42, 18);
            this.lblAddName.TabIndex = 17;
            this.lblAddName.Text = "Name ";
            // 
            // lblAddBM
            // 
            this.lblAddBM.AutoSize = true;
            this.lblAddBM.Location = new System.Drawing.Point(17, 48);
            this.lblAddBM.Name = "lblAddBM";
            this.lblAddBM.Size = new System.Drawing.Size(70, 18);
            this.lblAddBM.TabIndex = 17;
            this.lblAddBM.Text = "BM Number";
            // 
            // txtAddBM
            // 
            this.txtAddBM.Location = new System.Drawing.Point(93, 41);
            this.txtAddBM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddBM.Name = "txtAddBM";
            this.txtAddBM.Size = new System.Drawing.Size(332, 25);
            this.txtAddBM.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(325, 234);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(93, 142);
            this.txtAddSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(332, 25);
            this.txtAddSurname.TabIndex = 9;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(93, 92);
            this.txtAddName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(332, 25);
            this.txtAddName.TabIndex = 8;
            // 
            // dgvMembers
            // 
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(499, 46);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(443, 527);
            this.dgvMembers.TabIndex = 21;
            this.dgvMembers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMembers_RowHeaderMouseDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(660, 592);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 32);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(957, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Esylife members";
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

