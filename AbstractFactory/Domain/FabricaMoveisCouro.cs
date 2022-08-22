using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain
{
    public class FabricaMoveisCouro : IFabricaMoveis
    {
        public ICadeira FabricarCadeira()
        {
            return new CadeiraCouro();
        }

        public Isofa FabricarSofa()
        {
            return new SofaCouro(); ;
        }
    }
}
