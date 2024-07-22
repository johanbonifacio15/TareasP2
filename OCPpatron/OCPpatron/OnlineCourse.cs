namespace OCPpatron
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"El estudiante {std.Nombre} se ha suscrito al curso en linea {Title} satisfactoriamente.");
            Console.WriteLine();
        }
    }
}
