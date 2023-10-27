using Application.Brinquedos;
using Application.Monitoramento;

namespace Application;

public class SistemaParque
{
    private readonly IRegistroPresenca _registroPresenca;
    private readonly List<IBrinquedoOnline> _briquedos;
    private readonly List<Catraca> _catracas;

    public SistemaParque(IRegistroPresenca registroPresenca, List<IBrinquedoOnline> briquedos, List<Catraca> catracas)
    {
        _registroPresenca = registroPresenca;
        _briquedos = briquedos;
        _catracas = catracas;
    }

    public void InicializarParque()
    {
        foreach (var brinquedoOnline in _briquedos)
        {
            brinquedoOnline.Ligar();
        }

        _registroPresenca.Zerar();
        
        foreach (var catraca in _catracas)
        {
            catraca.Zerar();
        }
    }
    
    public void DesligarParque()
    {
        foreach (var brinquedoOnline in _briquedos)
        {
            brinquedoOnline.Desligar();
        }
    }
}