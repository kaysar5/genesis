namespace eStore_2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Orders : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "OrderedProduct_ProductCode", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "OrderedProduct_ProductCode" });
            RenameColumn(table: "dbo.Orders", name: "OrderedProduct_ProductCode", newName: "ProductCode");
            AddColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "ProductCode", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "ProductCode");
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "ProductCode", "dbo.Products", "ProductCode", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductCode", "dbo.Products");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Orders", new[] { "ProductCode" });
            AlterColumn("dbo.Orders", "ProductCode", c => c.Int());
            DropColumn("dbo.Orders", "CustomerId");
            RenameColumn(table: "dbo.Orders", name: "ProductCode", newName: "OrderedProduct_ProductCode");
            CreateIndex("dbo.Orders", "OrderedProduct_ProductCode");
            AddForeignKey("dbo.Orders", "OrderedProduct_ProductCode", "dbo.Products", "ProductCode");
        }
    }
}
