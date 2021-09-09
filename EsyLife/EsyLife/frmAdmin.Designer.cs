namespace EsyLife
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnPurchaseReport = new System.Windows.Forms.Button();
            this.btnFinanceReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRemainingStock = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPurchaseReport
            // 
            this.btnPurchaseReport.Location = new System.Drawing.Point(12, 132);
            this.btnPurchaseReport.Name = "btnPurchaseReport";
            this.btnPurchaseReport.Size = new System.Drawing.Size(200, 36);
            this.btnPurchaseReport.TabIndex = 24;
            this.btnPurchaseReport.Text = "Purchase Report";
            this.btnPurchaseReport.UseVisualStyleBackColor = true;
            // 
            // btnFinanceReport
            // 
            this.btnFinanceReport.Location = new System.Drawing.Point(12, 190);
            this.btnFinanceReport.Name = "btnFinanceReport";
            this.btnFinanceReport.Size = new System.Drawing.Size(200, 36);
            this.btnFinanceReport.TabIndex = 25;
            this.btnFinanceReport.Text = "Financial Report";
            this.btnFinanceReport.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Remaining stock:";
            // 
            // lstRemainingStock
            // 
            this.lstRemainingStock.FormattingEnabled = true;
            this.lstRemainingStock.ItemHeight = 18;
            this.lstRemainingStock.Location = new System.Drawing.Point(231, 132);
            this.lstRemainingStock.Name = "lstRemainingStock";
            this.lstRemainingStock.Size = new System.Drawing.Size(308, 238);
            this.lstRemainingStock.TabIndex = 34;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 36);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(12, 253);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(200, 36);
            this.btnProducts.TabIndex = 35;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(556, 623);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.lstRemainingStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFinanceReport);
            this.Controls.Add(this.btnPurchaseReport);
            this.Font = new System.Drawing.Font("Futura BdCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPurchaseReport;
        private System.Windows.Forms.Button btnFinanceReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRemainingStock;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnProducts;
    }
}