using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Gym.Models.Models;
using Gym.Interfaces.Titulos;

namespace Gym.Web.Controllers
{
    public class RutinaController : Controller
    {

        private readonly IRutinaTitulo servicio;

        public RutinaController(IRutinaTitulo _servicios)
        {
            servicio = _servicios;
        }


        // GET: Rutina
        public ViewResult Index(int? x)
        {
            if (x == null)
            {
                x = 4;
            }
            var _result = servicio.ListameTodo(x);
            return View(servicio.ListameTodo(x));
        }

        // GET: Rutina/Details/5
        public ActionResult Details(int id)
        {
            var model = servicio.TraerRutinaPorId(id);

            return View("Details", model);
        }

        // GET: Rutina/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Rutina/Create
        [HttpPost]
        public ActionResult Create(Rutina rutina)
        {
            try
            {
                // TODO: Add insert logic here

                servicio.Insertar(rutina);

                return RedirectToAction("Index", "Rutina");
            }
            catch
            {
                return View(rutina);
            }
        }

        // GET: Rutina/Edit/5
        public ActionResult Edit(int id)
        {
            var model = servicio.TraerRutinaPorId(id);
            return View("Edit", model);
        }

        // POST: Rutina/Edit/5
        [HttpPost]
        public ActionResult Edit(Rutina rutina)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servicio.Modificar(rutina);
                }
                // TODO: Add update logic here

                return RedirectToAction("Index","Seguimiento");
            }
            catch
            {
                return View(rutina);
            }
        }

        // GET: Rutina/Delete/5
        public ActionResult Delete(int id)
        {
            servicio.Eliminar(id);
            return RedirectToAction("Index", "Rutina");
        }

        //// POST: Rutina/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
