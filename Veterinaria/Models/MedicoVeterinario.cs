using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Models
{
    public class MedicoVeterinario
    {
        [Key]
        public int nroLegajo { get; set; }
        public int nroMatricula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public MedicoVeterinario(int nroLegajo, int nroMatricula, string nombre, string apellido)
        {
            this.nroLegajo = nroLegajo;
            this.nroMatricula = nroMatricula;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
