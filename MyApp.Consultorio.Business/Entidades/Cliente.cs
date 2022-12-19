using MyApp.Consultorio.Business.Interfaces.Common;
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

        //! Propiedad de Navegacion
        public List<Cita> Citas { get; set; }



        public Cliente(IRepository<Cliente> repo)
        {
            repository = repo;
        }

        public Cliente()
        {
            //! Crear un ID
            Id ??= Guid.NewGuid().ToString();
        }


        public override string ToString()
        {
            return $"{((IEntity)this).Id}, {Nombre}, {Apellido},{FechaNacimiento},{Direccion}";
        }



        public void AgregarCliente(Cliente cliente)
        {

            //Todo: Validar datos de entrada
            if (String.IsNullOrEmpty(cliente.Nombre) || String.IsNullOrEmpty(cliente.Apellido) )
            {
                throw new ArgumentException("Las propiedades deben tener un valor. " +
                    "La propiedadad Nombre, Apellidos o Direccion estan vacias");
            }

            if( DateTime.Today.Year - cliente.FechaNacimiento.Year < 18)
            {
                throw new ArgumentException("El cliente debe tener mas de 18 años");
            }

           
            repository.Agregar(cliente);
        }
       

        public List<Cliente> CargarDatos()
        {
            return repository.Consultar();
        }

        public void Guardar(List<Cliente> clientes)
        {
            repository.Guardar(clientes);
        }

    }
}
