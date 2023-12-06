namespace CineMania
{
    partial class Vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista));
            this.cINEMANIADataSet1 = new CineMania.CINEMANIADataSet1();
            this.pELICULASDISPONIBLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pELICULASDISPONIBLESTableAdapter = new CineMania.CINEMANIADataSet1TableAdapters.PELICULASDISPONIBLESTableAdapter();
            this.tableAdapterManager = new CineMania.CINEMANIADataSet1TableAdapters.TableAdapterManager();
            this.pELICULASDISPONIBLESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pELICULASDISPONIBLESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pELICULASDISPONIBLESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cINEMANIADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASDISPONIBLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASDISPONIBLESBindingNavigator)).BeginInit();
            this.pELICULASDISPONIBLESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASDISPONIBLESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cINEMANIADataSet1
            // 
            this.cINEMANIADataSet1.DataSetName = "CINEMANIADataSet1";
            this.cINEMANIADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pELICULASDISPONIBLESBindingSource
            // 
            this.pELICULASDISPONIBLESBindingSource.DataMember = "PELICULASDISPONIBLES";
            this.pELICULASDISPONIBLESBindingSource.DataSource = this.cINEMANIADataSet1;
            // 
            // pELICULASDISPONIBLESTableAdapter
            // 
            this.pELICULASDISPONIBLESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CineMania.CINEMANIADataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pELICULASDISPONIBLESBindingNavigator
            // 
            this.pELICULASDISPONIBLESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pELICULASDISPONIBLESBindingNavigator.BindingSource = this.pELICULASDISPONIBLESBindingSource;
            this.pELICULASDISPONIBLESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pELICULASDISPONIBLESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pELICULASDISPONIBLESBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pELICULASDISPONIBLESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pELICULASDISPONIBLESBindingNavigatorSaveItem});
            this.pELICULASDISPONIBLESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pELICULASDISPONIBLESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pELICULASDISPONIBLESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pELICULASDISPONIBLESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pELICULASDISPONIBLESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pELICULASDISPONIBLESBindingNavigator.Name = "pELICULASDISPONIBLESBindingNavigator";
            this.pELICULASDISPONIBLESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pELICULASDISPONIBLESBindingNavigator.Size = new System.Drawing.Size(891, 27);
            this.pELICULASDISPONIBLESBindingNavigator.TabIndex = 0;
            this.pELICULASDISPONIBLESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pELICULASDISPONIBLESBindingNavigatorSaveItem
            // 
            this.pELICULASDISPONIBLESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pELICULASDISPONIBLESBindingNavigatorSaveItem.Enabled = false;
            this.pELICULASDISPONIBLESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pELICULASDISPONIBLESBindingNavigatorSaveItem.Image")));
            this.pELICULASDISPONIBLESBindingNavigatorSaveItem.Name = "pELICULASDISPONIBLESBindingNavigatorSaveItem";
            this.pELICULASDISPONIBLESBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.pELICULASDISPONIBLESBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // pELICULASDISPONIBLESDataGridView
            // 
            this.pELICULASDISPONIBLESDataGridView.AutoGenerateColumns = false;
            this.pELICULASDISPONIBLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pELICULASDISPONIBLESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pELICULASDISPONIBLESDataGridView.DataSource = this.pELICULASDISPONIBLESBindingSource;
            this.pELICULASDISPONIBLESDataGridView.Location = new System.Drawing.Point(227, 118);
            this.pELICULASDISPONIBLESDataGridView.Name = "pELICULASDISPONIBLESDataGridView";
            this.pELICULASDISPONIBLESDataGridView.RowHeadersWidth = 51;
            this.pELICULASDISPONIBLESDataGridView.Size = new System.Drawing.Size(439, 308);
            this.pELICULASDISPONIBLESDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GENERO";
            this.dataGridViewTextBoxColumn1.HeaderText = "GENERO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRECIO";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(347, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Películas en el sistema";
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(395, 474);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(94, 34);
            this.btRegresar.TabIndex = 6;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(891, 621);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pELICULASDISPONIBLESDataGridView);
            this.Controls.Add(this.pELICULASDISPONIBLESBindingNavigator);
            this.Name = "Vista";
            this.Text = "Vista";
            this.Load += new System.EventHandler(this.Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cINEMANIADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASDISPONIBLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASDISPONIBLESBindingNavigator)).EndInit();
            this.pELICULASDISPONIBLESBindingNavigator.ResumeLayout(false);
            this.pELICULASDISPONIBLESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pELICULASDISPONIBLESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CINEMANIADataSet1 cINEMANIADataSet1;
        private System.Windows.Forms.BindingSource pELICULASDISPONIBLESBindingSource;
        private CINEMANIADataSet1TableAdapters.PELICULASDISPONIBLESTableAdapter pELICULASDISPONIBLESTableAdapter;
        private CINEMANIADataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pELICULASDISPONIBLESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pELICULASDISPONIBLESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pELICULASDISPONIBLESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRegresar;
    }
}