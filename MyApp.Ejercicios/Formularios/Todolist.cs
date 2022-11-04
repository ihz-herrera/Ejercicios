using MyApp.Ejercicios.Clases;
using MyApp.Ejercicios.Contexto;
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

        #region Eventos Controles

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var toDo = new ToDo(txtTitulo.Text,
                            txtDescripcion.Text,
                            dtpFechaEntrega.Value);

                //Agrega un elemento a la lista de tareas List<ToDo>
                toDo.AgregarTarea();

                ListaTareas.Add(toDo);

                LimpiarFormulario();

                dtgTareas.DataSource = null;
                dtgTareas.DataSource = ListaTareas;
                dtgTareas.Refresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error.", "Informativo");

            }

        }


        private void Todolist_Shown(object sender, EventArgs e)
        {
            try
            {
                Context context = new();

                var toDo = new ToDo();
                ListaTareas = toDo.CargarTareas();
                dtgTareas.DataSource = ListaTareas;
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error.", "Informativo");

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ToDo toDo = new();
                toDo.GuardarListaTareas(ListaTareas);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error.", "Informativo");

            }
            
        }

        #endregion

        #region Metodos Privados
        private void LimpiarFormulario()
        {
            try
            {
                txtTitulo.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                dtpFechaEntrega.Value = DateTime.Today;
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error.","Informativo");
            }
            finally
            {
                txtTitulo.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                dtpFechaEntrega.Value = DateTime.Today;
            }
            
        }






        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var text = txtBuscar.Text;

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                ToDo toDo = new ToDo();
                ListaTareas = toDo.CargarTareas();

                dtgTareas.DataSource = null;
                dtgTareas.DataSource = ListaTareas;
                dtgTareas.Refresh();
            }
            else
            {
                dtgTareas.DataSource = null;
                var result = ListaTareas.Where<ToDo>(x => 
                    {
                        var result = x.Titulo.ToUpper().Contains(text.ToUpper());
                        return result;
                    });

                dtgTareas.DataSource = result.ToList();
                dtgTareas.Refresh();
            }
            
            
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var text = txtBuscar.Text;

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                ToDo toDo = new ToDo();
                ListaTareas = toDo.CargarTareas();

                dtgTareas.DataSource = null;
                dtgTareas.DataSource = ListaTareas;
                dtgTareas.Refresh();
            }
            else
            {
                dtgTareas.DataSource = null;
                var result = ListaTareas.Where(x => x.Titulo.ToUpper()
                .Contains(text.ToUpper()));
                dtgTareas.DataSource = result.ToList();
                dtgTareas.Refresh();
            }
        }
    }
}
