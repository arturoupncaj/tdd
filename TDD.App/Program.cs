// See https://aka.ms/new-console-template for more information


using TDD.App;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Ingresa dato 1");
        var dato = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa dato 2");
        var dato2 = int.Parse(Console.ReadLine());
        
        // algoritmo
        // var resultado = dato + dato2;
        var fun = new Funciones();
        var resultado = fun.Sumar(dato, dato2);
        
        // imprimir resultado
        Console.WriteLine($"El resultado es: {resultado}");
    }
}