using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace Vivero.Model
{
    public class Persona
    {
        [Required]
        public int dni { get; set; }

        [Required, Display(Name ="Apellido")]
        public string apellido { get; set; }

        [Required, Display(Name = "Nombre")]
        public string nombre { get; set; }

        public string email { get; set; }

        public virtual string user { get; set; }
    }
}