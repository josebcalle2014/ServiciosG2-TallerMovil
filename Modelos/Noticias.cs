using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiciosClinicaUNMSM.Modelos
{
    public class Noticias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_noticia { get; set; }
        [Required]
        [StringLength(500)]
        public string url_noticia { get; set; }
        [StringLength(500)]
        public string img_noticia { get; set; }
        [Required]
        public int estado { get; set; }
    }
}
