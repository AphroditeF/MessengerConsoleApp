namespace PostConsoleApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        Condition_New = c.Boolean(nullable: false),
                        Condition_Edited = c.Boolean(nullable: false),
                        SenderUsername = c.String(maxLength: 128),
                        ReceiverUsername = c.String(maxLength: 128),
                        User_Username = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_Username)
                .ForeignKey("dbo.Users", t => t.ReceiverUsername)
                .ForeignKey("dbo.Users", t => t.SenderUsername)
                .Index(t => t.SenderUsername)
                .Index(t => t.ReceiverUsername)
                .Index(t => t.User_Username);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Role = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "SenderUsername", "dbo.Users");
            DropForeignKey("dbo.Posts", "ReceiverUsername", "dbo.Users");
            DropForeignKey("dbo.Posts", "User_Username", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "User_Username" });
            DropIndex("dbo.Posts", new[] { "ReceiverUsername" });
            DropIndex("dbo.Posts", new[] { "SenderUsername" });
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
        }
    }
}
