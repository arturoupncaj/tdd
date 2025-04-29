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
    public void ObtenerMayorCaso01()
    {
        var funciones = new Funciones();
        var lista = new List<int> { 10, 11, 9, 5, 3 };
        var resultado = funciones.ObtenerMayor(lista);
        Assert.AreEqual(11, resultado);
    }
    [Test]
    public void ObtenerMayorCaso02()
    {
        var funciones = new Funciones();
        var lista = new List<int> { 5, 4, 3, 2, 1 };
        var resultado = funciones.ObtenerMayor(lista);
        Assert.AreEqual(5, resultado);
    }
    [Test]
    public void ObtenerMayorCaso03()
    {
        var funciones = new Funciones();
        var lista = new List<int> { 3, 5, 7, 9 };
        var resultado = funciones.ObtenerMayor(lista);
        Assert.AreEqual(9, resultado);
    }

    [Test]
    public void ObtenerMayorCaso04()
    {
        var funciones = new Funciones();
        var lista = new List<int> { 35, 1, 2, 3, 4, 5, 6, 7, 8 };
        var resultado = funciones.ObtenerMayor(lista);
        Assert.AreEqual(35, resultado);
    }

    [Test]
    public void ObtenerMayorCaso05()
    {
        var funciones = new Funciones();
        var lista = new List<int> { 20, 30, 25, 10, 5, 9 };
        var resultado = funciones.ObtenerMayor(lista);
        Assert.AreEqual(30, resultado);
    }

    [Test]
    public void ValidarContrasenaCas01()
    {
        var password = "Hello12";
        var resultado = Funciones.ValidarContrasena(password);

        Assert.AreEqual(resultado,false);
    }

    [Test]
    public void ValidarContrasenaCas02()
    {
        var password = "HolaPeru";
        bool resultado = Funciones.ValidarContrasena(password); // Falla por falta de número y caracter especial
        Assert.AreEqual(false, resultado);
    }

    [Test]
    public void ValidarContrasenaCas03()
    {
        var password = "HolaPeru#1";
        bool resultado = Funciones.ValidarContrasena(password); // Cumple todos los requisitos
        Assert.AreEqual(true, resultado);
    }

    [Test]
    public void ValidarContrasenaCas04()
    {
        var password = "HolaPeru1";
        bool resultado = Funciones.ValidarContrasena(password); // Falla por falta de caracter especial
        Assert.AreEqual(false, resultado);
    }

    [Test]
    public void ValidarContrasenaCas05()
    {
        var password = "holaperu";
        bool resultado = Funciones.ValidarContrasena(password); // Falla por falta de mayúscula, número y caracter especial
        Assert.AreEqual(false, resultado);
    }
}