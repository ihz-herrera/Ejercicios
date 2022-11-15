using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Interfaces
{
    public interface IRepository<T>
    {
        void Guardar(List<T> entidades);
        void Agregar(T entity);
        List<T> Consultar();
        T ConsultarPorId(string id);

    }
}
