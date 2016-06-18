using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Gym.Models.Models;
using Gym.Interfaces.Titulos;
using Gym.Web.ViewModels;
using Gym.Services.Tramas;

namespace Gym.Web.Controllers
{
    public class InscripcionController : Controller
    {
        private ICursoTitulo service { get; set; }

        public InscripcionController(ICursoTitulo _services)
        {
            service = _services;
        }
        public ViewResult Create()
        {
            ViewBag.Cursos = service.ListarCursos("");
            return View("Create", new InscripcionViewModel());
            //return View();
        }

        [HttpPost]
        public ViewResult Guardar(InscripcionViewModel viewModel)
        {
            if (viewModel.Action == "Agregar")
            {
                ViewBag.Cursos = service.ListarCursos("");
                var model = ObtenerDetalle(viewModel);
                return View("Create", model);
            }
            else
            {
                // Guardarinscripcion(viewModel);
                return View("Create");
            }
        }

        private InscripcionViewModel ObtenerDetalle(InscripcionViewModel viewModel)
        {
            var cursoAAgregar = service.TraerCursoPorId(viewModel.CursoElegidoId.Value);
            var cursoViewModel = new CursoViewModel
            {
                CursoId = cursoAAgregar.Id,
                Nombre = cursoAAgregar.Nombre,
                Precio = cursoAAgregar.Precio,
                Stock = cursoAAgregar.Stock
            };

            viewModel.Cursos.Add(cursoViewModel);
            return viewModel;
        }

    }
}