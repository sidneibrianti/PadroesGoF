using Decorator.Interfaces;

namespace Decorator.Domain
{
    public class SorveteComCobertura : ISorvete //Decorator
    {
        //Component : IComponent
        ISorvete s;


        public SorveteComCobertura(ISorvete s)
        {
            this.s = s;
        }


        //State
        public double Preco
        {
            get
            {
                return s.Preco + 0.50;
            }
        }
    }
}
