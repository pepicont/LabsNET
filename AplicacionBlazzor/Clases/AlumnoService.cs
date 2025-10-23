using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clases
{
    public class AlumnoService
    {
        private UniversidadContext CreateContext()
        {
            return new UniversidadContext();
        }
        public List<Alumno> GetAll()
        {
            using var context = CreateContext();
            return context.Alumnos.ToList();


        }
        public Alumno? GetOne(int id) {
            using var context = CreateContext();
            return context.Alumnos.AsNoTracking().FirstOrDefault(a => a.Id == id);
        }
        public bool Create(Alumno nuevoAlumno)
        {
            using var context = CreateContext();
            context.Alumnos.Add(nuevoAlumno);
            var affected = context.SaveChanges();
            Console.WriteLine($"AlumnoService.Create: SaveChanges affected rows = {affected}");
            return affected > 0;
        }
        public bool Update(Alumno alumnoAModificar)
        {
            using var context = CreateContext();
            // Logear objeto recibido (JSON)
            Console.WriteLine("AlumnoService.Update called with: " + JsonSerializer.Serialize(alumnoAModificar));
            Alumno? alumno = context.Alumnos.Find(alumnoAModificar.Id);
            if (alumno != null)
            {
                alumno.Nombre = alumnoAModificar.Nombre;
                alumno.Apellido = alumnoAModificar.Apellido;
                alumno.Legajo = alumnoAModificar.Legajo;
                alumno.Direccion = alumnoAModificar.Direccion;
                var affected = context.SaveChanges();
                Console.WriteLine($"AlumnoService.Update: SaveChanges affected rows = {affected}");
                return affected > 0;
            }
            else return false;
        }
    }
}
