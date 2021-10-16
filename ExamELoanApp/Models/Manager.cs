using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExamELoanApp.Models
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }//colomns in database.

        [Required(ErrorMessage = "firstname is Required")]//validations for form.
        [MaxLength(100, ErrorMessage = "name cant be greater than 100")]
        [MinLength(3, ErrorMessage = "minimum length must be 3")]


        public string firstname { get; set; }

        [Required(ErrorMessage = "Lastname is Required")]
        [MaxLength(100, ErrorMessage = "name cant be greater than 100")]
        [MinLength(3, ErrorMessage = "minimum length must be 3")]


        public string Lastname { get; set; }

        [Required(ErrorMessage = "location is Required")]
        public string Location { get; set; }

        [MaxLength(12, ErrorMessage = "mobile number cant be greater than 12")]
        [MinLength(10, ErrorMessage = "minimum length must be 10")]


        [Required(ErrorMessage = "mobile is Required")]
        [DataType(DataType.PhoneNumber)]
        public string mobile { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }



        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }



        [Required(ErrorMessage = "password is Required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}