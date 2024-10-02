namespace FastFoodSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stoka : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DostavchikEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ElementEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Kg = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Type = c.String(unicode: false),
                        DostavchikEntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DostavchikEntities", t => t.DostavchikEntityId, cascadeDelete: true)
                .Index(t => t.DostavchikEntityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ElementEntities", "DostavchikEntityId", "dbo.DostavchikEntities");
            DropIndex("dbo.ElementEntities", new[] { "DostavchikEntityId" });
            DropTable("dbo.ElementEntities");
            DropTable("dbo.DostavchikEntities");
        }
    }
}
