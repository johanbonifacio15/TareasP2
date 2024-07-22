namespace OCPpatron
{
    public class Student
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }

        public ModalidadAsistencia modalidad {  get; set; }

        public Student (int Id, string Nombre, int Edad, string Correo, ModalidadAsistencia modalidad)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Correo = Correo;
            this.Edad = Edad;
            this.modalidad = modalidad;
        }
    }
}
