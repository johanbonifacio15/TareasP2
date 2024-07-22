using SRPpatron;
class Program
{
   static void Main(string[] args)
    {
        Persona persona = new Persona("Johan", 20, "Barrio Lindo, Alejandro Arias #35", "johanbonifacio15@outlook.com");

        PrinterPersona printer = new PrinterPersona();

        CorreoElectronicoService correo = new CorreoElectronicoService();

        printer.ImprimirDatos(persona);

        correo.enviarCorreoElectronico(persona.correoElectronico);
    }
}
