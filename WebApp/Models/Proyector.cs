namespace WebApp.Models
{
    public class Proyector
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
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
