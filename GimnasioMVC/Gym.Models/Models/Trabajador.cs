using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models.Models
{
    public class Trabajador
    {
        [Key]
        public Int32 Id { get; set; }
        public String Nombres { get; set; }
        public String ApePaterno { get; set; }
        public String ApeMaterno { get; set; }
        public String Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public Boolean Sexo { get; set; }
        public Boolean Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Decimal Salario { get; set; }
        public String Especialidad { get; set; }


    }
}
