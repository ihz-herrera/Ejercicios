using MyApp.Consultorio.Entidades;
using MyApp.Consultorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Repositorios
{
    public class DoctorRepository : IRepository<Doctor>
    {
        public void Agregar(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> Consultar()
        {
            throw new NotImplementedException();
        }

        public Doctor ConsultarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(List<Doctor> entidades)
        {
            throw new NotImplementedException();
        }
    }
}
