namespace JuegoDeLaVida
{
    partial class JuegoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.workerProceso = new System.ComponentModel.BackgroundWorker();
            this.contenedorTablero = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.contenedorTablero)).BeginInit();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerProceso
            // 
            this.workerProceso.WorkerReportsProgress = true;
            this.workerProceso.WorkerSupportsCancellation = true;
            this.workerProceso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerProceso_DoWork);
            this.workerProceso.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerProceso_ProgressChanged);
            // 
            // contenedorTablero
            // 
            this.contenedorTablero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorTablero.Location = new System.Drawing.Point(0, 24);
            this.contenedorTablero.Margin = new System.Windows.Forms.Padding(0);
            this.contenedorTablero.Name = "contenedorTablero";
            this.contenedorTablero.Size = new System.Drawing.Size(684, 638);
            this.contenedorTablero.TabIndex = 0;
            this.contenedorTablero.TabStop = false;
            this.contenedorTablero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contenedorTablero_MouseClick);
            this.contenedorTablero.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedorTablero_Paint);
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(684, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarMenuPrincipal_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerMenuPrincipal_Click);
            // 
            // JuegoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 662);
            this.Controls.Add(this.contenedorTablero);
            this.Controls.Add(this.MenuPrincipal);
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "JuegoForm";
            this.Text = "Juego de la vida 1.0";
            this.Resize += new System.EventHandler(this.JuegoForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.contenedorTablero)).EndInit();
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker workerProceso;
        private System.Windows.Forms.PictureBox contenedorTablero;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
    }
}

