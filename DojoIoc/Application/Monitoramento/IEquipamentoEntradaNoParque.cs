namespace Application.Monitoramento;

public interface IEquipamentoEntradaNoParque
{
    int Entradas { get; }
    void RegistrarEntrada();
    void RegistrarSaida();
    void Zerar();
}