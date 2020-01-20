using BlazorAppPeliculas.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppPeliculas.Client.Repositorios
{
    public interface IPeliculaRepositorio
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
