using Application;
using Application.Brinquedos;
using Application.Monitoramento;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IBrinquedoOnline, ArenaCarrinhoBateBate>();
builder.Services.AddTransient<IBrinquedoOnline, MontanhaRussa>();
builder.Services.AddTransient<IRegistroPresenca, RegistroPresenca>();
builder.Services.AddTransient<IEquipamentoEntradaNoParque, Catraca>();
builder.Services.AddTransient<IEquipamentoEntradaNoParque, Catraca>();
builder.Services.AddTransient<SistemaParque>();

var app = builder.Build();

app.MapPost("/ligar-parque", () =>
{
    return "Hello World!";
});

app.Run();