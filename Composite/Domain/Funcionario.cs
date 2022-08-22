namespace Composite.Domain
{
    public class Funcionario : HoraTrabalhada
    {
        public int Horas { get; set; }
        public override int GetHoraTrabalhada()
        {
            //logica
            System.Console.WriteLine($"O funcionário {Nome} registrou {Horas} trabalhadas");
            return Horas;
        }
    }
}
