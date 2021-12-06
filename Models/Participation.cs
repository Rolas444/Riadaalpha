using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riada.Models
{
    public class Participation
    {
        public int Id { get; set; }
        public Evento Evento { get; set; }
        public Person Person { get; set; }
        public int Estado { get; set; }
    }
}
