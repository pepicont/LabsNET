// See https://aka.ms/new-console-template for more information
//1) Dado un Array que incluya todas las Provincias de Argentina usar LINQ para obtener y mostrar
//por Consola aquellas provincias que empiezan con la letra “S” o “T”
using static System.Console;

string[] provincias = new string[] {
    "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos",
    "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro",
    "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego",
    "Tucumán", "Ciudad Autónoma de Buenos Aires"
};

var provinciasSOT = provincias.Where(p => p.StartsWith("S") || p.StartsWith("T"));
//sintaxis var=arreglo.Where(elemento => elemento.StartsWith("S") || ...)

WriteLine("Provincias que empiezan con la letra S o T:\n");

foreach (string provincia in provinciasSOT){
    WriteLine($"{provincia}");
}


