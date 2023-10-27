var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureServices(serviceCollection =>
{
    serviceCollection.AddSingleton<IMyInterface>(new MyClass());
});

var app = builder.Build();

app.Services.GetService<IMyInterface>();

app.MapGet("/", () => "Hello World!");

app.Run();

public interface IMyInterface
{
}

class MyClass : IMyInterface
{
}