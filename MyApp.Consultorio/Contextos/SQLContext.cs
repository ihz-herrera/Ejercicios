using Microsoft.EntityFrameworkCore;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Contextos
{
    public class SQLContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server = LAP-IVANH\\MSSQLSERVER01;  Database = Consultorio; Trusted_Connection = true");
        }

    }
}
