namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataBreachesMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataBreachChecks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Accounts", "DataBreachCheck_Id", c => c.Int());
            AddColumn("dbo.CreditCards", "DataBreachCheck_Id", c => c.Int());
            CreateIndex("dbo.Accounts", "DataBreachCheck_Id");
            CreateIndex("dbo.CreditCards", "DataBreachCheck_Id");
            AddForeignKey("dbo.CreditCards", "DataBreachCheck_Id", "dbo.DataBreachChecks", "Id");
            AddForeignKey("dbo.Accounts", "DataBreachCheck_Id", "dbo.DataBreachChecks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "DataBreachCheck_Id", "dbo.DataBreachChecks");
            DropForeignKey("dbo.CreditCards", "DataBreachCheck_Id", "dbo.DataBreachChecks");
            DropIndex("dbo.CreditCards", new[] { "DataBreachCheck_Id" });
            DropIndex("dbo.Accounts", new[] { "DataBreachCheck_Id" });
            DropColumn("dbo.CreditCards", "DataBreachCheck_Id");
            DropColumn("dbo.Accounts", "DataBreachCheck_Id");
            DropTable("dbo.DataBreachChecks");
        }
    }
}
