namespace Ejercicio6Clases
{
    public class Vehiculo
    {
        string Marca { set; get; }

        public void MostrarMarca() {
            Console.WriteLine(Marca);
        }

        public Vehiculo(string MARCA) {
            Marca = MARCA;
        }
    
    }

    public class Auto : Vehiculo {

        public void EncenderRadio() {
            Console.WriteLine("Radio encendida");
        }
        public Auto(string MARCA) : base(MARCA) { }
        }
    }


