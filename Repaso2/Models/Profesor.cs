using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repaso2.Models
{
    public class Profesor
    {
        [Key]
        public String BannerId { get; set; }
        public String Nombre { get; set; }
        public Double Sueldo { get; set; }
        public int FacultadId { get; set; }
        [ForeignKey("FacultadId")]
        public Facultad? Facultad { get; set; }

        public List<Materia>? Materias { get; set; }   
    }
}
