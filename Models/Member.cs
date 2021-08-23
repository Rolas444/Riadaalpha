using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riada.Models
{
    public class Member
    {
        public int Id { get; set; }
        public DateTime? DateBat {get;set;}
        public Person Person { get; set;}
        public ICollection<Ministry> Ministries { get; set; }

    }
}
