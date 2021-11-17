using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudVet.Models
{
    public class Persona : EntityBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
