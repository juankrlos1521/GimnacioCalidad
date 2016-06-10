using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gym.Models.Models
{
    public class Seguimiento
    {
        public Int32 Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Peso no válido;. Máximo dos decimales")]
        [Range(0, 999.99, ErrorMessage = "Peso no válido;. Colocar el peso en Kg")]
        public Decimal Peso { get; set; }
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Altura no válido;. Máximo dos decimales")]
        [Range(0, 9.99, ErrorMessage = "Altura no válido;. Colocar la Altura en Metros")]
        public Decimal Altura { get; set; }
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Medida no válido;. Máximo dos decimales")]
        [Range(0, 1.99 , ErrorMessage = "Medida no válido;. colocar la medida en cm")]
        public Decimal Brazo { get; set; }
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Medida no válido;. Máximo dos decimales")]
        [Range(0, 1.99 , ErrorMessage = "Medida no válido;. colocar la medida en cm")]
        public Decimal Pierna { get; set; }
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Medida no válido;. Máximo dos decimales")]
        [Range(0, 1.99 , ErrorMessage = "Medida no válido;. colocar la medida en cm")]
        public Decimal Cintura { get; set; }
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Medida no válido;. Máximo dos decimales")]
        [Range(0, 1.99 , ErrorMessage = "Medida no válido;. colocar la medida en cm")]
        public Decimal Abdomen { get; set; }
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Medida no válido;. Máximo dos decimales")]
        [Range(0, 1.99 , ErrorMessage = "Medida no válido;. colocar la medida en cm")]
        public Decimal Pecho { get; set; }        
        public String Observaciones { get; set; }


        public Int32? ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public List<Rutina> Rutinas { get; set; }



    }
}
