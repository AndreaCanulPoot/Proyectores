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
            //Uso de ViewBig
            ViewBag.Id = "1";
            ViewBag.Marca = "Epson";
            ViewBag.Modelo = "XLight";
            ViewBag.NSerie = "123456";
            ViewBag.Situacion = "Bueno";
            ViewBag.FechaAlta = DateTime.Now.ToString("d");
            return View();
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
