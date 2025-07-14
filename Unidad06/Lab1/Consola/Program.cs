// See https://aka.ms/new-console-template for more information
using System.Net.Http.Json;
using Dominio;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Esperando 10 segundos que levante la API...");
await Task.Delay(10000);

HttpClient httpClient = new HttpClient()
{
    BaseAddress = new Uri("http://localhost:5032") //fijarse siempre de que coincida el puerto con el asignado por
    //la api 5032http y 7251https
};

Alumno alumno1 = new Alumno()
{
    apellido = "Conti",
    nombre = "Stefano",
    direccion = "Laprida 14",
    legajo = 43434,
};

Alumno alumno2 = new Alumno()
{
    apellido = "Conti",
    nombre = "Luca",
    direccion = "Laprida 14",
    legajo = 65656,
};

Alumno alumno3 = new Alumno()
{
    apellido = "Vitali",
    nombre = "Bruno",
    direccion = "Zapallo 433",
    legajo = 42222
};
//post de los alumnos
await httpClient.PostAsJsonAsync("/alumnos", alumno1);
await httpClient.PostAsJsonAsync("/alumnos", alumno2);
await httpClient.PostAsJsonAsync("/alumnos", alumno3);

//retrieve de los alumnos
IEnumerable<Alumno> alumnos = await httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");

//muestreo de los alumnos
foreach (Alumno alumno in alumnos)
{
    Console.WriteLine($"{alumno.apellido}\n{alumno.nombre}\n{alumno.direccion}\n{alumno.legajo}\n");
}

//validacion extra e innecesaria
Console.WriteLine($"Total de alumnos: {alumnos.Count()}\nSi es 3 entonces es correcto.");

//para que no se cierre la consola
Console.ReadKey();