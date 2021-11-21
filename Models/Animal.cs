using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudVet.Models
{
    public class Animal : EntityBase
    {
        // ID lo hereda de la clase EntityBase
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Especie { get; set; }

        public string Raza { get; set; }

        [Required]
        public string Sexo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public short Edad { get; set; }

        [Required]
        public string MesesAños { get; set; }

        public float Peso { get; set; }
        
        [DefaultValue("false")]
        public bool Inactivo { get; set; }

        public DateTime FechaFalle { get; set; }

        [DefaultValue("false")]
        public bool Archivado { get; set; }

        //[Required]
        //public int PropietarioID { get; set; }

        //[ForeignKey("PropietarioID")]
        //public Propietario Propietario { get; set; }

        /* Propiedades de otras entidades */

        // TipoVacunaID
        // TipoVacunaDescripcion
        // VacunaID
        // VacunaMarca
        // VacunaComments
        // FechaVacunacion
        // ProximaFechaVacuancion
        // ID del veterianario / veterinaria en que se le aplicó

        // TipoDesparasitarioID
        // TipoDesparacitarioDescripcion
        // DesparasitarioID
        // DesparacitarioMarca
        // DesparacitarioComments
        // FechaDesparasitacion
        // ProximaFechaDesparasitacion



    }
}
