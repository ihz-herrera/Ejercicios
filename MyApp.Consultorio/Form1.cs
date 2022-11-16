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

            Ejemplo(3);
        }




        public void Ejemplo(int option)
        {
            IRepository<Cliente> repo;
            switch (option)
            {
                case 0:
                    repo = new ClienteSQLRepository();
                    break;
                case 1:
                    repo = new ClienteTextFileRepository();
                    break;
                case 2:
                    repo = new ClienteSqliteRepository();
                    break;
                default:
                    repo = new ClienteMemoryRepository();
                    break;
            }

            
            var cliente = new Cliente(repo);


            cliente.AgregarCliente(new Cliente(repo)
            {
                Nombre = "Martin",
                Apellido = "Ponce",
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