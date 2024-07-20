using Open_Closed_OCP_.Course;
using Open_Closed_OCP_.Students;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student { StudentId = 1, Name = "Angel Miguel de la Rosa" };

        Course onlineCourse = new OnlineCourse { CourseId = 101, Title = "C# Avanzado" };
        Course offlineCourse = new OfflineCourse { CourseId = 102, Title = "Base de datos avanzada" };
        Course hybridCourse = new HybridCourse { CourseId = 103, Title = "Probabilidad y estadistica" };

        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);
    }
}
