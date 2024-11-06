using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // class -- reference type olacak . referans tiiplerini tutacak yani 
    //IEntityde bizim veritabınımza karşılık gelen sınıfllarını tutacak
    //new -- newlenebilir olmak zorunda
    //newleme sebebimiz bizim IEntity varlığımız interface olduğu için onlarda newleme olmadığı için burda ekstra newlenebilir olsun istiyoruz generiç yapımızın 
    public interface IEntityRepository<T> where T : class, IEntity, new() //new sonda olması lazım 
    {
        List<T> GetAll();
        List<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
