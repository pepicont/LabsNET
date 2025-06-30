namespace Alumno
{
    public class Alumno
    {
        public int Id { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int legajo { get; set; }
        public string direccion { get; set; }

        public static readonly List<Alumno> Lista = new()
   {
       new Alumno { Id = 1, nombre = "Juan", apellido = "Pérez" },
       new Alumno { Id = 2, nombre = "Ana", apellido = "García" }
   };


    }
}
