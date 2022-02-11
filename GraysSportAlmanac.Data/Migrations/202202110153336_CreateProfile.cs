namespace GraysSportAlmanac.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GroupPost", "ProfileId", c => c.Int(nullable: false));
            AddColumn("dbo.Group", "ProfileId", c => c.Int(nullable: false));
            AddColumn("dbo.Post", "ProfileId", c => c.Int(nullable: false));
            CreateIndex("dbo.GroupPost", "ProfileId");
            CreateIndex("dbo.Group", "ProfileId");
            CreateIndex("dbo.Post", "ProfileId");
            AddForeignKey("dbo.GroupPost", "ProfileId", "dbo.Profile", "ProfileId", cascadeDelete: true);
            AddForeignKey("dbo.Group", "ProfileId", "dbo.Profile", "ProfileId", cascadeDelete: true);
            AddForeignKey("dbo.Post", "ProfileId", "dbo.Profile", "ProfileId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Post", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Group", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.GroupPost", "ProfileId", "dbo.Profile");
            DropIndex("dbo.Post", new[] { "ProfileId" });
            DropIndex("dbo.Group", new[] { "ProfileId" });
            DropIndex("dbo.GroupPost", new[] { "ProfileId" });
            DropColumn("dbo.Post", "ProfileId");
            DropColumn("dbo.Group", "ProfileId");
            DropColumn("dbo.GroupPost", "ProfileId");
        }
    }
}
