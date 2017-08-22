using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class ContextDBEntity:DbContext
    {
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
    }
}
