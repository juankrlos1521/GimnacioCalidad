using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Gym.Models.Models
{
    public class Secuencia
    {
        
        public Int32 Dia { get; set; }
        public Int32 Serie { get; set; }
        public Int32 Repeticiones { get; set; }
        public String Orden { get; set; }

        public Int32? EjercicioId { get; set; }
        public Ejercicio Ejercicios { get; set; }

        public Int32? RutinaId { get; set; }
        public Rutina Rutinas { get; set; }




    }
}
