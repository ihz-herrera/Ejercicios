using MyApp.Consultorio.Business.Servicios;
using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MyApp.Consultorio
{
    public class ConsultorioService
    {



       

        private string variable;
        private const string URLBase = "https://localhost:5001/";

        public ConsultorioService(string variable)
        {
            this.variable = variable;

           

        }

        public List<Cliente> ConsultarClientes()
        {
            variable = "A";
            
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(URLBase + variable);

                var message =  httpClient.GetFromJsonAsync<List<Cliente>>("api/v1/clientes").Result ?? new List<Cliente>();
                
                var m = from cliente in message
                        where cliente != null
                        select new { cliente.Nombre, cliente.Apellido};

                return message;
            }

        }
    }
}
