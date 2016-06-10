using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gym.Models.Models
{
    public class Ejercicio
    {
        public Int32 Id { get; set; }
        public String Nombre { get; set; }

        public Int32? TipoId { get; set; }
        public Tipo Tipo { get; set; }

        public List<Secuencia> Secuencias { get; set; }

    }
}
