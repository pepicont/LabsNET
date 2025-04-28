namespace Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string DNI { get; set; }

        public Persona(string nombre, string apellido, int edad, string dni) {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            DNI = dni;
            Console.WriteLine($"\nSe ha creado una persona de:\nNombre:{Nombre}\nApellido:{Apellido}\nEdad:{Edad}\nDNI:{DNI}\nDe esta manera, queda envidenciado que se pueden acceder a los atributos de persona");
        }
        ~Persona(){//sintaxis del destructor, ~Clase(){}. Sin public ni na'
            Console.WriteLine("\nEl destructor ha sido llamado");
        }
        public void GetFullName() {
            string resultado = Nombre + " " + Apellido;
            Console.WriteLine($"\n{resultado}");
        }
        }
}

