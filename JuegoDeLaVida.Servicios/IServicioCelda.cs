using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JuegoDeLaVida.Graphics;
using JuegoDeLaVida.Persistencia;

namespace JuegoDeLaVida.Servicios
{
    public interface IServicioCelda
    {
        bool NuevoEstadoCelula(int fila, int columna);
        ICelda[,] CelulaEstaViva { get;}
        void setTablero(ITablero tablero);
    }
}
