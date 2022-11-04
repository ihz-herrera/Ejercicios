using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MyApp.Ejercicios.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Ejercicios.Contexto
{
    public class Context : DbContext
    {
        private const string cnString= "Server=LAP-IVANH\\MSSQLSERVER01; Database=MyApp; Trusted_Connection=True";

        public DbSet<Persona>  Personas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<ToDo> ToDos { get; set; }

        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(cnString);
        }


    }
}
