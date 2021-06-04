namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Site = c.String(),
                        Note = c.String(),
                        Modification = c.DateTime(nullable: false),
                        Classification = c.Int(nullable: false),
                        Category_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Company = c.String(),
                        Number = c.String(),
                        Code = c.String(),
                        ExpirationMonth = c.Int(nullable: false),
                        ExpirationYear = c.Int(nullable: false),
                        Notes = c.String(),
                        Category_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        MasterKey = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditCards", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Categories", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Accounts", "User_Id", "dbo.Users");
            DropForeignKey("dbo.CreditCards", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Accounts", "Category_Id", "dbo.Categories");
            DropIndex("dbo.CreditCards", new[] { "User_Id" });
            DropIndex("dbo.CreditCards", new[] { "Category_Id" });
            DropIndex("dbo.Categories", new[] { "User_Id" });
            DropIndex("dbo.Accounts", new[] { "User_Id" });
            DropIndex("dbo.Accounts", new[] { "Category_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.CreditCards");
            DropTable("dbo.Categories");
            DropTable("dbo.Accounts");
        }
    }
}
