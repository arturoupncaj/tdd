// See https://aka.ms/new-console-template for more information

using TDD.App;

class Program
{
    static async Task Main(string[] args)
    {
        var es = new ExchangeService();
        var service = new ExchangeTotalService(es);

        var result = await service.ObtenerMontoARecibir(1000);

        Console.WriteLine("Monto a recibir: " + result);
    }
}