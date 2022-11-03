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
            FechaEntrega = fechaEntrega;

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

            if(String.IsNullOrEmpty(Titulo) || String.IsNullOrEmpty(Descripcion))
            {
                throw new ArgumentException("Las propiedades deben tener un valor. " +
                    "La propiedadad Titulo o Descripcion estan vacias");
            }


            /** Persistir Elemento en un archivo **/
            using (StreamWriter strWriter = new StreamWriter(Path, true))
            {
                //StrWriter.WriteLine( toDo.Titulo +"," + toDo.Descripcion + "," + toDo.FechaEntrega +",");

                strWriter.WriteLine(toDo.ToString());
                strWriter.Close();
            }
        }


        public List<ToDo> CargarTareas()
        {
            List<ToDo> toDoList = new ();

            if (System.IO.File.Exists(Path))
            {
                /*Leer archivo*/
                using (StreamReader strReader = new StreamReader(Path))
                {
                    string ln = string.Empty;

                    while ((ln = strReader.ReadLine()) != null)
                    {
                        string[] campos = ln.Split(",");

                        ToDo toDo = new()
                        {
                            Titulo = campos[0],
                            Descripcion = campos[1],
                            FechaEntrega = DateTime.Parse(campos[2])
                        };
                        toDoList.Add(toDo);
                    }
                }
            }
            return toDoList;
        }

        public void GuardarListaTareas(List<ToDo> ListaTareas)
        {
            foreach (ToDo toDo in ListaTareas)
            {
                using (StreamWriter strWriter = new StreamWriter(Path, true))
                {
                    strWriter.WriteLine(toDo.ToString());
                    strWriter.Close();
                }

            }
        }


    }
}
