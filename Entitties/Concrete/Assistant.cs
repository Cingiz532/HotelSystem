using Entitties.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties.Concrete
{//Burada default bir tarix ver.
    public class Assistant : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }
        public DateTime Birthday { get; set; }
    }
}
