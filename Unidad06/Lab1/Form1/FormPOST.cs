using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Form1
{
    public partial class FormPOST : Form
    {
        public FormPOST()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5032")
        };

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void buttonPOST_Click(object sender, EventArgs e)
        {
            Alumno alumnoACargar = new Alumno() {
                Id = int.Parse(this.textBoxID.Text),
                // Cambia las asignaciones para obtener el texto real de los TextBox
                apellido = this.textBoxApellido.Text,
                nombre = this.textBoxNombre.Text,
                direccion = this.textBoxDireccion.Text,
                legajo = int.Parse(this.textBoxLegajo.Text),
            };
            var response = await _httpClient.PostAsJsonAsync("alumnos", alumnoACargar);

            // El DataGridView espera una colección como DataSource
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Alumno cargado con éxito");
                this.dgvPOST.DataSource = new List<Alumno> { alumnoACargar };
            }
            else
            {
                MessageBox.Show("Error al cargar el alumno");
                this.dgvPOST.DataSource = null;
            }
        }
    }
}
