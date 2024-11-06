using Business.Abstarct;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

      
        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void ApplyBusinessRules(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
           return _ProductDal.GetAll();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
