using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyApp.Consultorio.Business.Interfaces.Servicios;

namespace MyApp.Consultorio.API.Controllers
{
    public class CitasController : Controller
    {
        public CitasController(ICitasService citasService,
            ILogger logger,IClienteService cliente, IDoctorService doctores)
        {

        }
    }
}
