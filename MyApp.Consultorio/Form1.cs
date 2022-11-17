using MyApp.Consultorio.Contextos;
using MyApp.Consultorio.Entidades;
using MyApp.Consultorio.Interfaces;
using MyApp.Consultorio.Repositorios;

namespace MyApp.Consultorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Ejemplo(0);
        }




        public void Ejemplo(int option)
        {
            IRepository<Cliente> repo;
            
            
            switch (option)
            {
                case 0:
                    repo = new ClienteSQLRepository( new SQLContext());
                    break;
                case 1:
                    repo = new ClienteTextFileRepository();
                    break;
                case 2:
                    repo = new ClienteSqliteRepository(new SqliteContext());
                    break;
                default:
                    repo = new ClienteMemoryRepository();
                    break;
            }

            
            var cliente = new Cliente(repo);


            cliente.AgregarCliente(new Cliente(repo)
            {
                Nombre = "Ivan",
                Apellido = "Herrera",
                Id = Guid.NewGuid().ToString()
            });

            cliente.AgregarCliente(new Cliente(repo)
            {
                Nombre = "Alan",
                Apellido = "Chavez",
                Id = Guid.NewGuid().ToString()
            });

            cliente.AgregarCliente(new Cliente(repo)
            {
                Nombre = "Abdiel",
                Apellido = "Sanchez",
                Id = Guid.NewGuid().ToString()
            });


            cliente.CargarDatos().ForEach(x =>
            {
                MessageBox.Show(x.Nombre);
            });




        }
    }
}