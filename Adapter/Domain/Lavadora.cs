using Adapter.Interfaces;

namespace Adapter.Domain
{
    public class Lavadora : TomadaABNT, IAparelho
    {
        //Request
        public string On()
        {
            Ligado = true;
            Console.WriteLine("a lavadora está lavando roupas");
            Lavar();
            Centrifugar();
            Enxaguar();
            Centrifugar();
            Enxaguar();
            Centrifugar();
            return Off();
        }
        //Request
        public string Off()
        {
            Ligado = false;
            return "agora a lavadora está desligada";
        }
        public static void Lavar()
        {
            Console.WriteLine("\tadicionando água e sabão em pó...");
            Thread.Sleep(2000);
            Console.WriteLine("\tlavando...");
        }
        private static void Enxaguar()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\tenxaguando...");
        }
        private static void Centrifugar()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\tcentrifugando...");
        }
    }
}