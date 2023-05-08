namespace VistaConfeccion
{
    partial class FrmConfecciones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.McConfecciones = new VistaConfeccion.MiCalendario();
            this.BtnAgregarPrenda = new System.Windows.Forms.Button();
            this.BtnModificarConfeccion = new System.Windows.Forms.Button();
            this.BtnCambiarDesplazarConfeccion = new System.Windows.Forms.Button();
            this.btnAgregarConfeccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // McConfecciones
            // 
            this.McConfecciones.Location = new System.Drawing.Point(18, 53);
            this.McConfecciones.Name = "McConfecciones";
            this.McConfecciones.TabIndex = 0;
            this.McConfecciones.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McConfecciones_DateSelected);
            // 
            // BtnAgregarPrenda
            // 
            this.BtnAgregarPrenda.BackColor = System.Drawing.Color.SlateGray;
            this.BtnAgregarPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPrenda.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarPrenda.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarPrenda.Location = new System.Drawing.Point(46, 359);
            this.BtnAgregarPrenda.Name = "BtnAgregarPrenda";
            this.BtnAgregarPrenda.Size = new System.Drawing.Size(167, 54);
            this.BtnAgregarPrenda.TabIndex = 1;
            this.BtnAgregarPrenda.Text = "Agregar Confeccion";
            this.BtnAgregarPrenda.UseVisualStyleBackColor = false;
            this.BtnAgregarPrenda.Click += new System.EventHandler(this.BtnAgregarPrenda_Click);
            // 
            // BtnModificarConfeccion
            // 
            this.BtnModificarConfeccion.BackColor = System.Drawing.Color.SlateGray;
            this.BtnModificarConfeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarConfeccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificarConfeccion.ForeColor = System.Drawing.Color.White;
            this.BtnModificarConfeccion.Location = new System.Drawing.Point(46, 450);
            this.BtnModificarConfeccion.Name = "BtnModificarConfeccion";
            this.BtnModificarConfeccion.Size = new System.Drawing.Size(167, 54);
            this.BtnModificarConfeccion.TabIndex = 2;
            this.BtnModificarConfeccion.Text = "Modificar confeccion";
            this.BtnModificarConfeccion.UseVisualStyleBackColor = false;
            // 
            // BtnCambiarDesplazarConfeccion
            // 
            this.BtnCambiarDesplazarConfeccion.BackColor = System.Drawing.Color.SlateGray;
            this.BtnCambiarDesplazarConfeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarDesplazarConfeccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCambiarDesplazarConfeccion.ForeColor = System.Drawing.Color.White;
            this.BtnCambiarDesplazarConfeccion.Location = new System.Drawing.Point(46, 542);
            this.BtnCambiarDesplazarConfeccion.Name = "BtnCambiarDesplazarConfeccion";
            this.BtnCambiarDesplazarConfeccion.Size = new System.Drawing.Size(167, 54);
            this.BtnCambiarDesplazarConfeccion.TabIndex = 3;
            this.BtnCambiarDesplazarConfeccion.Text = "Cambiar/Desplazar confeccion";
            this.BtnCambiarDesplazarConfeccion.UseVisualStyleBackColor = false;
            // 
            // btnAgregarConfeccion
            // 
            this.btnAgregarConfeccion.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregarConfeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarConfeccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarConfeccion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarConfeccion.Location = new System.Drawing.Point(46, 266);
            this.btnAgregarConfeccion.Name = "btnAgregarConfeccion";
            this.btnAgregarConfeccion.Size = new System.Drawing.Size(167, 54);
            this.btnAgregarConfeccion.TabIndex = 4;
            this.btnAgregarConfeccion.Text = "Agregar prenda";
            this.btnAgregarConfeccion.UseVisualStyleBackColor = false;
            this.btnAgregarConfeccion.Click += new System.EventHandler(this.BtnAgregarConfeccion_Click);
            // 
            // FrmConfecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.btnAgregarConfeccion);
            this.Controls.Add(this.BtnCambiarDesplazarConfeccion);
            this.Controls.Add(this.BtnModificarConfeccion);
            this.Controls.Add(this.BtnAgregarPrenda);
            this.Controls.Add(this.McConfecciones);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "FrmConfecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confecciones Alcatraz";
            this.Load += new System.EventHandler(this.FrmConfecciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MiCalendario McConfecciones;
        private Button BtnAgregarPrenda;
        private Button BtnModificarConfeccion;
        private Button BtnCambiarDesplazarConfeccion;
        private Button btnAgregarConfeccion;
    }
}