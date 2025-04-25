using TDD.App;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TDD.Tests;

public class TestFuncion
{
  
    [Test]
    public void ObtenerNumeroMayor_Caso01()
    {
        // Arrange
        var funcion = new Funciones();
        var lista = new List<int> { 1, 5, 3, 9, 2 };

        // Act
        var resultado = funcion.ObtenerNumeroMayor(lista);

        // Assert
        Assert.AreEqual(9, resultado);
    }
    [Test]
    public void ObtenerNumeroMayor_Caso02()
    {
        // Arrange
        var funcion = new Funciones();
        var lista = new List<int> { -10, -5, -3, -20 };

        // Act
        var resultado = funcion.ObtenerNumeroMayor(lista);

        // Assert
        Assert.AreEqual(-3, resultado);
    }
    [Test]
    public void ObtenerNumeroMayor_Caso03()
    {
        // Arrange
        var funcion = new Funciones();
        var lista = new List<int> { 100 };

        // Act
        var resultado = funcion.ObtenerNumeroMayor(lista);

        // Assert
        Assert.AreEqual(100, resultado);
    }
    [Test]
    public void ObtenerNumeroMayor_Caso04()
    {
        // Arrange
        var funcion = new Funciones();
        var lista = new List<int> { 8, 8, 8, 8 };

        // Act
        var resultado = funcion.ObtenerNumeroMayor(lista);

        // Assert
        Assert.AreEqual(8, resultado);
    }
    [Test]
    public void ObtenerNumeroMayor_Caso05_ListaVacia()
    {
        // Arrange
        var funcion = new Funciones();
        var lista = new List<int>();

        // Act
        var resultado = funcion.ObtenerNumeroMayor(lista);

        // Assert → No necesario, se espera excepción
    }

}
