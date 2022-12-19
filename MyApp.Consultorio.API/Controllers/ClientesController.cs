using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using MyApp.Consultorio.Business.Interfaces.Common;
using MyApp.Consultorio.Business.Interfaces.Servicios;
using MyApp.Consultorio.Contextos;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace MyApp.Consultorio.API.Controllers
{

    [ApiController]
    [Route("api/v1/clientes")]
    public class ClientesController : ControllerBase
    {

      
        private readonly IClienteService _clienteService;

        

        public ClientesController(IClienteService clienteService, ILogger logger)
        {
            _clienteService = clienteService;
        }

        [HttpGet()]
        public ActionResult ConsultarClientes()
        {
            var Clientes = _context.Clientes.ToList();

            return Ok(Clientes);
        }

        [HttpGet("{id}")]
        public ActionResult ConsultarClientes([FromRoute] string id)
        {
            Cliente cliente = _context.Clientes.Where(x => ((IEntity)x).Id == id).FirstOrDefault();
            try
            {
                //return cliente;
                if (cliente == null)
                {
                    return NotFound("Cliente no encontrado");
                }
                return Ok(cliente);
            }
            catch
            {
                return StatusCode(500, 
                    new { Error = "410025", 
                          Mensaje = "Error: Cliente no fue procesado", 
                          Data=cliente }) ;
            }
            
        }

        [HttpPost()]
        public ActionResult CrearCliente([FromBody] Cliente cliente)
        {
            _clienteService.AgregarCliente(cliente);

            return Ok(cliente);
        }

        //Todo: Tarea Funcionalidad de citas
        /**** 
         * Agregar cita
         * Consultar citas del cliente
         * Eliminar citas
         * Actualizar citas
         */

    }
}
