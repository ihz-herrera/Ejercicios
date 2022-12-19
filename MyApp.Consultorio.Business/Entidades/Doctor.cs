using MyApp.Consultorio.Business.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Entidades
{
    public class Doctor : Persona
    {
        //Todo: Crear clausulas de guarda, metodos de extensión, validar entradas, crear pruebas unitarias
        //!? De ser de máximo 16 digitos, sin separadores
        public string Cedula { get; set; }
        //!? Debe ser numérico, no debe contener "-", debe ser de 10 digitos
        public string NumeroDeTelefono { get; set; }

        //! Propiedad de Navegacion
        public List<Cita> Citas { get; set; }


        public override string ToString()
        {
            return $"{((IEntity)this).Id},{Cedula}, {Nombre}, {Apellido},{NumeroDeTelefono}";
        }

        public  List<Doctor> CargarDatos()
        {
            throw new NotImplementedException();
        }

        public Doctor()
        {
            Id ??= Guid.NewGuid().ToString();
        }
    }
}
