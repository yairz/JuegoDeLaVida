using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace JuegoDeLaVida.Persistencia
{
    public interface ICelda
    {
        bool Viva { get; set; }
        Rectangle Limites { get;}
        void SetDimensiones (Rectangle limites);
    }
}
