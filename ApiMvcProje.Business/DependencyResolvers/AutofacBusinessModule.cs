using ApiMvcProje.Business.Abstract;
using ApiMvcProje.Business.Concrete;
using ApiMvcProje.DataAccess.Abstract;
using ApiMvcProje.DataAccess.Concrete;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Business.DependencyResolvers
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
        }
    }
}
