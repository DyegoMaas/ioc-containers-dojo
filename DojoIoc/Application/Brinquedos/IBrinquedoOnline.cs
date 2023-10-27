namespace Application.Brinquedos;

public interface IBrinquedoOnline
{
    public bool Ligado { get; }
    void Ligar();
    void Desligar();
}