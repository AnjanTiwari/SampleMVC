using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Difference_betwwen_cookies_and_session.Models
{
    public class User
    {
        [Required(ErrorMessage ="Username required")]
        public string Username { get; set; }
    }
}