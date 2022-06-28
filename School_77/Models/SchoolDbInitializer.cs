using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace School_77.Models
{
    public class SchoolDbInitializer : DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext db)
        {
            db.Students.Add(new Student { Name = "Мельникова Ксения Витальевна", ClassName = "3Б"});
            db.Students.Add(new Student { Name = "Пименов Максим Евгеньевич", ClassName = "1А" });
            db.Students.Add(new Student { Name = "Бирт Елизавета Александровна", ClassName = "2В" });

            base.Seed(db);
        }
    }
}