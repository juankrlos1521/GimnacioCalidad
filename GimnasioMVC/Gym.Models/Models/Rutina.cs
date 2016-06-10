using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Models.Models
{
    public class Rutina
    {
        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Int32 Duracion { get; set; }

        public Int32? SeguimientoId { get; set; }
        public Seguimiento Seguimiento { get; set; }

        public List<Secuencia> Secuencias { get; set; }
    }
}
