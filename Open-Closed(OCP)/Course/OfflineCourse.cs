using Open_Closed_OCP_.Students;

namespace Open_Closed_OCP_.Course
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            //Codigo para suscribirte a un curso fuera de linea
            Console.WriteLine($"{std.Name} se ha suscrito al curso fuera de linea: {Title}");
        }
    }
}
