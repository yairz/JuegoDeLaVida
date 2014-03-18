using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using JuegoDeLaVida.Persistencia;

namespace JuegoDeLaVida.Graphics
{
    public class Tablero : ITablero
    {
        public ICelda[,] Celdas { get; private set; }
        public Size Tamano { get; private set; }
        public Rectangle Limites { get; private set; }

        public Tablero(Size tamanoTablero)
        {
            this.Tamano = tamanoTablero;
            this.Celdas = new Celda[this.Tamano.Height, this.Tamano.Width];

            for (int filaActual = 0; filaActual < this.Tamano.Height; filaActual++)
            {
                for (int columnaActual = 0; columnaActual < this.Tamano.Width; columnaActual++)
                {
                    this.Celdas[filaActual, columnaActual] = new Celda();
                }
            }
        }

        public void SetDimensiones(Rectangle limites)
        {
            Size tamano;

            this.Limites = limites;
            tamano = new Size((int)(((float)limites.Width) / ((float)this.Tamano.Width)), (int)(((float)limites.Height) / ((float)this.Tamano.Height)));

            for (int filaActual = 0; filaActual < this.Tamano.Height; filaActual++)
            {
                for (int columnaActual = 0; columnaActual < this.Tamano.Width; columnaActual++)
                {
                    this.Celdas[filaActual, columnaActual].SetDimensiones(new Rectangle(limites.Left + (tamano.Width * columnaActual), limites.Top + (tamano.Height * filaActual), tamano.Width, tamano.Height));
                }
            }
        }
    }
}
