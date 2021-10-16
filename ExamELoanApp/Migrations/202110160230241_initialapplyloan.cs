namespace ExamELoanApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialapplyloan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplyLoans",
                c => new
                    {
                        ApplyLoanId = c.Int(nullable: false, identity: true),
                        Loanname = c.String(nullable: false),
                        Amount = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        BuisnessStructure = c.String(nullable: false),
                        BillingIndicator = c.String(nullable: false),
                        TaxIndicator = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ApplyLoanId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApplyLoans");
        }
    }
}
