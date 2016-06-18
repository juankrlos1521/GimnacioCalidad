using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Web.ViewModels
{
    public class InscripcionViewModel
    {
        public InscripcionViewModel()
        {
            Cursos = new List<CursoViewModel>();
        }
        public Int32 ClienteId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Decimal Total { get; set; }
        public Boolean Estado { get; set; }
        public Int32? CursoElegidoId { get; set; }
        public String Action { get; set; }
        public List<CursoViewModel> Cursos { get; set; }
    }

    public class CursoViewModel
    {
        public Int32 CursoId { get; set; }
        public String Nombre { get; set; }
        public Decimal Precio { get; set; }
        public Int32 Stock { get; set; }
    }
}