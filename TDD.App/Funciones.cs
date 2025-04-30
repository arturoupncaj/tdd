using System.Text.RegularExpressions;
using System.Text;

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
    public bool EsContrasenaSegura(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto)) return false;

        bool tieneMayuscula = texto.Any(char.IsUpper);
        bool tieneMinuscula = texto.Any(char.IsLower);
        bool tieneNumero = texto.Any(char.IsDigit);
        bool tieneSimbolo = Regex.IsMatch(texto, @"[\W_]"); // símbolo o carácter especial
        bool longitudValida = texto.Length >= 8;

        return tieneMayuscula && tieneMinuscula && tieneNumero && tieneSimbolo && longitudValida;
    }
}