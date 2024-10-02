namespace FastFoodSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skrap1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SkrapElementiEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Kg = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Type = c.String(unicode: false),
                        SkrapEntityId = c.Int(nullable: false),
                        skrap_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SkrapElementiEntities", t => t.skrap_Id)
                .ForeignKey("dbo.SkrapEntities", t => t.SkrapEntityId, cascadeDelete: true)
                .Index(t => t.SkrapEntityId)
                .Index(t => t.skrap_Id);
            
            CreateTable(
                "dbo.SkrapEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        TotalPrice = c.Double(nullable: false),
                        SkrapDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SkrapElementiEntities", "SkrapEntityId", "dbo.SkrapEntities");
            DropForeignKey("dbo.SkrapElementiEntities", "skrap_Id", "dbo.SkrapElementiEntities");
            DropIndex("dbo.SkrapElementiEntities", new[] { "skrap_Id" });
            DropIndex("dbo.SkrapElementiEntities", new[] { "SkrapEntityId" });
            DropTable("dbo.SkrapEntities");
            DropTable("dbo.SkrapElementiEntities");
        }
    }
}
