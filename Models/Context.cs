using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Riada.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Address> addresses { get; set; }
        public DbSet<Evento> eventos { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<Ministry> ministries { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<TipoDoc> tipoDocs { get; set; }
        public DbSet<Ubigeo> ubigeos { get; set; }
    }
}
