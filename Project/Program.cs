using Project.Models;

using AlmacenContext db = new AlmacenContext();

Producto producto = new Producto();

Console.Write("Ingrese el nombre del producto -> ");
producto.Nombre = Console.ReadLine();

Console.Write("Ingrese una breve descripcion del producto -> ");
producto.Descripcion = Console.ReadLine();

Console.Write("Ingrese el precio del producto -> $");
producto.Precio = Convert.ToDecimal(Console.ReadLine());

Console.Write("Ingrese la cantidad de productos existentes -> ");
producto.Stock = Convert.ToInt32(Console.ReadLine());

db.Productos.Add(producto);
db.SaveChanges();

var ListProductos = db.Productos.ToList();

foreach (var i in ListProductos)
{
    Console.WriteLine($"\nNombre: {i.Nombre}");
    Console.WriteLine($"Descripcion: {i.Descripcion}");
    Console.WriteLine($"Precio: ${i.Precio}");
    Console.WriteLine($"Stock {i.Stock}");
}