using System.Threading.Tasks;

namespace ISPpatron
{
    public class SimplePrinter : PrinterBase, IPrint
    {
        public void Print(Document document)
        {
            ValidateDocument(document);
            PrintDocumentInfo("Imprimiendo", document);
        }
    }
}
