using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Gym.Models.Models;
using Gym.Interfaces.Titulos;

namespace Gym.Web.Controllers
{
    public class SecuenciaController : Controller
    {

        private readonly ISecuenciaTitulo servicio;

        public SecuenciaController(ISecuenciaTitulo _servicios)
        {
            servicio = _servicios;
        }


        // GET: Secuencia
        public ActionResult Index()
        {
            return View();
        }

        // GET: Secuencia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Secuencia/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Secuencia/Create
        [HttpPost]
        public ActionResult Create(Secuencia secuencia)
        {
            //try
            //{
                // TODO: Add insert logic here
                servicio.Insertar(secuencia);
                return RedirectToAction("Index", "Home");
            //}
            //catch
            //{
            //    return View(secuencia);
            //}
        }

        // GET: Secuencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Secuencia/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Secuencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Secuencia/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
