using Microsoft.EntityFrameworkCore;
using MyApp.Consultorio.Contextos;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Repositorios
{
    public class ClienteSqliteRepository : Repository<Cliente>
    {

        //private readonly SqliteContext _context;

        public ClienteSqliteRepository(DbContext context):base(context)
        {
            //_context = new SqliteContext();
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
