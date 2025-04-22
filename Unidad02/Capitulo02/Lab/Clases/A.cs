namespace Clases
{
    public class A
    {
        public string NombreInstancia { get; set; } //crea los métodos públicos para acceder y settear la variable
        // si yo luego get pongo {...} podría armarlo yo y no usar el default. lo mismo con set
        public A() //constructor por defecto
        {
            NombreInstancia = "Instancia sin nombre";
        }

        public A(string nombre) //constructor con parámetro
        {
            NombreInstancia = nombre;
        }

        public void MostrarNombre() //métodos
        {
            Console.WriteLine($"Nombre de la instancia: {NombreInstancia}");
        }

        public void M1()
        {
            Console.WriteLine("El método M1 fue invocado.");
        }

        public void M2()
        {
            Console.WriteLine("El método M2 fue invocado.");
        }

        public void M3()
        {
            Console.WriteLine("El método M3 fue invocado.");
        }
    }
}


