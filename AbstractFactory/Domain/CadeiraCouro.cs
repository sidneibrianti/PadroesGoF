using AbstractFactory.Interfaces;

namespace AbstractFactory.Domain
{
    public class CadeiraCouro : ICadeira
    {
        public string TipoCadeira()
        {
            return "Cadeira de Couro";
        }
    }
}
