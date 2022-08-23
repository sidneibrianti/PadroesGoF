using FactoryMethod.Interfaces;

namespace FactoryMethod.Domain
{
    public class Cliente
    {
        public void Main()
        {
            ICartaoCredito cartaoCredito = new PlatinumFactory().CriarCartaoCredito();
            if (cartaoCredito != null)
            {
                Console.WriteLine($"Tipo: {cartaoCredito.TipoDeCartao()}");
                Console.WriteLine($"Limite de Crédito: {cartaoCredito.LimiteCredito()}");
                Console.WriteLine($"Tipo: {cartaoCredito.Anuidade()}");

            }
            else
            {
                Console.Write("Cartão Inválido!");
            }
            Console.WriteLine("---------------");

            cartaoCredito = new TitaniumFactory().CriarCartaoCredito();

            if (cartaoCredito != null)
            {
                Console.WriteLine($"Tipo: {cartaoCredito.TipoDeCartao()}");
                Console.WriteLine($"Limite de Crédito: {cartaoCredito.LimiteCredito()}");
                Console.WriteLine($"Tipo: {cartaoCredito.Anuidade()}");

            }
            else
            {
                Console.Write("Cartão Inválido!");
            }
            Console.WriteLine("---------------");
            cartaoCredito = new ComumFactory().CriarCartaoCredito();

            if (cartaoCredito != null)
            {
                Console.WriteLine($"Tipo: {cartaoCredito.TipoDeCartao()}");
                Console.WriteLine($"Limite de Crédito: {cartaoCredito.LimiteCredito()}");
                Console.WriteLine($"Tipo: {cartaoCredito.Anuidade()}");

            }
            else
            {
                Console.Write("Cartão Inválido!");
            }




            Console.ReadKey();
        }


        
    }
}
