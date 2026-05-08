using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Proyector
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Debe proporcionar un valor para la Marca")]
        [StringLength(24)]
        public string Marca { get; set; }
        [Required(ErrorMessage ="Debe propocionar un valor para el Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage ="Debe proporcionar un valor para el Número de Serie")]
        public string NSerie { get; set; }
        public SituacionProyect Situacion { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
    }

    public enum SituacionProyect
    {
        Bueno = 1,
        Regular,
        Malo
    }
}
