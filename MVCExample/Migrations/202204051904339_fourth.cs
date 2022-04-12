namespace MVCExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "eMail", c => c.String());
            AddColumn("dbo.Carts", "orderDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carts", "orderDate");
            DropColumn("dbo.Carts", "eMail");
        }
    }
}
