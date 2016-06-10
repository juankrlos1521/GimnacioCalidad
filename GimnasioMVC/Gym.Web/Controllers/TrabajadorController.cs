using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Gym.Models.Models;
using Gym.Interfaces.Titulos;

namespace Gym.Web.Controllers
{
    public class TrabajadorController : Controller
    {

        private readonly ITrabajadorTitulo servicio;

        public TrabajadorController(ITrabajadorTitulo _servicios)
        {
            servicio = _servicios;
        }

        // GET: Trabajador
        [HttpGet]
        public ActionResult Index()
        {
            var _result = servicio.ListarTrabajadores("Solier");
            return View(_result);
        }
    }
}