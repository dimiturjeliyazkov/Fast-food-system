namespace FastFoodSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dostavkaName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DostavkaEntities", "Name", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DostavkaEntities", "Name");
        }
    }
}
