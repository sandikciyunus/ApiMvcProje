using ApiMvcProje.Core.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiMvcProje.Dto.Concrete
{
    public class CategoryDTO:IDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
