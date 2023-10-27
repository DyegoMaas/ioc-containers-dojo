using Application;
using Application.Brinquedos;
using Application.Monitoramento;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<SistemaParque>();
builder.Services.AddTransient<IBrinquedoOnline, MontanhaRussa>();
builder.Services.AddTransient<IBrinquedoOnline, ArenaCarrinhoBateBate>();
builder.Services.AddSingleton<IRegistroPresenca, RegistroPresenca>();
builder.Services.AddTransient<IEquipamentoEntradaNoParque>(serviceProvider => new Catraca("cachorro", registroPresenca: serviceProvider.GetRequiredService<IRegistroPresenca>()));
builder.Services.AddTransient<IEquipamentoEntradaNoParque>(serviceProvider => new Catraca("yuuko", registroPresenca: serviceProvider.GetRequiredService<IRegistroPresenca>()));
builder.Services.AddTransient<IEquipamentoEntradaNoParque>(serviceProvider => new Catraca("bebeto", registroPresenca: serviceProvider.GetRequiredService<IRegistroPresenca>()));


var app = builder.Build();

var sistemao = app.Services.GetService<SistemaParque>();
var catracas = sistemao.Catracas.ToList();

catracas[0].RegistrarEntrada();
catracas[2].RegistrarSaida();
catracas[1].RegistrarEntrada();

app.MapGet("/", () => "Hello World!");

app.Run();