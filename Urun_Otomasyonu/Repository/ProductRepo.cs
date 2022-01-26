using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Urun_Otomasyonu.Repository
{
    using Entities;
    using VM;
  

    //Veri tabanına erişim için kullanıyoruz.Repositoryi. 
    //Repository'de CRUD işlemlerini yaptığımız birr yer. 
    public class ProductRepo
    {
        //Her defasında connection oluşturuyyorum.Globalde tanımlasam.
        private SqlConnection con; //ProductReponun dışından erişilmesin. Fieldları dışarı kapatıyorduk.
        private string connectionString;
        public ProductRepo()
        {
            //Config dosyasına eklediğimiz connection string bilgisini configirationmanager nesnesi üzerinden okuduk.
            connectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            con = new SqlConnection();
            con = new SqlConnection(connectionString);
        }
        //liste Şeklinde Product Dönecek. Listeyi çekmeye ihtiyacım var.bu metot bu yüzden.
        public List<Product> GetProducts() // Producları çeken bir metot. Lista şeklinde product dönecek.
        {
            List<Product> products = new List<Product>();
            try
            {

                SqlCommand command = new SqlCommand("Sp_Productt", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (con.State == ConnectionState.Closed) con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var product=ProductMapping(reader);
                    products.Add(product);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return products;
        }

        //Tek Product dönen metodu yapalım..
        public Product Get(int ProductId)
        {
            //Id parametresini gönderirsem bana o ürünü dönsün.
            Product product = null;
                
            try
            {

                SqlCommand command = new SqlCommand("Sp_Productt", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", ProductId); //ProductId'yi gönderiyoruz.
                if (con.State == ConnectionState.Closed) con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product = ProductMapping(reader);
                  
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return product;
        }

        private Product ProductMapping(SqlDataReader reader)
        {
            Product product = new Product();
            product.ProductID = Convert.ToInt32(reader["ProductID"]);
            product.ProductName = reader["ProductName"].ToString();
            product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
            product.SupplierID = Convert.ToInt32(reader["SupplierID"]);
            product.QuantityPerUnit = reader["QuantityPerUnit"].ToString();
            product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
            product.UnitsInStock = Convert.ToInt16(reader["UnitsInStock"]);
            product.UnitsOnOrder = Convert.ToInt16(reader["UnitsOnOrder"]);
            product.ReorderLevel = Convert.ToInt16(reader["ReorderLevel"]);
            product.Discontinued = Convert.ToBoolean(reader["Discontinued"]);
            return product;
        }


        public List<VMProduct> GetVMProducts() // Productları çeken bir metot. Lista şeklinde product dönecek. Ekranda sadece Vm sınıfındakiler gözüksün diye yapıyoruz.
        {
            List<VMProduct> products = new List<VMProduct>();
            try
            {

                SqlCommand command = new SqlCommand("Sp_Productt", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (con.State == ConnectionState.Closed) con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    VMProduct product = new VMProduct();
                    product.ProductID = Convert.ToInt32(reader["ProductID"]);
                    product.ProductName = reader["ProductName"].ToString();
                    product.SupplierName = reader["SupplierName"].ToString();
                    product.CategoryName= reader["CategoryName"].ToString();


                    products.Add(product);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return products;
        }

        public int Create(Product item)
        {
            int id = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Create", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", item.ProductID);
                command.Parameters.AddWithValue("@ProductName", item.ProductName);
                command.Parameters.AddWithValue("@SupplierId", item.SupplierID);
                command.Parameters.AddWithValue("@CategoryId", item.CategoryID);
                command.Parameters.AddWithValue("@QantityPerUnit", item.QuantityPerUnit);
                command.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                command.Parameters.AddWithValue("@UnitsInStock", item.UnitsInStock);
                command.Parameters.AddWithValue("@UnitsOnOrder", item.UnitsOnOrder);
                command.Parameters.AddWithValue("@ReorderLevel", item.ReorderLevel);
                command.Parameters.AddWithValue("@Discontinued", item.Discontinued);
                if (con.State == ConnectionState.Closed) con.Open();
                id = Convert.ToInt32(command.ExecuteScalar());
                //ExecuteScalar sorgu tek bir değer döndürdüğünde kullanılır. Burada id yi döndürüyoruz.
                //Insert yaptığım zaman id yi alıyorum. Update işleminde Id Yi biliyorum ki update ediyorum.
            }
            catch (Exception ex)
            {
                //Loglama yap.           
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return id; 
        }
        public int Update(Product item)
        {
            int id = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Create", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", item.ProductID);
                command.Parameters.AddWithValue("@ProductName", item.ProductName);
                command.Parameters.AddWithValue("@SupplierId", item.SupplierID);
                command.Parameters.AddWithValue("@CategoryId", item.CategoryID);
                command.Parameters.AddWithValue("@QantityPerUnit", item.QuantityPerUnit);
                command.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                command.Parameters.AddWithValue("@UnitsInStock", item.UnitsInStock);
                command.Parameters.AddWithValue("@UnitsOnOrder", item.UnitsOnOrder);
                command.Parameters.AddWithValue("@ReorderLevel", item.ReorderLevel);
                command.Parameters.AddWithValue("@Discontinued", item.Discontinued);
                if (con.State == ConnectionState.Closed) con.Open();
                id = Convert.ToInt32(command.ExecuteScalar());
                //ExecuteScalar sorgu tek bir değer döndürdüğünde kullanılır. Burada id yi döndürüyoruz.
                //Insert yaptığım zaman id yi alıyorum. Update işleminde Id Yi biliyorum.
            }
            catch (Exception)
            {
                //Loglama yap.           
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return id; //benim gönderdiğim Id yi bana geri dön.
        }
    }
}
