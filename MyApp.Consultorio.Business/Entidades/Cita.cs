using MyApp.Consultorio.Business.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Entidades
{
    public class Cita:IEntity
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime Fecha { get; set; } = DateTime.Now;

        //! Propiedad de referencia
        public string ClienteId { get; set; }
        //! Propiedad de navegacion
        public Cliente Cliente { get; set; }

        public string DoctorId { get; set; }
        public Doctor Doctor { get; set; }



        //Todo: Tarea Agregar Funcionalidad Citas
        /***
         * Validar la entrada de datos (mismo cliente - misma hora)!
         * 
         */

        public Cita AgregarCita(Cita cita) => new Cita();

    }
}
