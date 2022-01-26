using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun_Otomasyonu.Repository
{
    using Entities;
    using System.Data.SqlClient;

    //Repositolarin belirl bir standardı olsun.Metotları standardı olsun.
    public class SupplierRepo :RepositoryBase, IRepository<Supplier>
    {
        public void Create(Supplier item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> Get()
        {
            List<Supplier> suppliers = new List<Supplier>();
            SqlCommand command = new SqlCommand("Select SupplierID,ContactTitle,ContactName,CompanyName From Suppliers", this.Connection);
            if (this.Connection.State == System.Data.ConnectionState.Closed) this.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                suppliers.Add(new Supplier()
                {
                   SupplierID = Convert.ToInt32(reader["SupplierID"]),
                    CompanyName = reader["CompanyName"].ToString(),
                    ContactName= reader["ContactName"].ToString(),
                    ContactTitle= reader["ContactTitle"].ToString(),
                });
            }
            if (this.Connection.State == System.Data.ConnectionState.Open) this.Connection.Close();
            return suppliers;
        }

        public Supplier GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Supplier item)
        {
            throw new NotImplementedException();
        }
    }
}
