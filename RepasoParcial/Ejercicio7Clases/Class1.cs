namespace Ejercicio7Clases
{
    public class Animal
    {
        public void Hablar() {
            Console.WriteLine("*balbucea en animal*");
        }
        public virtual void Moverse() {
            Console.WriteLine("*se mueve en animal*");
        }
    }

    public class Perro : Animal {
        public new void Hablar() {
            Console.WriteLine("*ladra*");

        }
        public override void Moverse()
        {
            Console.WriteLine("*se mueve como perro*");
        }
    }
}
