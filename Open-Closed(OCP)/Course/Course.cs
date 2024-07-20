using Open_Closed_OCP_.Students;

namespace Open_Closed_OCP_.Course
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public abstract void Subscribe(Student std);
    }
}
