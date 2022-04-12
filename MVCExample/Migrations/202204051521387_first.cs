namespace MVCExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        foodID = c.Int(nullable: false),
                        qty = c.Int(nullable: false),
                        price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Foods", t => t.foodID, cascadeDelete: true)
                .Index(t => t.foodID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "foodID", "dbo.Foods");
            DropIndex("dbo.Carts", new[] { "foodID" });
            DropTable("dbo.Carts");
        }
    }
}
