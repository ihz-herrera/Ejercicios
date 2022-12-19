using MyApp.Consultorio.Business.Interfaces.Common;
using MyApp.Consultorio.Entidades;

namespace MyApp.Consultorio.Business.Interfaces.Repositorios
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ConsultarporNombre(string nombre);
    }
}