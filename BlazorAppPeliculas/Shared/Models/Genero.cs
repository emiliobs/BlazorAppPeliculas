using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorAppPeliculas.Shared.Models
{
    public class Genero
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El Campo {0} es requerido")]
        public string Nombre { get; set; }
    }
}
