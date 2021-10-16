using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamELoanApp.Models
{
    public class @enum
    {
        public enum Buisnessstatus
        {
            Individual=1,
            Organisation=2
        }
        public enum Billingstatus
        {
            Salaried_Person=1,
            Not_Salaried_person=2
        }
        public enum Taxstatus
        {
            Tax_Payer=1, 
            Not_Tax_Payer=2
        }
        public enum Loanstatus
        {
            Notreceived=1,
                Received=2,
                Accept=3,
                Reject=4,
                Done=5
        }


    }

}