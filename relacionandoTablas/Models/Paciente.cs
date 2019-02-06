using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace relacionandoTablas.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual List<Turno> Turnos { get; set; }
    }
}