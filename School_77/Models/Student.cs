using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace School_77.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
    }
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}