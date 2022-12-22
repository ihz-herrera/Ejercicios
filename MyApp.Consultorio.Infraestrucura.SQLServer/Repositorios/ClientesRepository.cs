using Microsoft.EntityFrameworkCore;
using MyApp.Consultorio.Business.Interfaces.Repositorios;
using MyApp.Consultorio.Contextos;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Repositorios
{
    public class ClientesRepository : Repository<Cliente>, IClientesRepository
    {
        //private readonly SQLContext _context;

        public ClientesRepository(DbContext context) : base(context)
        {
            //_context = new SQLContext();

        }

        public IEnumerable<Cita> ConsultarCitas(string clienteId)
        {
            return ConsultarPorId(clienteId).Citas;
        }

        public Cliente ConsultarporNombre(string nombre)
        {
            return Consultar().FirstOrDefault(x => x.Nombre == nombre)!;
        }

        public bool FechaDisponible(string clienteId, DateTime fecha)
        {
            return !ConsultarPorId(clienteId).
                Citas.Any(x => x.Fecha.Date == fecha.Date);
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
