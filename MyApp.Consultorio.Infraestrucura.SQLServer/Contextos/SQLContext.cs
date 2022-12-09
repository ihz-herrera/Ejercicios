using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
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
        public DbSet<Cita> Citas { get; set; }


        public SQLContext(DbContextOptions opt):base(opt)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    builder.UseSqlServer("Server = LAP-IVANH\\MSSQLSERVER01;  Database = Consultorio; Trusted_Connection = true");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("dbo");



            builder.Entity<Cliente>().ToTable("Clientes", "cat")
                .HasKey(e => e.Id).HasName("codigoCliente");

            builder.Entity<Cliente>().Property(p =>p.Nombre)
                .HasMaxLength(50).IsRequired().HasColumnName("nombreCliente");

            builder.Entity<Cliente>().Property(p => p.Apellido)
                .HasMaxLength(50).IsRequired().HasColumnName("apellidoCliente");

            builder.Entity<Cliente>().Property(p => p.Direccion)
                .HasMaxLength(200).IsRequired().HasColumnName("direccion");




            builder.Entity<Doctor>().ToTable("Doctores", "cat")
               .HasKey(e => e.Id).HasName("codigoDoctor");

            builder.Entity<Doctor>().Property(p => p.Nombre)
                .HasMaxLength(50).IsRequired().HasColumnName("nombreDoctor");

            builder.Entity<Doctor>().Property(p => p.Apellido)
                .HasMaxLength(50).IsRequired().HasColumnName("apellidoDoctor");


            builder.Entity<Cita>().ToTable("RegCitas", "At")
                .HasKey(e => e.Id);

            builder.Entity<Cita>()
                .HasOne<Cliente>(sc => sc.Cliente)
                .WithMany(s => s.Citas)
                .HasForeignKey(e => e.ClienteId);

            builder.Entity<Cita>()
                .HasOne<Doctor>(sc => sc.Doctor)
                .WithMany(s => s.Citas)
                .HasForeignKey(e => e.DoctorId);


            //builder.Entity<Cliente>()
            //    .HasMany<Cita>(e => e.Citas)
            //    .WithOne(e => e.Cliente)
            //    .HasForeignKey(e => e.ClienteId);

        }

    }
}
