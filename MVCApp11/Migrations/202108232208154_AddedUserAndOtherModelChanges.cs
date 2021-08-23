namespace MVCApp11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserAndOtherModelChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DrivingLicense");
        }
    }
}
