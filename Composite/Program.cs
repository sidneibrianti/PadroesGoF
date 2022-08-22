using Composite.Domain;

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Organizacao organizacao = new Organizacao { Nome = "Quebra Galho Inc." };

            Organizacao departamentoTI = new Organizacao { Nome = " TI " };
            departamentoTI.Add(new Funcionario { Nome = "Maria", Horas = 8 });
            departamentoTI.Add(new Funcionario { Nome = "Miguel", Horas = 9 });
            departamentoTI.Add(new Funcionario { Nome = "Marta", Horas = 10 });

            Organizacao departamentoRH = new Organizacao { Nome = " RH " };
            departamentoRH.Add(new Funcionario { Nome = "Beatriz", Horas = 9 });
            departamentoRH.Add(new Funcionario { Nome = "Amanda", Horas = 10 });

            organizacao.Add(departamentoTI);
            organizacao.Add(departamentoRH);

            organizacao.GetHoraTrabalhada();

            Console.ReadKey();
        }
    }

}