using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strongly_typed_Partial_View.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string picture { get; set; }
    }
}