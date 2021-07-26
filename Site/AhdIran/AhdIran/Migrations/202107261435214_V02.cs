namespace Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TextItemTypes", "TypeName", c => c.String());
            DropColumn("dbo.TextItemTypes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TextItemTypes", "Name", c => c.String());
            DropColumn("dbo.TextItemTypes", "TypeName");
        }
    }
}
