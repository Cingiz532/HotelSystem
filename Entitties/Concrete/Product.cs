using Entitties.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties.Concrete
{
    public class Product : BaseEntity
    {
        public string PrName { get; set; }
        public short PrCount { get; set; }
        public double PrPrice { get; set; }
        public string PrDescription { get; set; } = string.Empty;
    }
}
