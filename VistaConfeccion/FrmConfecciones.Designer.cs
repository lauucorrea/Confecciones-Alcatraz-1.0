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
            this.button1 = new System.Windows.Forms.Button();
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
            this.BtnAgregarPrenda.Text = "Agregar Prenda";
            this.BtnAgregarPrenda.UseVisualStyleBackColor = false;
            this.BtnAgregarPrenda.Click += new System.EventHandler(this.BtnAgregarConfeccion_Click);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(46, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar confeccion";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmConfecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCambiarDesplazarConfeccion);
            this.Controls.Add(this.BtnModificarConfeccion);
            this.Controls.Add(this.BtnAgregarPrenda);
            this.Controls.Add(this.McConfecciones);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "FrmConfecciones";
            this.Text = "Confecciones Alcatraz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MiCalendario McConfecciones;
        private Button BtnAgregarPrenda;
        private Button BtnModificarConfeccion;
        private Button BtnCambiarDesplazarConfeccion;
        private Button button1;
    }
}