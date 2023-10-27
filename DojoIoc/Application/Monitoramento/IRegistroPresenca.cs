namespace Application.Monitoramento;

public interface IRegistroPresenca
{
    public int PessoasNoParque { get; }
    void RegistrarEntrada();
    void RegistrarSaida();
    void Zerar();
}