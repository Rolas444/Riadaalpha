using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riada.Models
{
    public class Ubigeo
    {
        public int Id { get; set; }
        public string Code { get; set; } 
        public string Dpto { get; set; }
        public string Prov { get; set; }
        public string Dist { get; set; }
        public string Code2 { get; set; }
        public string Order { get; set; }

        public ICollection<Address> addresses { get; set; }

    }
}
