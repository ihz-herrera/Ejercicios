

using System;
using static MyApp.Consola.CalculosMatematicos;

namespace MyApp.Consola
{
    class Program
    {
        
        static int Numero1 = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            

      


            int Numero2 = 10;

            CalculosMatematicos calculos = new CalculosMatematicos();

            var mensaje = String.Empty;

            calculos.Multiplicar(5, 15);
            
            mensaje = calculos.MensajeResultado(calculos.Resultado, Idioma.Español);
            Console.WriteLine(mensaje);

            mensaje = calculos.MensajeResultado(calculos.Resultado, Idioma.Ingles);
            Console.WriteLine(mensaje);

            mensaje = calculos.MensajeResultado(calculos.Resultado, Idioma.Aleman);
            Console.WriteLine(mensaje);

            



        }

        


    }
}
