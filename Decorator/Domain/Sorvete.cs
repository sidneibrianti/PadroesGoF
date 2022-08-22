using Decorator.Interfaces;

namespace Decorator.Domain
{
    //Component
    public sealed class Sorvete : ISorvete
    {
        //State
        public double Preco
        {
            get
            {
                return 1.50;
            }
        }
    }
}
