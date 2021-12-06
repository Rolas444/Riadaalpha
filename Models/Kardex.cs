using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riada.Models
{
    public class Kardex
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public decimal nTotal { get; set; }
        public int Currency { get; set; }
        public string document { get; set; }
        public DateTime? DateOperation { get; set; }
        public Statekardex state { get; set; }

    }
}
