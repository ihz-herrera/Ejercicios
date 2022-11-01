using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Ejercicios.Clases
{
    public class ToDo
    {
        
        private readonly string  Path = "D:\\Residencias\\ToDoList.csv";

        public string Titulo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Descripcion { get; set; }


        public ToDo()
        {

        }

        public ToDo(string titulo, string descripcion, DateTime fechaEntrega)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            FechaEntrega = FechaEntrega;

        }


        public override string ToString()
        {
            return $"{Titulo}, {Descripcion}, {FechaEntrega}";
        }
        
        
        public void AgregarTarea()
        {

            ToDo toDo = new ToDo()
            {
                Titulo = Titulo,
                Descripcion = Descripcion,
                FechaEntrega = FechaEntrega
            };

            AgregarTarea(toDo);

        }

        public void AgregarTarea(ToDo toDo)
        {
            /** Persistir Elemento en un archivo **/
            using (StreamWriter strWriter = new StreamWriter(Path, true))
            {
                //StrWriter.WriteLine( toDo.Titulo +"," + toDo.Descripcion + "," + toDo.FechaEntrega +",");

                strWriter.WriteLine(toDo.ToString());
                strWriter.Close();
            }
        }

       


    }
}
