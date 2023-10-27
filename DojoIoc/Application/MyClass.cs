using Application.Brinquedos;
using Application.Monitoramento;
using System.Collections;

namespace Application;

public class SistemaParque
{
    private readonly IRegistroPresenca _registroPresenca;
    private readonly IEnumerable<IBrinquedoOnline> _briquedos;
    public readonly IEnumerable<IEquipamentoEntradaNoParque> Catracas;

    public SistemaParque(IRegistroPresenca registroPresenca, IEnumerable<IBrinquedoOnline> briquedos, IEnumerable<IEquipamentoEntradaNoParque> catracas)
    {
        _registroPresenca = registroPresenca;
        _briquedos = briquedos;
        Catracas = catracas;
    }

    public void InicializarParque()
    {
        foreach (var brinquedoOnline in _briquedos)
        {
            brinquedoOnline.Ligar();
        }

        _registroPresenca.Zerar();
        
        //foreach (var catraca in _catracas)
        //{
        //    catraca.Zerar();
        //}
    }
    
    public void DesligarParque()
    {
        foreach (var brinquedoOnline in _briquedos)
        {
            brinquedoOnline.Desligar();
        }
    }
}