using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExamELoanApp.Models
{
    public class CustomerLogin
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }



        [Required(ErrorMessage = "password is Required")]
        [DataType(DataType.Password)]
        public string password { get; set; }

    }
}