namespace GraysSportAlmanac.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Working : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answer",
                c => new
                    {
                        AnswerId = c.Int(nullable: false, identity: true),
                        AuthorId = c.Guid(nullable: false),
                        AnswerContent = c.String(),
                        FAQId = c.Int(nullable: false),
                        ProfileId = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.AnswerId)
                .ForeignKey("dbo.FAQ", t => t.FAQId, cascadeDelete: false)
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: false)
                .Index(t => t.FAQId)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.FAQ",
                c => new
                    {
                        FaqId = c.Int(nullable: false, identity: true),
                        AuthorId = c.Guid(nullable: false),
                        Question = c.String(),
                        ProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FaqId)
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: false)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        UserName = c.String(nullable: false),
                        Bio = c.String(nullable: false),
                        Record = c.String(),
                        TotalRisked = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAccount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitSize = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Units = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProfileId);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        AuthorId = c.Guid(nullable: false),
                        UserName = c.String(),
                        ContentComment = c.String(nullable: false),
                        CreateUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ProfileId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                        FaqId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.FAQ", t => t.FaqId)
                .ForeignKey("dbo.Post", t => t.PostId, cascadeDelete: false)
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: false)
                .Index(t => t.ProfileId)
                .Index(t => t.PostId)
                .Index(t => t.FaqId);
            
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        AuthorId = c.Guid(nullable: false),
                        ProfileId = c.Int(nullable: false),
                        UserName = c.String(),
                        BetDate = c.String(nullable: false),
                        Bet = c.String(nullable: false),
                        Risked = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Odds = c.Int(nullable: false),
                        Result = c.String(),
                        Payout = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: false)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.Answer", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Answer", "FAQId", "dbo.FAQ");
            DropForeignKey("dbo.FAQ", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Comment", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Comment", "PostId", "dbo.Post");
            DropForeignKey("dbo.Post", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.Comment", "FaqId", "dbo.FAQ");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Post", new[] { "ProfileId" });
            DropIndex("dbo.Comment", new[] { "FaqId" });
            DropIndex("dbo.Comment", new[] { "PostId" });
            DropIndex("dbo.Comment", new[] { "ProfileId" });
            DropIndex("dbo.FAQ", new[] { "ProfileId" });
            DropIndex("dbo.Answer", new[] { "ProfileId" });
            DropIndex("dbo.Answer", new[] { "FAQId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Post");
            DropTable("dbo.Comment");
            DropTable("dbo.Profile");
            DropTable("dbo.FAQ");
            DropTable("dbo.Answer");
        }
    }
}
