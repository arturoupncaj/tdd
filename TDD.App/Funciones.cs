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
    public int EncontrarMayor(int[] numeros)
    {
        if (numeros == null || numeros.Length == 0)
        {
            throw new ArgumentException("El arreglo no puede ser nulo o vac�o");
        }

        int mayor = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
        }
        return mayor;
    }

}