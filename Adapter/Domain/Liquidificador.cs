using Adapter.Interfaces;

namespace Adapter.Domain;
public class Liquidificador : TomadaABNT, IAparelho
{
    //Request
    public String On()
    {
        this.Ligado = true;
        return "o liquidificador está ligado";
    }
    //Request
    public String Off()
    {
        this.Ligado = false;
        return "o liquidificador está desligado";
    }
}
