namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newColumnPhysician : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Physicians", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Physicians", "City");
        }
    }
}
