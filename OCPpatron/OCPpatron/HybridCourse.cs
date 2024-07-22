namespace OCPpatron
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
            if (std.modalidad == ModalidadAsistencia.Online)
            {
                Console.WriteLine($"El estudiante {std.Nombre} se ha suscrito al curso híbrido {Title} en modalidad en línea satisfactoriamente.");
                Console.WriteLine();
            }
            else if (std.modalidad == ModalidadAsistencia.Presencial)
            {
                Console.WriteLine($"El estudiante {std.Nombre} se ha suscrito al curso híbrido {Title} en modalidad presencial satisfactoriamente.");
                Console.WriteLine();
            }
        }
    }
}
