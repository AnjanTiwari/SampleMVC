//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SignUp_and_Login_with_session_and_logout.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    using System.Data.Entity;

    public partial class user
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="FirstName is rquired")]
        [DisplayName("First Name")]
        public string firstName { get; set; }
        [DisplayName("Last Name")]

        [Required(ErrorMessage = "LastName is rquired")]

        public string lastName { get; set; }
        [Required(ErrorMessage = "Gender is rquired")]
        [DisplayName("Gender")]


        public string gender { get; set; }
        [Required(ErrorMessage = "Age is rquired")]
        [DisplayName("Age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Email is rquired")]
        [DisplayName("Email ID")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage ="Inavalid Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Username is rquired")]
        [DisplayName("Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is rquired")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string password { get; set; }


        [Required(ErrorMessage = "Confirm Password is rquired")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("password",ErrorMessage ="password doesn't math with confirm passowrd")]
        public string confirm_password { get; set; }

    }
}
