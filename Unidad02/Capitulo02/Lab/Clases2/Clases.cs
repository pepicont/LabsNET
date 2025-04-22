namespace Clases //Observar que se estan definiendo dos clases en el mismo archivo físico.
                 //Para la CLR esto es completamente transparente.
                 //Solo importa que se esta definiendo Clases.A y Clases.B dentro de un assembly llamado clases.
{
    public class A
    {
        public void F() { Console.WriteLine("A.F"); }
        public virtual void G() { Console.WriteLine("A.G"); }
    }

    public class B : A
    {
        new public void F() { Console.WriteLine("B.F"); }
        public override void G() { Console.WriteLine("B.G"); }
    }
}//si tiene el método virtual de la clase A y el de B override, el método
// de B sobreescribe el de A, solo si tiene el virtual el otro
//si no pongo new para ocultar el método de la padre, es mala práctica y usa el de A el obj polimorfico
//si no pongo override no hace nada, ni oculta entonces las 2 ultimas salidas son el método de A

