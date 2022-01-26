using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Urun_Otomasyonu.Repository
{
    //İçindekilerde abstrack olcak.Repository'ye yardımcı olması için yazıyoruz.
    public abstract class RepositoryBase
    {
        //bağlantı kısmını standartlaştırdım.

        SqlConnection connection = null;
        public RepositoryBase()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString);
        }

        
        public SqlConnection Connection
        {
            get
            {
                return connection; 
            }
            
        }




    }
}
