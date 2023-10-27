namespace Application.Monitoramento;

public class RegistroPresenca : IRegistroPresenca
{
    public int PessoasNoParque { get; private set; }
    
    public void RegistrarEntrada()
    {
        PessoasNoParque++;
    }

    public void RegistrarSaida()
    {
        PessoasNoParque--;
    }

    public void Zerar()
    {
        PessoasNoParque = 0;
    }
}