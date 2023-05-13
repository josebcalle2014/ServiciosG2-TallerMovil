using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiciosClinicaUNMSM.Modelos
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_usuario { get; set; }
        [Required]
        [MaxLength(30)]
        public string nombre { get; set; }
        [Required]
        [MaxLength(30)]
        public string apellidoPaterno { get; set; }
        [MaxLength(30)]
        public string apellidoMaterno{ get; set; }
        [Required]
        [MaxLength(70)]
        public string correo {get; set; }
        [Required]
        [MaxLength(18)]
        public string contrasenia { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public string imagen { get; set; }
        public int estado { get; set; }
    }
}
