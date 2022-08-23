using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interfaces
{
    public interface ICartaoCredito
    {
        string TipoDeCartao();
        int LimiteCredito();
        int Anuidade();
    }
}
