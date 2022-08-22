using Decorator.Domain;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sorvete s = new Sorvete();


            Console.WriteLine("Sorvete:");
            Console.WriteLine("{0:c}", s.Preco);


            Console.WriteLine();


            SorveteComCobertura c;
            c = new SorveteComCobertura(s);


            Console.WriteLine("Sorvete com cobertura:");
            Console.WriteLine("{0:c}", c.Preco);


            Console.WriteLine();


            SorveteComBalinha b;
            b = new SorveteComBalinha(s);

            Console.WriteLine("Sorvete com balinha:");
            Console.WriteLine("{0:c}", b.Preco);


            Console.WriteLine();


            SorveteComCobertura cb;
            cb = new SorveteComCobertura(b);


            Console.WriteLine("Sorvete com cobertura E balinha:");
            Console.WriteLine("{0:c}", cb.Preco);


            Console.ReadKey();
        }
    }
}
