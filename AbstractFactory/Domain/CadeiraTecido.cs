using AbstractFactory.Interfaces;

namespace AbstractFactory.Domain
{
    public class CadeiraTecido : ICadeira
    {
        public string TipoCadeira()
        {
            return "Cadeira de Tecido";
        }
    }
}
