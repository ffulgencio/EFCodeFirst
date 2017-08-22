using System.Collections.Generic;

namespace CodeFirst
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Profesor> Profesores { get; set; }
    }
}