namespace ProyectoProgramacion
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAprobar = new System.Windows.Forms.Button();
            this.BtnDesaprobrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOTA DEL EXAMEN ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 186);
            this.dataGridView1.TabIndex = 3;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(53, 55);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo";
            // 
            // BtnAprobar
            // 
            this.BtnAprobar.Location = new System.Drawing.Point(177, 52);
            this.BtnAprobar.Name = "BtnAprobar";
            this.BtnAprobar.Size = new System.Drawing.Size(75, 23);
            this.BtnAprobar.TabIndex = 6;
            this.BtnAprobar.Text = "Aprobó";
            this.BtnAprobar.UseVisualStyleBackColor = true;
            this.BtnAprobar.Click += new System.EventHandler(this.BtnAprobar_Click);
            // 
            // BtnDesaprobrar
            // 
            this.BtnDesaprobrar.Location = new System.Drawing.Point(273, 53);
            this.BtnDesaprobrar.Name = "BtnDesaprobrar";
            this.BtnDesaprobrar.Size = new System.Drawing.Size(75, 23);
            this.BtnDesaprobrar.TabIndex = 7;
            this.BtnDesaprobrar.Text = "Desaprobó";
            this.BtnDesaprobrar.UseVisualStyleBackColor = true;
            this.BtnDesaprobrar.Click += new System.EventHandler(this.BtnDesaprobrar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgramacion.Properties.Resources.puntos_azules_1024x640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 334);
            this.Controls.Add(this.BtnDesaprobrar);
            this.Controls.Add(this.BtnAprobar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.MdiChildActivate += new System.EventHandler(this.Form5_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAprobar;
        private System.Windows.Forms.Button BtnDesaprobrar;
    }
}