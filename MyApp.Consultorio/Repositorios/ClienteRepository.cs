using MyApp.Consultorio.Entidades;
using MyApp.Consultorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Repositorios
{
    public class ClienteRepository : IRepository<Cliente>
    {
        public void Agregar(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Consultar()
        {
            throw new NotImplementedException();
        }

        public Cliente ConsultarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(List<Cliente> entidades)
        {
            throw new NotImplementedException();
        }
    }
}
