using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public int BrandsId { get; set; }
        public int ColorId { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }


    }
}
