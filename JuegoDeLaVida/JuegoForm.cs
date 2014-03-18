using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Threading;
using JuegoDeLaVida.Servicios;
using JuegoDeLaVida.Graphics;
using JuegoDeLaVida.Persistencia;

namespace JuegoDeLaVida
{
    public partial class JuegoForm : Form
    {
        delegate bool RevisorCeldaDelegado(int fila, int columna);
        delegate void DibujaTableroDelegado(object sender, PaintEventArgs e);

        private ICelda[,] celulaViva;

        RevisorCeldaDelegado revisaNuevoEstado;

        int filas;
        int columnas;
        bool ejecutando;

        private ITablero tablero;

        public JuegoForm()
        {
            filas = 300;
            columnas = 240;
            InitializeComponent();            
            
            this.tablero = new Tablero(new Size(columnas, filas));
            this.tablero.SetDimensiones(new Rectangle(0, 0, this.contenedorTablero.ClientSize.Width, this.contenedorTablero.ClientSize.Height));

            IServicioCelda servicio = ServicioCeldaBasico.Instancia;
            servicio.setTablero(tablero);
            revisaNuevoEstado = servicio.NuevoEstadoCelula;   
         
            celulaViva = tablero.Celdas;
            ToggleIniciarDetenerHbilitado();
            Refresh();
        }

        private void workerProceso_DoWork(object sender, DoWorkEventArgs e)
        {
            ICelda[,] celulaVivaTemp;
            celulaVivaTemp = CopiadorGenerico<ICelda[,]>.DeepCopy(celulaViva);

            while (ejecutando)
            {
                for (int filaActual = 0; filaActual < filas; filaActual++)
                {
                    for (int columnaActual = 0; columnaActual < columnas; columnaActual++)
                    {
                        celulaVivaTemp[filaActual, columnaActual].Viva = revisaNuevoEstado(filaActual, columnaActual);
                    }
                }
                for (int filaActual = 0; filaActual < filas; filaActual++)
                {
                    for (int columnaActual = 0; columnaActual < columnas; columnaActual++)
                    {
                        celulaViva[filaActual, columnaActual].Viva = celulaVivaTemp[filaActual, columnaActual].Viva;
                    }
                }
                workerProceso.ReportProgress(1);

                Thread.Sleep(100);
            }
        }

        private void workerProceso_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Refresh();
        }

        private void JuegoForm_Resize(object sender, EventArgs e)
        {
            this.tablero.SetDimensiones(new Rectangle(0, 0, this.contenedorTablero.ClientSize.Width, this.contenedorTablero.ClientSize.Height));
            Refresh();
        }
        
        private void contenedorTablero_MouseClick(object sender, MouseEventArgs e)
        {
            for (int filaActual = 0; filaActual < this.tablero.Tamano.Height; filaActual++)
            {
                for (int columnaActual = 0; columnaActual < this.tablero.Tamano.Width; columnaActual++)
                {
                    if (this.tablero.Celdas[filaActual, columnaActual].Limites.Contains(e.X, e.Y))
                    {
                        OperacionesCelda.CambiaEstado(this.tablero.Celdas[filaActual, columnaActual]);
                        Refresh();
                    }
                }
            }
        }

        private void contenedorTablero_Paint(object sender, PaintEventArgs e)
        {
            for (int filaActual = 0; filaActual < this.tablero.Tamano.Height; filaActual++)
            {
                for (int columnaActual = 0; columnaActual < this.tablero.Tamano.Width; columnaActual++)
                {
                    if (this.tablero.Celdas[filaActual, columnaActual].Viva)
                    {
                        e.Graphics.FillRectangle(System.Drawing.Brushes.Black, this.tablero.Celdas[filaActual, columnaActual].Limites);
                    }
                    else if (!this.tablero.Celdas[filaActual, columnaActual].Viva)
                    {
                        e.Graphics.FillRectangle(System.Drawing.Brushes.White, this.tablero.Celdas[filaActual, columnaActual].Limites);
                    }
                        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, this.tablero.Celdas[filaActual, columnaActual].Limites);                    
                }
            }
        }

        private void iniciarMenuPrincipal_Click(object sender, EventArgs e)
        {
            ejecutando = true;
            ToggleIniciarDetenerHbilitado();
            this.workerProceso.RunWorkerAsync();
        }

        private void detenerMenuPrincipal_Click(object sender, EventArgs e)
        {
            ejecutando = false;
            ToggleIniciarDetenerHbilitado();
        }

        private void ToggleIniciarDetenerHbilitado()
        {
            iniciarToolStripMenuItem.Enabled = !ejecutando;
            detenerToolStripMenuItem.Enabled = ejecutando;
        }
    }
}
