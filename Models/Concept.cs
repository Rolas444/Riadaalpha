using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riada.Models
{
    public class Contribution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Active { get; set; } 
        public EntryEgress EntryEgress { get; set; }



    }
}
