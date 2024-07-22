namespace SRPpatron
{
    // CLASE QUE SE ENCARGARA DEL ENVIO DE CORREO ELECTRONICO
    public class CorreoElectronicoService
    {
        public void enviarCorreoElectronico(string correoElectronico) 
        {

            Console.WriteLine("Escriba el correo a enviar:");
            string mensaje = Console.ReadLine()!;
            Console.WriteLine($"El correo electronico con el destinatario: {correoElectronico} ha sido enviado.");
            Console.WriteLine($"Mensaje: {mensaje}");
        }
    }
}
