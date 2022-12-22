using Microsoft.EntityFrameworkCore;
using MyApp.Consultorio.Business.Interfaces.Common;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Repositorios
{
    public class Repository <T> : IRepository<T> where T: class,IEntity,new()
    {
        private readonly DbContext _context;



        public Repository(DbContext context)
        {
            _context = context;
        }

        public void AceptarCambios()
        {
            throw new NotImplementedException();
        }

        public void Agregar(T entity)
        {
            _context.Set<T>().Add(entity);
          
        }

        public List<T> Consultar()
        {
            return _context.Set<T>().ToList();
        }

        public T ConsultarPorId(string id)
        {
            return _context.Set<T>().Where(x=>x.Id == id).ToList().FirstOrDefault();
        }

        public void Guardar(List<T> entidades)
        {
            _context.AddRange(entidades);
        }

        public void GuardarCambios()
        {
            _context.SaveChanges();
        }
    }
}
