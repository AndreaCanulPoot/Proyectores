using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var modelo = LoadData();
            //var modelo = new List<Proyector>();
            return View(modelo);
        }

        private IEnumerable<Proyector> LoadData()
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


        public IActionResult Create()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
