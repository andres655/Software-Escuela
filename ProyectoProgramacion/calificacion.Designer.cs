
namespace ProyectoProgramacion
{
    partial class calificacion
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
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estudianteDataSet = new ProyectoProgramacion.EstudianteDataSet();
            this.estudianteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteDataSet3 = new ProyectoProgramacion.EstudianteDataSet3();
            this.clasificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasificacionTableAdapter = new ProyectoProgramacion.EstudianteDataSet3TableAdapters.ClasificacionTableAdapter();
            this.iDClasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.Location = new System.Drawing.Point(80, 39);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(100, 20);
            this.TxtReferencia.TabIndex = 0;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(80, 65);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(143, 20);
            this.TxtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Referencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(8, 127);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(89, 127);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(170, 127);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClasificacionDataGridViewTextBoxColumn,
            this.clasificacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clasificacionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 129);
            this.dataGridView1.TabIndex = 7;
            // 
            // estudianteDataSet
            // 
            this.estudianteDataSet.DataSetName = "EstudianteDataSet";
            this.estudianteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteDataSetBindingSource
            // 
            this.estudianteDataSetBindingSource.DataSource = this.estudianteDataSet;
            this.estudianteDataSetBindingSource.Position = 0;
            // 
            // estudianteDataSet3
            // 
            this.estudianteDataSet3.DataSetName = "EstudianteDataSet3";
            this.estudianteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasificacionBindingSource
            // 
            this.clasificacionBindingSource.DataMember = "Clasificacion";
            this.clasificacionBindingSource.DataSource = this.estudianteDataSet3;
            // 
            // clasificacionTableAdapter
            // 
            this.clasificacionTableAdapter.ClearBeforeFill = true;
            // 
            // iDClasificacionDataGridViewTextBoxColumn
            // 
            this.iDClasificacionDataGridViewTextBoxColumn.DataPropertyName = "ID_Clasificacion";
            this.iDClasificacionDataGridViewTextBoxColumn.HeaderText = "ID_Clasificacion";
            this.iDClasificacionDataGridViewTextBoxColumn.Name = "iDClasificacionDataGridViewTextBoxColumn";
            // 
            // clasificacionDataGridViewTextBoxColumn
            // 
            this.clasificacionDataGridViewTextBoxColumn.DataPropertyName = "Clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.HeaderText = "Clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.Name = "clasificacionDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Referencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion";
            // 
            // calificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(244, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtReferencia);
            this.Name = "calificacion";
            this.Text = "calificacion";
            this.Load += new System.EventHandler(this.calificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtReferencia;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EstudianteDataSet estudianteDataSet;
        private System.Windows.Forms.BindingSource estudianteDataSetBindingSource;
        private EstudianteDataSet3 estudianteDataSet3;
        private System.Windows.Forms.BindingSource clasificacionBindingSource;
        private EstudianteDataSet3TableAdapters.ClasificacionTableAdapter clasificacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}