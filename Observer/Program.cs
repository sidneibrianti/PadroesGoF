using System;
using System.Collections.Generic;
using System.Linq;
using Observer.Domain;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investidor("Sorros"));
            ibm.Attach(new Investidor("Berkshire"));
            // Fluctuating prices will notify investors
            ibm.Preco = 120.10;
            ibm.Preco = 121.00;
            ibm.Preco = 120.50;
            ibm.Preco = 120.75;
            // Wait for user
            Console.ReadKey();
        }
    }
}