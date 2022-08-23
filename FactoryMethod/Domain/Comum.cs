using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Domain
{
    public class Comum : ICartaoCredito
    {
        public int Anuidade()
        {
            return 500;
        }

        public int LimiteCredito()
        {
            return 15000;
        }

        public string TipoDeCartao()
        {
            return "Comum";
        }
    }
}
