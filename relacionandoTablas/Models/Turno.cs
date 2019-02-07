using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace relacionandoTablas.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }
        public virtual Paciente Paciente { get; set; }
        public int PacienteID { get; set; }
    }
}