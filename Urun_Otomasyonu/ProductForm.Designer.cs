
namespace Urun_Otomasyonu
{
    partial class ProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDiscontiuned = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nuReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nuUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nuUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nuUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.cmbSupplierID = new System.Windows.Forms.ComboBox();
            this.cmbCategoryID = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 72);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.chkDiscontiuned);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nuReorderLevel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nuUnitsOnOrder);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nuUnitsInStock);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nuUnitPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtQuantityPerUnit);
            this.panel2.Controls.Add(this.cmbSupplierID);
            this.panel2.Controls.Add(this.cmbCategoryID);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 276);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Satışta mı?";
            // 
            // chkDiscontiuned
            // 
            this.chkDiscontiuned.AutoSize = true;
            this.chkDiscontiuned.Location = new System.Drawing.Point(407, 176);
            this.chkDiscontiuned.Name = "chkDiscontiuned";
            this.chkDiscontiuned.Size = new System.Drawing.Size(15, 14);
            this.chkDiscontiuned.TabIndex = 34;
            this.chkDiscontiuned.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Kritik Seviye";
            // 
            // nuReorderLevel
            // 
            this.nuReorderLevel.DecimalPlaces = 2;
            this.nuReorderLevel.Location = new System.Drawing.Point(407, 135);
            this.nuReorderLevel.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nuReorderLevel.Name = "nuReorderLevel";
            this.nuReorderLevel.Size = new System.Drawing.Size(113, 25);
            this.nuReorderLevel.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Mevcut Sipariş";
            // 
            // nuUnitsOnOrder
            // 
            this.nuUnitsOnOrder.DecimalPlaces = 2;
            this.nuUnitsOnOrder.Location = new System.Drawing.Point(407, 104);
            this.nuUnitsOnOrder.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nuUnitsOnOrder.Name = "nuUnitsOnOrder";
            this.nuUnitsOnOrder.Size = new System.Drawing.Size(113, 25);
            this.nuUnitsOnOrder.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mevcut Stok";
            // 
            // nuUnitsInStock
            // 
            this.nuUnitsInStock.DecimalPlaces = 2;
            this.nuUnitsInStock.Location = new System.Drawing.Point(407, 74);
            this.nuUnitsInStock.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuUnitsInStock.Name = "nuUnitsInStock";
            this.nuUnitsInStock.Size = new System.Drawing.Size(113, 25);
            this.nuUnitsInStock.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fiyat";
            // 
            // nuUnitPrice
            // 
            this.nuUnitPrice.Location = new System.Drawing.Point(110, 137);
            this.nuUnitPrice.Name = "nuUnitPrice";
            this.nuUnitPrice.Size = new System.Drawing.Size(154, 25);
            this.nuUnitPrice.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Birim";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(110, 106);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(155, 25);
            this.txtQuantityPerUnit.TabIndex = 24;
            // 
            // cmbSupplierID
            // 
            this.cmbSupplierID.FormattingEnabled = true;
            this.cmbSupplierID.Location = new System.Drawing.Point(110, 174);
            this.cmbSupplierID.Name = "cmbSupplierID";
            this.cmbSupplierID.Size = new System.Drawing.Size(154, 25);
            this.cmbSupplierID.TabIndex = 23;
            // 
            // cmbCategoryID
            // 
            this.cmbCategoryID.FormattingEnabled = true;
            this.cmbCategoryID.Location = new System.Drawing.Point(110, 73);
            this.cmbCategoryID.Name = "cmbCategoryID";
            this.cmbCategoryID.Size = new System.Drawing.Size(159, 25);
            this.cmbCategoryID.TabIndex = 22;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(110, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(409, 25);
            this.txtProductName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tedarikçi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ürün Adı";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(110, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 348);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductForm";
            this.Text = "Ürün Formu";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDiscontiuned;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nuReorderLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuUnitsOnOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuUnitsInStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.ComboBox cmbSupplierID;
        private System.Windows.Forms.ComboBox cmbCategoryID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
    }
}