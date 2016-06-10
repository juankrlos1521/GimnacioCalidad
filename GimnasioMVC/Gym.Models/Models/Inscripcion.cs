using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gym.Models.Models
{
    public class Inscripcion
    {
        [Key]
        public Int32 Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Decimal Total { get; set; }
        public Boolean Tipo { get; set; }
        public Int32? ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
