using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Entities.Concrete
{
    public class Person:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
