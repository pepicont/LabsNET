namespace Dominio

{
    public class Alumno
    {
        public int Id { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int legajo { get; set; }
        public string direccion { get; set; }

        public static readonly List<Alumno> Lista = new();
  

    }
}
