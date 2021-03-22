
namespace ProyectoProgramacion
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ID_Estudiante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.estudianteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteDataSet4 = new ProyectoProgramacion.EstudianteDataSet4();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteDataSet1 = new ProyectoProgramacion.EstudianteDataSet1();
            this.BtnFactura = new System.Windows.Forms.Button();
            this.estudianteTableAdapter = new ProyectoProgramacion.EstudianteDataSet1TableAdapters.EstudianteTableAdapter();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.estudianteTableAdapter1 = new ProyectoProgramacion.EstudianteDataSet4TableAdapters.EstudianteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // ID_Estudiante
            // 
            this.errorProvider1.SetError(this.ID_Estudiante, "Debe tener un campo");
            this.ID_Estudiante.Location = new System.Drawing.Point(109, 57);
            this.ID_Estudiante.Name = "ID_Estudiante";
            this.ID_Estudiante.Size = new System.Drawing.Size(100, 20);
            this.ID_Estudiante.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Estudiante";
            // 
            // TxtPagar
            // 
            this.TxtPagar.Location = new System.Drawing.Point(109, 83);
            this.TxtPagar.Name = "TxtPagar";
            this.TxtPagar.Size = new System.Drawing.Size(100, 20);
            this.TxtPagar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pagar";
            // 
            // estudianteBindingSource1
            // 
            this.estudianteBindingSource1.DataMember = "Estudiante";
            this.estudianteBindingSource1.DataSource = this.estudianteDataSet4;
            // 
            // estudianteDataSet4
            // 
            this.estudianteDataSet4.DataSetName = "EstudianteDataSet4";
            this.estudianteDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.estudianteDataSet1;
            // 
            // estudianteDataSet1
            // 
            this.estudianteDataSet1.DataSetName = "EstudianteDataSet1";
            this.estudianteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnFactura
            // 
            this.BtnFactura.Location = new System.Drawing.Point(547, 155);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(88, 35);
            this.BtnFactura.TabIndex = 8;
            this.BtnFactura.Text = "Facturar";
            this.BtnFactura.UseVisualStyleBackColor = true;
            this.BtnFactura.Click += new System.EventHandler(this.BtnFactura_Click);
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(215, 55);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "Seleccionar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // estudianteTableAdapter1
            // 
            this.estudianteTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.puntos_azules_1024x640;
            this.ClientSize = new System.Drawing.Size(677, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_Estudiante);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox ID_Estudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFactura;
        private EstudianteDataSet1 estudianteDataSet1;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private EstudianteDataSet1TableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private EstudianteDataSet4 estudianteDataSet4;
        private System.Windows.Forms.BindingSource estudianteBindingSource1;
        private EstudianteDataSet4TableAdapters.EstudianteTableAdapter estudianteTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}