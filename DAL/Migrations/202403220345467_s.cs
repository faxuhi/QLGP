namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permission",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Description = c.String(maxLength: 100),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Role_Permission",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        PermissionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.PermissionId })
                .ForeignKey("dbo.Permission", t => t.PermissionId, cascadeDelete: true)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(),
                        UserName = c.String(nullable: false, maxLength: 50),
                        PassWord = c.String(nullable: false, maxLength: 250),
                        Name = c.String(maxLength: 50),
                        Birthday = c.DateTime(),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        RegisteredDate = c.DateTime(),
                        IsOnline = c.Boolean(nullable: false),
                        LastLogin = c.DateTime(),
                        Intro = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.User_Permission",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        PermissionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.PermissionId })
                .ForeignKey("dbo.Permission", t => t.PermissionId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PermissionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Permission", "UserId", "dbo.User");
            DropForeignKey("dbo.User_Permission", "PermissionId", "dbo.Permission");
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Role_Permission", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Role_Permission", "PermissionId", "dbo.Permission");
            DropIndex("dbo.User_Permission", new[] { "PermissionId" });
            DropIndex("dbo.User_Permission", new[] { "UserId" });
            DropIndex("dbo.User", new[] { "RoleId" });
            DropIndex("dbo.Role_Permission", new[] { "PermissionId" });
            DropIndex("dbo.Role_Permission", new[] { "RoleId" });
            DropTable("dbo.User_Permission");
            DropTable("dbo.User");
            DropTable("dbo.Role_Permission");
            DropTable("dbo.Role");
            DropTable("dbo.Permission");
        }
    }
}
