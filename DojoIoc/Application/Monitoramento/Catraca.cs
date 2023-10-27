namespace Application.Monitoramento;

public class Catraca : IEquipamentoEntradaNoParque
{
    private readonly IRegistroPresenca _registroPresenca;
    public int Entradas { get; private set; }

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
    
    public override string ToString()
    {
        return $"Catraca {Id}";
    }
}