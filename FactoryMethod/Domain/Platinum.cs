using FactoryMethod.Interfaces;

namespace FactoryMethod.Domain
{
    public class Platinum : ICartaoCredito
    {
        public int Anuidade()
        {
            return 2000;
        }

        public int LimiteCredito()
        {
            return 35000;
        }

        public string TipoDeCartao()
        {
            return "Platinum Plus";
        }
    }
}
