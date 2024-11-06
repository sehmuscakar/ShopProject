using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public interface IServiceRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        // İş katmanına özgü ekstra metotlar:
        bool Validate(T entity);  // Doğrulama işlemleri için
        void ApplyBusinessRules(T entity);  // İş kuralları için
    }


}
