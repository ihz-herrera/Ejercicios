
using MyApp.Consultorio.Entidades;
using MyApp.Consultorio.Formularios;

namespace MyApp.Consultorio
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();

            //Ejemplo(0);

            //ConsultorioService service = new("");

            //var result = service.ConsultarClientes();

            //ImprimirValores(result);


            try
            {
                Cliente cliente = new();

                cliente.Nombre = "";

                //if (cliente.Nombre == null)
                //{
                //    throw new ArgumentException("El nombre del Cliente es nulo");
                //}


                MessageBox.Show(cliente.Nombre);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void tarea()
        {
            Cliente cliente = new();

            cliente.Nombre = null;

        }

        //public void Ejemplo(int option)
        //{
        //    IRepository<Cliente> repo;


        //todo   switch (option)
        //  {
        //    case 0:
        //           repo = new ClienteSQLRepository(new SQLContext(null));
        //          break;
        //        case 1:
        //           repo = new ClienteTextFileRepository();
        //            break;
        //       case 2:
        //           repo = new ClienteSqliteRepository(new SqliteContext());
        //            break;
        //        default:
        //            repo = new ClienteMemoryRepository();
        //            break;
        //    }


        //    var cliente = new Cliente(repo);


        //    cliente.AgregarCliente(new Cliente(repo)
        //    {
        //        Nombre = "Ivan",
        //        Apellido = "Herrera",
        //        Id = Guid.NewGuid().ToString()
        //    });

        //    cliente.AgregarCliente(new Cliente(repo)
        //    {
        //        Nombre = "Alan",
        //        Apellido = "Chavez",
        //        Id = Guid.NewGuid().ToString()
        //    });

        //    cliente.AgregarCliente(new Cliente(repo)
        //    {
        //        Nombre = "Abdiel",
        //        Apellido = "Sanchez",
        //        Id = Guid.NewGuid().ToString()
        //     });


        //    cliente.CargarDatos().ForEach(x =>
        //    {
        //        MessageBox.Show(x.Nombre);
        //    });




        //}

        public void ImprimirValores(List<Cliente> clientes)
        {
            clientes.ForEach(x =>
            {
                MessageBox.Show(x.Nombre);
            });
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmclientes = new frmClientes();
            frmclientes.ShowDialog();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            var frmdoctores = new frmDoctores();
            frmdoctores.ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            var frmcitas = new frmCitas();
            frmcitas.ShowDialog();
        }
    }
}