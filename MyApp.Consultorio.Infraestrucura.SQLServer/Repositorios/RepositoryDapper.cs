using MyApp.Consultorio.Business.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Infraestrucura.SQLServer.Repositorios
{
    internal class RepositoryDapper<T> : IRepository<T> where T : class, IEntity, new()
    {
        public void Agregar(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> Consultar()
        {
            throw new NotImplementedException();
        }

        public T ConsultarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(List<T> entidades)
        {
            throw new NotImplementedException();
        }
    }
}
