using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Models
{
    public class Mascota
    {
        [Key]
        public int legajoMascota { get; set; }
        public string nombre { get; set; }

        //public Mascota(int legajoMascota, string nombre)
        //{
        //    this.legajoMascota = legajoMascota;
        //    this.nombre = nombre;
        //}
    }
}
