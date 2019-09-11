using System;
using System.ComponentModel.DataAnnotations;

namespace TESHApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Alumnos
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        [Key]
        public int Id { get; set; }

    }
}