// See https://aka.ms/new-console-template for more information
using Contexto;
using Universidad;


Console.WriteLine("Empezando pruebas ABM en SSMS. Press any key to continue every procedure ahre");

//Console.ReadKey();
Console.WriteLine("\nAlumno creado...");
// Crear un alumno
CrearAlumno("Perez", "Juan", 12345, "Calle Falsa 123");

//Console.ReadKey();
//Console.WriteLine("\nAlumno buscado por legajo...");
//Buscar un alumno por legajo
//BuscarAlumnoXLegajo(12345);
//Console.ReadKey();
//Console.WriteLine("\nAlumno modificado...");
// Modificar un alumno
//ModificarAlumno(12345);
Console.ReadKey();
Console.WriteLine("\nAlumno borrado...");
// Borrar un alumno
BorrarAlumno(12345);


void CrearAlumno(string apellido, string nombre, int legajo, string direccion) {
    using (var context = new UniversidadContext()) //al usar using abre y cierra la conex
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
        // Reemplaza la línea problemática por FirstOrDefault() para obtener un solo objeto Alumno o null
        var alumno = context.Alumnos
            .FirstOrDefault(a => a.Legajo == legajo);
        if (alumno != null)
        {
            Console.WriteLine($"\nAlumno encontrado: {alumno.Nombre} {alumno.Apellido}, Legajo: {alumno.Legajo}, Direccion: {alumno.Direccion}");
        }

        else { Console.WriteLine("\nNo se encontró un alumno con ese legajo"); }
    }
}

void ModificarAlumno (int legajo) {
    using (var context = new UniversidadContext())
    {
        var alumno = context.Alumnos
                .FirstOrDefault(a => a.Legajo == legajo);
        if (alumno != null)
        {
            Console.WriteLine($"\nAlumno encontrado: {alumno.Nombre} {alumno.Apellido},\n Legajo: {alumno.Legajo},\n Direccion: {alumno.Direccion}");
            Console.WriteLine("\nIngrese el nuevo apellido del alumno:");
            string nuevoApellido = Console.ReadLine();
            Console.WriteLine("\nIngrese el nuevo nombre del alumno:");
            string nuevoNombre = Console.ReadLine();
            Console.WriteLine("\nIngrese la nueva dirección del alumno:");
            string nuevaDireccion = Console.ReadLine();
            Console.WriteLine("\nIngrese nuevo legajo del alumno:");
            int nuevoLegajo = int.Parse(Console.ReadLine());

            // Actualizar los campos del alumno
            alumno.Apellido = nuevoApellido;
            alumno.Nombre = nuevoNombre;
            alumno.Direccion = nuevaDireccion;
            alumno.Legajo = nuevoLegajo;

            context.SaveChanges();
        }

        else { Console.WriteLine("\nNo se encontró un alumno con ese legajo"); }
    }
}

void BorrarAlumno(int legajo) {
    using (var context = new UniversidadContext())
    {
        // Reemplaza la línea problemática por FirstOrDefault() para obtener un solo objeto Alumno o null
        var alumno = context.Alumnos
            .FirstOrDefault(a => a.Legajo == legajo);
        if (alumno != null)
        {
            Console.WriteLine($"\nAlumno encontrado: {alumno.Nombre} {alumno.Apellido},\n Legajo: {alumno.Legajo},\n Direccion: {alumno.Direccion}");
            Console.WriteLine($"\n¿Está seguro de que desea eliminar al alumno? (S/N)");
            string respuesta = Console.ReadLine().ToUpper();
            if (respuesta == "S")
            {
                context.Alumnos.Remove(alumno);
                context.SaveChanges();
                Console.WriteLine("\nAlumno eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("\nEliminación cancelada.");
            }
        }

        else { Console.WriteLine("\nNo se encontró un alumno con ese legajo"); }
    }
}



