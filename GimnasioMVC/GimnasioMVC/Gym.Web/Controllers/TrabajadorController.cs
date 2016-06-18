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

        // GET: Trabajador/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Trabajador/Create
        [HttpPost]
        public ActionResult Create(Trabajador trabajador)
        {
            try
            {
                // TODO: Add insert logic here
                servicio.InsertarTrabajador(trabajador);

                return RedirectToAction("Index", "Trabajador");

            }
            catch
            {
                return View(trabajador);
            }
        }

        // GET: Trabajador/Details
        public ActionResult Details(int id)
        {
            var model = servicio.TraerTrabajadorPorId(id);

            return View("Details", model);
        }

        // GET: Trabajador/Edit
        public ActionResult Edit(int id)
        {
            var model = servicio.TraerTrabajadorPorId(id);
            return View("Edit", model);
        }

        // POST: Trabajador/Edit
        [HttpPost]
        public ActionResult Edit(Trabajador trabajador)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servicio.ModificarTrabajador(trabajador);
                }
                // TODO: Add update logic here

                return RedirectToAction("Index", "Trabajador");
            }
            catch
            {
                return View(trabajador);
            }
        }
        public ActionResult Inhabilitar(int id, bool? estado)
        {
            servicio.InhabilitarTrabajador(id, estado);
            return RedirectToAction("Index", "Trabajador");

        }
    }
}