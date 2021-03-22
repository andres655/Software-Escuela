namespace ProyectoProgramacion
{
    partial class Form3
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
            this.button8 = new System.Windows.Forms.Button();
            this.lb_peso = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LbNombre = new System.Windows.Forms.Label();
            this.BtnAsistencia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LbAsistencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(532, 330);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 37);
            this.button8.TabIndex = 31;
            this.button8.Text = "Nota de Examen";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lb_peso.Location = new System.Drawing.Point(37, 168);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(0, 13);
            this.lb_peso.TabIndex = 22;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lb_nombre.Location = new System.Drawing.Point(46, 115);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_nombre.TabIndex = 20;
            this.lb_nombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Pase de asistencia ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(361, 1);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 33;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(128, 75);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(68, 20);
            this.TxtCodigo.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Codigo Estudiante ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 163);
            this.dataGridView1.TabIndex = 36;
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(125, 115);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(0, 13);
            this.LbNombre.TabIndex = 37;
            // 
            // BtnAsistencia
            // 
            this.BtnAsistencia.Location = new System.Drawing.Point(238, 72);
            this.BtnAsistencia.Name = "BtnAsistencia";
            this.BtnAsistencia.Size = new System.Drawing.Size(75, 23);
            this.BtnAsistencia.TabIndex = 38;
            this.BtnAsistencia.Text = "Asistencia";
            this.BtnAsistencia.UseVisualStyleBackColor = true;
            this.BtnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(26, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Numero de Asistencia:";
            // 
            // LbAsistencia
            // 
            this.LbAsistencia.AutoSize = true;
            this.LbAsistencia.Location = new System.Drawing.Point(146, 168);
            this.LbAsistencia.Name = "LbAsistencia";
            this.LbAsistencia.Size = new System.Drawing.Size(0, 13);
            this.LbAsistencia.TabIndex = 40;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.puntos_azules_1024x640;
            this.ClientSize = new System.Drawing.Size(587, 366);
            this.Controls.Add(this.LbAsistencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAsistencia);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.lb_nombre);
            this.Name = "Form3";
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Button BtnAsistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbAsistencia;
    }
}