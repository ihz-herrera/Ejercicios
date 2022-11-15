using MyApp.Consultorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Entidades
{
    public class Cliente : Persona
    {
        public readonly string Path="";
        public readonly IRepository<Cliente> repository;
       
        public DateTime FechaNacimiento { get; set; }
        public string? Direccion { get; set; }



        public Cliente(IRepository<Cliente> repo)
        {
            repository = repo;
        }


        public override string ToString()
        {
            return $"{Id}, {Nombre}, {Apellido},{FechaNacimiento},{Direccion}";
        }

        public override List<Cliente> CargarDatos<Cliente>()
        {
            return repository.Consultar();
        }

        public void Guardar(List<Cliente> clientes)
        {
            repository.Guardar(clientes);
        }

    }
}
