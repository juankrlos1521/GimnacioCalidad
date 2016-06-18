using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym.Web.ViewModels;
using Gym.Models.Models;
using Gym.Services.Tramas;
using Gym.Interfaces.Titulos;

namespace Gym.Web.Controllers
{
    public class RutinaSecuenciaController : Controller
    {
        private readonly IRutinaSecuencia servicio;

        public RutinaSecuenciaController(IRutinaSecuencia _servicios)
        {
            servicio = _servicios;
        }


        // GET: RutinaSecuencia
        public ActionResult Index()
        {
            return View();
        }

        // GET: RutinaSecuencia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RutinaSecuencia/Create
        public ActionResult Create()
        {
            ViewBag.Ejercicios = servicio.ObtenerTodosLosEjercicios();
            return View("Crear", new RutinaViewModels());
        }

        [HttpPost]
        public ViewResult Guardar(RutinaViewModels viewModel)
        {
            if (viewModel.Action == "Agregar")
            {

                ViewBag.Ejercicios = servicio.ObtenerTodosLosEjercicios();

                var model = ObtenerDetalle(viewModel);

                return View("Crear", model);
            }
            else
            {
                GuardarRutina(viewModel);
                return View("Crear");
                // guardaremos
            }
        }


        private RutinaViewModels ObtenerDetalle(RutinaViewModels viewModel)
        {
            var ejercicioAgregar = servicio.FindEjercicio(viewModel.EjercicioElegidoId.Value);

            var ejercicioViewModel = new EjerciciosViewModels
            {
                EjercicioId = ejercicioAgregar.Id,
                Nombre = ejercicioAgregar.Nombre,
                //Precio = ejercicioAgregar.Precio

            };

            viewModel.Detalle.Add(ejercicioViewModel);

            return viewModel;
        }

        private void GuardarRutina(RutinaViewModels viewModel)
        {
            //var Cliente = new Cliente
            //{
            //    RazonSocial = viewModel.RazonSocial,
            //};
            // guarar lciente
            var Rutina = new Rutina
            {
                FechaInicio = viewModel.FechaInicio,
                FechaFin = viewModel.FechaFin,
                //SeguimientoId = Cliente.Id,
            };

            // guarda venta

            foreach (var item in viewModel.Detalle)
            {
                var VentaProducto = new Secuencia
                {
                    RutinaId = Rutina.Id,
                    EjercicioId = item.EjercicioId,
                    Dia = item.Dia,
                    Serie = item.Serie,
                    Repeticiones = item.Repeticion,
                    Orden = item.Orden,

                };

                //guardo
            }


        }

        //// POST: RutinaSecuencia/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RutinaSecuencia/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: RutinaSecuencia/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RutinaSecuencia/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: RutinaSecuencia/Delete/5
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
