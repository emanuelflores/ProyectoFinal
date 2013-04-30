using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Juego_de_la_serpiente
{
    public class Comida
    {
        private int x, y, ancho, largo;
        private SolidBrush brocha;
        public Rectangle RecComida;

        public Comida(Random RandComida)
        {
            x = RandComida.Next(0, 29) * 10;
            y = RandComida.Next(0, 26) * 10;

            brocha = new SolidBrush(Color.Red);

            ancho = 10;
            largo = 10;

            RecComida = new Rectangle(x, y, ancho, largo);
        }

        public void PosicionComida(Random RandComida)
        {
            x = RandComida.Next(0, 29) * 10;
            y = RandComida.Next(0, 26) * 10;
        }

        public void DibComida(Graphics papel)
        {
            RecComida.X = x;
            RecComida.Y = y;

            papel.FillRectangle(brocha, RecComida);
        }

    }
}
