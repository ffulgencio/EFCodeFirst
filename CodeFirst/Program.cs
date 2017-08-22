using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ContextDBEntity db = new ContextDBEntity())
            {
                // Carrera c = new Carrera();
                var ca = db.Carreras.FirstOrDefault(x => x.Id == 2);// "Ing. En Sistemas";
                db.Carreras.Remove(ca);
                db.SaveChanges();
            }
        }
    }
}
