using AbstractFactory.Domain;
using AbstractFactory.Interfaces;
namespace AbstractFactory;

class Client
{
    public static void Main()
    {
       
        Console.WriteLine("Fabricar de Couro");
        FabricarMoveis(new FabricaMoveisCouro());
        Console.WriteLine();

        Console.WriteLine("Fabricar de Tecido");
        FabricarMoveis(new FabricaMoveisTecido());

        Console.ReadKey();
    }

   
    public static void FabricarMoveis(IFabricaMoveis fabricaMoveis)
    {
        var cadeira = fabricaMoveis.FabricarCadeira();
        var sofa = fabricaMoveis.FabricarSofa();

        Console.WriteLine(cadeira.TipoCadeira());
        Console.WriteLine(sofa.TipoSofa());
    }
}

