using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudVet.Models
{
    public class Profesional : Persona
    {
        // ID hereda de clase base (ver vídeo)
        public string Matricula { get; set; }
        public int EspecialidadID { get; set; }
        
        // Suponiendo que trabaja solo en una. ¿Como sería si trabajara en más de una vete?
        public int VeterinariaID { get; set; }
    }
}
