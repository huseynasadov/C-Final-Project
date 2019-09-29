namespace GymRegistration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PackageEntryQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "PackageEntryQuantity", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "PackageEntryQuantity");
        }
    }
}
