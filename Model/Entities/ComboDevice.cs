using System;

namespace MultiplasInterfaces.Model.Entities
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string doc)
        {
            Console.WriteLine("ComboDevice, printing: "+doc);
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("ComboDevice processing: "+doc);
        }

        public string Scan()
        {
            return "ComboDevice scanning!!!";
        }
    }
}
