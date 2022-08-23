using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Domain
{
    public class TitaniumFactory : CartaoCreditoFactory
    {
        protected override ICartaoCredito FazerCartaoCredito()
        {
            ICartaoCredito cartaoCredito = new Titanium();
            return cartaoCredito;
        }
    }
}
