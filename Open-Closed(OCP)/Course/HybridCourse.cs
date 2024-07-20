using Open_Closed_OCP_.Students;

namespace Open_Closed_OCP_.Course
{
    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            //Codigo para suscribirte a un curso hibrido
            Console.WriteLine($"{std.Name} se ha suscrito al curso hibrido: {Title}");
        }
    }
}
