using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun_Otomasyonu.Repository
{
    using Entities;
    using System.Data.SqlClient;

    public class CategoryRepo :RepositoryBase, IRepository<Category> // Söylediğim tipe göre interface oluşturuyorum.
    {
        public CategoryRepo() 
        {

        }
        public void Create(Category item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get() // herhangi bir parametreye gerek yok hepsi gelecek.
        {
            List<Category> categories = new List<Category>();
            SqlCommand command = new SqlCommand("Select CategoryID,CategoryName,Description,Picture From Categories", this.Connection);
            if (this.Connection.State == System.Data.ConnectionState.Closed) this.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                categories.Add(new Category()
                {
                    CategoryId = Convert.ToInt32(reader["CategoryId"]),
                    CategoryName = reader["CategoryName"].ToString(),
                    Description = reader["Description"].ToString(),
                    Picture = reader.IsDBNull(3)? null :(byte[])reader["Picture"]
                });           
             }
            if (this.Connection.State == System.Data.ConnectionState.Open) this.Connection.Close();
            return categories;
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
