namespace Application.Brinquedos;

public class MontanhaRussa : IBrinquedoOnline
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
}