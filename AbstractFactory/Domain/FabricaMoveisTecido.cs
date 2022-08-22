using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain
{
    public class FabricaMoveisTecido : IFabricaMoveis
    {
        public ICadeira FabricarCadeira()
        {
            return new CadeiraTecido();
        }

        public Isofa FabricarSofa()
        {
            return new SofaTecido();
        }
    }
}
