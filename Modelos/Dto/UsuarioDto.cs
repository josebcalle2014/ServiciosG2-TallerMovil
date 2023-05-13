using System.ComponentModel.DataAnnotations;

namespace ServiciosClinicaUNMSM.Modelos.Dto
{
    public class UsuarioDto
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public string imagen { get; set; }
        public int estado { get; set; }
    }
}
