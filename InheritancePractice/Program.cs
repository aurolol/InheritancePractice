using InheritancePractice;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.FirstName = "Atakan";
        student.LastName = "Çelik";
        student.StudentNumber = 233;
        student.StudentInfo();
        Teacher teacher = new Teacher();
        teacher.FirstName = "Fatih";
        teacher.LastName = "Özkan";
        teacher.Salary = 45000;
        teacher.TeacherInfo();

    }
}