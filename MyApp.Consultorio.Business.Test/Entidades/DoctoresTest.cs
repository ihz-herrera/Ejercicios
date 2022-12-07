using MyApp.Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Business.Test.Entidades
{
    public class DoctoresTest
    {


        [Fact]
        public void Doctor_GetDefaultId()
        {
            var doctor = new Doctor();

            Assert.NotNull(doctor.Id);
        }
    }
}
