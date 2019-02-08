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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Display(Name ="Fecha de Nacimiento")]
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Dirección { get; set; }
        public string ObraSocial { get; set; }
        public string HistoriaMedica { get; set; }
        public string Correo { get; set; }

        public virtual List<Turno> Turnos { get; set; }
    }
}