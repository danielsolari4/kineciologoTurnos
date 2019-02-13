using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace relacionandoTablas.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        [Display(Name ="Fecha de Nacimiento")]
        public int Edad { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        public string Dirección { get; set; }
        [Display(Name = "Obra Social")]
        public string ObraSocial { get; set; }
        [Display(Name = "Historia Médica")]
        public string HistoriaMedica { get; set; }
        public string Correo { get; set; }

        public virtual List<Turno> Turnos { get; set; }
    }
}