// See https://aka.ms/new-console-template for more information
/*2. Realizar:
    - Provincias que comienzan con “C” o “B”.
    - Lista de edades, mostrar mayores de 30.
    - Lista de objetos tipo `Ciudad` (Nombre, CP), filtrar las que contengan “san”.
    - Mostrar resultado con `foreach`.*/
//1ero
/*List<string> ciudadesLista = new List<string>
{
    "Buenos Aires",
    "Catamarca",
    "Chaco",
    "Chubut",
    "Córdoba",
    "Corrientes",
    "Entre Ríos",
    "Formosa",
    "Jujuy",
    "La Pampa",
    "La Rioja",
    "Mendoza",
    "Misiones",
    "Neuquén",
    "Río Negro",
    "Salta",
    "San Juan",
    "San Luis",
    "Santa Cruz",
    "Santa Fe",
    "Santiago del Estero",
    "Tierra del Fuego",
    "Tucumán"
};
List<string> ciudadesBoC = ciudadesLista.Where(c => c.StartsWith('B') || c.StartsWith('C')).ToList();
Console.WriteLine("Las ciudades que arrancan con C o B son:");
foreach (string ciudad in ciudadesBoC) {
    Console.WriteLine(ciudad);
}
*/

//2do
/*
int[] edades = { 18, 25, 32, 41, 29, 37, 22, 55, 30, 44 };
int[] edades30 = edades.Where(e => e > 30).ToArray();
Console.WriteLine(String.Join(' ',edades));
Console.WriteLine("Edades mayores a 30:");
foreach (int edad in edades30) {
    Console.WriteLine(edad);
}*/
//3ero
List<Ciudad> ciudades = new List<Ciudad>
{
    new Ciudad("Buenos Aires", "1000"),
    new Ciudad("Catamarca", "4700"),
    new Ciudad("Chaco", "3500"),
    new Ciudad("Chubut", "9100"),
    new Ciudad("Córdoba", "5000"),
    new Ciudad("Corrientes", "3400"),
    new Ciudad("Entre Ríos", "3100"),
    new Ciudad("Formosa", "3600"),
    new Ciudad("Jujuy", "4600"),
    new Ciudad("La Pampa", "6300"),
    new Ciudad("La Rioja", "5300"),
    new Ciudad("Mendoza", "5500"),
    new Ciudad("Misiones", "3300"),
    new Ciudad("Neuquén", "8300"),
    new Ciudad("Río Negro", "8500"),
    new Ciudad("Salta", "4400"),
    new Ciudad("San Juan", "5400"),
    new Ciudad("San Luis", "5700"),
    new Ciudad("Santa Cruz", "9400"),
    new Ciudad("Santa Fe", "3000"),
    new Ciudad("Santiago del Estero", "4200"),
    new Ciudad("Tierra del Fuego", "9410"),
    new Ciudad("Tucumán", "4000")
};
Console.WriteLine("Las ciudades que arrancan con san son...");
var ciudadesSan = ciudades.Where(c => c.Nombre.ToLower().Contains("san"));
foreach (Ciudad ciudad in ciudadesSan) {
    Console.WriteLine($"{ciudad.Nombre} - {ciudad.CP}");
}
public class Ciudad 
{
    public string Nombre { set; get; }
    public string CP { set; get; }
    public Ciudad(string nombre, string cp) {
        Nombre = nombre;
        CP = cp;
    }
}
