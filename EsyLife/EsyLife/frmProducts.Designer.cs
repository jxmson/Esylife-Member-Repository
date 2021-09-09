namespace EsyLife
{
    partial class frmProducts
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.btnAssignBM = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(387, 18);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(366, 370);
            this.dgvProducts.TabIndex = 23;
            this.dgvProducts.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_RowHeaderMouseDoubleClick);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.nudQuantity);
            this.grpAdd.Controls.Add(this.btnDeleteProduct);
            this.grpAdd.Controls.Add(this.btnEdit1);
            this.grpAdd.Controls.Add(this.btnAssignBM);
            this.grpAdd.Controls.Add(this.btnAddProduct);
            this.grpAdd.Controls.Add(this.btnClear);
            this.grpAdd.Controls.Add(this.lblContact);
            this.grpAdd.Controls.Add(this.lblAddSurname);
            this.grpAdd.Controls.Add(this.lblAddName);
            this.grpAdd.Controls.Add(this.txtPrice);
            this.grpAdd.Controls.Add(this.txtProductName);
            this.grpAdd.Location = new System.Drawing.Point(12, 18);
            this.grpAdd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpAdd.Size = new System.Drawing.Size(349, 286);
            this.grpAdd.TabIndex = 30;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Product details:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(116, 140);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(213, 25);
            this.nudQuantity.TabIndex = 29;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteProduct.Location = new System.Drawing.Point(248, 192);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(81, 32);
            this.btnDeleteProduct.TabIndex = 27;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnEdit1
            // 
            this.btnEdit1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit1.Location = new System.Drawing.Point(136, 192);
            this.btnEdit1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(81, 32);
            this.btnEdit1.TabIndex = 26;
            this.btnEdit1.Text = "Edit";
            this.btnEdit1.UseVisualStyleBackColor = true;
            this.btnEdit1.Click += new System.EventHandler(this.btnEdit1_Click);
            // 
            // btnAssignBM
            // 
            this.btnAssignBM.Location = new System.Drawing.Point(180, 233);
            this.btnAssignBM.Name = "btnAssignBM";
            this.btnAssignBM.Size = new System.Drawing.Size(138, 32);
            this.btnAssignBM.TabIndex = 28;
            this.btnAssignBM.Text = "Assign BM";
            this.btnAssignBM.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProduct.Location = new System.Drawing.Point(25, 192);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(81, 32);
            this.btnAddProduct.TabIndex = 19;
            this.btnAddProduct.Text = "Add ";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(25, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 32);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(20, 142);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(55, 18);
            this.lblContact.TabIndex = 19;
            this.lblContact.Text = "Quantity";
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Location = new System.Drawing.Point(20, 98);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(34, 18);
            this.lblAddSurname.TabIndex = 17;
            this.lblAddSurname.Text = "Price";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(20, 53);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(42, 18);
            this.lblAddName.TabIndex = 17;
            this.lblAddName.Text = "Name ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(116, 95);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(213, 25);
            this.txtPrice.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(116, 50);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(213, 25);
            this.txtProductName.TabIndex = 8;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(907, 529);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.dgvProducts);
            this.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProducts";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnAssignBM;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductName;
    }
}