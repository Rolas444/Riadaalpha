using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riada.Models
{
    public class Address
    {
        public int Id {get;set;}
        public string Descripcion { get; set; }
        public string Number { get; set; }
        public string Reference { get; set; }
        public int State { get; set; }
        public Ubigeo Ubigeo { get; set; }
        public Person Person { get; set; }



    }
}
