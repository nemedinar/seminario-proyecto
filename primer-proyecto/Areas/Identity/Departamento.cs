using System.ComponentModel.DataAnnotations;

namespace primer_proyecto.Areas.Identity
{
    public class Departamento
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string? Nombre { get; set; }
        public ICollection<Ciudad>? Ciudades { get; set; }
    }
}
