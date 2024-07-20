using Open_Closed_OCP_.Students;

namespace Open_Closed_OCP_.Course
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            //Codigo para suscribirte a un curso en linea
            Console.WriteLine($"{std.Name} se ha suscrito al curso en linea: {Title}");
        }
    }
}
