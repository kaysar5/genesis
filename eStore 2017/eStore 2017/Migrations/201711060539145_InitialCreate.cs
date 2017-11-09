namespace eStore_2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 25),
                        EmailAddress = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderNumber = c.Int(nullable: false, identity: true),
                        OrderStatus = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        OrderedProduct_ProductCode = c.Int(),
                    })
                .PrimaryKey(t => t.OrderNumber)
                .ForeignKey("dbo.Products", t => t.OrderedProduct_ProductCode)
                .Index(t => t.OrderedProduct_ProductCode);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductCode = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "OrderedProduct_ProductCode", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "OrderedProduct_ProductCode" });
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
