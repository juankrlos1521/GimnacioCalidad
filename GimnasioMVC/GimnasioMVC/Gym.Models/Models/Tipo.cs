using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Models.Models
{
    public class Tipo
    {
        public Int32 Id { get; set; }
        public String Nombre { get; set; }

        public List<Ejercicio> Ejercicios { get; set; }
    }
}
