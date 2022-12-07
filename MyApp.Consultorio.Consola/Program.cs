using MyApp.Consultorio.Consola;
using MyApp.Consultorio.Consola.Enums;
using MyApp.Consultorio.Consola.Enums.Shared;
using System.ComponentModel;
using System.Linq.Expressions;

internal class Program
{

    


    private static T Funcion<T>(Action<T> expression) where T : new()
    {
        T c = new T();

        expression.Invoke(c);
        return c;

        EnumTest(OptionType.option);
;    }

    public static void EnumTest(OptionType card)
    {

        Console.WriteLine(card.DisplayName());
        switch (card)
        {
            case  OptionType.option:
                
                break;
            case OptionType.option2:
                break;
            default: throw new ArgumentException();
        }
    }

    private static void Main(string[] args)
    {
        EnumTest(OptionType.option);


        Console.WriteLine("Hello, World!");
        var result = Funcion<Persona>(opt =>
        {
            opt.A = "hola";
            opt.Name = "ivan";
        });

        var lista = new List<Persona>()
        {
            new Persona() { A = "Hello",Name="Persona" },
            new Persona() { A = "Hola",Name="Ivan" },
            new Persona() { A = "No",Name="Herrera" },
        };

        var r = lista.WhereTo<Persona>(x => x.A.Equals("No"));

        (string mensaje, string nombre) = result;

        Console.WriteLine($"{mensaje} {nombre}: {r.Count}");
        var t = 5..10;
        foreach(var i in 1..6)
        {
            Console.WriteLine(i);
        }
        
        List<Persona> personas = new List<Persona>();


       

    }
    class Persona
    {
        public string Name { get; set; }
        public string A { get; set; }

        internal void Deconstruct(out string a, out string name)
        {
            a = A;
            name = Name;
        }
    }

    public enum OptionType
    {
        [Description("A webo")]
        option,
        option2
    }
}