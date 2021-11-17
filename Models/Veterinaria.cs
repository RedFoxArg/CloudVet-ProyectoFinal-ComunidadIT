using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudVet.Models
{
    public class Veterinaria
    {
        // ID hereda de clase base (ver vídeo)
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CUIT { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }

        // sucursal ID ???
    }
}
