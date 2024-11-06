using Core.DataAccess;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductDal : IProductDal
    {
      private readonly  List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product>() //burda bir product listesi oluşturuyorum.aşahıda da içini dolduyorum
            {
             new Product{Id=1,Name="ÇAMAŞIR MAKİNESİ",Price=500},
             new Product{Id=1,Name="KURUTMA MAKİNESİ",Price=1200},
             new Product{Id=1,Name="SAÇ MAKİNESİ",Price=400},

            };
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
           return _products; //sen burda neyi geri döndürürsen onun typide ondan olmalı
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
