using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace APIWForms
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {

            string id = txtboxid.Text.ToString();
            // URL de la API que deseas consumir
            string apiUrl = "https://swapi.dev/api/people/" + id + "/";


            HttpClient httpClient = new HttpClient();

            HttpResponseMessage solicitud = await httpClient.GetAsync(apiUrl);
            

            if (solicitud.IsSuccessStatusCode)
            {
                // Leer el contenido de la respuesta como una cadena JSON
                string json = await solicitud.Content.ReadAsStringAsync();
                //Deserealizamos la respuesta para poder trabajarla de manera mas eficiente
                ApiResponse Apirespuesta = JsonConvert.DeserializeObject<ApiResponse>(json);


                txtname.Text = Apirespuesta.name;
                txtaltura.Text = Apirespuesta.height;
                txtojos.Text = Apirespuesta.eye_color;

            }
            else
            {
                MessageBox.Show("Solicitud errónea => ID inválido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            string textoid = txtboxid.Text.Trim();
            if (string.IsNullOrEmpty(textoid))
            {
                MessageBox.Show("Debe colocar un ID y hacer la llamada luego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string stringBusqueda = txtname.Text;

            string googleSearchUrl = "https://www.google.com/search?q=" + stringBusqueda;

            Process.Start(googleSearchUrl);
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtojos.Text = "";
            txtboxid.Text = "";
            txtaltura.Text = "";

        }
    }
}

