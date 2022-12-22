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
    public class ClienteSocioService : IClienteService
    {


        public Cita AgregarCita(string clienteId, string doctorId, DateTime fechaConsulta, string motivo = "")
        {
            //Validaciones ClienteService 


            //+++ Validar Membrecia
            throw new NotImplementedException();

        }

        public Cliente AgregarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
