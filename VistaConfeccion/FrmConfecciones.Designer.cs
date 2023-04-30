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
            this.BtnAgregarConfeccion = new System.Windows.Forms.Button();
            this.BtnModificarConfeccion = new System.Windows.Forms.Button();
            this.BtnCambiarDesplazarConfeccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // McConfecciones
            // 
            this.McConfecciones.Location = new System.Drawing.Point(18, 53);
            this.McConfecciones.Name = "McConfecciones";
            this.McConfecciones.TabIndex = 0;
            this.McConfecciones.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McConfecciones_DateSelected);
            // 
            // BtnAgregarConfeccion
            // 
            this.BtnAgregarConfeccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarConfeccion.Location = new System.Drawing.Point(46, 283);
            this.BtnAgregarConfeccion.Name = "BtnAgregarConfeccion";
            this.BtnAgregarConfeccion.Size = new System.Drawing.Size(167, 54);
            this.BtnAgregarConfeccion.TabIndex = 1;
            this.BtnAgregarConfeccion.Text = "Agregar confeccion";
            this.BtnAgregarConfeccion.UseVisualStyleBackColor = true;
            this.BtnAgregarConfeccion.Click += new System.EventHandler(this.BtnAgregarConfeccion_Click);
            // 
            // BtnModificarConfeccion
            // 
            this.BtnModificarConfeccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnModificarConfeccion.Location = new System.Drawing.Point(46, 370);
            this.BtnModificarConfeccion.Name = "BtnModificarConfeccion";
            this.BtnModificarConfeccion.Size = new System.Drawing.Size(167, 54);
            this.BtnModificarConfeccion.TabIndex = 2;
            this.BtnModificarConfeccion.Text = "Modificar confeccion";
            this.BtnModificarConfeccion.UseVisualStyleBackColor = true;
            // 
            // BtnCambiarDesplazarConfeccion
            // 
            this.BtnCambiarDesplazarConfeccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCambiarDesplazarConfeccion.Location = new System.Drawing.Point(46, 462);
            this.BtnCambiarDesplazarConfeccion.Name = "BtnCambiarDesplazarConfeccion";
            this.BtnCambiarDesplazarConfeccion.Size = new System.Drawing.Size(167, 54);
            this.BtnCambiarDesplazarConfeccion.TabIndex = 3;
            this.BtnCambiarDesplazarConfeccion.Text = "Cambiar/Desplazar confeccion";
            this.BtnCambiarDesplazarConfeccion.UseVisualStyleBackColor = true;
            // 
            // FrmConfecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.BtnCambiarDesplazarConfeccion);
            this.Controls.Add(this.BtnModificarConfeccion);
            this.Controls.Add(this.BtnAgregarConfeccion);
            this.Controls.Add(this.McConfecciones);
            this.Name = "FrmConfecciones";
            this.Text = "Confecciones Alcatraz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MiCalendario McConfecciones;
        private Button BtnAgregarConfeccion;
        private Button BtnModificarConfeccion;
        private Button BtnCambiarDesplazarConfeccion;
    }
}