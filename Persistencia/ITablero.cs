using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace JuegoDeLaVida.Persistencia
{
    public interface ITablero
    {
        Size Tamano { get; }
        ICelda[,] Celdas { get;}
        void SetDimensiones(Rectangle limites);
    }
}
