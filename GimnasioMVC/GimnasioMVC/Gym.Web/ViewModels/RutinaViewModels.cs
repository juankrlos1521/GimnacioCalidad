using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Web.ViewModels
{
    public class RutinaViewModels
    {
        public RutinaViewModels()
        {
            Detalle = new List<EjerciciosViewModels>();
        }
        public int? EjercicioElegidoId { get; set; }
        public Int32 Dia { get; set; }
        public Int32 Serie { get; set; }
        public Int32 Repeticion { get; set; }
        public String Orden { get; set; }
        public String Action { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<EjerciciosViewModels> Detalle { get; set; }
    }

    public class EjerciciosViewModels
    {
        public Int32? EjercicioId { get; set; }
        public String Nombre { get; set; }
        public Int32 Dia { get; set; }
        public Int32 Serie { get; set; }
        public Int32 Repeticion { get; set; }
        public String Orden { get; set; }
    }
}