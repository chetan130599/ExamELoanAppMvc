namespace ExamELoanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialapplyloan2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplyLoans", "status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplyLoans", "status");
        }
    }
}
