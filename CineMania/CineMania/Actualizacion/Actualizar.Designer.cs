namespace CineMania.Actualizacion
{
    partial class Actualizar
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
            this.btCambiar = new System.Windows.Forms.Button();
            this.gbCambiar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txCambio = new System.Windows.Forms.TextBox();
            this.cbCambio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txCodSeccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btActu = new System.Windows.Forms.Button();
            this.gbCambiar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCambiar
            // 
            this.btCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCambiar.Location = new System.Drawing.Point(525, 146);
            this.btCambiar.Name = "btCambiar";
            this.btCambiar.Size = new System.Drawing.Size(85, 28);
            this.btCambiar.TabIndex = 39;
            this.btCambiar.Text = "Cambiar";
            this.btCambiar.UseVisualStyleBackColor = true;
            this.btCambiar.Click += new System.EventHandler(this.btCambiar_Click);
            // 
            // gbCambiar
            // 
            this.gbCambiar.Controls.Add(this.btActu);
            this.gbCambiar.Controls.Add(this.label4);
            this.gbCambiar.Controls.Add(this.txCambio);
            this.gbCambiar.Controls.Add(this.cbCambio);
            this.gbCambiar.Controls.Add(this.label1);
            this.gbCambiar.Location = new System.Drawing.Point(13, 265);
            this.gbCambiar.Name = "gbCambiar";
            this.gbCambiar.Size = new System.Drawing.Size(775, 152);
            this.gbCambiar.TabIndex = 40;
            this.gbCambiar.TabStop = false;
            this.gbCambiar.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(336, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "¿Por cual?";
            // 
            // txCambio
            // 
            this.txCambio.Location = new System.Drawing.Point(339, 67);
            this.txCambio.Name = "txCambio";
            this.txCambio.Size = new System.Drawing.Size(175, 20);
            this.txCambio.TabIndex = 3;
            // 
            // cbCambio
            // 
            this.cbCambio.FormattingEnabled = true;
            this.cbCambio.Items.AddRange(new object[] {
            "NOMBRE",
            "VALOR",
            "CODSECCION"});
            this.cbCambio.Location = new System.Drawing.Point(58, 67);
            this.cbCambio.Name = "cbCambio";
            this.cbCambio.Size = new System.Drawing.Size(190, 21);
            this.cbCambio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué campo desea actualizar?";
            // 
            // txCodSeccion
            // 
            this.txCodSeccion.Location = new System.Drawing.Point(326, 210);
            this.txCodSeccion.Name = "txCodSeccion";
            this.txCodSeccion.Size = new System.Drawing.Size(129, 20);
            this.txCodSeccion.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(235, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre";
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(525, 198);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(85, 28);
            this.btRegresar.TabIndex = 38;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(235, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Valor";
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(525, 91);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(85, 28);
            this.btBuscar.TabIndex = 37;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(183, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Código de la sección";
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(326, 82);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(129, 20);
            this.txCodigo.TabIndex = 33;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(326, 130);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(129, 20);
            this.txNombre.TabIndex = 34;
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(325, 171);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(129, 20);
            this.txValor.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(235, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(315, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Actualizar una pelicula";
            // 
            // btActu
            // 
            this.btActu.Location = new System.Drawing.Point(581, 58);
            this.btActu.Name = "btActu";
            this.btActu.Size = new System.Drawing.Size(75, 37);
            this.btActu.TabIndex = 24;
            this.btActu.Text = "Actualizar";
            this.btActu.UseVisualStyleBackColor = true;
            this.btActu.Click += new System.EventHandler(this.btActu_Click);
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btCambiar);
            this.Controls.Add(this.gbCambiar);
            this.Controls.Add(this.txCodSeccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.gbCambiar.ResumeLayout(false);
            this.gbCambiar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCambiar;
        private System.Windows.Forms.GroupBox gbCambiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCambio;
        private System.Windows.Forms.ComboBox cbCambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCodSeccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btActu;
    }
}