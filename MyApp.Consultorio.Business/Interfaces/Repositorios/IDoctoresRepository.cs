using MyApp.Consultorio.Business.Interfaces.Common;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Business.Interfaces.Repositorios
{
    public interface IDoctoresRepository:IRepository<Doctor>
    {

        IEnumerable<Cita> ConsultarCitas(string doctorId);

        bool FechaDisponible(string doctorId, DateTime fecha);


    }
}
