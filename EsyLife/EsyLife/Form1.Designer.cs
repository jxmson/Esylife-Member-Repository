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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRegMembers = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnAssignBM = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.btnAddUn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddName1 = new System.Windows.Forms.TextBox();
            this.txtAddSurname1 = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.txtAddContact1 = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberSponsor = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 9;
            // 
            // dgvMembers
            // 
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(436, 139);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(539, 429);
            this.dgvMembers.TabIndex = 21;
            this.dgvMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellContentClick);
            this.dgvMembers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMembers_RowHeaderMouseDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(927, 29);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 32);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Unregistered members:";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnViewAll);
            this.grpSearch.Controls.Add(this.label6);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpSearch.Location = new System.Drawing.Point(436, 15);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpSearch.Size = new System.Drawing.Size(459, 70);
            this.grpSearch.TabIndex = 25;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search unregistered member by:";
            // 
            // btnViewAll
            // 
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewAll.Location = new System.Drawing.Point(362, 30);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(86, 32);
            this.btnViewAll.TabIndex = 20;
            this.btnViewAll.Text = "View all";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(279, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 32);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 25);
            this.txtSearch.TabIndex = 8;
            // 
            // btnRegMembers
            // 
            this.btnRegMembers.Location = new System.Drawing.Point(33, 521);
            this.btnRegMembers.Name = "btnRegMembers";
            this.btnRegMembers.Size = new System.Drawing.Size(138, 35);
            this.btnRegMembers.TabIndex = 26;
            this.btnRegMembers.Text = "Registered Members";
            this.btnRegMembers.UseVisualStyleBackColor = true;
            this.btnRegMembers.Click += new System.EventHandler(this.btnRegMembers_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(247, 521);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(138, 32);
            this.btnPurchase.TabIndex = 27;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnAssignBM
            // 
            this.btnAssignBM.Location = new System.Drawing.Point(191, 322);
            this.btnAssignBM.Name = "btnAssignBM";
            this.btnAssignBM.Size = new System.Drawing.Size(138, 32);
            this.btnAssignBM.TabIndex = 28;
            this.btnAssignBM.Text = "Assign BM";
            this.btnAssignBM.UseVisualStyleBackColor = true;
            this.btnAssignBM.Click += new System.EventHandler(this.btnAssignBM_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete1.Location = new System.Drawing.Point(271, 281);
            this.btnDelete1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(81, 32);
            this.btnDelete1.TabIndex = 27;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnEdit1
            // 
            this.btnEdit1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit1.Location = new System.Drawing.Point(146, 281);
            this.btnEdit1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(81, 32);
            this.btnEdit1.TabIndex = 26;
            this.btnEdit1.Text = "Edit";
            this.btnEdit1.UseVisualStyleBackColor = true;
            this.btnEdit1.Click += new System.EventHandler(this.btnEdit1_Click);
            // 
            // btnAddUn
            // 
            this.btnAddUn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddUn.Location = new System.Drawing.Point(23, 281);
            this.btnAddUn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnAddUn.Name = "btnAddUn";
            this.btnAddUn.Size = new System.Drawing.Size(81, 32);
            this.btnAddUn.TabIndex = 19;
            this.btnAddUn.Text = "Add ";
            this.btnAddUn.UseVisualStyleBackColor = true;
            this.btnAddUn.Click += new System.EventHandler(this.btnAddUn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(37, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 32);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAddName1
            // 
            this.txtAddName1.Location = new System.Drawing.Point(116, 50);
            this.txtAddName1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAddName1.Name = "txtAddName1";
            this.txtAddName1.Size = new System.Drawing.Size(236, 25);
            this.txtAddName1.TabIndex = 8;
            // 
            // txtAddSurname1
            // 
            this.txtAddSurname1.Location = new System.Drawing.Point(116, 95);
            this.txtAddSurname1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAddSurname1.Name = "txtAddSurname1";
            this.txtAddSurname1.Size = new System.Drawing.Size(236, 25);
            this.txtAddSurname1.TabIndex = 9;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(20, 57);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(42, 18);
            this.lblAddName.TabIndex = 17;
            this.lblAddName.Text = "Name ";
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Location = new System.Drawing.Point(20, 95);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(58, 18);
            this.lblAddSurname.TabIndex = 17;
            this.lblAddSurname.Text = "Surname ";
            // 
            // txtAddContact1
            // 
            this.txtAddContact1.Location = new System.Drawing.Point(115, 142);
            this.txtAddContact1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAddContact1.Name = "txtAddContact1";
            this.txtAddContact1.Size = new System.Drawing.Size(237, 25);
            this.txtAddContact1.TabIndex = 18;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(22, 142);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(49, 18);
            this.lblContact.TabIndex = 19;
            this.lblContact.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sponsor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID number";
            // 
            // txtMemberSponsor
            // 
            this.txtMemberSponsor.Location = new System.Drawing.Point(115, 237);
            this.txtMemberSponsor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtMemberSponsor.Name = "txtMemberSponsor";
            this.txtMemberSponsor.Size = new System.Drawing.Size(237, 25);
            this.txtMemberSponsor.TabIndex = 23;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(115, 190);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(237, 25);
            this.txtMemberID.TabIndex = 24;
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnDelete1);
            this.grpAdd.Controls.Add(this.btnEdit1);
            this.grpAdd.Controls.Add(this.btnAssignBM);
            this.grpAdd.Controls.Add(this.btnAddUn);
            this.grpAdd.Controls.Add(this.btnCancel);
            this.grpAdd.Controls.Add(this.txtMemberID);
            this.grpAdd.Controls.Add(this.txtMemberSponsor);
            this.grpAdd.Controls.Add(this.label4);
            this.grpAdd.Controls.Add(this.label5);
            this.grpAdd.Controls.Add(this.lblContact);
            this.grpAdd.Controls.Add(this.txtAddContact1);
            this.grpAdd.Controls.Add(this.lblAddSurname);
            this.grpAdd.Controls.Add(this.lblAddName);
            this.grpAdd.Controls.Add(this.txtAddSurname1);
            this.grpAdd.Controls.Add(this.txtAddName1);
            this.grpAdd.Location = new System.Drawing.Point(33, 134);
            this.grpAdd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpAdd.Size = new System.Drawing.Size(381, 367);
            this.grpAdd.TabIndex = 29;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Member details:";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Location = new System.Drawing.Point(860, 97);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(115, 32);
            this.btnAdmin.TabIndex = 25;
            this.btnAdmin.Text = "Admin Login";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1018, 673);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnRegMembers);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Esylife members";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRegMembers;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnAssignBM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddUn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox txtAddName1;
        private System.Windows.Forms.TextBox txtAddSurname1;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.TextBox txtAddContact1;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemberSponsor;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.GroupBox grpAdd;
        public System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Button btnAdmin;
    }
}

