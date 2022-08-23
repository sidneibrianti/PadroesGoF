using FactoryMethod.Interfaces;

namespace FactoryMethod.Domain
{
    public class ComumFactory : CartaoCreditoFactory
    {
        protected override ICartaoCredito FazerCartaoCredito()
        {
            ICartaoCredito cartaoCredito = new Comum();
            return cartaoCredito;
        }
    }
}
