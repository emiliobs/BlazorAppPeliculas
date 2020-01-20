using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppPeliculas.Shared.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string PhotoPath { get; set; }
        public DateTime Lanzamiento { get; set; }
        public string TituloCortado 
        {
            get 
            {
                if (string.IsNullOrWhiteSpace(Titulo) )
                {
                    return null;
                }

                if (Titulo.Length > 60)
                {
                    return $"{Titulo.Substring(0, 60)} ...";
                }
                else
                {
                    return Titulo;
                }
            }
           
        }
    }
}
