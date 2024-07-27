namespace ISPpatron
{
    public class Document
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Document(string name, string description)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "El nombre del documento no puede ser nulo.");
            Description = description;
        }
    }
}
