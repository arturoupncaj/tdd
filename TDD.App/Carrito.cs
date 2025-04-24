namespace TDD.App;

public class Carrito
{
    private List<Libro> libros = new List<Libro>();
    private Cliente cliente;
    public Carrito(Cliente cliente)
    {
        this.cliente = cliente;
    }
    
    public void AddLibro(Libro libro)
    {
        libros.Add(libro);
    }
    
    public decimal CalcularTotal()
    {
        return libros.Sum(x => x.Precio);
    }
}