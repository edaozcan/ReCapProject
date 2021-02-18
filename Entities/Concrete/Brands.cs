using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    class Brands:IEntity
    {
        public int BrandsId { get; set; }
        public int BrandsName { get; set; }

    }
}
