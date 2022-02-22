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
    public partial class Ganador : Form
    {
       
        public Ganador()
        {
            InitializeComponent();
        }

        //BOTON SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir de la generala?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        //BOTON DE VOLVER A JUGAR
        private void button1_Click(object sender, EventArgs e)
        {
            Jugar jugar = new Jugar();
            this.Hide();
            jugar.ShowDialog();
        }

       
    }
}
