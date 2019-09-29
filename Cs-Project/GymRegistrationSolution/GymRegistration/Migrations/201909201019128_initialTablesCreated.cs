namespace GymRegistration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialTablesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        Status = c.Boolean(nullable: false),
                        Balance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        MenuItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.MenuItems", t => t.MenuItemId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.MenuItemId);
            
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        PackageId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Packages", t => t.PackageId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.PackageId);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        EntryQuantity = c.Byte(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "PackageId", "dbo.Packages");
            DropForeignKey("dbo.Payments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.MenuOrders", "MenuItemId", "dbo.MenuItems");
            DropForeignKey("dbo.MenuOrders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Payments", new[] { "PackageId" });
            DropIndex("dbo.Payments", new[] { "CustomerId" });
            DropIndex("dbo.MenuOrders", new[] { "MenuItemId" });
            DropIndex("dbo.MenuOrders", new[] { "CustomerId" });
            DropTable("dbo.Packages");
            DropTable("dbo.Payments");
            DropTable("dbo.MenuItems");
            DropTable("dbo.MenuOrders");
            DropTable("dbo.Customers");
        }
    }
}
