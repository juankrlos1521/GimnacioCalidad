using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Models.Models
{
    public class Pago
    {
        [Key]
        public Int32 Id { get; set; }
        public Decimal Total { get; set; }
        public Int32? InscripcionId { get; set; }
        public Inscripcion Inscripcion { get; set; }
    }
}
