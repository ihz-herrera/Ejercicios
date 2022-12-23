using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using MyApp.Consultorio.API.Dtos;
using MyApp.Consultorio.Business.Interfaces.Common;
using MyApp.Consultorio.Business.Interfaces.Servicios;
using MyApp.Consultorio.Contextos;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace MyApp.Consultorio.API.Controllers
{

    [ApiController]
    [Route("api/v1/clientes")]
    public class ClientesController : ControllerBase
    {


        private readonly IClienteService _clienteService;
        private readonly ILogger _logger;

        public ClientesController(IClienteService clienteService, 
            ILogger logger)
        {
            _clienteService = clienteService;
            _logger = logger;
        }

        #region Metodos Clientes
        [HttpGet()]
        public ActionResult ConsultarClientes()
        {
           // var Clientes = _context.Clientes.ToList();

            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult ConsultarClientes([FromRoute] string id)
        {

           
            return Ok();
          


          
            //Cliente cliente = _context.Clientes.Where(x => ((IEntity)x).Id == id).FirstOrDefault();
            //try
            //{
            //    //return cliente;
            //    if (cliente == null)
            //    {
            //        return NotFound("Cliente no encontrado");
            //    }
            //    return Ok(cliente);
            //}
            //catch
            //{
            //    return StatusCode(500,
            //        new { Error = "410025",
            //            Mensaje = "Error: Cliente no fue procesado",
            //            Data = cliente });
            //}

        }

        [HttpPost()]
        public ActionResult CrearCliente([FromBody] Cliente cliente)
        {
            _clienteService.AgregarCliente(cliente);

            return Ok(cliente);
        }

        #endregion


        //Todo: Tarea Funcionalidad de citas
        /**** 
         * Agregar cita
         * Consultar citas del cliente
         * Eliminar citas
         * Actualizar citas
         */


        [HttpGet("{idCliente}/citas")]
        public IActionResult ConsultaTodasCitas()
        {
            return Ok();
        }

        [HttpGet("{idCliente}/citas/{idCita}")]
        public IActionResult ConsultarCita(int idCliente, int idCita)
        {
            return Ok();
        }

        [HttpPost("{idCliente}/citas")]
        public IActionResult CrearCita([FromRoute] string idCliente, 
            [FromBody] CitaCreateRequest cita)
        {
            try
            {
                var result = _clienteService.AgregarCita(idCliente, cita.DoctorId,
                    cita.FechaConsulta, cita.Motivo);

                return Ok(result);
            }
            catch (ValidationException ve) when (ve.Message.Contains("no existe"))
            {
                _logger.LogError(ve.Message);
                return NotFound(ve.Message);
            }
            catch (ValidationException ve)
            {
                _logger.LogError(ve.Message);
                return BadRequest(ve.Message);
            }
            catch (ArgumentNullException)
            {
                _logger.LogError("Argumentos invalidos {cita}",cita);
                return BadRequest("Objeto requerido.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Error Interno del Servidor");
            }

        }

        [HttpPut("{idCliente}/citas/{idCita}")]
        public IActionResult ActualizarCita()
        {
            return Ok();
        }

        [HttpDelete("{idCliente}/citas/{idCita}")]
        public IActionResult EliminarCita()
        {
            return Ok();
        }

    }
}
