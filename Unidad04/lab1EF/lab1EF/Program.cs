// See https://aka.ms/new-console-template for more information
using Contexto;
using Universidad;


Console.WriteLine("Empezando pruebas ABM en SSMS. Press any key to continue every procedure ahre");

Console.ReadKey();
Console.WriteLine("\nAlumno creado...");
// Crear un alumno
CrearAlumno("Perez", "Juan", 12345, "Calle Falsa 123");

Console.ReadKey();
Console.WriteLine("\nAlumno buscado por legajo...");
// Buscar un alumno por legajo
BuscarAlumnoXLegajo(12345);

Console.ReadKey();


void CrearAlumno(string apellido, string nombre, int legajo, string direccion) {
    using (var context = new UniversidadContext())
    {
        var alumno = new Alumno()
        {
            //Id (int)
            Apellido = apellido,
            Nombre = nombre,
            Legajo = legajo,
            Direccion = direccion
        };

        context.Alumnos.Add(alumno);
        context.SaveChanges();
    }
}

void BuscarAlumnoXLegajo(int legajo)
{
    using (var context = new UniversidadContext())
    {
        Alumno alumno = (Alumno)context.Alumnos
            .Where(a => a.Legajo == legajo);
        if (alumno != null)
        {
            Console.WriteLine($"\nAlumno encontrado: {alumno.Nombre} {alumno.Apellido}, Legajo: {alumno.Legajo}, Direccion: {alumno.Direccion}");
        }

        else { Console.WriteLine("\nNo se encontró un alumno con ese legajo"); }
    }
}


