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
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Especie")]
        public string Especie { get; set; }

        [Display(Name = "Raza")]
        public string Raza { get; set; }

        [Required]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Edad")]
        public short Edad { get; set; }

        [Required]
        public string MesesAños { get; set; }

        [Display(Name = "Peso")]
        public float Peso { get; set; }
        
        [DefaultValue("false")]
        public bool Inactivo { get; set; }

        [Display(Name = "Fecha de Fallecimiento")]
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
