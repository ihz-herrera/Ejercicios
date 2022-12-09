using MyApp.Consultorio.Entidades;

namespace MyApp.Consultorio.Business.Test.Clientes
{
    public class ClienteTest
    {

        [Theory]
        [InlineData("","Nombre")]
        [InlineData("IA", "Nombre")]

        public void ClienteCreateValidationNombre_NotNullOrWhiteSpace(string value, string paramname)
        {
            var cliente = new Cliente();
            Assert.Throws<ArgumentException>(paramname,()=> cliente.Nombre = value);
        }

        [Theory]
        [InlineData("", "Apellido")]
        [InlineData("IALOR", "Apellido")]

        public void ClienteCreateValidationApellido_NotNullOrWhiteSpace(string value, string paramname)
        {
            var cliente = new Cliente();
            Assert.Throws<ArgumentException>(paramname, () => cliente.Apellido = value);
        }

        [Fact]
        public void Cliente_GetDefaultId()
        {
            var cliente = new Cliente();

            Assert.NotNull(cliente.Id);
        }


    }
}
