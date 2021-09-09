namespace EsyLife
{
    partial class frmEditDelete
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.txtEditSponsor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtEditContact = new System.Windows.Forms.TextBox();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddBM = new System.Windows.Forms.Label();
            this.txtEditBM = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Futura-Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(157, 26);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(246, 20);
            this.lblAdd.TabIndex = 27;
            this.lblAdd.Text = "Edit/Delete Esylife Member";
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnCancel);
            this.grpAdd.Controls.Add(this.btnDelete);
            this.grpAdd.Controls.Add(this.txtEditID);
            this.grpAdd.Controls.Add(this.txtEditSponsor);
            this.grpAdd.Controls.Add(this.label2);
            this.grpAdd.Controls.Add(this.label1);
            this.grpAdd.Controls.Add(this.btnEdit);
            this.grpAdd.Controls.Add(this.lblContact);
            this.grpAdd.Controls.Add(this.txtEditContact);
            this.grpAdd.Controls.Add(this.lblAddSurname);
            this.grpAdd.Controls.Add(this.lblAddName);
            this.grpAdd.Controls.Add(this.lblAddBM);
            this.grpAdd.Controls.Add(this.txtEditBM);
            this.grpAdd.Controls.Add(this.txtEditSurname);
            this.grpAdd.Controls.Add(this.txtEditName);
            this.grpAdd.Location = new System.Drawing.Point(12, 66);
            this.grpAdd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpAdd.Size = new System.Drawing.Size(517, 413);
            this.grpAdd.TabIndex = 28;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Member details:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(242, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 39);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(108, 263);
            this.txtEditID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(388, 25);
            this.txtEditID.TabIndex = 24;
            // 
            // txtEditSponsor
            // 
            this.txtEditSponsor.Location = new System.Drawing.Point(107, 317);
            this.txtEditSponsor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtEditSponsor.Name = "txtEditSponsor";
            this.txtEditSponsor.Size = new System.Drawing.Size(388, 25);
            this.txtEditSponsor.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sponsor";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(133, 351);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 39);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(20, 216);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(49, 18);
            this.lblContact.TabIndex = 19;
            this.lblContact.Text = "Contact";
            // 
            // txtEditContact
            // 
            this.txtEditContact.Location = new System.Drawing.Point(107, 213);
            this.txtEditContact.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtEditContact.Name = "txtEditContact";
            this.txtEditContact.Size = new System.Drawing.Size(388, 25);
            this.txtEditContact.TabIndex = 18;
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Location = new System.Drawing.Point(20, 168);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(58, 18);
            this.lblAddSurname.TabIndex = 17;
            this.lblAddSurname.Text = "Surname ";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(20, 117);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(42, 18);
            this.lblAddName.TabIndex = 17;
            this.lblAddName.Text = "Name ";
            // 
            // lblAddBM
            // 
            this.lblAddBM.AutoSize = true;
            this.lblAddBM.Location = new System.Drawing.Point(20, 64);
            this.lblAddBM.Name = "lblAddBM";
            this.lblAddBM.Size = new System.Drawing.Size(70, 18);
            this.lblAddBM.TabIndex = 17;
            this.lblAddBM.Text = "BM Number";
            // 
            // txtEditBM
            // 
            this.txtEditBM.Location = new System.Drawing.Point(108, 57);
            this.txtEditBM.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtEditBM.Name = "txtEditBM";
            this.txtEditBM.Size = new System.Drawing.Size(387, 25);
            this.txtEditBM.TabIndex = 10;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Location = new System.Drawing.Point(108, 161);
            this.txtEditSurname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(387, 25);
            this.txtEditSurname.TabIndex = 9;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(108, 110);
            this.txtEditName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(387, 25);
            this.txtEditName.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 39);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(545, 493);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.lblAdd);
            this.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEditDelete";
            this.Text = "frmEditDelete";
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblAdd;
        public System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox txtEditID;
        public System.Windows.Forms.TextBox txtEditSponsor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblContact;
        public System.Windows.Forms.TextBox txtEditContact;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddBM;
        public System.Windows.Forms.TextBox txtEditBM;
        public System.Windows.Forms.TextBox txtEditSurname;
        public System.Windows.Forms.TextBox txtEditName;
    }
}