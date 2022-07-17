using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using primer_proyecto.Areas.Identity;

namespace primer_proyecto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento>? Departamentos { get; set; }
        public DbSet<Persona>? Personas { get; set; }
        public DbSet<Ciudad>? Ciudades { get; set; }

    }
}