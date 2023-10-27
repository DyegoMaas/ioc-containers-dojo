namespace Application.Monitoramento;

public class Catraca : IEquipamentoEntradaNoParque
{
    private readonly IRegistroPresenca _registroPresenca;
    private int Entradas = 0;

    public Catraca(string id, IRegistroPresenca registroPresenca)
    {
        Id = id;
        _registroPresenca = registroPresenca;
    }

    public string Id { get; }
    
    public void RegistrarEntrada()
    {
        _registroPresenca.RegistrarEntrada();
        Entradas++;
    }

    public void RegistrarSaida()
    {
        _registroPresenca.RegistrarSaida();
        Entradas--;
    }

    public void Zerar()
    {
        Entradas = 0;
    }
}