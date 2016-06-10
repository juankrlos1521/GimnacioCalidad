using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Gym.Models.Models;
using Gym.Interfaces.Titulos;

namespace Gym.Web.Controllers
{
    public class SeguimientoController : Controller
    {

        private readonly ISeguimientoTitulo servicio;

        public SeguimientoController(ISeguimientoTitulo _servicios)
        {
            servicio = _servicios;
        }

        // GET: Seguimiento
        [HttpGet]
        public ViewResult Index(int? x)
        {
            if (x == null)
            {
                x = 2;
            }
            var _result = servicio.ListameTodo(x);
            return View(servicio.ListameTodo(x));
        }

        // GET: Seguimiento/Details/5
        public ActionResult Details(int id)
        {
           
            var model = servicio.TraerSeguimientoPorId(id);           
      
            return View("Details", model);
        }

        // GET: Seguimiento/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Seguimiento/Create
        [HttpPost]
        public ActionResult Create(Seguimiento seguimiento)
        {
            try
            {
                // TODO: Add insert logic here
                servicio.Insertar(seguimiento);            

                return RedirectToAction("Index", "Seguimiento");
                
            }
            catch
            {
                return View(seguimiento);
            }
        }

        // GET: Seguimiento/Edit/5
        public ActionResult Edit(int id)
        {
            var model = servicio.TraerSeguimientoPorId(id);
            return View("Edit", model);
        }

        // POST: Seguimiento/Edit/5
        [HttpPost]
        public ActionResult Edit(Seguimiento seguimiento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servicio.Modificar(seguimiento);
                }
                // TODO: Add update logic here

                return RedirectToAction("Index","Seguimiento");
            }
            catch
            {
                return View(seguimiento);
            }
        }

        [HttpGet]
        // GET: Seguimiento/Delete/5
        public ActionResult Delete(int id)
        {
            servicio.Eliminar(id);
            return RedirectToAction("Index","Seguimiento");
        }

       
       
    }
}
