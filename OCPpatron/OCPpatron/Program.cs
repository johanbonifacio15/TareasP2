using OCPpatron;

class Program
{
    static void Main(string[] args)
    {
        #region Cursos
        Course onlineCourse = new OnlineCourse
        {
            CourseId = 1,
            Title = "Curso de TypeScript Avanzado"
        };

        Course offlineCourse = new OfflineCourse
        {
            CourseId = 2,
            Title = "Curso de Matemáticas Discretas"
        };

        Course hybridCourse = new HybridCourse((OnlineCourse)onlineCourse, (OfflineCourse)offlineCourse)
        {
            CourseId = 3,
            Title = "Curso de Ciencia de Datos"
        };
        #endregion


        #region Estudiantes
        Student std1 = new Student(402, "Johan Bonifacio", 20, "johanbonifacio15@outlook.com", ModalidadAsistencia.Online);
        Student std2 = new Student(1507, "Edward Solano", 18, "esolano03@gmail.com", ModalidadAsistencia.Presencial);
        #endregion

        #region Suscripciones
        onlineCourse.Subscribe(std1);
        offlineCourse.Subscribe(std2);
        hybridCourse.Subscribe(std1);
        hybridCourse.Subscribe(std2);
        #endregion
    }
}
