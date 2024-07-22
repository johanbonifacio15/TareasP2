namespace OCPpatron
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"El estudiante {std.Nombre} se ha suscrito al curso presencial {Title} satisfactoriamente.");
            Console.WriteLine();
        }
    }
}
