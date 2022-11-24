using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
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


        private List<Cliente> Clientes= new List<Cliente>();

        public ClientesController()
        {

            Clientes = new List<Cliente>(){
                new Cliente()
                {
                    Id= "965105c2-0b8b-405a-b6cd-803656b8a84a",
                    Apellido = "Herrera",
                    Nombre = "Ivan",
                    Direccion = "Centro"
                },
                 new Cliente()
                {
                    Id= "71c1838a-af4a-4269-a97a-15e8f063f86b",
                    Apellido = "Alan",
                    Nombre = "Chavez",
                    Direccion = "Centro"
                }, new Cliente()
                {
                    Id= "b3faf68f-30a9-4fbf-8748-7fad8202d03f",
                    Apellido = "Martin",
                    Nombre = "Ponce",
                    Direccion = "Centro"
                },
                  new Cliente()
                {
                    Id= "8dabf431-78bf-484c-8706-2296fc836ab0",
                    Apellido = "Abdiel",
                    Nombre = "Sanchez",
                    Direccion = "Centro"
                }
            };

        }

        [HttpGet()]
        public ActionResult ConsultarClientes()
        {
            return Ok(Clientes);
        }

        [HttpGet("{id}")]
        public ActionResult ConsultarClientes([FromRoute] string id)
        {
            Cliente cliente = Clientes.Where(x => x.Id == id).FirstOrDefault();
            try
            {
               

                //return cliente;
                if (cliente == null)
                {
                    return NotFound("Cliente no encontrado");
                }

                throw new NotImplementedException();

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

        



    }
}
