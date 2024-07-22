namespace LSPpatron
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"El estudiante {std.Nombre} se ha suscrito al curso en línea {Title} satisfactoriamente.");
        }

        public override string GetCourseDetails()
        {
            return $"Curso en Línea: {Title} (ID: {CourseId})";
        }
    }
}

