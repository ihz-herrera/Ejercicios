using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Business.Test.Entidades
{
    public class CitasTest
    {
        //Todo: Pruebas


        [Theory]
        [InlineData("", "0fd7897a-d92c-4ceb-b423-a40d255a7d6d", "12/12/2022","","clienteId")]
        [InlineData("0fd7897a-d92c-4ceb-b423-a40d255a7d6d", "", "12/12/2022","","doctorId")]
        [InlineData("0fd7897a-d92c-4ceb-b423-a40d255a7d6d", "0fd7897a-d92c-4ceb-b423-a40d255a7d6d", "12/18/2022", "", "fechaConsulta")]
        public void Constructor_ShouldThrowException_WhenValuesnotFit(
            string clienteId,string doctorId,DateTime fecha, string motivo, string paramName)
        {

            Assert.Throws<ArgumentException>(paramName,()=> {
                var cliente = new Cita(clienteId,doctorId, fecha,motivo);
                });


           
        }
    }
}
