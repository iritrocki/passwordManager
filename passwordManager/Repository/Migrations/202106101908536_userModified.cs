namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userModified : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Categories", "User_Id", "dbo.Users");
            DropForeignKey("dbo.CreditCards", "User_Id", "dbo.Users");
            DropIndex("dbo.Accounts", new[] { "User_Id" });
            DropIndex("dbo.Categories", new[] { "User_Id" });
            DropIndex("dbo.CreditCards", new[] { "User_Id" });
            DropColumn("dbo.Accounts", "User_Id");
            DropColumn("dbo.Categories", "User_Id");
            DropColumn("dbo.CreditCards", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CreditCards", "User_Id", c => c.Int());
            AddColumn("dbo.Categories", "User_Id", c => c.Int());
            AddColumn("dbo.Accounts", "User_Id", c => c.Int());
            CreateIndex("dbo.CreditCards", "User_Id");
            CreateIndex("dbo.Categories", "User_Id");
            CreateIndex("dbo.Accounts", "User_Id");
            AddForeignKey("dbo.CreditCards", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Categories", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Accounts", "User_Id", "dbo.Users", "Id");
        }
    }
}
