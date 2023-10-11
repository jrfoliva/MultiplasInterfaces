using MultiplasInterfaces.Model.Entities;
namespace MultiplasInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementando multiplas interfaces");
            ComboDevice cb = new ComboDevice() { SerialNumber = "1234" };
            cb.Print("Teste de impressão!");
            cb.ProcessDoc("Teste de Processamento de documento");
            Console.WriteLine(cb.Scan());

        }
    }
}