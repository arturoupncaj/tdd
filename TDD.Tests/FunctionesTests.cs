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
}