namespace ISPpatron
{
    // Interfaz para cumplir con la segregacion de interfaces, evitando que SimplePrinter tenga que heredar el metodo Scan
    public interface IScan
    {
        public void Scan(Document document);
    }
}
