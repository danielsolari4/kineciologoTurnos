namespace relacionandoTablas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class keloke : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Edad = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Telefono = c.Int(nullable: false),
                        Dirección = c.String(nullable: false),
                        ObraSocial = c.String(),
                        HistoriaMedica = c.String(),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dia = c.String(nullable: false),
                        Hora = c.String(nullable: false),
                        PacienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pacientes", t => t.PacienteID, cascadeDelete: true)
                .Index(t => t.PacienteID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Userr = c.String(nullable: false),
                        Pass = c.String(nullable: false),
                        Logueado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnoes", "PacienteID", "dbo.Pacientes");
            DropIndex("dbo.Turnoes", new[] { "PacienteID" });
            DropTable("dbo.Users");
            DropTable("dbo.Turnoes");
            DropTable("dbo.Pacientes");
        }
    }
}
