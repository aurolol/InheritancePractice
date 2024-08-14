using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class BaseKisi
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    public class Student : BaseKisi
    {
        public int StudentNumber { get; set; }
        public void StudentInfo()
        {
            Console.WriteLine($"{StudentNumber} numaralı öğrencimizin adı {FirstName} soyadı {LastName}");
        }

    }
    public class Teacher : BaseKisi
    {
        public int Salary { get; set; }
        public void TeacherInfo()
        {
            Console.WriteLine($"Öğretmenimizin adı {FirstName} soyadı {LastName} ve maaşı {Salary}");

        }
    }
}
