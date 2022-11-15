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


        }


        public void Ejemplo()
        {

            var doctor = new Doctor();
            var doctor2 = new Doctor();
            var doctor3 = new Doctor();

            doctor.Nombre = "Alan";
            doctor2.Nombre = "Martin";
            doctor3.Nombre = "Abdiel";


            doctor.CargarDatos();


            var repo = new ClienteRepository();
            
            var cliente = new Cliente(repo);

            cliente.CargarDatos();

            var persona = new Persona();


        }
    }
}