namespace Application.Brinquedos;

public class ArenaCarrinhoBateBate : IBrinquedoOnline
{
    public bool Ligado { get; set; }
    
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
        return nameof(ArenaCarrinhoBateBate);
    }
}