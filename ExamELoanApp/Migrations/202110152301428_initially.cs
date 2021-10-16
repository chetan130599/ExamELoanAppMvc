namespace ExamELoanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initially : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerLogins");
        }
    }
}
