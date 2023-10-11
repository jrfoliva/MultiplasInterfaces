namespace MultiplasInterfaces.Model.Entities
{
    internal abstract class Device
    {
        public string SerialNumber { get; set; }
        public abstract void ProcessDoc(string doc);
    }
}
