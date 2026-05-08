using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresEnMemoriaService : IProyectoresService
    {
        private static List<Proyector> _proyectores = LoadData();

        public void AddProyector(Proyector proyector)
        {
            if (proyector != null) 
            { 
                _proyectores.Add(proyector);
            }
        }

        public IEnumerable<Proyector> GetAll()
        {
            return _proyectores;        
        }



        private static List<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NSerie = "123456",
                Situacion = SituacionProyect.Bueno,
                FechaAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 2,
                Marca = "Epson",
                Modelo = "XLight",
                NSerie = "567890",
                Situacion = SituacionProyect.Bueno,
                FechaAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "Epson",
                Modelo = "Performer",
                NSerie = "144556",
                Situacion = SituacionProyect.Regular,
                FechaAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "Epson",
                Modelo = "XLight",
                NSerie = "456789",
                Situacion = SituacionProyect.Bueno,
                FechaAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Epson",
                Modelo = "XLight",
                NSerie = "234567",
                Situacion = SituacionProyect.Bueno,
                FechaAlta = DateTime.Now
            });


            return proyectores;
        }


    }
}
