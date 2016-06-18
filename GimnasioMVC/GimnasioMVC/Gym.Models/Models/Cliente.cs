using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gym.Models.Models
{
    public class Cliente
    {
        [Key]
        public Int32 Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre", Description = "nombre")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "El campo DNI es obligatorio y unico")]
        [MinLength(8, ErrorMessage = "Verifique el Nro. de dígitos.")]
        [MaxLength(8, ErrorMessage = "Verifique el Nro. de dígitos.")]
        [Display(Name = "DNI")]
        [Index("NroDocumentoUnique",IsUnique = true )]
        
        public String Dni { get; set; }
        [Required(ErrorMessage = "El apelldio paterno es requerido")]
        [Display(Name = "Apellido Paterno", Description = "apellido paterno")]
        public String ApellidoPaterno { get; set; }
        [Required(ErrorMessage = "El apellido materno es requerido")]
        [Display(Name = "Apellido Materno", Description = "apellido materno")]
        public String ApellidoMaterno { get; set; }
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
        [Required(ErrorMessage = "El email es requerido")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email", Description = "ejemplo@ejemplo.com")]
        public String Email { get; set; }
        public Boolean Sexo { get; set; }
        public Boolean Estado { get; set; }

        public virtual ICollection<Seguimiento> Seguimiento { get; set; }

    }
}
