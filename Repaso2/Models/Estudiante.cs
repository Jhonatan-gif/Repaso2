using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Repaso2.Models
{
    public class Estudiante
    {
        [Key]
        [MaxLength(9)]
        public String BannerId { get; set; }
        [MaxLength(100)]
        [DisplayName("Ingrese el Nombre: ")]
        public String Nombre { get; set; }

        public String? Hobbies { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool TieneBeca { get; set; }
        public int CarreraId { get; set; }

        [ForeignKey("CarreraId")]
        public Carrera? Carrera { get; set; }


    }

}
