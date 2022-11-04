using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Ejercicios.Clases
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public int Numero { get; set; }
    }
}
