using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using Dominio;

namespace Form1
{
    public partial class FormPUT : Form
    {
        public FormPUT()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5032")
        };

        private async void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxBuscar.Text);
            var alumno = await _httpClient.GetFromJsonAsync<Alumno>($"alumnos/{id}");

            // El DataGridView espera una colección como DataSource
            if (alumno != null)
            {
                this.textBoxID.Text = id.ToString();
                this.textBoxNombre.Text = alumno.nombre;
                this.textBoxDireccion.Text = alumno.direccion;
                this.textBoxApellido.Text = alumno.apellido;
                this.textBoxLegajo.Text = alumno.legajo.ToString();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPOST_Click(object sender, EventArgs e)
        {

        }

        private async void buttonPUT_Click(object sender, EventArgs e)
        {
            Alumno alumnoAModificar = new Alumno()
            {
                Id = int.Parse(this.textBoxID.Text),
                apellido = this.textBoxApellido.Text,
                nombre = this.textBoxNombre.Text,
                direccion = this.textBoxDireccion.Text,
                legajo = int.Parse(this.textBoxLegajo.Text),
            };
            var response = await _httpClient.PutAsJsonAsync($"alumnos", alumnoAModificar);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Alumno modificado con éxito");
                this.dgvPUT.DataSource = new List<Alumno> { alumnoAModificar };

                // Limpiar los TextBox
                this.textBoxID.Clear();
                this.textBoxNombre.Clear();
                this.textBoxDireccion.Clear();
                this.textBoxApellido.Clear();
                this.textBoxLegajo.Clear();
            }
            else
            {
                MessageBox.Show("Error al modificar el alumno");
                this.dgvPUT.DataSource = null;
            }
        }
    }
}
