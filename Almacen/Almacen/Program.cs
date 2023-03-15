// See https://aka.ms/new-console-template for more information
using Almacen.Models;

//Console.WriteLine("Hello, World!");

using AlmacenContext db = new AlmacenContext();

Producto producto = new Producto();

Console.WriteLine("Ingrese nombre del producto");
producto.Nombre = (Console.ReadLine());

Console.WriteLine("Ingrese descripciòn");
producto.Descripcion = (Console.ReadLine());

Console.WriteLine("Ingrese el precio");
producto.Precio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingrese el stock");
producto.Stock = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Los datos que ingreso son: Nombre {producto.Nombre}, Descripcion {producto.Descripcion}, Precio {producto.Precio} y Stock {producto.Stock} ");

db.Productos.Add(producto);
db.SaveChanges();
