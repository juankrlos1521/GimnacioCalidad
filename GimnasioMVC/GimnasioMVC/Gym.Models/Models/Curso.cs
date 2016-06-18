using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models.Models
{
    public class Curso
    {
        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public Int32 Sesiones { get; set; }
        public Boolean LimiteTiempo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Decimal Precio { get; set; }
        public Int32 Stock { get; set; }
        public Trabajador Trabajador { get; set; }
        public Int32 TrabajadorId { get; set; }
        public List<Inscripcion> Inscripciones { get; set; }

        public Curso() 
        {
            this.Inscripciones = new List<Inscripcion>();
        }
    }
}
