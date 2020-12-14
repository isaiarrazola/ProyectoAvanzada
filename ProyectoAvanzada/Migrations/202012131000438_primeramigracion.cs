namespace ProyectoAvanzada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeramigracion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "Existencia", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "Existencia");
        }
    }
}
