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
        private readonly IClientesRepository _repo;
        private readonly ICitasRepository _citaRepo;
        private readonly IDoctoresRepository _doctorRepo;

        public ClienteService(IClientesRepository repo, ICitasRepository citaRepo,
            IDoctoresRepository doctorRepo)
        {
            this._repo = repo;
            _citaRepo = citaRepo;
            _doctorRepo = doctorRepo;
        }

        public Cita AgregarCita(string clienteId, string doctorId, DateTime fechaConsulta, string motivo = "")
        {

            //Validar que el cliente exista
            if (_repo.ConsultarPorId(clienteId) == null)
            {
                throw new ValidationException ("El cliente no existe");
            }
            //Validar que el doctor exista
            if (_doctorRepo.ConsultarPorId(doctorId) == null)
            {
                throw new ValidationException("El Doctor no existe");
            }
            
            //Validar que ni el doctor ni el paciente tengan citas en mismo horario
            if(_doctorRepo.FechaDisponible(doctorId,fechaConsulta) && 
                _repo.FechaDisponible(clienteId,fechaConsulta))
                throw new ValidationException("Fecha no disponible");

            var cita = new Cita(
                clienteId,
                doctorId,
                fechaConsulta,
                motivo
            );


           // cita.Update(doctorId,fechaConsulta);// = DateTime.Now.AddDays(-1);


            _citaRepo.Agregar(cita);
            _citaRepo.AceptarCambios();

            return cita;




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
