using MyApp.Consultorio.Business.Interfaces.Repositorios;
using MyApp.Consultorio.Business.Interfaces.Servicios;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Business.Servicios
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repo;

        public ClienteService(IClienteRepository repo)
        {
            this._repo = repo;
        }

        public Cliente AgregarCliente(Cliente cliente)
        {

            //! Validar si el cliente existe
            if(!(_repo.ConsultarporNombre(cliente.Nombre) is null))
            {
                throw new ValidationException("El cliente ya existe en la base de datos");
            }

            //Crear un nuevo Cliente
            var cte = new Cliente();
            cte.AgregarCliente(cliente);


            //Guardar Cambios

            return cte;

        }
    }
}
