using MyApp.Consultorio.Business.Interfaces.Common;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Repositorios
{
    public class ClienteMemoryRepository : IRepository<Cliente>
    {
        /*** Persistencia en Memoria ***/
        private List<Cliente> Clientes = new List<Cliente>();
        /********************************/

        public void Agregar(Cliente entity)
        {
            Clientes.Add(entity);
        }

        public List<Cliente> Consultar()
        {
            return Clientes;
        }

        public Cliente ConsultarPorId(string id)
        {
            return Clientes.Where(x => ((IEntity)x).Id.Equals(id)).FirstOrDefault();
        }

        public void Guardar(List<Cliente> entidades)
        {
            Clientes = entidades;
        }
    }
}
