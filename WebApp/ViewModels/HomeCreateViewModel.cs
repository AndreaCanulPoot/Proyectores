using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required(ErrorMessage = "Debe proporcionar un valor para la Marca")]
        [StringLength(24)]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Debe propocionar un valor para el Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el Número de Serie")]
        public string NSerie { get; set; }
        public SituacionProyect Situacion { get; set; }
        = SituacionProyect.Bueno;
        public DateTime FechaAlta { get; set; }

        public DateTime? FechaBaja { get; set; }
    }
}
