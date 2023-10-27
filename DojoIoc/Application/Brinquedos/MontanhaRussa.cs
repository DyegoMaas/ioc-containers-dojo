namespace Application.Brinquedos;

public class MontanhaRussa : IBrinquedoOnline
{
    public bool Ligado { get; private set; }
    
    public void Ligar()
    {
        Ligado = true;
    }

    public void Desligar()
    {
        Ligado = false;
    }
    
    public override string ToString()
    {
        return nameof(MontanhaRussa);
    }
}