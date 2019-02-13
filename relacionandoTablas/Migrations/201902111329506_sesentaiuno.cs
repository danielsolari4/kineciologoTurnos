namespace relacionandoTablas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sesentaiuno : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pacientes", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Pacientes", "Apellido", c => c.String(nullable: false));
            AlterColumn("dbo.Pacientes", "Dirección", c => c.String(nullable: false));
            AlterColumn("dbo.Turnoes", "Dia", c => c.String(nullable: false));
            AlterColumn("dbo.Turnoes", "Hora", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Turnoes", "Hora", c => c.String());
            AlterColumn("dbo.Turnoes", "Dia", c => c.String());
            AlterColumn("dbo.Pacientes", "Dirección", c => c.String());
            AlterColumn("dbo.Pacientes", "Apellido", c => c.String());
            AlterColumn("dbo.Pacientes", "Nombre", c => c.String());
        }
    }
}
