namespace TDD.App;

public class Funciones
{
    public int Sumar(int dato1, int dato2)
    {
        return dato1 + dato2;
    }

    public bool EsPalindrome(string text)
    {
        var reverse = new string(text.Reverse().ToArray());
        text = text.Replace(" ", "");
        reverse = reverse.Replace(" ", "");
        return reverse.ToLower().Equals(text.ToLower());
    }
    public int ObtenerNumeroMayor(List<int> numeros)
    {
        if (numeros == null || numeros.Count == 0)
        {
            throw new InvalidOperationException("La lista está vacía.");
        }

        int mayor = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }
        }
        return mayor;
    }
}