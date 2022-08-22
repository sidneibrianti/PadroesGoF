namespace Adapter.Domain;
public class TomadaABNT   //Adaptee
{
    //SpecificRequest
    private bool ligado;
    public bool Ligado
    {
        get
        {
            return this.ligado;
        }
        set
        {
            this.ligado = value;
            Console.WriteLine(">>> {0}ligando", this.ligado ? "" : "des");
        }
    }
}
