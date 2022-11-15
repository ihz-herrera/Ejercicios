using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Entidades
{
    public abstract class Persona
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual List<T> CargarDatos<T>()
        {
            throw new NotImplementedException();
        } 

    }
}
