using MyApp.Ejercicios.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.Ejercicios.Formularios
{
    public partial class Todolist : Form
    {

        public List<ToDo> ListaTareas;

        public Todolist()
        {
            InitializeComponent();
            
        }

        private void CargarTareas()
        {
            /*Leer archivo*/
            using (StreamReader strReader = new StreamReader("D://Residencias//ToDoList.csv"))
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

                    

                    ListaTareas.Add(toDo);

                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            var toDo = new ToDo(txtTitulo.Text, 
                        txtDescripcion.Text,
                        dtpFechaEntrega.Value);


            //Agrega un elemento a la lista de tareas List<ToDo>
            ListaTareas.Add(toDo);

            toDo.AgregarTarea();


            //Todo: Verificar como refrescar data source

            LimpiarFormulario();

            dtgTareas.DataSource = null;
            dtgTareas.DataSource = ListaTareas;
            dtgTareas.Refresh();


        }

       

        private void LimpiarFormulario()
        {
            txtTitulo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            dtpFechaEntrega.Value = DateTime.Today;
        }

        private void Todolist_Shown(object sender, EventArgs e)
        {
            //Instancias de objetos
            ListaTareas = new List<ToDo>();
            CargarTareas();
            dtgTareas.DataSource = ListaTareas;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            foreach(ToDo toDo in ListaTareas)
            {
                using (StreamWriter strWriter = new StreamWriter("D:\\Residencias\\ToDoList2.csv", true))
                {
                    //StrWriter.WriteLine( toDo.Titulo +"," + toDo.Descripcion + "," + toDo.FechaEntrega +",");

                    strWriter.WriteLine(toDo.ToString());
                    strWriter.Close();
                }

            }


        }
    }
}
