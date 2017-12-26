namespace BoilerplateInitiative.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_Field : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Fields");
            AlterColumn("dbo.Fields", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Fields", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Fields");
            AlterColumn("dbo.Fields", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Fields", "Id");
        }
    }
}
