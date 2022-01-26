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
    public partial class Form1 : Form
    {
        ProductRepo productRepo; //kullanacağım şeyi field olarak tanımlıyorum.
        public Form1()
        {
            InitializeComponent();
            productRepo = new ProductRepo(); // Form 1'den örnek aldığında o anda hazır olsun.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            grdProducts.DataSource = productRepo.GetVMProducts();
        }

        private void grdProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            //tıklanan satırını alabileyim.
        {
            if (e.RowIndex == -1) return;
                   var product=  (grdProducts.DataSource as List<VM.VMProduct>)[e.RowIndex];
            //productId sine erişebiliyorum.
            //e.Rowindex tıklanan satırı aslında tespit edebiliyorum
            //Double click yapıldığında form cgüncelleme işlemi yapacak. çift tıkladığımda tag deıd varsa güncelleme işlemi yapıcaz.
            ProductForm form = new ProductForm();
            form.Tag = product.ProductID;
            form.ShowDialog();
            FillGrid();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
            FillGrid();
        }
    }
}
