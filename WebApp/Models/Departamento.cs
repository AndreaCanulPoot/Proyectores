using Microsoft.AspNetCore.Cors.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe proporcionar el títuo del departamento")]
        public string Titulo { get; set; } = string.Empty;

        //Propiedades de navegación de la relación
        public IEnumerable<Proyector> Proyectores { get; set; } = new List<Proyector>();

    }
}
