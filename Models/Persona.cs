using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba_tecnica_net.Models
{
    public class Persona
    {
        public string Identificador { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Email { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string NumeroIdentificacionConcat { get; set; }
        public string NombreCompleto { get; set; }
    }
}