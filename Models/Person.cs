using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riada.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Doc { get; set; }
        public DateTime? DateOfBirth  { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public Typedocument TDocument { get; set; }

    }
}
