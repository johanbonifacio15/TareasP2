namespace ISPpatron
{

    // Clase base para manejar las validaciones y mostrar en pantalla la informacion del documento
    public abstract class PrinterBase
    {
        protected void ValidateDocument(Document document)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document), "El documento no puede ser nulo.");

            if (string.IsNullOrEmpty(document.Name))
                throw new ArgumentException("El nombre del documento no puede ser nulo o vacío.", nameof(document.Name));
        }

        protected void PrintDocumentInfo(string action, Document document)
        {
            Console.WriteLine($"{action} documento: {document.Name}");
            Thread.Sleep(200);
            Console.WriteLine($"El proceso se completó satisfactoriamente. Nombre: {document.Name}, Descripción: {document.Description}");
        }
    }
}
