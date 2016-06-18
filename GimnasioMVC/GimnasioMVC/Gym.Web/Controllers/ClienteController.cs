using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Gym.Models.Models;
using Gym.Interfaces.Titulos;

namespace Gym.Web.Controllers
{
    public class ClienteController : Controller
    {

        private readonly IClienteTitulo servicio;

        public ClienteController(IClienteTitulo _servicios)
        {
            servicio = _servicios;
        }


        // GET: Cliente
        public ActionResult Index()
        {
            var _result = servicio.ListameTodo("");
            return View("Index", _result);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var model = servicio.TraerClientePorId(id);

            return View("Details", model);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                // TODO: Add insert logic here

                servicio.Insertar(cliente);

                return RedirectToAction("Index", "Cliente");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var model = servicio.TraerClientePorId(id);
            return View("Edit", model);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servicio.Modificar(cliente);
                }
                // TODO: Add update logic here

                return RedirectToAction("Index", "Cliente");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            servicio.Eliminar(id);
            return RedirectToAction("Index", "Cliente");
        }

       
    }
}
