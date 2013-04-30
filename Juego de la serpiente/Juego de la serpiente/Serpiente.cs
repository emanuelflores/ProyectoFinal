using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Juego_de_la_serpiente
{
    public class Serpiente
    {
        private Rectangle[] RecSerpiente;
        private SolidBrush brocha;
        private int x, y, ancho, largo;

        public Rectangle[] recSerpiente
        {
            get { return RecSerpiente; }
        }

        public Serpiente()
        {
            RecSerpiente = new Rectangle[3];
            brocha = new SolidBrush(Color.Blue);

            x = 20;
            y = 0;
            ancho = 10;
            largo = 10;

            for (int i = 0; i < RecSerpiente.Length; i++)
            {
                RecSerpiente[i] = new Rectangle(x, y, ancho, largo);
                x -= 10;
            }
        }

        public void DibujarSerp(Graphics papel)
        {
            foreach (Rectangle rec in RecSerpiente)
            {
                papel.FillRectangle(brocha, rec);
            }

        }

        public void DibujarSerp()
        {
            for (int i = RecSerpiente.Length - 1; i > 0; i--)
            {
                RecSerpiente[i] = RecSerpiente[i - 1];
            }
        }

        public void MoverAbajo()
        {
            DibujarSerp();
            RecSerpiente[0].Y += 10;
        }

        public void MoverArriba()
        {
            DibujarSerp();
            RecSerpiente[0].Y -= 10;
        }

        public void MoverDerecha()
        {
            DibujarSerp();
            RecSerpiente[0].X += 10;
        }

        public void MoverIzquierda()
        {
            DibujarSerp();
            RecSerpiente[0].X -= 10;
        }

        public void AumentarSerp()
        {
            List<Rectangle> rec = RecSerpiente.ToList();
            rec.Add(new Rectangle(RecSerpiente[RecSerpiente.Length - 1].X, RecSerpiente[RecSerpiente.Length - 1].Y, ancho, largo));
            RecSerpiente = rec.ToArray();
        }

        }
}




