using Clases.ApiRest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        DBApi dBApi = new DBApi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            dynamic resultado = dBApi.Get("https://rickandmortyapi.com/api/episode/"+textEpisode.Text+"");
            //pictureBox1.ImageLocation = resultado.data[1].avatar.ToString();
            txtNombreGET.Text = resultado.air_date.ToString();
            txtApellidoGET.Text = resultado.episode.ToString();
            txtEmail.Text = resultado.name.ToString();

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona
            {
                job = txtTrabajador.Text,
                name = txtNombresPost.Text
            };

            string json = JsonConvert.SerializeObject(persona);

            dynamic respuesta = dBApi.Post("https://reqres.in/api/users",json);

            MessageBox.Show(respuesta.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic resultado = dBApi.Get("https://animechan.vercel.app/api/random");
            textFrase.Text = resultado.quote.ToString();
            textAnime.Text = resultado.anime.ToString();
            textPersona.Text = resultado.character.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dynamic resultado = dBApi.Get("https://official-joke-api.appspot.com/jokes/random");
            textJoke.Text = resultado.setup.ToString();
            textRES.Text = resultado.punchline.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

    public class Persona
    {
        public string name { get; set; }
        public string job { get; set; }
    }
}

