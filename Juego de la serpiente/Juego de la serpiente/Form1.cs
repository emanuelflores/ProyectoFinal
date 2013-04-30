using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Juego_de_la_serpiente
{
    public partial class Form1 : Form
    {
        

        Random RandComida = new Random();
        Graphics papel;
        Serpiente serpiente = new Serpiente();
        Comida comida;

        bool izquierda = false;
        bool derecha = false;
        bool abajo = false;
        bool arriba = false;

        int puntuacion = 0;

        public Form1()
        {
            InitializeComponent();
            comida = new Comida(RandComida);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            papel = e.Graphics;
            comida.DibComida(papel);
            serpiente.DibujarSerp(papel);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                timer1.Enabled = true;
                BarraPresionarEnter.Text = "";
                abajo = false;
                arriba = false;
                derecha = false;
                izquierda = false;
            }

            if (e.KeyData == Keys.Down && arriba == false)
            {
                abajo = true;
                arriba = false;
                derecha = false;
                izquierda = false;
            }
            if (e.KeyData == Keys.Up && abajo == false)
            {
                abajo = false;
                arriba = true;
                derecha = false;
                izquierda = false;
            }
            if (e.KeyData == Keys.Right && izquierda == false)
            {
                abajo = false;
                arriba = false;
                derecha = true;
                izquierda = false;
            }
            if (e.KeyData == Keys.Left && derecha == false)
            {
                abajo = false;
                arriba = false;
                derecha = false;
                izquierda = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarraPuntuacionSerpiente.Text = Convert.ToString(puntuacion);

            if (abajo) { serpiente.MoverAbajo(); }
            if (arriba) { serpiente.MoverArriba(); }
            if (derecha) { serpiente.MoverDerecha(); }
            if (izquierda) { serpiente.MoverIzquierda(); }

            for (int i = 0; i < serpiente.recSerpiente.Length; i++)
            {
                if (serpiente.recSerpiente[i].IntersectsWith(comida.RecComida))
                {
                    puntuacion += 10;
                    serpiente.AumentarSerp();
                    comida.PosicionComida(RandComida);
                }
            }

            Colision();
            Ganar();
            
            this.Invalidate();

        }

        public void Colision()
        {
            for (int i = 1; i < serpiente.recSerpiente.Length; i++)
            {
                if (serpiente.recSerpiente[0].IntersectsWith(serpiente.recSerpiente[i]))
                {
                    Reiniciar();
                }
            }

            if (serpiente.recSerpiente[0].X < 0 || serpiente.recSerpiente[0].X > 280)
            {
                Reiniciar();
            }

            if (serpiente.recSerpiente[0].Y < 0 || serpiente.recSerpiente[0].Y > 265)
            {
                Reiniciar();
            }

        }

        public void Reiniciar()
        {
            timer1.Enabled = false;
            MessageBox.Show("Perdiste. \nTu Puntuacion es " + puntuacion);

            BarraPuntuacionSerpiente.Text = "0";
            puntuacion = 0;
            BarraPresionarEnter.Text = "Presiona Enter para iniciar";
            serpiente = new Serpiente();

        }

        public void Ganar()
        {
            if (puntuacion == 100)
            {
                timer1.Enabled = false;
                MessageBox.Show("Ganaste el juego\n Tu puntuacion es: " + puntuacion);
                BarraPuntuacionSerpiente.Text = "0";
                puntuacion = 0;
                BarraPresionarEnter.Text = "Presiona Enter para iniciar";
                serpiente = new Serpiente();
            }   
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*public void Resultados()
        {
            


        }*/

    }
}



       

                
    

