namespace KaleMeCrazy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewAddMigrationAfterMerge : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Shop", "MenuItemId", "dbo.MenuItem");
            DropIndex("dbo.Shop", new[] { "MenuItemId" });
            AddColumn("dbo.Customer", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Customer", "Email", c => c.String());
            AddColumn("dbo.Customer", "PhoneNumber", c => c.String());
            AddColumn("dbo.Customer", "Address", c => c.String());
            AddColumn("dbo.Customer", "ShopId", c => c.Int(nullable: false));
            AddColumn("dbo.MenuItem", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Menu", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Menu", "Name", c => c.String());
            AddColumn("dbo.Shop", "Menu", c => c.String());
            CreateIndex("dbo.Customer", "ShopId");
            AddForeignKey("dbo.Customer", "ShopId", "dbo.Shop", "ShopId", cascadeDelete: true);
            DropColumn("dbo.Customer", "OrderId");
            DropColumn("dbo.Customer", "IsMember");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customer", "IsMember", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customer", "OrderId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Customer", "ShopId", "dbo.Shop");
            DropIndex("dbo.Customer", new[] { "ShopId" });
            DropColumn("dbo.Shop", "Menu");
            DropColumn("dbo.Menu", "Name");
            DropColumn("dbo.Menu", "OwnerId");
            DropColumn("dbo.MenuItem", "OwnerId");
            DropColumn("dbo.Customer", "ShopId");
            DropColumn("dbo.Customer", "Address");
            DropColumn("dbo.Customer", "PhoneNumber");
            DropColumn("dbo.Customer", "Email");
            DropColumn("dbo.Customer", "OwnerId");
            CreateIndex("dbo.Shop", "MenuItemId");
            AddForeignKey("dbo.Shop", "MenuItemId", "dbo.MenuItem", "ItemId");
        }
    }
}
