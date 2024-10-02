namespace FastFoodSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DostavkaElementEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DostavkaElementiEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Kg = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Type = c.String(unicode: false),
                        DostavkaEntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DostavkaEntities", t => t.DostavkaEntityId, cascadeDelete: true)
                .Index(t => t.DostavkaEntityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DostavkaElementiEntities", "DostavkaEntityId", "dbo.DostavkaEntities");
            DropIndex("dbo.DostavkaElementiEntities", new[] { "DostavkaEntityId" });
            DropTable("dbo.DostavkaElementiEntities");
        }
    }
}
