namespace MVCExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EcomCategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        desc = c.String(),
                        photoPath = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        categID = c.Int(nullable: false),
                        name = c.String(),
                        desc = c.String(),
                        photoPath = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.EcomCategories", t => t.categID, cascadeDelete: true)
                .Index(t => t.categID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "categID", "dbo.EcomCategories");
            DropIndex("dbo.Foods", new[] { "categID" });
            DropTable("dbo.Foods");
            DropTable("dbo.EcomCategories");
        }
    }
}
