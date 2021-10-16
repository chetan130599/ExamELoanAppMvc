namespace ExamELoanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialapplyloan1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ApplyLoans", "BuisnessStructure", c => c.Int(nullable: false));
            AlterColumn("dbo.ApplyLoans", "BillingIndicator", c => c.Int(nullable: false));
            AlterColumn("dbo.ApplyLoans", "TaxIndicator", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ApplyLoans", "TaxIndicator", c => c.String(nullable: false));
            AlterColumn("dbo.ApplyLoans", "BillingIndicator", c => c.String(nullable: false));
            AlterColumn("dbo.ApplyLoans", "BuisnessStructure", c => c.String(nullable: false));
        }
    }
}
