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
    public partial class FormDELETE : Form
    {
        public FormDELETE()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5032")
        };

        private async void botonDELETE_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxDELETE.Text);
            var alumnoBorrado = await _httpClient.DeleteFromJsonAsync<Alumno>($"alumnos/{id}");

            // El DataGridView espera una colección como DataSource
            if (alumnoBorrado != null)
            {
                MessageBox.Show("Alumno borrado con éxito");
                this.dgvDELETE.DataSource = new List<Alumno> { alumnoBorrado };
            }
            else
            {
                this.dgvDELETE.DataSource = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
