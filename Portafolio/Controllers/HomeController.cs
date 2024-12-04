using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        //private readonly ServicioDelimitado servicioDelimitado;
        //private readonly ServicioUnico servicioUnico;
        //private readonly ServicioTransitorio servicioTransitorio;
        //public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos,
        //    ServicioDelimitado servicioDelimitado, ServicioUnico servicioUnico,
        //    ServicioTransitorio servicioTransitorio
        //    )
        //{
        //    _logger = logger;
        //    this.repositorioProyectos = repositorioProyectos;
        //    this.servicioDelimitado = servicioDelimitado;
        //    this.servicioUnico = servicioUnico;
        //    this.servicioTransitorio = servicioTransitorio;
        //}
        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }
        public IActionResult Index()
        {
            //var repositorioProyectos = new RepositorioProyectos();
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            //var guidViewModel = new EjemploGUIDViewModel()
            //{
            //    Delimitado = servicioDelimitado.ObtenerGuid,
            //    Transitorio = servicioTransitorio.ObtenerGuid,
            //    Unico = servicioUnico.ObtenerGuid
            //};
            //var modelo = new HomeIndexViewModel() {
            //    Proyectos = proyectos,
            //EjemploGUID_1 = guidViewModel};
            var modelo = new HomeIndexViewModel()
            {
                Proyectos = proyectos

            };
            return View(modelo);
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
