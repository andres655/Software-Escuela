
namespace ProyectoProgramacion
{
    partial class Empleado
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
            System.Windows.Forms.Button BtnAgregar;
            System.Windows.Forms.Button BtnEliminar;
            System.Windows.Forms.Button BtnActualizar;
            System.Windows.Forms.TextBox TxtID_Empleado;
            System.Windows.Forms.TextBox TxtNombre;
            System.Windows.Forms.TextBox TxtSueldo;
            System.Windows.Forms.TextBox TxtTelefono;
            System.Windows.Forms.TextBox TxtDireccion;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estudianteDataSet = new ProyectoProgramacion.EstudianteDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new ProyectoProgramacion.EstudianteDataSetTableAdapters.EmpleadoTableAdapter();
            this.iDEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BtnAgregar = new System.Windows.Forms.Button();
            BtnEliminar = new System.Windows.Forms.Button();
            BtnActualizar = new System.Windows.Forms.Button();
            TxtID_Empleado = new System.Windows.Forms.TextBox();
            TxtNombre = new System.Windows.Forms.TextBox();
            TxtSueldo = new System.Windows.Forms.TextBox();
            TxtTelefono = new System.Windows.Forms.TextBox();
            TxtDireccion = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmpleadoDataGridViewTextBoxColumn,
            this.sueldoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.contratoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // estudianteDataSet
            // 
            this.estudianteDataSet.DataSetName = "EstudianteDataSet";
            this.estudianteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.estudianteDataSet;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // iDEmpleadoDataGridViewTextBoxColumn
            // 
            this.iDEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ID_Empleado";
            this.iDEmpleadoDataGridViewTextBoxColumn.HeaderText = "ID_Empleado";
            this.iDEmpleadoDataGridViewTextBoxColumn.Name = "iDEmpleadoDataGridViewTextBoxColumn";
            // 
            // sueldoDataGridViewTextBoxColumn
            // 
            this.sueldoDataGridViewTextBoxColumn.DataPropertyName = "Sueldo";
            this.sueldoDataGridViewTextBoxColumn.HeaderText = "Sueldo";
            this.sueldoDataGridViewTextBoxColumn.Name = "sueldoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // contratoDataGridViewTextBoxColumn
            // 
            this.contratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato";
            this.contratoDataGridViewTextBoxColumn.HeaderText = "Contrato";
            this.contratoDataGridViewTextBoxColumn.Name = "contratoDataGridViewTextBoxColumn";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new System.Drawing.Point(538, 155);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new System.Drawing.Size(96, 37);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Actualizar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new System.Drawing.Point(426, 155);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new System.Drawing.Size(96, 37);
            BtnEliminar.TabIndex = 2;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new System.Drawing.Point(324, 155);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new System.Drawing.Size(96, 37);
            BtnActualizar.TabIndex = 3;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtID_Empleado
            // 
            TxtID_Empleado.Location = new System.Drawing.Point(77, 26);
            TxtID_Empleado.Name = "TxtID_Empleado";
            TxtID_Empleado.Size = new System.Drawing.Size(100, 20);
            TxtID_Empleado.TabIndex = 4;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new System.Drawing.Point(77, 64);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new System.Drawing.Size(100, 20);
            TxtNombre.TabIndex = 5;
            // 
            // TxtSueldo
            // 
            TxtSueldo.Location = new System.Drawing.Point(77, 102);
            TxtSueldo.Name = "TxtSueldo";
            TxtSueldo.Size = new System.Drawing.Size(100, 20);
            TxtSueldo.TabIndex = 6;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new System.Drawing.Point(376, 26);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new System.Drawing.Size(100, 20);
            TxtTelefono.TabIndex = 7;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Location = new System.Drawing.Point(376, 64);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new System.Drawing.Size(100, 20);
            TxtDireccion.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 13);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 13);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 13);
            label3.TabIndex = 11;
            label3.Text = "Sueldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(321, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 13);
            label4.TabIndex = 12;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(318, 67);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 13);
            label5.TabIndex = 13;
            label5.Text = "Direccion";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.puntos_azules_1024x640;
            this.ClientSize = new System.Drawing.Size(646, 351);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(TxtDireccion);
            this.Controls.Add(TxtTelefono);
            this.Controls.Add(TxtSueldo);
            this.Controls.Add(TxtNombre);
            this.Controls.Add(TxtID_Empleado);
            this.Controls.Add(BtnActualizar);
            this.Controls.Add(BtnEliminar);
            this.Controls.Add(BtnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EstudianteDataSet estudianteDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private EstudianteDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contratoDataGridViewTextBoxColumn;
    }
}