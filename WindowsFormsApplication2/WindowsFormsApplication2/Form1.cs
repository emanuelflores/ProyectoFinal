using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int turno = 0;

        public void Limpiar()
        {
            imagen1o.Visible = false;
            imagen1x.Visible = false;
            imagen2o.Visible = false;
            imagen2x.Visible = false;
            imagen3o.Visible = false;
            imagen3x.Visible = false;
            imagen4o.Visible = false;
            imagen4x.Visible = false;
            imagen5o.Visible = false;
            imagen5x.Visible = false;
            imagen6o.Visible = false;
            imagen6x.Visible = false;
            imagen7o.Visible = false;
            imagen7x.Visible = false;
            imagen8o.Visible = false;
            imagen8x.Visible = false;
            imagen9o.Visible = false;
            imagen9x.Visible = false;
        }

        public void gano()
        {
            if (((imagen1x.Visible == true) && (imagen2x.Visible == true) && (imagen3x.Visible == true)) ||
                ((imagen1x.Visible == true) && (imagen5x.Visible == true) && (imagen9x.Visible == true)) ||
                ((imagen1x.Visible == true) && (imagen4x.Visible == true) && (imagen7x.Visible == true)) ||
                ((imagen2x.Visible == true) && (imagen5x.Visible == true) && (imagen8x.Visible == true)) ||
                ((imagen3x.Visible == true) && (imagen6x.Visible == true) && (imagen9x.Visible == true)) ||
                ((imagen3x.Visible == true) && (imagen5x.Visible == true) && (imagen7x.Visible == true)) ||
                ((imagen4x.Visible == true) && (imagen5x.Visible == true) && (imagen6x.Visible == true)) ||
                ((imagen7x.Visible == true) && (imagen8x.Visible == true) && (imagen9x.Visible == true)))
            {
                MessageBox.Show("Felicidades, Gano la X");
            }


            else if (((imagen1o.Visible == true) && (imagen2o.Visible == true) && (imagen3o.Visible == true)) ||
                ((imagen1o.Visible == true) && (imagen5o.Visible == true) && (imagen9o.Visible == true)) ||
                ((imagen1o.Visible == true) && (imagen4o.Visible == true) && (imagen7o.Visible == true)) ||
                ((imagen2o.Visible == true) && (imagen5o.Visible == true) && (imagen8o.Visible == true)) ||
                ((imagen3o.Visible == true) && (imagen6o.Visible == true) && (imagen9o.Visible == true)) ||
                ((imagen3o.Visible == true) && (imagen5o.Visible == true) && (imagen7o.Visible == true)) ||
                ((imagen4o.Visible == true) && (imagen5o.Visible == true) && (imagen6o.Visible == true)) ||
                ((imagen7o.Visible == true) && (imagen8o.Visible == true) && (imagen9o.Visible == true)))
            {
                MessageBox.Show("Felicidades, Gano la O");
            }

        }

        public void bt1_Click(object sender, EventArgs e)
        {
            // si el turno es par lo va a tomar como X si no lo tomara como O
            if (turno % 2 == 0)
            {
                imagen1x.Visible = true;
                imagen1o.Visible = false;
            }
            else
            {
                imagen1x.Visible = false;
                imagen1o.Visible = true;
            }
            gano();
            turno++;
        }

        public void bt2_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen2x.Visible = true;
                imagen2o.Visible = false;
            }
            else
            {
                imagen2x.Visible = false;
                imagen2o.Visible = true;
            }
            gano();
            turno++;
        }

        public void bt3_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen3x.Visible = true;
                imagen3o.Visible = false;
            }
            else
            {
                imagen3x.Visible = false;
                imagen3o.Visible = true;
            }
            gano();
            turno++;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen4x.Visible = true;
                imagen4o.Visible = false;
            }
            else
            {
                imagen4x.Visible = false;
                imagen4o.Visible = true;
            }
            gano();
            turno++;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen5x.Visible = true;
                imagen5o.Visible = false;
            }
            else
            {
                imagen5x.Visible = false;
                imagen5o.Visible = true;
            }
            gano();
            turno++;
        }

        public void bt6_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen6x.Visible = true;
                imagen6o.Visible = false;
            }
            else
            {
                imagen6x.Visible = false;
                imagen6o.Visible = true;
            }
            gano();
            turno++;
        }

        public void bt7_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen7x.Visible = true;
                imagen7o.Visible = false;
            }
            else
            {
                imagen7x.Visible = false;
                imagen7o.Visible = true;
            }
            gano();
            turno++;
        }

        public void bt8_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen8x.Visible = true;
                imagen8o.Visible = false;
            }
            else
            {
                imagen8x.Visible = false;
                imagen8o.Visible = true;
            }
            gano();
            turno++;
        }

        public void bt9_Click(object sender, EventArgs e)
        {
            if (turno % 2 == 0)
            {
                imagen9x.Visible = true;
                imagen9o.Visible = false;
            }
            else
            {
                imagen9x.Visible = false;
                imagen9o.Visible = true;
            }
            gano();
            turno++;
        }

        
        public void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        
    }
}
