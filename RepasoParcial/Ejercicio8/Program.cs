// See https://aka.ms/new-console-template for more information
/*1. Crear clase `Persona` con: `Nombre`, `Apellido`, `Edad`, `DNI`.
2. Constructor que reciba los valores.
3. Destructor que muestre mensaje por consola.
4. Métodos:
    - `GetFullName()`: devuelve Nombre + Apellido.
    - `EsMayorDeEdad()`: devuelve `true` si Edad ≥ 18.
5. Instanciar desde consola y probar sus métodos.*/


Console.WriteLine("Ingrese nombre de la persona: ");
string nombre = Console.ReadLine();
Console.WriteLine("\nIngrese apellido de la persona: ");
string apellido = Console.ReadLine();
Console.WriteLine("\nIngrese edad de la persona: ");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("\nIngrese dni de la persona: ");
int dni = int.Parse(Console.ReadLine());
Persona persona = new Persona(nombre, apellido, edad, dni);

Console.WriteLine("\nSe invoca GetFullName y se muestra en consola");
//string nombreCompleto = persona.GetFullName();
Console.WriteLine($"{persona.GetFullName()}");

Console.WriteLine("\nSe invoca EsMayorDeEdad y se muestra en consola");
Console.WriteLine($"{persona.EsMayorDeEdad()}");



public class Persona {
    string Nombre { set; get; }
    string Apellido { set; get; }
    int Edad { set; get; }
    int Dni { set; get; }

    public Persona(string nombre, string apellido, int edad, int dni) {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Dni = dni;
    }

    public string GetFullName() {
        string nombreCompleto = Nombre + " " + Apellido;
        return nombreCompleto;
    }
    public bool EsMayorDeEdad() {
        if (Edad > 17)
            return true;
        else
            return false;
    }
    ~Persona(){
        Console.WriteLine("Se invocó el destructor");
    }
}
