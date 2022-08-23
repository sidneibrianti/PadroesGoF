using FactoryMethod.Interfaces;

namespace FactoryMethod.Domain
{
    public abstract class CartaoCreditoFactory
    {
        protected abstract ICartaoCredito FazerCartaoCredito();
        public ICartaoCredito CriarCartaoCredito()
        {
            return this.FazerCartaoCredito();
        }
    }
}
