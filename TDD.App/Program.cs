// See https://aka.ms/new-console-template for more information

using TDD.App;

class Program
{
    static async Task Main(string[] args)
    {

        Console.WriteLine("Ingrese el monto que desea cambiar:");
        var monto = Decimal.Parse(Console.ReadLine());

        var casaCambio = new CasaDeCambio(new ExchangeService());
        var total = await casaCambio.EstimarMontoARecibir(monto);

        Console.WriteLine("Su monto a recibir es: " + total);

    }
}