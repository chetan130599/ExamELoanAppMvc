using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ExamELoanApp.Models
{
    public class LoansDbcontext :DbContext
    {
        public DbSet<customer> customers { get; set; }
        public DbSet<CustomerLogin> customerLogins { get; set; }

        public DbSet<Manager>managers { get; set; }

        public DbSet<ManagerLogin> managerLogins { get; set; }

        public DbSet<ApplyLoan> ApplyLoans { get; set; }
    }
}