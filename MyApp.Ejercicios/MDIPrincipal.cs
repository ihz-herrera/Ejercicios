using MyApp.Ejercicios.Formularios;

namespace MyApp.Ejercicios
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void btnArrays_Click(object sender, EventArgs e)
        {
            var frmArrays = new ArraysForm();

            frmArrays.ShowDialog();
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            try
            {
                var frmTodoList = new Todolist();

                frmTodoList.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error.", "Informativo");
                //Todo: Logger
            }

        }
    }
}