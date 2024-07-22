namespace LSPpatron
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public abstract void Subscribe(Student std);
        public abstract string GetCourseDetails();
    }
}

