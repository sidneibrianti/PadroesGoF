using FactoryMethod.Interfaces;

namespace FactoryMethod.Domain
{
    public class Titanium : ICartaoCredito
    {
        public int Anuidade()
        {
            return 1500;
        }

        public int LimiteCredito()
        {
            return 25000;
        }

        public string TipoDeCartao()
        {
            return "Titanium Edge";
        }
    }
}
