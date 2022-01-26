using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Otomasyonu
{
    using Repository;
    using Entities;
    public partial class ProductForm : Form
    {
        CategoryRepo categoryRepo;
        SupplierRepo supplierRepo;
        ProductRepo productRepo;
        public ProductForm()
        {
            InitializeComponent();
            categoryRepo = new CategoryRepo();
            supplierRepo = new SupplierRepo();
            productRepo = new ProductRepo();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillControls();
            FillData();

        }
        //ekran eğer bir kayıt üzerinden açılır ise. Update modda çalışacak ise selecteditem dolu olması lazım.
        Product selectedItem = null;

        private void FillData()
        {
            int productId = Convert.ToInt32(this.Tag);
            if (productId > 0)
            {
                var product = productRepo.Get(productId);
                if (product != null)
                {
                    selectedItem = product;


                    txtProductName.Text = product.ProductName;
                    cmbCategoryID.SelectedValue = product.CategoryID;
                    txtQuantityPerUnit.Text = product.QuantityPerUnit;
                    nuUnitPrice.Value = Convert.ToDecimal(product.UnitPrice);
                    cmbSupplierID.SelectedValue = product.SupplierID;
                    nuUnitsInStock.Value = Convert.ToDecimal(product.UnitsInStock);
                    nuUnitsOnOrder.Value = Convert.ToDecimal(product.UnitsOnOrder);
                    nuReorderLevel.Value = Convert.ToDecimal(product.ReorderLevel);
                    chkDiscontiuned.Checked = product.Discontinued;
                }
            }

        }

        private void FillControls()
        {
            FillCategory();
            FillSupplier();
        }

        private void FillSupplier()
        {
            var suppliers = supplierRepo.Get();
            cmbSupplierID.DisplayMember = "CompanyName";
            cmbSupplierID.ValueMember = "SupplierID";
            cmbSupplierID.DataSource = suppliers;
        }

        private void FillCategory()
        {
            var categories = categoryRepo.Get();

            cmbCategoryID.DisplayMember = "CategoryName";
            cmbCategoryID.ValueMember = "CategoryId";
            cmbCategoryID.DataSource = categories;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
        }
        public void FormSave()
        {
            if (this.selectedItem == null) //Null değilse Update işlemi olcak.
            {
                this.selectedItem = new Product();
            }

            //Formun insert işlemi yapmak istediği anlamına gelir.
            //Burası hem ınsertte hem update de çalışacak.
            this.selectedItem = new Product();
            this.selectedItem.ProductName = txtProductName.Text;
            this.selectedItem.SupplierID = Convert.ToInt32(cmbSupplierID.SelectedValue);
            this.selectedItem.CategoryID = Convert.ToInt32(cmbCategoryID.SelectedValue);
            this.selectedItem.QuantityPerUnit = txtQuantityPerUnit.Text;
            this.selectedItem.UnitPrice = nuUnitPrice.Value;
            this.selectedItem.UnitsInStock = Convert.ToInt16(nuUnitsInStock.Value);
            this.selectedItem.UnitsOnOrder = Convert.ToInt16(nuUnitsOnOrder.Value);
            this.selectedItem.ReorderLevel = Convert.ToInt16(nuReorderLevel.Value);
            this.selectedItem.Discontinued = chkDiscontiuned.Checked;

            if (Convert.ToInt32(this.Tag) == 0)
            {
                //Insert
                this.selectedItem.ProductID = productRepo.Create(this.selectedItem);
                this.Tag = this.selectedItem.ProductID;
            }
            else
            // 1 kere basınca ınsert ikinci kez basınca update oluyor.
            {
                productRepo.Update(this.selectedItem);
            }
          
        }

    }
}
