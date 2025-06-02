// See https://aka.ms/new-console-template for more information
/*1. Crear solución `LabHerencia` con dos proyectos: consola y librería de clases.
2. En la librería crear clase `Vehiculo` con propiedad `Marca`, método `MostrarMarca()` y constructores.
3. Crear clase `Auto` que herede de `Vehiculo` y agregue método `EncenderRadio()`.
4. En el proyecto consola, instanciar ambas clases, llamar a sus métodos.*/

using Ejercicio6Clases;

Vehiculo vehiculo = new Vehiculo("Yamaha");
Auto auto = new Auto("Chevrolet");
vehiculo.MostrarMarca();
auto.MostrarMarca();
auto.EncenderRadio();