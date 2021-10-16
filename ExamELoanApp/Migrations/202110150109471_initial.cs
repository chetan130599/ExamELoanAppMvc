namespace ExamELoanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstname = c.String(nullable: false),
                        Lastname = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        mobile = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.customers");
        }
    }
}
