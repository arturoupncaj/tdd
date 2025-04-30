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
    public void EncontrarMayor_Caso01_ArregloPositivos()
    {
        // Arrange
        var funciones = new Funciones();
        var numeros = new int[] { 12, 45, 23, 67, 34, 89, 15 };

        // Act
        var resultado = funciones.EncontrarMayor(numeros);

        // Assert
        Assert.AreEqual(89, resultado);
    }

    [Test]
    public void EncontrarMayor_Caso02_ArregloNegativos()
    {
        // Arrange
        var funciones = new Funciones();
        var numeros = new int[] { -12, -45, -23, -67, -34, -89, -15 };

        // Act
        var resultado = funciones.EncontrarMayor(numeros);

        // Assert
        Assert.AreEqual(-12, resultado);
    }

    [Test]
    public void EncontrarMayor_Caso03_ArregloMezclado()
    {
        // Arrange
        var funciones = new Funciones();
        var numeros = new int[] { -5, 0, 12, -8, 7, 3 };

        // Act
        var resultado = funciones.EncontrarMayor(numeros);

        // Assert
        Assert.AreEqual(12, resultado);
    }

    [Test]
    public void EncontrarMayor_Caso04_ArregloUnElemento()
    {
        // Arrange
        var funciones = new Funciones();
        var numeros = new int[] { 42 };

        // Act
        var resultado = funciones.EncontrarMayor(numeros);

        // Assert
        Assert.AreEqual(42, resultado);
    }

    [Test]
    public void EncontrarMayor_Caso05_ArregloVacio()
    {
        // Arrange
        var funciones = new Funciones();
        var numeros = new int[] { };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => funciones.EncontrarMayor(numeros));
    }

    [Test]
    public void EncontrarMayor_Caso06_ArregloNull()
    {
        // Arrange
        var funciones = new Funciones();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => funciones.EncontrarMayor(null));
    }
        public void EsContrasenaSegura_Caso01_Valida()
    {
        var funciones = new Funciones();
        var contrasena = "Abcd1234!";
        var resultado = funciones.EsContrasenaSegura(contrasena);
        Assert.IsTrue(resultado);
    }

    [Test]
    public void EsContrasenaSegura_Caso02_FaltaMayuscula()
    {
        var funciones = new Funciones();
        var contrasena = "abcd1234!";
        var resultado = funciones.EsContrasenaSegura(contrasena);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void EsContrasenaSegura_Caso03_FaltaSimbolo()
    {
        var funciones = new Funciones();
        var contrasena = "Abcd1234";
        var resultado = funciones.EsContrasenaSegura(contrasena);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void EsContrasenaSegura_Caso04_MenosDe8Caracteres()
    {
        var funciones = new Funciones();
        var contrasena = "A1!";
        var resultado = funciones.EsContrasenaSegura(contrasena);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void EsContrasenaSegura_Caso05_FaltaNumero()
    {
        var funciones = new Funciones();
        var contrasena = "Abcd!def";
        var resultado = funciones.EsContrasenaSegura(contrasena);
        Assert.IsFalse(resultado);
    }

}
