using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace relacionandoTablas.Models
{
    public class kineContext : DbContext
    {
        public kineContext() :base("kineConnection")
        {
            //Database.SetInitializer<kineContext>(new DropCreateDatabaseAlways<kineContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turno>().HasRequired(x => x.Paciente).WithMany(s => s.Turnos).HasForeignKey(t => t.PacienteID);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<User> UsersTabla { get; set; }
    }
}