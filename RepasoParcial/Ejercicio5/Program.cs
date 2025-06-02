// See https://aka.ms/new-console-template for more information
/*1. Crear clase `Producto` con propiedades `Id`, `Nombre`, `Precio`.
2. Pedir al usuario ingresar 5 productos (en consola).
3. Mostrar:
    - Todos los productos ordenados por precio ascendente y descendente.
    - Productos cuyo nombre contenga “a” (ignorando mayúsculas).*/

List<Producto> productos = new List<Producto>();
for (int i = 0; i < 5; i++) {
    Console.WriteLine($"Ingrese id del producto {i+1}");
    string id = Console.ReadLine();
    Console.WriteLine("Ahora ingrese su nombre");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ahora su precio");
    float precio = float.Parse(Console.ReadLine());
    Producto producto = new Producto(id, nombre, precio);
    productos.Add(producto);
}

Console.WriteLine("\nProductos por precio ascendente");
List<Producto> productosASC = productos.OrderBy(producto => producto.Precio).ToList();
foreach (Producto prod in productosASC) {
    Console.WriteLine(prod.Id);
    Console.WriteLine(prod.Nombre);
    Console.WriteLine($"{prod.Precio}\n");
}

Console.WriteLine("\nProductos por precio descendente");
List<Producto> productosDES = productos.OrderByDescending(producto => producto.Precio).ToList();
foreach (Producto prod in productosDES)
{
    Console.WriteLine(prod.Id);
    Console.WriteLine(prod.Nombre);
    Console.WriteLine($"{prod.Precio}\n");
}

Console.WriteLine("\nProductos que contienen \"a\"");
List<Producto> productosA = productos.Where(prod=> prod.Nombre.Contains('a')).ToList();
foreach (Producto prod in productosA)
{
    Console.WriteLine(prod.Id);
    Console.WriteLine(prod.Nombre);
    Console.WriteLine($"{prod.Precio}\n");
}




public class Producto {
     public string Id {set;get;}
    public string Nombre { set; get; }
    public float Precio { set; get; }

    public Producto(string ID, string NOMBRE, float PRECIO) {
        Id = ID;
        Nombre = NOMBRE;
        Precio = PRECIO;
    }
}