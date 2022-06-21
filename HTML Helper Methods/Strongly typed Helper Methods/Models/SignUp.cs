using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strongly_typed_Helper_Methods.Models
{
    public class SignUp
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
    }
}