using Decorator.Interfaces;

namespace Decorator.Domain
{
    public class SorveteComBalinha : ISorvete //Decorator
    {
        //Component : IComponent
        ISorvete s;


        public SorveteComBalinha(ISorvete s)
        {
            this.s = s;
        }


        //State
        public double Preco
        {
            get
            {
                return s.Preco + 0.75;
            }
        }
    }
}
