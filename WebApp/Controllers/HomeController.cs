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
            //Uso del modelo de modelos de la vista

            var proyector = new Proyector()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NSerie = "123456",
                Situacion = SituacionProyect.Bueno,
                FechaAlta = DateTime.Now
            };
            return View(proyector);
        }

        public IActionResult Privacy()
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
