using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun_Otomasyonu.Repository
{
   public interface IRepository<T>
    {
        //metotların bir standardı olsun diye ınterface oluşturduk. 
        //Repositolarin bir kalıbı olsun. Bir repositorin içinde bunların bulunması gerekiyor.En base şekkilde. Bu yüzden ınterfa oluşturduk. 
        //ınterfacele
        List<T> Get();
        T GetById(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
