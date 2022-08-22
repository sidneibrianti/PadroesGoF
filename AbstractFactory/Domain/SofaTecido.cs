using AbstractFactory.Interfaces;

namespace AbstractFactory.Domain
{
    public class SofaTecido : Isofa
    {
        public string TipoSofa()
        {
            return "Sofá de Tecido";
        }
    }
}
