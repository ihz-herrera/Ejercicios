using MyApp.Consultorio.Business.Interfaces.Common;
using MyApp.Consultorio.Entidades;

namespace MyApp.Consultorio.Business.Interfaces.Repositorios
{
    public interface IClientesRepository : IRepository<Cliente>
    {
        Cliente ConsultarporNombre(string nombre);

        IEnumerable<Cita> ConsultarCitas(string clienteId);

        bool FechaDisponible(string clienteId, DateTime fecha);

    }
}