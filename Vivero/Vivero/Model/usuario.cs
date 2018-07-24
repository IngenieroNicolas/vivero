using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vivero.Model
{
    public class usuario
    {
        [Required, Display(Name = "usuario")]
        public string user { get; set; }

        [Required, StringLength(8), Display(Name="contraseña")]
        public string contraseña { get; set; }
    }
}