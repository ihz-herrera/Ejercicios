using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Entidades
{
    public class Doctor : Persona
    {


        public string Cedula { get; set; }
        public string NumeroDeTelefono { get; set; }


        public override string ToString()
        {
            return $"{Id},{Cedula}, {Nombre}, {Apellido},{NumeroDeTelefono}";
        }

        public  List<Doctor> CargarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
