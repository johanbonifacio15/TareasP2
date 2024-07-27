namespace ISPpatron
{
    class Program
    {
        static void Main(string[] args)
        {
            Document prnt = new Document("Prueba de impresion", "Esta es la descripcion de la prueba de impresion.");
            Document scn = new Document("Prueba de scaneo", "Descripcion de la prueba de scaneo.");

            IPrint impresoraSimple = new SimplePrinter();
            impresoraSimple.Print(prnt);

            IPrint impresoraMultiFuncionalPrint = new MultiFunctionPrinter();
            IScan impresoraMultiFuncionalScan = new MultiFunctionPrinter();

            impresoraMultiFuncionalPrint.Print(prnt);
            impresoraMultiFuncionalScan.Scan(scn);
        }
    }
}

