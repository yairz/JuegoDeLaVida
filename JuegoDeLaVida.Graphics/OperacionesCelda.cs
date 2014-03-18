using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JuegoDeLaVida.Persistencia;

namespace JuegoDeLaVida.Graphics
{
    public static class OperacionesCelda
    {
        public static void CambiaEstado(ICelda celda)
        {
            celda.Viva = !celda.Viva;
        }
    }
}
