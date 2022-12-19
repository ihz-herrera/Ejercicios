using Microsoft.EntityFrameworkCore;
using MyApp.Consultorio.Business.Interfaces.Repositorios;
using MyApp.Consultorio.Contextos;
using MyApp.Consultorio.Entidades;
using MyApp.Consultorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Repositorios
{
    public class ClienteSQLRepository : Repository<Cliente>, IClienteRepository
    {
        //private readonly SQLContext _context;

        public ClienteSQLRepository(DbContext context) : base(context)
        {
            //_context = new SQLContext();

        }

        public Cliente ConsultarporNombre(string nombre)
        {
            return Consultar().FirstOrDefault(x => x.Nombre == nombre)!;
        }


        //public void Agregar(Cliente entity)
        //{
        //    _context.Clientes.Add(entity);
        //    _context.SaveChanges();
        //}

        //public List<Cliente> Consultar()
        //{
        //    return _context.Clientes.ToList();
        //}

        //public Cliente ConsultarPorId(string id)
        //{
        //    return _context.Clientes.Where(x => x.Id == id).FirstOrDefault();
        //}

        //public void Guardar(List<Cliente> entidades)
        //{
        //    _context.Clientes.AddRange(entidades);
        //    _context.SaveChanges();

        //}
    }
}
