using System;

namespace MyApp.Consultorio.API.Dtos
{
    public class CitaCreateRequest
    {
        public string DoctorId { get; set; }
        public DateTime  FechaConsulta { get; set; }

        public string Motivo { get; set; }
    }
}
