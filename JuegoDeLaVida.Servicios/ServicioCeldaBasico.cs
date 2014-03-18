using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JuegoDeLaVida.Graphics;
using JuegoDeLaVida.Persistencia;
using System.Drawing;

namespace JuegoDeLaVida.Servicios
{
    public class ServicioCeldaBasico : IServicioCelda
    {
        private ITablero tablero;
        private static readonly ServicioCeldaBasico instancia = new ServicioCeldaBasico();

        private ServicioCeldaBasico()
        {            
        }

        public static ServicioCeldaBasico Instancia
        {
            get
            {
                return instancia;
            }
        }

        public void setTablero(ITablero tablero)
        {
            this.tablero = tablero;
        }


        private int NumeroVecinosVivos(int fila, int columna)
        {
            int contadorVecinosVivos = 0;
            int indiceDeFila;
            int indiceDeColumna;

            for (int numeroDeFilaASumar = -1; numeroDeFilaASumar <= 1; numeroDeFilaASumar++)
            {
                indiceDeFila = numeroDeFilaASumar + fila;
                if (indiceDeFila >= 0 && indiceDeFila < this.tablero.Tamano.Height)
                {
                    for (int numeroDeColumnaASumar = -1; numeroDeColumnaASumar <= 1; numeroDeColumnaASumar++)
                    {
                        indiceDeColumna = numeroDeColumnaASumar + columna;
                        if (indiceDeColumna >= 0 && indiceDeColumna < this.tablero.Tamano.Width)
                        {
                            if (CelulaEstaViva[indiceDeFila, indiceDeColumna].Viva && (indiceDeFila != fila || indiceDeColumna != columna))
                                contadorVecinosVivos++;
                        }
                    }
                }
            }

            return contadorVecinosVivos;
        }

        public bool NuevoEstadoCelula(int fila, int columna)
        {
            bool estaViva;

            int numeroVecinosVivos = NumeroVecinosVivos(fila, columna);

            if (numeroVecinosVivos == 3)
            {
                estaViva = true;
            }
            else if (numeroVecinosVivos != 2)
            {
                estaViva = false;
            }
            else
            {
                estaViva = CelulaEstaViva[fila, columna].Viva;
            }

            return estaViva;
        }

        public ICelda[,] CelulaEstaViva
        {
            get
            {
                return this.tablero.Celdas;
            }
        }
    }
}
