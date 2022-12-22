using MyApp.Consultorio.Entidades;

namespace MyApp.Consultorio.Business.Interfaces.Servicios
{
    public interface IClienteService
    {
        Cliente AgregarCliente(Cliente cliente);

        Cita AgregarCita(string clienteId, string doctorId, DateTime fechaConsulta, string motivo = "");

    }
}