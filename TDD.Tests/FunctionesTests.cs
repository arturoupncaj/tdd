using TDD.App;

namespace TDD.Tests;

public class FunctionesTests
{
    [Test]
    public void SumarCaso01()
    {
        //Arrange -> Preparar el escenario, datos intancias
        var funciones = new Funciones();
        var dato1 = 10;
        var dato2 = 20;
        //Act
        var resultado = funciones.Sumar(dato1, dato2);
        //Assert
        Assert.AreEqual(30, resultado);
    }

    [Test]
    public void SumarCaso02()
    {
        //Arrange -> Preparar el escenario, datos intancias
        var funciones = new Funciones();
        var dato1 = 15;
        var dato2 = 15;
        //Act
        var resultado = funciones.Sumar(dato1, dato2);
        //Assert
        Assert.AreEqual(30, resultado);
    }

    [Test]
    public void SumarCaso03()
    {
        //Arrange -> Preparar el escenario, datos intancias
        var funciones = new Funciones();
        var dato1 = 6;
        var dato2 = 7;
        //Act
        var resultado = funciones.Sumar(dato1, dato2);
        //Assert
        Assert.AreEqual(13, resultado);
    }

    [Test]
    public void EsPalindromeCaso01()
    {
        var funciones = new Funciones();
        var dato1 = "ana";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsTrue(resultado);
    }

    [Test]
    public void EsPalindromeCaso02()
    {
        var funciones = new Funciones();
        var dato1 = "reconocer";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsTrue(resultado);
    }

    [Test]
    public void EsPalindromeCaso03()
    {
        var funciones = new Funciones();
        var dato1 = "miercoles";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void EsPalindromeCaso04()
    {
        var funciones = new Funciones();
        var dato1 = "Reconocer";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsTrue(resultado);
    }

    [Test]
    public void EsPalindromeCaso05()
    {
        var funciones = new Funciones();
        var dato1 = "Anita lava la tina";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsTrue(resultado);
    }

    [Test]
    public void EsContrasenaSegura_Caso01_Valida()
    {
        var funciones = new Funciones();
        var contrasena = "Clave#2024";
        var resultado = funciones.EsContrasenaSegura(contrasena);
        Assert.True( resultado);
    }
    [Test]
    public void  EsContrasenaSegura_Caso2_Valida()
    {
        var funciones = new Funciones();
        var contrasena = "Clave#2024";
        var resultado = funciones.EsContrasenaSegura(contrasena);
        Assert.True( resultado);
    }
    [Test]
    public void NoEsContrasenaSeguraCaso03_FaltaMayuscula()
    {
        var funciones = new Funciones();
        var dato = "hola@123"; // Falta mayúscula
        var resultado = funciones.EsContrasenaSegura(dato);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void NoEsContrasenaSeguraCaso04_FaltaSimbolo()
    {
        var funciones = new Funciones();
        var dato = "Clave2024"; // Falta símbolo especial
        var resultado = funciones.EsContrasenaSegura(dato);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void NoEsContrasenaSeguraCaso05_ContenidoInvalido()
    {
        var funciones = new Funciones();
        var dato = " jjj¿"; // Espacio y carácter no válido
        var resultado = funciones.EsContrasenaSegura(dato);
        Assert.IsFalse(resultado);
    }
    [Test]
    public void NoEsContrasenaSeguraCaso06()
    {
        var funciones = new Funciones();
        var dato = "Contrasena2024";
        var resultado = funciones.EsContrasenaSegura(dato);
        Assert.IsFalse(resultado);
    }




} 