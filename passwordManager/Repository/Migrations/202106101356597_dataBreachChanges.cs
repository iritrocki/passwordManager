namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataBreachChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CreditCards", "DataBreachCheck_Id", "dbo.DataBreachChecks");
            DropForeignKey("dbo.Accounts", "DataBreachCheck_Id", "dbo.DataBreachChecks");
            DropIndex("dbo.Accounts", new[] { "DataBreachCheck_Id" });
            DropIndex("dbo.CreditCards", new[] { "DataBreachCheck_Id" });
            CreateTable(
                "dbo.DataBreachLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Line = c.String(),
                        DataBreachCheck_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataBreachChecks", t => t.DataBreachCheck_Id)
                .Index(t => t.DataBreachCheck_Id);
            
            CreateTable(
                "dbo.CreditCardDataBreachChecks",
                c => new
                    {
                        CreditCard_Id = c.Int(nullable: false),
                        DataBreachCheck_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CreditCard_Id, t.DataBreachCheck_Id })
                .ForeignKey("dbo.CreditCards", t => t.CreditCard_Id, cascadeDelete: true)
                .ForeignKey("dbo.DataBreachChecks", t => t.DataBreachCheck_Id, cascadeDelete: true)
                .Index(t => t.CreditCard_Id)
                .Index(t => t.DataBreachCheck_Id);
            
            CreateTable(
                "dbo.DataBreachCheckAccounts",
                c => new
                    {
                        DataBreachCheck_Id = c.Int(nullable: false),
                        Account_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DataBreachCheck_Id, t.Account_Id })
                .ForeignKey("dbo.DataBreachChecks", t => t.DataBreachCheck_Id, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.Account_Id, cascadeDelete: true)
                .Index(t => t.DataBreachCheck_Id)
                .Index(t => t.Account_Id);
            
            DropColumn("dbo.Accounts", "DataBreachCheck_Id");
            DropColumn("dbo.CreditCards", "DataBreachCheck_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CreditCards", "DataBreachCheck_Id", c => c.Int());
            AddColumn("dbo.Accounts", "DataBreachCheck_Id", c => c.Int());
            DropForeignKey("dbo.DataBreachCheckAccounts", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.DataBreachCheckAccounts", "DataBreachCheck_Id", "dbo.DataBreachChecks");
            DropForeignKey("dbo.CreditCardDataBreachChecks", "DataBreachCheck_Id", "dbo.DataBreachChecks");
            DropForeignKey("dbo.CreditCardDataBreachChecks", "CreditCard_Id", "dbo.CreditCards");
            DropForeignKey("dbo.DataBreachLines", "DataBreachCheck_Id", "dbo.DataBreachChecks");
            DropIndex("dbo.DataBreachCheckAccounts", new[] { "Account_Id" });
            DropIndex("dbo.DataBreachCheckAccounts", new[] { "DataBreachCheck_Id" });
            DropIndex("dbo.CreditCardDataBreachChecks", new[] { "DataBreachCheck_Id" });
            DropIndex("dbo.CreditCardDataBreachChecks", new[] { "CreditCard_Id" });
            DropIndex("dbo.DataBreachLines", new[] { "DataBreachCheck_Id" });
            DropTable("dbo.DataBreachCheckAccounts");
            DropTable("dbo.CreditCardDataBreachChecks");
            DropTable("dbo.DataBreachLines");
            CreateIndex("dbo.CreditCards", "DataBreachCheck_Id");
            CreateIndex("dbo.Accounts", "DataBreachCheck_Id");
            AddForeignKey("dbo.Accounts", "DataBreachCheck_Id", "dbo.DataBreachChecks", "Id");
            AddForeignKey("dbo.CreditCards", "DataBreachCheck_Id", "dbo.DataBreachChecks", "Id");
        }
    }
}
