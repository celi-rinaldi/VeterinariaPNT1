using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Models
{
    public class Turno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int nroTurno { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Ingrese hora del turno:")]
        public double horario { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ingrese fecha:")]
        public DateTime fecha { get; set; }

        [Display(Name = "Ingrese su dni:")]
        [Required(ErrorMessage = "Ingrese su dni")]
        public string dni { get; set; }


        [ForeignKey("Mascota")]
        public int legajoMascota { get; set; }
        public Mascota Mascota { get; set; }

        [ForeignKey("MedicoVeterinario")]
        public int nroLegajo { get; set; }
        public MedicoVeterinario Medico { get; set; }

    }
}
