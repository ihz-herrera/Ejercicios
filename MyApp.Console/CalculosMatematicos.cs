using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyApp.Consola
{
    class CalculosMatematicos
    {

        public enum Idioma
        {
            Español,
            Ingles,
            Aleman
        }

        //Atributo
        private int _resultado;

        //Propiedad
        public int Resultado { 
            get { 
                return _resultado; 
            } 
          
        }

        //Metodo
        public string MensajeResultado(int resultado, Idioma opcion)
        {
            string mensaje = String.Empty;

            switch (opcion)
            {
                case Idioma.Español:
                    mensaje = "El Resultado de la Operacion es:" + resultado;
                    break;
                case Idioma.Ingles:
                    mensaje = "The result of the operation is:" + resultado;
                    break;
                case Idioma.Aleman:
                    mensaje = "Das Ergebnis der Operation ist:" + resultado;
                    break;
                default:
                    mensaje = "El Resultado de la Operacion es:" + resultado;
                    break;
            }
            
            return mensaje;
        }

        public int Sumar(int x, int y)
        {
            _resultado = x + y;
            return Resultado;
        }

        public int Multiplicar(int x, int y)
        {

            if (x<y)
            {
                _resultado = x * y;
            }
            else
            {
                _resultado = 0;
            }

            
            return Resultado;
        }
    }
}
