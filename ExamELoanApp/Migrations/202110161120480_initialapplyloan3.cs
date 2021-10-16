namespace ExamELoanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialapplyloan3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplyLoans", "BuisnessStatus", c => c.Int(nullable: false));
            AddColumn("dbo.ApplyLoans", "Billingstatus", c => c.Int(nullable: false));
            AddColumn("dbo.ApplyLoans", "Taxstatus", c => c.Int(nullable: false));
            AddColumn("dbo.ApplyLoans", "Loanstatus", c => c.Int(nullable: false));
            AlterColumn("dbo.ApplyLoans", "Loanname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.customers", "firstname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.customers", "Lastname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Managers", "firstname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Managers", "Lastname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Managers", "mobile", c => c.String(nullable: false, maxLength: 12));
            DropColumn("dbo.ApplyLoans", "BuisnessStructure");
            DropColumn("dbo.ApplyLoans", "BillingIndicator");
            DropColumn("dbo.ApplyLoans", "TaxIndicator");
            DropColumn("dbo.ApplyLoans", "status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApplyLoans", "status", c => c.Int(nullable: false));
            AddColumn("dbo.ApplyLoans", "TaxIndicator", c => c.Int(nullable: false));
            AddColumn("dbo.ApplyLoans", "BillingIndicator", c => c.Int(nullable: false));
            AddColumn("dbo.ApplyLoans", "BuisnessStructure", c => c.Int(nullable: false));
            AlterColumn("dbo.Managers", "mobile", c => c.String(nullable: false));
            AlterColumn("dbo.Managers", "Lastname", c => c.String(nullable: false));
            AlterColumn("dbo.Managers", "firstname", c => c.String(nullable: false));
            AlterColumn("dbo.customers", "Lastname", c => c.String(nullable: false));
            AlterColumn("dbo.customers", "firstname", c => c.String(nullable: false));
            AlterColumn("dbo.ApplyLoans", "Loanname", c => c.String(nullable: false));
            DropColumn("dbo.ApplyLoans", "Loanstatus");
            DropColumn("dbo.ApplyLoans", "Taxstatus");
            DropColumn("dbo.ApplyLoans", "Billingstatus");
            DropColumn("dbo.ApplyLoans", "BuisnessStatus");
        }
    }
}
