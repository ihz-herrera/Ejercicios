using MyApp.Consultorio.Business.Interfaces.Repositorios;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Business.Servicios
{
    public class CitasService
    {
        private readonly IClienteRepository clienteRepo;
        private readonly IDoctorRepository doctorRepo;
        private readonly ICitasRepository citasRepo;

        public CitasService(IClienteRepository clienteRepo,IDoctorRepository doctorRepo
            ICitasRepository citasRepo)
        {
            this.clienteRepo = clienteRepo;
            this.doctorRepo = doctorRepo;
            this.citasRepo = citasRepo;
        }

        public void AgendarCita(Cliente cliente, Doctor doctor, Cita cita)
        {
            //Todo: Validar que exista elcliente

            if(!(clienteRepo.ConsultarporNombre(cliente.Nombre) is null))
            {
                throw new ValidationException();
            }

            //Validar que exista el doctor
            //Validar que la fecha es valida doctor - cliente
            //Crear la cita

            citasRepo.Agregar(cita);
            //Guardo

            citasRepo.Guardar();




        }

    }
}
