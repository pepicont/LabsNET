using Dominio;
using System.Net.Http.Json;

namespace Forms
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5032")
        };

        // Asumiendo que el DataGridView se llama 'dgvAlumnos'
        private DataGridView dgvAlumnos;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            // Inicializar el DataGridView si no está en el diseñador
            dgvAlumnos = new DataGridView
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(dgvAlumnos);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");
            dgvAlumnos.DataSource = alumnos?.ToList();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno
            {
                nombre = textBox1.Text,
                apellido = textBox2.Text,
                direccion = textBox3.Text,
                legajo = int.Parse(textBox4.Text)
            };

            var response = await _httpClient.PostAsJsonAsync("alumnos", alumno);
            if (response.IsSuccessStatusCode)
                MessageBox.Show("Alumno agregado exitosamente");

            // Actualizar grilla
            var alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");
            dgvAlumnos.DataSource = alumnos.ToList();
        }
    }
    }

