namespace SRPpatron
{
    // CLASE QUE SE ENCARGA DE MANEJAR LOS DATOS DE LAS PERSONAS
    public class Persona
    {
        public string nombre;
        public int edad;
        public string direccion;
        public string correoElectronico;

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }
    }
}
