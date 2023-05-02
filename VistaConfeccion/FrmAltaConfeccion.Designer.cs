namespace VistaConfeccion
{
    partial class FrmAltaConfeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaConfeccion));
            this.BtnAgregarConfeccion = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAgregarConfeccion
            // 
            this.BtnAgregarConfeccion.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.BtnAgregarConfeccion, "BtnAgregarConfeccion");
            this.BtnAgregarConfeccion.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarConfeccion.Name = "BtnAgregarConfeccion";
            this.BtnAgregarConfeccion.UseVisualStyleBackColor = false;
            this.BtnAgregarConfeccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.BtnCancelar, "BtnCancelar");
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmAltaConfeccion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregarConfeccion);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "FrmAltaConfeccion";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnAgregarConfeccion;
        private Button BtnCancelar;
    }
}