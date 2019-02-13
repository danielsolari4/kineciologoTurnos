using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace relacionandoTablas.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Userr { get; set; }
        [Required]
        public string Pass { get; set; }

        public int Logueado { get; set; }
    }
}