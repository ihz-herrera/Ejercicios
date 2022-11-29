using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MyApp.Consultorio
{
    public class ConsultorioService
    {


        public List<Cliente> ConsultarClientes()
        {

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:5001/");

                var message =  httpClient.GetFromJsonAsync<List<Cliente>>("api/v1/clientes").Result;
                
                return message;
            }

        }
    }
}
