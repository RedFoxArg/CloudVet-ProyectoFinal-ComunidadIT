using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudVet.Models
{
    public class Propietario : Persona
    {
        // ID hereda de clase base (ver vídeo)
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
