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
    public class CitasRepository : Repository<Cita>, ICitasRepository
    {
        public CitasRepository(DbContext context) : base(context)
        {
        }
    }
}
