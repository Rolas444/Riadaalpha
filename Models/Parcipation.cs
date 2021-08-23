using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riada.Models
{
    public class Parcipation
    {
        public int Id { get; set; }
        public Evento Evento { get; set; }
        public Member Member { get; set; }
        public DateTime? DateEvent { get; set; }
        public int Estado { get; set; }
    }
}
