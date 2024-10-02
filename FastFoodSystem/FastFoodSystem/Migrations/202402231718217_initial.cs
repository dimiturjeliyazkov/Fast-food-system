namespace FastFoodSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IngridientEntitiesz",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Kg = c.Double(nullable: false),
                        ItemEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemEntity_Id)
                .Index(t => t.ItemEntity_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Price = c.Double(nullable: false),
                        Type = c.String(unicode: false),
                        Quantity = c.Int(nullable: false),
                        PoruchkaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PoruchkaEntities", t => t.PoruchkaId, cascadeDelete: true)
                .Index(t => t.PoruchkaId);
            
            CreateTable(
                "dbo.PoruchkaEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(unicode: false),
                        OrderDate = c.DateTime(nullable: false, precision: 0),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "PoruchkaId", "dbo.PoruchkaEntities");
            DropForeignKey("dbo.IngridientEntities", "ItemEntity_Id", "dbo.Items");
            DropIndex("dbo.Items", new[] { "PoruchkaId" });
            DropIndex("dbo.IngridientEntities", new[] { "ItemEntity_Id" });
            DropTable("dbo.PoruchkaEntities");
            DropTable("dbo.Items");
            DropTable("dbo.IngridientEntities");
        }
    }
}
