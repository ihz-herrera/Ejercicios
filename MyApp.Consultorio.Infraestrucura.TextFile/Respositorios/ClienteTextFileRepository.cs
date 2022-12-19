using MyApp.Consultorio.Business.Interfaces.Common;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Repositorios
{
    public class ClienteTextFileRepository : IRepository<Cliente>
    {
        private const string path = "D:\\Residencias\\Clientes.csv";

        public void Agregar(Cliente entity)
        {
            using (StreamWriter strWriter = new StreamWriter(path, true))
            {

                strWriter.WriteLine(entity.ToString());
                strWriter.Close();
            }
        }

        public List<Cliente> Consultar()
        {
            if (!System.IO.File.Exists(path))
            {
                return new List<Cliente>();
            }

            using (StreamReader strReader = new StreamReader(path))
            {

                List<Cliente> clientes = new List<Cliente>();
                string ln = string.Empty;

                while ((ln = strReader.ReadLine()) != null)
                {
                    string[] campos = ln.Split(",");

                    Cliente cliente = new Cliente ()
                    {
                        //Id = campos[0],
                        Nombre = campos[1],
                        Apellido = campos[2],
                        FechaNacimiento =  DateTime.Parse(campos[3]),
                        Direccion = campos[4]
                    };
                    clientes.Add(cliente);
                }

                return clientes;
            }
        }

        public Cliente ConsultarPorId(string id)
        {
            return Consultar().Where(x => ((IEntity)x).Id.Equals(id)).FirstOrDefault();
        }

        public void Guardar(List<Cliente> entidades)
        {
            foreach (Cliente cliente in entidades)
            {
                using (StreamWriter strWriter = new StreamWriter(path, true))
                {
                    strWriter.WriteLine(cliente.ToString());
                    strWriter.Close();
                }

            }
        }
    }
}
