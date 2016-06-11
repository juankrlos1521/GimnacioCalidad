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
        [Required]
        public String Nombres { get; set; }
        [Required]
        public String ApePaterno { get; set; }
        [Required]
        public String ApeMaterno { get; set; }
        [Required(ErrorMessage = "El campo DNI es obligatorio.")]
        [MinLength(8, ErrorMessage = "Verifique el Nro. de dígitos.")]
        [MaxLength(8, ErrorMessage = "Verifique el Nro. de dígitos.")]
        [Display(Name = "DNI")]
        [Index("NroDocumentoUnique", IsUnique = true)]
        public String Dni { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        [StringLength(250)]
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }
        [MinLength(6, ErrorMessage = "El campo Teléfono debe tener una longitud mínima de 6 dígitos.")]
        [Display(Name = "Teléfono")]
        public String Telefono { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(200)]
        [Display(Name = "Correo Electrónico")]
        public String Email { get; set; }
        [Required]
        public Boolean Sexo { get; set; }
        public Boolean Estado { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaIngreso { get; set; }
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Salario no válido;. Máximo dos decimales")]
        public Decimal Salario { get; set; }
        [Required]
        public String Especialidad { get; set; }


    }
}
