using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generala
{
    public partial class Jugar : Form
    {//DECLARO LOS  DOS JUGADORES
        String jugador1;
        String jugador2;
        

        public Jugar()
        {
            InitializeComponent();
        }

       
        //APRETANDO EL BOTON SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir de la generala?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        //APRETANDO EL BOTON EMPEZAR A JUGAR
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            //LEE LOS DOS JUGADORES Y LOS PASA A MAYUSCULA
            jugador1 = txtUsu1.Text.ToUpper();
            jugador2 = txtUsu2.Text.ToUpper();

            //SI LOS CAMPOS DE JUAGORES ESTAN VACIOS QUE MANDE ERROR
            if (string.IsNullOrEmpty(jugador1) || string.IsNullOrEmpty(jugador2))
         {
           MessageBox.Show("Ingrese un nombre");
          }
          
         else{

            //ASIGNANDO LOS NOMBRE DE LOS JUGADORES Y EN LOS TURNOS
                Jugar2 jugar2 = new Jugar2();
                jugar2.txtJugador1.Text = txtUsu1.Text.ToUpper();
                jugar2.txtJugador2.Text = txtUsu2.Text.ToUpper();
                jugar2.txtTurno1.Text = txtUsu1.Text.ToUpper();
                jugar2.txtTurno2.Text = txtUsu2.Text.ToUpper();

                this.Hide();
                jugar2.ShowDialog();

            }

           
        }

        //VOLVER AL INICO
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 volver = new Form1();
            this.Hide();
            volver.ShowDialog();
        }
    }
}
