using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Required.Models
{
    public class Employee
    {
        [DisplayName("Employee ID")] //this requires namspace System.componenet model
        [Required]//this will put default mesage 
        public int id { get; set; }




        [Required(ErrorMessage ="Username is mandatory")] //this will put custom message in ""
        [StringLength(20,MinimumLength =5)] //this will put default mesage but this 
        public string Username { get; set; }




        [DisplayName("Employee Age")] //to display custom Names in form
        [Range(18,60,ErrorMessage ="Age should be between 18 to 60")] //It check for numeric range  
        public int? Age { get; set; } ///We are making it nullable beacuse in MVC all integers by deefault 
        //set to be required




        [StringLength(20, MinimumLength = 5,ErrorMessage ="minimum 5 and maximum 10 char is required")]//
        public string Gender { get; set; }




        [Required(ErrorMessage ="Email ID is mandatory")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",ErrorMessage ="Invalid Email ID")]
        public string Email { get; set; }




        [Required(ErrorMessage ="Password is mandatory")]
        [RegularExpression("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$",ErrorMessage = "Password must be between 8 and 15 characters long with at least one number,one uppercase letter,one lowercase letter.")]
        public string Password { get; set; }





        [Required(ErrorMessage ="Please confirm the password")]
        [Compare("Password",ErrorMessage ="Confirm password is not identical")]
        public string ConfirmPassword { get; set; }





        [DisplayName("Organization")]
        [ReadOnly(true)] //this will show a deffault value in text box
        public string OrganizationName { get; set; }





        //Now DataType data annotation where we use Editor for and it has its own way 
        //of including bootstrap clasess
        [DisplayName("Address")]
        [Required(ErrorMessage ="Address is mandatory")]
        [DataType(DataType.MultilineText)]//DataType annotation used to provide information about specific purpose of a property at run time
        public string EmpAddress { get; set; }




        [DisplayName("Joining Date")] //this requires namspace System.componenet model
        [Required(ErrorMessage ="Its a mandatory field")]
        [DataType(DataType.Date)] //DataType annotation used to provide information about specific purpose of a property at run time
        public string EmpJoiningDate { get; set; }




        [DisplayName("Joining Time")] //this requires namspace System.componenet model
        [Required(ErrorMessage = "Its a mandatory field")]
        [DataType(DataType.Time)] //DataType annotation used to provide information about specific purpose of a property at run time
        public string EmpJoiningTime { get; set; }
    }
}