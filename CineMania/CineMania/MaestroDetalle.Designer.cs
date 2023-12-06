namespace CineMania
{
    partial class MaestroDetalle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaestroDetalle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODSECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPELICULACODSEC3E52440BBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sECCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cINEMANIADataSet = new CineMania.CINEMANIADataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sECCIONTableAdapter = new CineMania.CINEMANIADataSetTableAdapters.SECCIONTableAdapter();
            this.pELICULATableAdapter = new CineMania.CINEMANIADataSetTableAdapters.PELICULATableAdapter();
            this.btRegresar = new System.Windows.Forms.Button();
            this.Secciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPELICULACODSEC3E52440BBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cINEMANIADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.cODSECCIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKPELICULACODSEC3E52440BBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(204, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            // 
            // cODSECCIONDataGridViewTextBoxColumn
            // 
            this.cODSECCIONDataGridViewTextBoxColumn.DataPropertyName = "CODSECCION";
            this.cODSECCIONDataGridViewTextBoxColumn.HeaderText = "CODSECCION";
            this.cODSECCIONDataGridViewTextBoxColumn.Name = "cODSECCIONDataGridViewTextBoxColumn";
            // 
            // fKPELICULACODSEC3E52440BBindingSource
            // 
            this.fKPELICULACODSEC3E52440BBindingSource.DataMember = "FK__PELICULA__CODSEC__3E52440B";
            this.fKPELICULACODSEC3E52440BBindingSource.DataSource = this.sECCIONBindingSource;
            // 
            // sECCIONBindingSource
            // 
            this.sECCIONBindingSource.DataMember = "SECCION";
            this.sECCIONBindingSource.DataSource = this.cINEMANIADataSet;
            // 
            // cINEMANIADataSet
            // 
            this.cINEMANIADataSet.DataSetName = "CINEMANIADataSet";
            this.cINEMANIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sECCIONBindingSource;
            this.comboBox1.DisplayMember = "GENERO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(388, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // sECCIONTableAdapter
            // 
            this.sECCIONTableAdapter.ClearBeforeFill = true;
            // 
            // pELICULATableAdapter
            // 
            this.pELICULATableAdapter.ClearBeforeFill = true;
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(369, 365);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(94, 34);
            this.btRegresar.TabIndex = 2;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // Secciones
            // 
            this.Secciones.AutoSize = true;
            this.Secciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Secciones.Location = new System.Drawing.Point(293, 86);
            this.Secciones.Name = "Secciones";
            this.Secciones.Size = new System.Drawing.Size(78, 18);
            this.Secciones.TabIndex = 3;
            this.Secciones.Text = "Secciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(345, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maestro detalle";
            // 
            // MaestroDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Secciones);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaestroDetalle";
            this.Text = "MaestroDetalle";
            this.Load += new System.EventHandler(this.MaestroDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPELICULACODSEC3E52440BBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cINEMANIADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CINEMANIADataSet cINEMANIADataSet;
        private System.Windows.Forms.BindingSource sECCIONBindingSource;
        private CINEMANIADataSetTableAdapters.SECCIONTableAdapter sECCIONTableAdapter;
        private System.Windows.Forms.BindingSource fKPELICULACODSEC3E52440BBindingSource;
        private CINEMANIADataSetTableAdapters.PELICULATableAdapter pELICULATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODSECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label Secciones;
        private System.Windows.Forms.Label label1;
    }
}