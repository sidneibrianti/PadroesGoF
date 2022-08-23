using Observer.Interfaces;

namespace Observer.Domain
{
    public abstract class Acao
    {
        private string? _simbolo;
        private double _preco;
        private List<IInvestidor> investidores = new List<IInvestidor>();

        public Acao(string simbolo, double preco)
        {
            _simbolo = simbolo;
            _preco = preco;
        }
        public void Attach(IInvestidor investidor)
        {
            investidores.Add(investidor);
        }
        public void Detach(IInvestidor investidor)
        {
            investidores.Remove(investidor);
        }
        public void Notify()
        {
            foreach (IInvestidor investidor in investidores)
            {
                investidor.Update(this);
            }
            Console.WriteLine("");
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (_preco != value)
                {
                    _preco = value;
                    Notify();
                }
            }
        }

        public string? Simbolo
        {
            get { return _simbolo; }
        }
    }

}
