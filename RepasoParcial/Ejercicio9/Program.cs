// See https://aka.ms/new-console-template for more information
/*1. Crear una nueva aplicación de consola llamada `LabCamposPrivados`.
2. Agregar una clase llamada `Producto` con los siguientes miembros privados


    private string nombre;
    private decimal precio;

3. No crear propiedades públicas para esos campos. En cambio, implementar dos métodos públicos:
    - `SetDatos(string nombre, decimal precio)`
    - `MostrarDatos()`
4. En el método `SetDatos`, asignar los valores a los campos privados.
    - Validar que el precio no sea negativo. Si lo es, mostrar un mensaje y no asignar el valor.
    - Si el nombre está vacío, asignar "Producto sin nombre".
5. En el método `MostrarDatos`, imprimir en consola el nombre y el precio del producto.
6. En el `Main`, crear una instancia de `Producto`, llamar a `SetDatos` con valores válidos e inválidos y luego llamar a `MostrarDatos` para verificar el comportamiento.*/




Producto producto = new Producto();
producto.SetDatos("Calabaza", -12.203333333333m);
producto.MostrarDatos();
public class Producto {
    private string m_nombre;
    private decimal? m_precio; //el ? es para que pueda ser null

    public void SetDatos(string nombre, decimal precio) {
        if (nombre == string.Empty)
            m_nombre = "Producto sin nombre";
        else
            m_nombre = nombre;
        if (precio < 0)
            Console.WriteLine("Error, no se puede asignar un precio negativo");
        else
            m_precio = precio;
    }

    public void MostrarDatos() {
        Console.WriteLine(m_nombre);
        Console.WriteLine(m_precio);
    }
}

