using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Generala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }
        SoundPlayer sonar;

        //BOTON SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir de la generala?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) 
            {
                this.Close();
            }
            
        }

        //BOTON PARA IR AL FORM REGLAS
        private void btnReglas_Click(object sender, EventArgs e)
        {
            Reglas reglas = new Reglas();
            this.Hide();
            reglas.ShowDialog();
          
        }

        //BOTON PARA EMPEZAR A JUGAR
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Jugar jugar = new Jugar();
            this.Hide();
            jugar.ShowDialog();
        }

        //BOTON PARA VER EL VIDEO EXPLICATIVO EN YOU TUBE 
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/m3S4FriaU5c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sonar = new SoundPlayer(Application.StartupPath + @"\sonidos\auto.wav");

            sonar.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sonar = new SoundPlayer(Application.StartupPath + @"\sonidos\auto.wav");

            sonar.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sonar !=null)
            {
                sonar.Stop();
            }
        }
    }
}
