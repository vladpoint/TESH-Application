using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TESHApp.Models
{
    public class Alumno
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string NombreAlumno { get; set; }
        [Required]
        public string ApellidoAlumno { get; set; }
        [Required]
        public int Matricula { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }
        public int Calificacion {get; set;}
    }
}
