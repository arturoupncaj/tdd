using TDD.App;

namespace TDD.Tests;

public class CarritoTest
{
    [Test]
    public void CalcularTotalCaso01()
    {
        // Arrange -> 0 libros
        var cliente = new Cliente(){Id = 1, Nombre = "Cliente 1"};

        var carrito = new Carrito(cliente);
                
        // Act

        var total = carrito.CalcularTotal();
        
        // Assets
        Assert.AreEqual(0m, total);
    }
    
    [Test]
    public void CalcularTotalCaso02()
    {
        // Arrange -> 1 libro
        var cliente = new Cliente(){Id = 1, Nombre = "Cliente 1"};

        var carrito = new Carrito(cliente);
        var libro = new Libro
        {
            Id = 1,
            Titulo = "Libro 1",
            Autor = "Autor 1",
            Precio = 10m
        };
        
        carrito.AddLibro(libro);
                
        // Act

        var total = carrito.CalcularTotal();
        
        // Assets
        Assert.AreEqual(10m, total);
    }
    
    [Test]
    public void CalcularTotalCaso03()
    {
        // Arrange -> 1 libro
        var cliente = new Cliente(){Id = 1, Nombre = "Cliente 1"};
        var carrito = new Carrito(cliente);
        var libro = new Libro
        {
            Id = 1,
            Titulo = "Libro 1",
            Autor = "Autor 1",
            Precio = 10m
        };
        var libro2 = new Libro
        {
            Id = 2,
            Titulo = "Libro 2",
            Autor = "Autor 2",
            Precio = 20m
        };
        
        carrito.AddLibro(libro);
        carrito.AddLibro(libro2);
                
        // Act

        var total = carrito.CalcularTotal();
        
        // Assets
        Assert.AreEqual(30m, total);
    }
}