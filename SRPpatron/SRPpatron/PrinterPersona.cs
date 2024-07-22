namespace SRPpatron
{
    // CLASE QUE SE ENCARGA DE IMPRIMIR LOS DATOS DE LAS PERSONAS
    public class PrinterPersona
    {
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.nombre}");
            Console.WriteLine($"Edad: {persona.edad}");
            Console.WriteLine($"Direccion: {persona.direccion}");
            Console.WriteLine($"Correo electrónico: {persona.correoElectronico}");
        }
    }
}
