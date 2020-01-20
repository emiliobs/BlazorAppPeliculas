using BlazorAppPeliculas.Shared.Models;
using System;
using System.Collections.Generic;

namespace BlazorAppPeliculas.Client.Repositorios
{
    public class PeliculaRepositorio : IPeliculaRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>
              {


                   new  Pelicula {Id = 1,  Lanzamiento = new DateTime(2019,5,5), Titulo = "Spider-Man", PhotoPath ="https://m.media-amazon.com/images/M/MV5BZDEyN2NhMjgtMjdhNi00MmNlLWE5YTgtZGE4MzNjMTRlMGEwXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                   new  Pelicula {Id = 2,  Lanzamiento = new DateTime(2018,5,5), Titulo = "Moana", PhotoPath="https://m.media-amazon.com/images/M/MV5BNWFkN2E3ZDYtYmVlMy00N2YyLWI1NzQtOTRlZmYyYmQ1MzRjXkEyXkFqcGdeQXVyMjI2NzcyNDk@._V1_UY268_CR43,0,182,268_AL_.jpg" },
                   new  Pelicula {Id = 3,  Lanzamiento = new DateTime(2017,5,5), Titulo = "Inception",  PhotoPath ="https://m.media-amazon.com/images/M/MV5BZGFjOTRiYjgtYjEzMS00ZjQ2LTkzY2YtOGQ0NDI2NTVjOGFmXkEyXkFqcGdeQXVyNDQ5MDYzMTk@._V1_UX182_CR0,0,182,268_AL_.jpg"},


             };
        }
    }
}
