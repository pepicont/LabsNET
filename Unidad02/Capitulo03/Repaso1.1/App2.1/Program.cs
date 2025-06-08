// See https://aka.ms/new-console-template for more information
/*Crear proyecto consola llamado ContadorDePalabras.

Pedir al usuario ingresar 3 frases.

Guardar cada frase en un array.

Por cada frase, contar cuántas palabras tiene (separadas por espacio) y mostrarlo.

Mostrar al final el total general de palabras ingresadas entre todas las frases.*/

Console.WriteLine("Favor de ingresar 3 frases: ");
string[] frases = new string[3];
for (int i = 0; i < 3; i++) {
    Console.WriteLine($"Ingrese frase {i + 1}");
    frases[i] = Console.ReadLine();
}
int cant = 0;
foreach (string frase in frases) {
    string [] frasesAux = frase.Split(' ');
    int cantAux = (frasesAux.Length);
    cant = cant + cantAux;
    Console.WriteLine($"la frase 1 tiene {cantAux} palabras");
}
Console.WriteLine($"\nLa cantidad total de palabras es {cant}");