﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traditional_Routing.Models
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string  Class { get; set; }

        public Address Address { get; set; }
    }
}