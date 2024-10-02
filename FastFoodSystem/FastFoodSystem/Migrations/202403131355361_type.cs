namespace FastFoodSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class type : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IngridientEntities", "type", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.IngridientEntities", "type");
        }
    }
}
