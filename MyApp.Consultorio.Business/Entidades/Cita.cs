using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Entidades
{
    public class Cita
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime Fecha { get; set; } = DateTime.Now;

        //! Propiedad de referencia
        public string ClienteId { get; set; }
        //! Propiedad de navegacion
        public Cliente Cliente { get; set; }

        public string DoctorId { get; set; }
        public Doctor Doctor { get; set; }

    }
}
