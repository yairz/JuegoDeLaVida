using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using JuegoDeLaVida.Persistencia;

namespace JuegoDeLaVida.Graphics
{
    [Serializable]
    public class Celda : ICelda
{
    public bool Viva { get; set; }   

    public Rectangle Limites { get; private set; }
    
    public Celda ()
    {
        this.Viva = false;
    }

    public void SetDimensiones (Rectangle limites)
    {
        this.Limites = limites;
    }
}
}
