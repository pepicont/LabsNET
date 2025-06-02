// See https://aka.ms/new-console-template for more information
/*1. Crear solución `LabPOO` con librería y proyecto consola.
2. Crear clase base `Animal` con métodos `Hablar()` y `Moverse()` (uno virtual).
3. Clase `Perro` hereda y:
    - Usa `new` en `Hablar()` para ocultar.
    - Usa `override` en `Moverse()` para redefinir.
4. Instanciar ambas desde consola y observar los resultados.*/

using Ejercicio7Clases;

Animal animal = new Animal();
Perro perro = new Perro();

animal.Hablar();
animal.Moverse();
perro.Hablar();
perro.Moverse();
