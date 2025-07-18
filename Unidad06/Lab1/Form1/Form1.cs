using Dominio;
using System.Net.Http.Json;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5032")
        };


        private async void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<Alumno> alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");
            this.Alumnos.DataSource = alumnos;
        }

        private async void botonActualizar_Click(object sender, EventArgs e)
        {
            IEnumerable<Alumno> alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");
            this.Alumnos.DataSource = alumnos;
        }
    }
}
