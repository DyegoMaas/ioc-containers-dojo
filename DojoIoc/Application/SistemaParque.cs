using Application.Brinquedos;
using Application.Monitoramento;
using System.Collections;
using System.Text;

namespace Application;

public class SistemaParque
{
    private readonly IRegistroPresenca _registroPresenca;
    private readonly IList<IBrinquedoOnline> _briquedos;
    public IList<IEquipamentoEntradaNoParque> EquipamentosControleEntrada { get; }

    public SistemaParque(IRegistroPresenca registroPresenca, IEnumerable<IBrinquedoOnline> briquedos, IEnumerable<IEquipamentoEntradaNoParque> equipamentosControleEntrada)
    {
        _registroPresenca = registroPresenca;
        _briquedos = briquedos.ToArray();
        EquipamentosControleEntrada = equipamentosControleEntrada.ToArray();
    }

    public void InicializarParque()
    {
        foreach (var brinquedoOnline in _briquedos)
        {
            brinquedoOnline.Ligar();
        }

        _registroPresenca.Zerar();
        
        foreach (var equipamento in EquipamentosControleEntrada)
        {
            equipamento.Zerar();
        }
    }
    
    public void DesligarParque()
    {
        foreach (var brinquedoOnline in _briquedos)
        {
            brinquedoOnline.Desligar();
        }
    }

    public string GerarDiagnostico()
    {
        StringBuilder builder = new();
        builder.AppendLine("---Diagnóstico do parque---");
        
        builder.AppendLine("Brinquedos:");
        foreach (var brinquedo in _briquedos)
        {
            builder.AppendLine($"- {brinquedo}: {brinquedo.Ligado}");
        }
        
        builder.AppendLine($"Pessoas no parque (registro geral) = {_registroPresenca.PessoasNoParque}");
        foreach (var equipamentoEntradaNoParque in EquipamentosControleEntrada)
        {
            builder.AppendLine($"- {equipamentoEntradaNoParque}: {equipamentoEntradaNoParque.Entradas}");
        }

        return builder.ToString();
    }
}