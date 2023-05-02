namespace VistaConfeccion
{
    partial class FrmAltaPrenda
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.NumPrendasHora = new System.Windows.Forms.NumericUpDown();
            this.TxtDistintivo = new System.Windows.Forms.TextBox();
            this.RchDescripcion = new System.Windows.Forms.RichTextBox();
            this.LblCategoriaPrenda = new System.Windows.Forms.Label();
            this.LblDistintivo = new System.Windows.Forms.Label();
            this.LblPrendasHora = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblErrores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrendasHora)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SlateGray;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnAgregar.Location = new System.Drawing.Point(257, 454);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(160, 39);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar prenda";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(60, 454);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(160, 39);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(210, 42);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(166, 23);
            this.CmbCategoria.TabIndex = 2;
            // 
            // NumPrendasHora
            // 
            this.NumPrendasHora.Location = new System.Drawing.Point(211, 106);
            this.NumPrendasHora.Name = "NumPrendasHora";
            this.NumPrendasHora.Size = new System.Drawing.Size(87, 23);
            this.NumPrendasHora.TabIndex = 3;
            // 
            // TxtDistintivo
            // 
            this.TxtDistintivo.Location = new System.Drawing.Point(211, 176);
            this.TxtDistintivo.Name = "TxtDistintivo";
            this.TxtDistintivo.Size = new System.Drawing.Size(165, 23);
            this.TxtDistintivo.TabIndex = 4;
            // 
            // RchDescripcion
            // 
            this.RchDescripcion.Location = new System.Drawing.Point(21, 267);
            this.RchDescripcion.Name = "RchDescripcion";
            this.RchDescripcion.Size = new System.Drawing.Size(409, 159);
            this.RchDescripcion.TabIndex = 5;
            this.RchDescripcion.Text = "";
            // 
            // LblCategoriaPrenda
            // 
            this.LblCategoriaPrenda.AutoSize = true;
            this.LblCategoriaPrenda.Location = new System.Drawing.Point(76, 50);
            this.LblCategoriaPrenda.Name = "LblCategoriaPrenda";
            this.LblCategoriaPrenda.Size = new System.Drawing.Size(98, 15);
            this.LblCategoriaPrenda.TabIndex = 6;
            this.LblCategoriaPrenda.Text = "Categoria prenda";
            // 
            // LblDistintivo
            // 
            this.LblDistintivo.AutoSize = true;
            this.LblDistintivo.Location = new System.Drawing.Point(76, 184);
            this.LblDistintivo.Name = "LblDistintivo";
            this.LblDistintivo.Size = new System.Drawing.Size(57, 15);
            this.LblDistintivo.TabIndex = 7;
            this.LblDistintivo.Text = "Distintivo";
            // 
            // LblPrendasHora
            // 
            this.LblPrendasHora.AutoSize = true;
            this.LblPrendasHora.Location = new System.Drawing.Point(76, 114);
            this.LblPrendasHora.Name = "LblPrendasHora";
            this.LblPrendasHora.Size = new System.Drawing.Size(86, 15);
            this.LblPrendasHora.TabIndex = 8;
            this.LblPrendasHora.Text = "Prendas / Hora";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(21, 249);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(137, 15);
            this.LblDescripcion.TabIndex = 9;
            this.LblDescripcion.Text = "Descripcion de la prenda";
            // 
            // LblErrores
            // 
            this.LblErrores.AutoSize = true;
            this.LblErrores.Location = new System.Drawing.Point(21, 429);
            this.LblErrores.Name = "LblErrores";
            this.LblErrores.Size = new System.Drawing.Size(0, 15);
            this.LblErrores.TabIndex = 10;
            // 
            // FrmAltaPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(470, 531);
            this.Controls.Add(this.LblErrores);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblPrendasHora);
            this.Controls.Add(this.LblDistintivo);
            this.Controls.Add(this.LblCategoriaPrenda);
            this.Controls.Add(this.RchDescripcion);
            this.Controls.Add(this.TxtDistintivo);
            this.Controls.Add(this.NumPrendasHora);
            this.Controls.Add(this.CmbCategoria);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "FrmAltaPrenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaPrenda";
            this.Load += new System.EventHandler(this.FrmAltaPrenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumPrendasHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAgregar;
        private Button BtnCancelar;
        private ComboBox CmbCategoria;
        private NumericUpDown NumPrendasHora;
        private TextBox TxtDistintivo;
        private RichTextBox RchDescripcion;
        private Label LblCategoriaPrenda;
        private Label LblDistintivo;
        private Label LblPrendasHora;
        private Label LblDescripcion;
        private Label LblErrores;
    }
}