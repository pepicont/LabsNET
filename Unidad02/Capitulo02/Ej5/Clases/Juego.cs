namespace Clases
{
    public class Juego
    {
        public int Record { set; get; }
        public void ComenzarJuego()
        {
            Record = 1;
            string opc = "0";
            while (opc != "exit")
            {
                Console.WriteLine("\nIngrese:\n1.Para comenzar un juego\n2.Para comparar histórico\n\"exit\" Para salir");
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
                        Juegoo();
                        break;
                    case "2":
                        Historico();
                        break;
                    case "exit":
                        Console.WriteLine("Saliendo del juego.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        private void Juegoo()
        {
            Console.WriteLine("\nJuego iniciado\nIngrese un máximo número a adivinar: ");
            int nroMaximo = int.Parse(Console.ReadLine());
            Jugada jugada = new Jugada(nroMaximo);
            Console.WriteLine("Arranco el juego! Empezá a adivinar el número o 404 para salir");
            int nro = 400; //valor lejos para poder inicializar el bucle
            jugada.Intentos = 0; //inicializamos la jugada
            jugada.Adivino = false; // ""
            while (nro != jugada.Numero && nro!= 404) {
                nro = int.Parse(Console.ReadLine());
                jugada.Intentos++;
                Console.WriteLine($"\nNo es ese número, intenta de nuevo. Van {jugada.Intentos} intentos");
            }
            if (nro == jugada.Numero) {
                Console.WriteLine($"Felicitaciones! Adivinaste el número {jugada.Numero} en {jugada.Intentos} intentos");
                jugada.Adivino = true;
                if (jugada.Intentos < Record) {
                    Record = jugada.Intentos;
                }
            }            

        }

        private void Historico() {
            Console.WriteLine($"El histórico es {Record} intentos");
        }
    }

}
