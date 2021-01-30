using ApiMvcProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Business.Abstract
{
    public interface IProductService
    {
        IList<Product> GetAll();
        Product GetById(int id);
        IList<Product> GetByCategoryId(int id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
