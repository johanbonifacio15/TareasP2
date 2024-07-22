﻿namespace LSPpatron
{
    public class Student
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }

        public ModalidadAsistencia Modalidad { get; set; }

        public Student(int id, string nombre, int edad, string correo, ModalidadAsistencia modalidad)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Edad = edad;
            Modalidad = modalidad;
        }
    }
}
