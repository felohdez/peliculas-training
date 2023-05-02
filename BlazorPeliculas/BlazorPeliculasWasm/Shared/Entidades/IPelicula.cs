using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculasWasm.Shared.Entidades
{
    public interface IPelicula
    {
        public string? Nombre { get; set; }
        public DateTime FechaLanzamiento { get; set; }
    }

    public class Pelicula : IPelicula
    {
        public string? Nombre { get; set; }
        public DateTime FechaLanzamiento { get; set; }
    }
}
