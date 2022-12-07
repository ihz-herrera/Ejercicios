using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Consultorio.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IOptions<Cliente> options )
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpPost]
        public ActionResult CrearEvento()
        {

            try
            {
                return Ok("El evento se guardo correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message,ex);
                return StatusCode(500, "Error Interno del Servidor");
            }
        }

        [HttpPut]
        public ActionResult ActualizarEvento()
        {

            try
            {
                return Ok("El evento se actualizó correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return StatusCode(500, "Error Interno del Servidor");
            }
        }
        [HttpDelete]
        public ActionResult EliminarEvento()
        {

            return Ok("El evento se eliminó correctamente");
        }
        //public string MensajeSalida()
        //{
        //    return ;
        //}
    }
}
