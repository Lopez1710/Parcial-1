using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Denis_Wilfredo_Lopez_Ortega.Models.ViewModel
{
    public class CajeroViewModel
    {
        [Display(Name = "Monto")]
        [Required(ErrorMessage ="Este campo es requerido")]
        public int Monto {get; set;}
    }
}