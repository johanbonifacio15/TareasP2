namespace LSPpatron
{
    public class HybridCourse : Course
    {
        private readonly OnlineCourse onlineCourse;
        private readonly OfflineCourse offlineCourse;

        public HybridCourse(OnlineCourse onlineCourse, OfflineCourse offlineCourse)
        {
            this.onlineCourse = onlineCourse;
            this.offlineCourse = offlineCourse;
        }
        public override void Subscribe(Student std)
        {
            if (std.Modalidad == ModalidadAsistencia.Online)
            {
                Console.WriteLine($"El estudiante {std.Nombre} se ha suscrito al curso híbrido {Title} en modalidad en línea satisfactoriamente.");
            }
            else if (std.Modalidad == ModalidadAsistencia.Presencial)
            {
                Console.WriteLine($"El estudiante {std.Nombre} se ha suscrito al curso híbrido {Title} en modalidad presencial satisfactoriamente.");
            }
        }

        public override string GetCourseDetails()
        {
            return $"Curso Híbrido: {Title} (ID: {CourseId})";
        }
    }
}

