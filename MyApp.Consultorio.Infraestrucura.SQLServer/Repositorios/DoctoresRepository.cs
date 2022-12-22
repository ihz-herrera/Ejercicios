using Microsoft.EntityFrameworkCore;
using MyApp.Consultorio.Business.Interfaces.Repositorios;
using MyApp.Consultorio.Entidades;
using MyApp.Consultorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Infraestrucura.SQLServer.Repositorios
{
    public class DoctoresRepository : Repository<Doctor>, IDoctoresRepository
    {
        public DoctoresRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Cita> ConsultarCitas(string doctorId)
        {
            return ConsultarPorId(doctorId).Citas;
        }

        public bool FechaDisponible(string doctorId, DateTime fecha)
        {
            return !ConsultarPorId(doctorId).
                Citas.Any(x => x.Fecha.Date == fecha.Date 
                && x.Fecha.Hour == fecha.Hour);
        }


     
    }
}
