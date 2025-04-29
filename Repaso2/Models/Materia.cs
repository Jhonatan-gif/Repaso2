using System.ComponentModel.DataAnnotations.Schema;

namespace Repaso2.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Profesor> Profesores { get; set; }
        public int CarreraId { get; set; }
        [ForeignKey("CarreraId")]
        public Carrera? Carrera { get; set; }
    }
}
