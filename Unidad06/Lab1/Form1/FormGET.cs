using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using System.Net.Http.Json;

namespace Form1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5032")
        };

        private async void botonGET_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxGET.Text);
            var alumno = await _httpClient.GetFromJsonAsync<Alumno>($"alumnos/{id}");

            // El DataGridView espera una colección como DataSource
            if (alumno != null)
            {
                this.dgvGET.DataSource = new List<Alumno> { alumno };
            }
            else
            {
                this.dgvGET.DataSource = null;
            }
        }
    }
}