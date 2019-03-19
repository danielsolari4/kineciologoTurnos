using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace relacionandoTablas.Models
{
    public class Turno
    {
        public int Id { get; set; }
        [Required]
        public string Dia { get; set; }
        [Required]
        public string Hora { get; set; }
        public virtual Paciente Paciente { get; set; }
        public int PacienteID { get; set; }
    }
}