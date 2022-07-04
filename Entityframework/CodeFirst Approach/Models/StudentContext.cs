using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Data.Entity;

namespace CodeFirst_Approach.Models
{
    public class StudentContext : DbContext //need System.Data.Entity;
    {
        public DbSet<Student> Students { get; set; } //after this you will make connection string

    }
}