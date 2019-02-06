namespace relacionandoTablas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primermigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dia = c.String(),
                        PacienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pacientes", t => t.PacienteID, cascadeDelete: true)
                .Index(t => t.PacienteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnoes", "PacienteID", "dbo.Pacientes");
            DropIndex("dbo.Turnoes", new[] { "PacienteID" });
            DropTable("dbo.Turnoes");
            DropTable("dbo.Pacientes");
        }
    }
}
