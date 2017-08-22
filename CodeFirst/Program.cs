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
                // AGREGAR
                Carrera c = new Carrera();
                c.Nombre = "Telematica";
                db.Carreras.Add(c);
                db.SaveChanges();

                ////ELIMINAR
                //var ca = db.Carreras.FirstOrDefault(x => x.Id == 2);// "Ing. En Sistemas";
                //db.Carreras.Remove(ca);
                //db.SaveChanges();

                //MODIFICAR
                //var ca = db.Carreras.FirstOrDefault(x => x.Id == 2);// "Ing. En Sistemas";
                //ca.Nombre = "Ing. En Sistemas";
                //db.SaveChanges();
            }
        }
    }
}
