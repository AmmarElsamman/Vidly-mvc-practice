namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "Nmae");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Nmae", c => c.String());
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
