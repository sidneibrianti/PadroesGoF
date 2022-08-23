using Observer.Interfaces;

namespace Observer.Domain
{
   
    public class Investidor : IInvestidor
    {
        private string _nome;
        private Acao? _acao;
        // Constructor
        public Investidor(string nome)
        {
            _nome = nome;
        }
        public void Update(Acao acao)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", _nome, acao.Simbolo, acao.Preco);
        }
        // Gets or sets the stock
        public Acao? Acao
        {
            get { return _acao; }
            set { _acao = value; }
        }
    }
}
