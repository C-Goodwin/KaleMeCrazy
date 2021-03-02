namespace KaleMeCrazy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madethemenuitemIdnullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Shop", "MenuItemId", "dbo.MenuItem");
            DropIndex("dbo.Shop", new[] { "MenuItemId" });
            AlterColumn("dbo.Shop", "MenuItemId", c => c.Int());
            CreateIndex("dbo.Shop", "MenuItemId");
            AddForeignKey("dbo.Shop", "MenuItemId", "dbo.MenuItem", "ItemId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shop", "MenuItemId", "dbo.MenuItem");
            DropIndex("dbo.Shop", new[] { "MenuItemId" });
            AlterColumn("dbo.Shop", "MenuItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Shop", "MenuItemId");
            AddForeignKey("dbo.Shop", "MenuItemId", "dbo.MenuItem", "ItemId", cascadeDelete: true);
        }
    }
}
