using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Entities.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public bool isDeleted { get; set; }
        public IList<Product> Products { get; set; }
    }
}
