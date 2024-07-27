
namespace ISPpatron
{
    public class MultiFunctionPrinter : PrinterBase, IPrint, IScan
    {
        public void Print(Document document)
        {
            ValidateDocument(document);
            PrintDocumentInfo("Imprimiendo", document);
        }

        public void Scan(Document document)
        {
            ValidateDocument(document);
            PrintDocumentInfo("Escaneando", document);
        }
    }
}
