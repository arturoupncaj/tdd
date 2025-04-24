// See https://aka.ms/new-console-template for more information


using TDD.App;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Ingresa texto");
        var text = Console.ReadLine();
        
        // imprimir resultado
        var f = new Funciones();
        var resultado = f.EsPalindrome(text);
        if (resultado)
        {
            Console.WriteLine($"Su palabra '{text}' es palindrome");
        }
        else
        {
            Console.WriteLine($"Su palabra '{text}' no es palindrome");
        }
    }
}