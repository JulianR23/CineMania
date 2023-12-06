namespace CineMania
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actualizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresar = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistente = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedades = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.menuStrip1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1068, 577);
            this.panelPrincipal.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(10, 10, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizacion,
            this.asistente,
            this.consulta,
            this.novedades,
            this.salirToolStripMenuItem,
            this.webToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1064, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actualizacion
            // 
            this.actualizacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresar,
            this.eliminarPelicula,
            this.cambiarDatosToolStripMenuItem});
            this.actualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.actualizacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.actualizacion.Name = "actualizacion";
            this.actualizacion.Size = new System.Drawing.Size(103, 21);
            this.actualizacion.Text = "Actualización";
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ingresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(223, 22);
            this.ingresar.Text = "Ingresar nueva pelicula";
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // eliminarPelicula
            // 
            this.eliminarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.eliminarPelicula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminarPelicula.Name = "eliminarPelicula";
            this.eliminarPelicula.Size = new System.Drawing.Size(223, 22);
            this.eliminarPelicula.Text = "Eliminar pelicula";
            this.eliminarPelicula.Click += new System.EventHandler(this.eliminarPelicula_Click);
            // 
            // cambiarDatosToolStripMenuItem
            // 
            this.cambiarDatosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.cambiarDatosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cambiarDatosToolStripMenuItem.Name = "cambiarDatosToolStripMenuItem";
            this.cambiarDatosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.cambiarDatosToolStripMenuItem.Text = "Actualizar";
            this.cambiarDatosToolStripMenuItem.Click += new System.EventHandler(this.cambiarDatosToolStripMenuItem_Click);
            // 
            // asistente
            // 
            this.asistente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestroDetalleToolStripMenuItem,
            this.vToolStripMenuItem,
            this.asistenteToolStripMenuItem});
            this.asistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.asistente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.asistente.Name = "asistente";
            this.asistente.Size = new System.Drawing.Size(78, 21);
            this.asistente.Text = "Asistente";
            // 
            // maestroDetalleToolStripMenuItem
            // 
            this.maestroDetalleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.maestroDetalleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maestroDetalleToolStripMenuItem.Name = "maestroDetalleToolStripMenuItem";
            this.maestroDetalleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.maestroDetalleToolStripMenuItem.Text = "Peliculas por sección";
            this.maestroDetalleToolStripMenuItem.Click += new System.EventHandler(this.maestroDetalleToolStripMenuItem_Click);
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.vToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.vToolStripMenuItem.Text = "Todas las peliculas";
            this.vToolStripMenuItem.Click += new System.EventHandler(this.vToolStripMenuItem_Click);
            // 
            // asistenteToolStripMenuItem
            // 
            this.asistenteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.asistenteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.asistenteToolStripMenuItem.Name = "asistenteToolStripMenuItem";
            this.asistenteToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.asistenteToolStripMenuItem.Text = "Asistente";
            this.asistenteToolStripMenuItem.Click += new System.EventHandler(this.asistenteToolStripMenuItem_Click);
            // 
            // consulta
            // 
            this.consulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoToolStripMenuItem,
            this.nombreToolStripMenuItem});
            this.consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.consulta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(75, 21);
            this.consulta.Text = "Consulta";
            // 
            // codigoToolStripMenuItem
            // 
            this.codigoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.codigoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            this.codigoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.codigoToolStripMenuItem.Text = "Codigo";
            this.codigoToolStripMenuItem.Click += new System.EventHandler(this.codigoToolStripMenuItem_Click);
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.nombreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.nombreToolStripMenuItem.Text = "Nombre";
            this.nombreToolStripMenuItem.Click += new System.EventHandler(this.nombreToolStripMenuItem_Click);
            // 
            // novedades
            // 
            this.novedades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoToolStripMenuItem,
            this.entregaToolStripMenuItem});
            this.novedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.novedades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.novedades.Name = "novedades";
            this.novedades.Size = new System.Drawing.Size(92, 21);
            this.novedades.Text = "Novedades";
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.prestamoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.prestamoToolStripMenuItem.Text = "Prestamo";
            this.prestamoToolStripMenuItem.Click += new System.EventHandler(this.prestamoToolStripMenuItem_Click);
            // 
            // entregaToolStripMenuItem
            // 
            this.entregaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.entregaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.entregaToolStripMenuItem.Name = "entregaToolStripMenuItem";
            this.entregaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.entregaToolStripMenuItem.Text = "Entrega";
            this.entregaToolStripMenuItem.Click += new System.EventHandler(this.entregaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.webToolStripMenuItem.Text = "Web";
            this.webToolStripMenuItem.Click += new System.EventHandler(this.webToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cerrarSesiónToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 577);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineMania";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asistente;
        private System.Windows.Forms.ToolStripMenuItem consulta;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacion;
        private System.Windows.Forms.ToolStripMenuItem ingresar;
        private System.Windows.Forms.ToolStripMenuItem eliminarPelicula;
        private System.Windows.Forms.ToolStripMenuItem cambiarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedades;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestroDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}