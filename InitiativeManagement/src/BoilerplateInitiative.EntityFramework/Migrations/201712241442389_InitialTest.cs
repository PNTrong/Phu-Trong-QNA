namespace BoilerplateInitiative.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FieldGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        IsDeactive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FieldGroupId = c.Int(),
                        FieldName = c.String(),
                        IsDeactive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FieldGroups", t => t.FieldGroupId)
                .Index(t => t.FieldGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fields", "FieldGroupId", "dbo.FieldGroups");
            DropIndex("dbo.Fields", new[] { "FieldGroupId" });
            DropTable("dbo.Fields");
            DropTable("dbo.FieldGroups");
        }
    }
}
