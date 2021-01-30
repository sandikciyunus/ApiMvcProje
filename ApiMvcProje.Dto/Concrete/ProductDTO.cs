using ApiMvcProje.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Dto.Concrete
{
    public class ProductDTO:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        
    }
}
