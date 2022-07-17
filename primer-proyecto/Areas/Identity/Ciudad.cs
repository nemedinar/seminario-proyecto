using System.ComponentModel.DataAnnotations;

namespace primer_proyecto.Areas.Identity
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string? Nombre { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }
        public ICollection<Persona>? Personas { get; set; }
    }
}
