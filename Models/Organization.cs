using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riada.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DocumentID { get; set; }
        public Typedocument Tdocument { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        
    }
}
