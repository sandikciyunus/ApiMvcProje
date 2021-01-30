using ApiMvcProje.Business.Abstract;
using ApiMvcProje.DataAccess.Abstract;
using ApiMvcProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Business.Concrete
{
    public class ProductService:IProductService
    {
        private IProductDal _productDal;
        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Add(product);
        }

        public IList<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public IList<Product> GetByCategoryId(int id)
        {
            return _productDal.GetList(p => p.CategoryId == id);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        
    }
}
