using System;

class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }
    public int Codigo { get; set; }

    public Producto(string nombre, double precio, int cantidad, int codigo)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
        Codigo = codigo;
    }
}

class Tienda
{
    private Producto[] productos;
    private int cantidadProductos;

    public Tienda(int capacidadMaxima)
    {
        productos = new Producto[capacidadMaxima];
        cantidadProductos = 0;
    }

    public void AgregarProducto(Producto producto)
    {
        if (cantidadProductos < productos.Length)
        {
            productos[cantidadProductos] = producto;
            cantidadProductos++;
        }
        else
        {
            Console.WriteLine("No se puede agregar más productos. La tienda está llena.");
        }
    }

    public void MostrarInventario()
    {
        Console.WriteLine("Inventario de la tienda:");
        for (int i = 0; i < cantidadProductos; i++)
        {
            Console.WriteLine(
                $"Nombre: {productos[i].Nombre}, Precio: {productos[i].Precio}, Cantidad: {productos[i].Cantidad}, Código: {productos[i].Codigo}"
            );
        }
    }

    public double CalcularValorTotal()
    {
        double total = 0;
        for (int i = 0; i < cantidadProductos; i++)
        {
            total += productos[i].Precio * productos[i].Cantidad;
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        Tienda tienda = new Tienda(10); // Capacidad máxima de 10 productos

        tienda.AgregarProducto(new Producto("Manzanas", 12.00, 10, 1357));
        tienda.AgregarProducto(new Producto("Teléfono", 80.7, 3, 2468));
        tienda.AgregarProducto(new Producto("Refresco", 21.67, 2, 1234));
        tienda.AgregarProducto(new Producto("Juguete", 430.00, 1, 0987));
        tienda.AgregarProducto(new Producto("Sabrita", 50.8, 2, 0123));

        tienda.MostrarInventario();

        Console.WriteLine($"Valor total del inventario: {tienda.CalcularValorTotal()} pesos");
    }
}
