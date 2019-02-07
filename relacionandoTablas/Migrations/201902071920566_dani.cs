namespace relacionandoTablas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dani : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Userr = c.String(),
                        Pass = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Turnoes", "Hora", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Turnoes", "Hora");
            DropTable("dbo.Users");
        }
    }
}
