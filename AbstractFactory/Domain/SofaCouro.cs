using AbstractFactory.Interfaces;

namespace AbstractFactory.Domain
{
    public class SofaCouro : Isofa
    {
        public string TipoSofa()
        {
            return "Sofá de Couro";
        }
    }
}
