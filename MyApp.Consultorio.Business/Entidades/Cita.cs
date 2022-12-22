using MyApp.Consultorio.Business.Interfaces.Common;
using MyApp.Consultorio.Transversal.Guards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Entidades
{
    public class Cita:IEntity
    {

        public string Id { get; private set; }

        public DateTime Fecha { get; private set; } = DateTime.Now;

        public string? Motivo { get; private set; }

        //! Propiedad de referencia
        public string ClienteId { get; private set; }
        //! Propiedad de navegacion
        public Cliente Cliente { get;  set; }

        public string DoctorId { get; private set; }
        public Doctor Doctor { get;  set; }



        //Todo: Tarea Agregar Funcionalidad Citas
        /***
         * Validar la entrada de datos (mismo cliente - misma hora)!
         * 
         */

       

        public Cita()
        {
            
        }

        public Cita(string clienteId, string doctorId, DateTime fechaConsulta, string motivo=""):this()
        {
            Id ??= Guid.NewGuid().ToString();
            ClienteId = clienteId.IsId();
            DoctorId = doctorId.IsId();
            Fecha = fechaConsulta
                .HourBetween(8,19)
                .LaborDays().AfterNow();
            Motivo = motivo;
        }

        internal void Update(string doctorId, DateTime fechaConsulta)
        {
            if(fechaConsulta == Fecha && DoctorId == doctorId)
            {
                return;
            }

            DoctorId = doctorId.IsId();
            Fecha = fechaConsulta.
                HourBetween(8, 19)
                .LaborDays().AfterNow();

           
            //Guard.NotNull(
            //Guard.AfterNow(Guard.LaborDays( 
            //   Guard.HourBetween(Fecha, 10, 20, "")
            //   ,"")
            //   ,"")
            //,"");
        }

        public enum PartTime
        {
            Hour,Day,Month,Year
        }
    }
}
