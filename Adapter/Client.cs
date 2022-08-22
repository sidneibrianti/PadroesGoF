using Adapter.Domain;
using Adapter.Interfaces;

class Client
    {
        public static void Main()
        {
            IAparelho a = new Liquidificador();
            Console.WriteLine(a.On());
            Console.WriteLine(a.Off());
            Console.WriteLine();

            a= new Lavadora();
            Console.WriteLine(a.On());
            Console.ReadKey();
        }
}




