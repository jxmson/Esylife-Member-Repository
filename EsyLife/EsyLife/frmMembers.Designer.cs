namespace EsyLife
{
    partial class frmMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembers));
            this.dgvRegisteredMembers = new System.Windows.Forms.DataGridView();
            this.btnRegPurchase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddUn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditRegistered = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredMembers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegisteredMembers
            // 
            this.dgvRegisteredMembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegisteredMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisteredMembers.Location = new System.Drawing.Point(302, 127);
            this.dgvRegisteredMembers.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dgvRegisteredMembers.Name = "dgvRegisteredMembers";
            this.dgvRegisteredMembers.Size = new System.Drawing.Size(642, 417);
            this.dgvRegisteredMembers.TabIndex = 22;
            this.dgvRegisteredMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegisteredMembers_CellContentClick);
            this.dgvRegisteredMembers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRegisteredMembers_RowHeaderMouseClick);
            this.dgvRegisteredMembers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRegisteredMembers_RowHeaderMouseDoubleClick);
            // 
            // btnRegPurchase
            // 
            this.btnRegPurchase.Location = new System.Drawing.Point(154, 127);
            this.btnRegPurchase.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRegPurchase.Name = "btnRegPurchase";
            this.btnRegPurchase.Size = new System.Drawing.Size(115, 32);
            this.btnRegPurchase.TabIndex = 25;
            this.btnRegPurchase.Text = "Purchase";
            this.btnRegPurchase.UseVisualStyleBackColor = true;
            this.btnRegPurchase.Click += new System.EventHandler(this.btnRegPurchase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewAll);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(329, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox1.Size = new System.Drawing.Size(533, 70);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search unregistered member by:";
            // 
            // btnViewAll
            // 
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewAll.Location = new System.Drawing.Point(441, 30);
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
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(358, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 25);
            this.txtSearch.TabIndex = 8;
            // 
            // btnAddUn
            // 
            this.btnAddUn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddUn.Location = new System.Drawing.Point(12, 127);
            this.btnAddUn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnAddUn.Name = "btnAddUn";
            this.btnAddUn.Size = new System.Drawing.Size(115, 32);
            this.btnAddUn.TabIndex = 19;
            this.btnAddUn.Text = "Add ";
            this.btnAddUn.UseVisualStyleBackColor = true;
            this.btnAddUn.Click += new System.EventHandler(this.btnAddUn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(889, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 32);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Registered members:";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(12, 245);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(257, 32);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back to unregistered members list";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditRegistered
            // 
            this.btnEditRegistered.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditRegistered.Location = new System.Drawing.Point(12, 186);
            this.btnEditRegistered.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnEditRegistered.Name = "btnEditRegistered";
            this.btnEditRegistered.Size = new System.Drawing.Size(115, 32);
            this.btnEditRegistered.TabIndex = 37;
            this.btnEditRegistered.Text = "Edit / Delete";
            this.btnEditRegistered.UseVisualStyleBackColor = true;
            this.btnEditRegistered.Click += new System.EventHandler(this.btnEditRegistered_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(960, 566);
            this.Controls.Add(this.btnEditRegistered);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddUn);
            this.Controls.Add(this.btnRegPurchase);
            this.Controls.Add(this.dgvRegisteredMembers);
            this.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMembers";
            this.Text = "Members";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredMembers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegPurchase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddUn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditRegistered;
        public System.Windows.Forms.DataGridView dgvRegisteredMembers;
    }
}