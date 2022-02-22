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
    public partial class Jugar2 : Form
    {
        //DECLARANDO VARIABLES DE PUNTOS, CONTADOR Y GANADOR
        int puntoEsc = 0;
        int puntoFull = 0;
        int puntoPoker = 0;
        int puntoGene = 0;
        int puntoDoble = 0;
        int puntoEsc2 = 0;
        int puntoFull2 = 0;
        int puntoPoker2 = 0;
        int puntoGene2 = 0;
        int puntoDoble2 = 0;
        int puntuacion = 0;
        int puntuacion2 = 0;
        String jugador1;
        String jugador2;
        String turno;
        int contador = 0;
        String cont;
        String ganador;
       

        public Jugar2()
        {
            //INICIAMOS EN JUGADOR 1 Y ESTABLECEMOS LOS COLORES DE CADA TURNO
            InitializeComponent();
           
            txtTurno1.BackColor = Color.Green;
            txtTurno2.BackColor = Color.Red;
            turno = jugador1;
           
        }

       //CUANDO HACE CLIC EN EL CUBILETE
        private void cubilete_Click_1(object sender, EventArgs e)
        {
           //ESTABLECE EL TURNO DEL JUGADOR Y NOMBRE DE CADA UNO
            turno = jugador2;
            jugador1 = txtJugador1.Text;
            jugador2 = txtJugador2.Text;

            //SI EL CONTADOR ES PAR ES EL TURNO DEL JUGADOR1
            if(contador %2 == 0)
            {
                turno = jugador1;
            }
            else
            {
                turno = jugador2;
            }
            //SI ES TURNO DEL JUGADOR2 CABIA COLORES EN TURNO
            if (turno == jugador2)
            {
               
                    txtTurno1.BackColor = Color.Red;
                    txtTurno2.BackColor = Color.Green;
               
            }
            if (turno == jugador1)
            {

                txtTurno1.BackColor = Color.Green;
                txtTurno2.BackColor = Color.Red;

            }


            // DECLARAMOS VARIABLES Y LE ASIGNAMOS UN NUMERO AL AZAR
            Random ran = new Random();
            int dado1;
            int dado2;
            int dado3;
            int dado4;
            int dado5;

            dado1 = ran.Next(1, 7);
            dado2 = ran.Next(1, 7);
            dado3 = ran.Next(1, 7);
            dado4 = ran.Next(1, 7);
            dado5 = ran.Next(1, 7);

         

            // AL DADO 1 LE PONEMOS LA IMAGEN AL AZAR DEL NUMERO QUE SALIO Y SE PONE EL NUMERO 1 TAMBIEN ABAJO DEL DADO
            if (dado1 == 1)
            {
                picDado1.Image = Properties.Resources.dado1;
                lblDado1.Text = dado1.ToString();
            }
            if (dado1 == 2)
            {
                picDado1.Image = Properties.Resources.dado2;
                lblDado1.Text = dado1.ToString();
            }
            if (dado1 == 3)
            {
                picDado1.Image = Properties.Resources.dado3;
                lblDado1.Text = dado1.ToString();
            }
            if (dado1 == 4)
            {
                picDado1.Image = Properties.Resources.dado4;
                lblDado1.Text = dado1.ToString();
            }
            if (dado1 == 5)
            {
                picDado1.Image = Properties.Resources.dado5;
                lblDado1.Text = dado1.ToString();
            }
            if (dado1 == 6)
            {
                picDado1.Image = Properties.Resources.dado6;
                lblDado1.Text = dado1.ToString();
            }
            // AL DADO 2 LE PONEMOS LA IMAGEN AL AZAR DEL NUMERO QUE SALIO Y SE PONE EL NUMERO 1 TAMBIEN ABAJO DEL DADO
            if (dado2 == 1)
            {
                picDado2.Image = Properties.Resources.dado1;
                lblDado2.Text = dado2.ToString();
            }
            if (dado2 == 2)
            {
                picDado2.Image = Properties.Resources.dado2;
                lblDado2.Text = dado2.ToString();
            }
            if (dado2 == 3)
            {
                picDado2.Image = Properties.Resources.dado3;
                lblDado2.Text = dado2.ToString();
            }
            if (dado2 == 4)
            {
                picDado2.Image = Properties.Resources.dado4;
                lblDado2.Text = dado2.ToString();
            }
            if (dado2 == 5)
            {
                picDado2.Image = Properties.Resources.dado5;
                lblDado2.Text = dado2.ToString();
            }
            if (dado2 == 6)
            {
                picDado2.Image = Properties.Resources.dado6;
                lblDado2.Text = dado2.ToString();
            }
            // AL DADO 3 LE PONEMOS LA IMAGEN AL AZAR DEL NUMERO QUE SALIO Y SE PONE EL NUMERO 1 TAMBIEN ABAJO DEL DADO
            if (dado3 == 1)
            {
                picDado3.Image = Properties.Resources.dado1;
                lblDado3.Text = dado3.ToString();
            }
            if (dado3 == 2)
            {
                picDado3.Image = Properties.Resources.dado2;
                lblDado3.Text = dado3.ToString();
            }
            if (dado3 == 3)
            {
                picDado3.Image = Properties.Resources.dado3;
                lblDado3.Text = dado3.ToString();
            }
            if (dado3 == 4)
            {
                picDado3.Image = Properties.Resources.dado4;
                lblDado3.Text = dado3.ToString();
            }
            if (dado3 == 5)
            {
                picDado3.Image = Properties.Resources.dado5;
                lblDado3.Text = dado3.ToString();
            }
            if (dado3 == 6)
            {
                picDado3.Image = Properties.Resources.dado6;
                lblDado3.Text = dado3.ToString();
            }
            // AL DADO 4 LE PONEMOS LA IMAGEN AL AZAR DEL NUMERO QUE SALIO Y SE PONE EL NUMERO 1 TAMBIEN ABAJO DEL DADO
            if (dado4 == 1)
            {
                picDado4.Image = Properties.Resources.dado1;
                lblDado4.Text = dado4.ToString();
            }
            if (dado4 == 2)
            {
                picDado4.Image = Properties.Resources.dado2;
                lblDado4.Text = dado4.ToString();
            }
            if (dado4 == 3)
            {
                picDado4.Image = Properties.Resources.dado3;
                lblDado4.Text = dado4.ToString();
            }
            if (dado4 == 4)
            {
                picDado4.Image = Properties.Resources.dado4;
                lblDado4.Text = dado4.ToString();
            }
            if (dado4 == 5)
            {
                picDado4.Image = Properties.Resources.dado5;
                lblDado4.Text = dado4.ToString();
            }
            if (dado4 == 6)
            {
                picDado4.Image = Properties.Resources.dado6;
                lblDado4.Text = dado4.ToString();
            }
            // AL DADO 5 LE PONEMOS LA IMAGEN AL AZAR DEL NUMERO QUE SALIO Y SE PONE EL NUMERO 1 TAMBIEN ABAJO DEL DADO
            if (dado5 == 1)
            {
                picDado5.Image = Properties.Resources.dado1;
                lblDado5.Text = dado5.ToString();
            }
            if (dado5 == 2)
            {
                picDado5.Image = Properties.Resources.dado2;
                lblDado5.Text = dado5.ToString();
            }
            if (dado5 == 3)
            {
                picDado5.Image = Properties.Resources.dado3;
                lblDado5.Text = dado5.ToString();
            }
            if (dado5 == 4)
            {
                picDado5.Image = Properties.Resources.dado4;
                lblDado5.Text = dado5.ToString();
            }
            if (dado5 == 5)
            {
                picDado5.Image = Properties.Resources.dado5;
                lblDado5.Text = dado5.ToString();
            }
            if (dado5 == 6)
            {
                picDado5.Image = Properties.Resources.dado6;
                lblDado5.Text = dado5.ToString();
            }
            //SI HACE GENERALA SE LE SUMA PUNTOS AL JUGADOR Y SE CAMBIA COLOR DEL BOTON
            if (dado1 == dado2 && dado1 == dado3 && dado1 == dado4 && dado1 == dado5)
            {
                if (turno == jugador1) { 
                MessageBox.Show(jugador1+" HIZO GENERALA");
                btnGeneJug1.BackColor = Color.Green;
                puntoGene = 50;
                txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO GENERALA");
                    btnGeneJug2.BackColor = Color.Green;
                    puntoGene2 = 50;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            //SI HACE GENERALA DOBLE SE LE SUMA PUNTOS AL JUGADOR Y SE CAMBIA COLOR DEL BOTON
            else if (dado1 == dado2 && dado1 == dado3 && dado1 == dado4 && dado1 == dado5 && dado1 == 1 && dado2 == 1 && dado3 == 1 && dado4 ==1 && dado5 ==1)
            {
                if (turno == jugador1) {
                MessageBox.Show(jugador1 + " HIZO DOBLE GENERALA");
                btnDobJug1.BackColor = Color.Green;
                puntoDoble = 100;
                txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO DOBLE GENERALA");
                    btnDobJug2.BackColor = Color.Green;
                    puntoDoble2 = 100;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }

            //SI HACE POKER SE LE SUMA PUNTOS AL JUGADOR Y SE CAMBIA COLOR DEL BOTON
            else if (dado1 == dado2 && dado1 == dado3 && dado1 == dado4)
            {
                if (turno == jugador1)
                {
                    MessageBox.Show(jugador1 +" HIZO POKER");
                    btnPokJug1.BackColor = Color.Green;
                    puntoPoker = 40;
                    txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO POKER");
                    btnPokJug2.BackColor = Color.Green;
                    puntoPoker2 = 40;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            else if(dado1 == dado3 && dado1 == dado4 && dado1 == dado5)
            {
                if (turno == jugador1)
                {
                    MessageBox.Show(jugador1 +" HIZO POKER");
                    btnPokJug1.BackColor = Color.Green;
                    puntoPoker = 40;
                    txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO POKER");
                    btnPokJug2.BackColor = Color.Green;
                    puntoPoker2 = 40;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            else if(dado1 == dado2 && dado1 == dado4 && dado1 == dado5)
            {
                if (turno == jugador1)
                {
                    MessageBox.Show(jugador1 +" HIZO POKER");
                    btnPokJug1.BackColor = Color.Green;
                    puntoPoker = 40;
                    txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO POKER");
                    btnPokJug2.BackColor = Color.Green;
                    puntoPoker2 = 40;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            else if(dado1 == dado2 && dado1 == dado3 && dado1 == dado5)
            {
                if (turno == jugador1)
                {
                    MessageBox.Show(jugador1 +" HIZO POKER");
                    btnPokJug1.BackColor = Color.Green;
                    puntoPoker = 40;
                    txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO POKER");
                    btnPokJug2.BackColor = Color.Green;
                    puntoPoker2 = 40;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            else if(dado2 == dado3 && dado2 == dado4 && dado2 == dado5)
            {
                if (turno == jugador1) { 
                MessageBox.Show(jugador1 +" HIZO POKER");
                btnPokJug1.BackColor = Color.Green;
                puntoPoker = 40;
                txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO POKER");
                    btnPokJug2.BackColor = Color.Green;
                    puntoPoker2 = 40;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            //SI HACE FULL SE LE SUMA PUNTOS AL JUGADOR Y SE CAMBIA COLOR DEL BOTON
            else if (dado1 == dado2 && dado1 == dado3 && dado4 == dado5)
            {
                if (turno == jugador1)
                {
                    MessageBox.Show(jugador1 +" HIZO FULL");
                    btnFullJug1.BackColor = Color.Green;
                    puntoFull = 30;
                    txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO FULL");
                    btnFullJug2.BackColor = Color.Green;
                    puntoFull2 = 30;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            else if(dado1 == dado2 && dado1 == dado4 && dado3 == dado5)
            {
                if (turno == jugador1)
                {
                    MessageBox.Show(jugador1 +" HIZO FULL");
                    btnFullJug1.BackColor = Color.Green;
                    puntoFull = 30;
                    txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO FULL");
                    btnFullJug2.BackColor = Color.Green;
                    puntoFull2 = 30;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            else if(dado1 == dado2 && dado1 == dado5 && dado4 == dado3)
            {
                if (turno == jugador1)
                {
                    MessageBox.Show(jugador1 +" HIZO FULL");
                    btnFullJug1.BackColor = Color.Green;
                    puntoFull = 30;
                    txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO FULL");
                    btnFullJug2.BackColor = Color.Green;
                    puntoFull2 = 30;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            else if(dado1 == dado3 && dado1 == dado5 && dado4 == dado2)
            {
                if (turno == jugador1)
                {
                    MessageBox.Show(jugador1 +" HIZO FULL");
                    btnFullJug1.BackColor = Color.Green;
                    puntoFull = 30;
                    txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO FULL");
                    btnFullJug2.BackColor = Color.Green;
                    puntoFull2 = 30;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            else if(dado3 == dado4 && dado3 == dado5 && dado1 == dado2)
            {
              
                    if (turno == jugador1)
                    {
                        MessageBox.Show(jugador1 +" HIZO FULL");
                        btnFullJug1.BackColor = Color.Green;
                        puntoFull = 30;
                        txtPuntos1.Text = puntuacion.ToString();
                    }
                    if (turno == jugador2)
                    {
                        MessageBox.Show(jugador2 +" HIZO FULL");
                        btnFullJug2.BackColor = Color.Green;
                        puntoFull2 = 30;
                        txtPuntos2.Text = puntuacion2.ToString();
                    }
                }
            
            else if(dado2 == dado3 && dado2 == dado4 && dado1 == dado5)
            {
                if (turno == jugador1)
                {
                    MessageBox.Show(jugador1 +" HIZO FULL");
                    btnFullJug1.BackColor = Color.Green;
                    puntoFull = 30;
                    txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO FULL");
                    btnFullJug2.BackColor = Color.Green;
                    puntoFull2 = 30;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            else if(dado2 == dado4 && dado2 == dado5 && dado1 == dado3)
            {
                if (turno == jugador1) {
                MessageBox.Show(jugador1 +" HIZO FULL");
                btnFullJug1.BackColor = Color.Green;
                puntoFull = 30;
                txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO FULL");
                    btnFullJug2.BackColor = Color.Green;
                    puntoFull2 = 30;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }

            //SI HACE ESCALERA SE LE SUMA PUNTOS AL JUGADOR Y SE CAMBIA COLOR DEL BOTON
            else if (dado1 != dado2  && dado1 != dado3 && dado1 != dado4 && dado1 != dado5 && dado2 != dado3 && dado2!=dado4 && dado2 != dado5 && dado2 != dado1 && dado3!=dado1 && dado3 != dado2 && dado3 != dado4 && dado3 != dado5 && dado4 != dado1 && dado4 != dado2 && dado4 != dado3 && dado4 != dado5 && dado5 != dado1 && dado5 != dado2 && dado5 != dado3 && dado5 != dado4)
            {
                if (turno == jugador1) { 
                MessageBox.Show(jugador1 +" HIZO ESCALERA");
                btnEscaJug1.BackColor = Color.Green;
                puntoEsc = 20;
                txtPuntos1.Text = puntuacion.ToString();
                }
                if (turno == jugador2)
                {
                    MessageBox.Show(jugador2 +" HIZO ESCALERA");
                    btnEscaJug2.BackColor = Color.Green;
                    puntoEsc2 = 20;
                    txtPuntos2.Text = puntuacion2.ToString();
                }
            }
            //SE SUMA DE A UNO AL CONTADOR
            //SE SUMA LA PUNTUACION DE CADA JUGADOR Y SE LA ASIGAN A SU TXT
           
                contador++;
                puntuacion = puntoEsc + puntoFull + puntoPoker + puntoGene + puntoDoble;
                txtPuntos1.Text = puntuacion.ToString();
                puntuacion2 = puntoEsc2 + puntoFull2 + puntoPoker2 + puntoGene2 + puntoDoble2;
                txtPuntos2.Text = puntuacion2.ToString();

                txtContador.Text = contador.ToString();

            
            //CUANDO EL CONTADOR LLEGA A 30 SE TERMINA EL JUEGO
            //EL QUE TIENE MAS PUNTOS GANA Y SE PASA A EL FORM GANADOR (EN EMPATE TAMBIEN)
            if (contador == 30)
            {
                MessageBox.Show("TERMINÓ EL JUEGO");
                if (puntuacion > puntuacion2)
                {
                    ganador = jugador1;
                    MessageBox.Show("HA GANADO "+ganador);
                    Ganador ganador1 = new Ganador();
                    this.Hide();
                    ganador1.lblGanar.Text = txtJugador1.Text;
                    ganador1.ShowDialog();
                   
                }
                else if (puntuacion < puntuacion2)
                {
                    ganador = jugador2;
                    MessageBox.Show("HA GANADO " + ganador);
                    Ganador ganador2 = new Ganador();
                    this.Hide();
                    ganador2.lblGanar.Text = txtJugador2.Text;
                    ganador2.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("FUE UN EMPATE");
                    Ganador empate = new Ganador();
                    this.Hide();
                    empate.lblFelicidades.Text = "EMPATARON";

                    empate.lblTxtGanaste.Text= "REINTENTEN";
                    empate.ShowDialog();
                }
            }

           
        }
        
          
        private void Jugar2_Load(object sender, EventArgs e)
        {
          
        }

        //CUANDO APRIETA EL BOTON SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir de la generala?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }


    }
}
