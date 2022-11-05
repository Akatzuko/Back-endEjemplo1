using Back_endEjemplo1.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Back_endEjemplo1.Services
{
    public class PeliculasServices
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "SuperMan",
                Duracion = 123,
                Pais = "USA",
                Publicacion = new DateTime(2015, 12, 01)
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "SpiderMan",
                Duracion = 130,
                Pais = "USA",
                Publicacion = new DateTime(2015, 12, 01)
            };
            return new List<Pelicula> { pelicula1, pelicula2 };
        }
        
    }
}