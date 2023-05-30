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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfecciones));
            this.BtnAgregarPrenda = new System.Windows.Forms.Button();
            this.BtnModificarConfeccion = new System.Windows.Forms.Button();
            this.BtnCambiarDesplazarConfeccion = new System.Windows.Forms.Button();
            this.btnAgregarConfeccion = new System.Windows.Forms.Button();
            this.McConfecciones = new VistaConfeccion.MiCalendario();
            this.SuspendLayout();
            // 
            // BtnAgregarPrenda
            // 
            this.BtnAgregarPrenda.BackColor = System.Drawing.Color.SlateGray;
            this.BtnAgregarPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPrenda.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarPrenda.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarPrenda.Location = new System.Drawing.Point(244, 383);
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
            this.BtnModificarConfeccion.Location = new System.Drawing.Point(49, 462);
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
            this.BtnCambiarDesplazarConfeccion.Location = new System.Drawing.Point(244, 462);
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
            this.btnAgregarConfeccion.Location = new System.Drawing.Point(49, 383);
            this.btnAgregarConfeccion.Name = "btnAgregarConfeccion";
            this.btnAgregarConfeccion.Size = new System.Drawing.Size(167, 54);
            this.btnAgregarConfeccion.TabIndex = 4;
            this.btnAgregarConfeccion.Text = "Agregar prenda";
            this.btnAgregarConfeccion.UseVisualStyleBackColor = false;
            this.btnAgregarConfeccion.Click += new System.EventHandler(this.BtnAgregarConfeccion_Click);
            // 
            // McConfecciones
            // 
            this.McConfecciones.BackColor = System.Drawing.Color.LightSteelBlue;
            this.McConfecciones.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.McConfecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.McConfecciones.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.McConfecciones.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.McConfecciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.McConfecciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.McConfecciones.Location = new System.Drawing.Point(18, 18);
            this.McConfecciones.MaxSelectionCount = 20;
            this.McConfecciones.Name = "McConfecciones";
            this.McConfecciones.ShowToday = false;
            this.McConfecciones.TabIndex = 12;
            this.McConfecciones.TitleBackColor = System.Drawing.Color.AliceBlue;
            this.McConfecciones.TitleForeColor = System.Drawing.Color.Black;
            this.McConfecciones.TrailingForeColor = System.Drawing.Color.DarkGoldenrod;
            // 
            // FrmConfecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1042, 578);
            this.Controls.Add(this.McConfecciones);
            this.Controls.Add(this.btnAgregarConfeccion);
            this.Controls.Add(this.BtnCambiarDesplazarConfeccion);
            this.Controls.Add(this.BtnModificarConfeccion);
            this.Controls.Add(this.BtnAgregarPrenda);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confecciones Alcatraz";
            this.Load += new System.EventHandler(this.FrmConfecciones_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnAgregarPrenda;
        private Button BtnModificarConfeccion;
        private Button BtnCambiarDesplazarConfeccion;
        private Button btnAgregarConfeccion;
        private MiCalendario McConfecciones;
    }
}