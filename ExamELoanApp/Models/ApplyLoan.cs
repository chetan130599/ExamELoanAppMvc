using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExamELoanApp.Models
{
    public class ApplyLoan
    {
        [Key]
        public int ApplyLoanId { get; set; }


        [MaxLength(100, ErrorMessage = "name cant be greater than 100")]
        [MinLength(3, ErrorMessage = "minimum length must be 3")]

        [Required(ErrorMessage = "Loanname is Required")]

        public string Loanname { get; set; }


        [Required(ErrorMessage = "Amount is Required")]//validations for form.

        public int Amount { get; set; }





        [Required(ErrorMessage = "Date is Required")]

        public DateTime Date { get; set; }


        [Required(ErrorMessage = " BuisnessStatus is Required")]
        public @enum.Buisnessstatus BuisnessStatus { get; set; }


        [Required(ErrorMessage = "Billingstatus is Required")]
      
        public @enum.Billingstatus Billingstatus { get; set; }



        [Required(ErrorMessage = "Taxstatus is Required")]
        public @enum.Taxstatus Taxstatus { get; set; }


        [Required(ErrorMessage = "Loanstatus is Required")]
        public @enum.Loanstatus Loanstatus { get; set; }





    }
    
}