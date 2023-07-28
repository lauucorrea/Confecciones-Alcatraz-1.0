namespace Vista
{
    partial class FrmCalendario
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalendario));
            DtgCalendario = new DataGridView();
            LblMesActual = new Label();
            BtnMesSiguiente = new Button();
            BtnMesAnterior = new Button();
            label4 = new Label();
            BtnCerrarSesion = new Button();
            BtnCancelar = new Button();
            BtnAceptarFecha = new Button();
            ((System.ComponentModel.ISupportInitialize)DtgCalendario).BeginInit();
            SuspendLayout();
            // 
            // DtgCalendario
            // 
            DtgCalendario.AllowUserToAddRows = false;
            DtgCalendario.AllowUserToDeleteRows = false;
            DtgCalendario.AllowUserToResizeColumns = false;
            DtgCalendario.AllowUserToResizeRows = false;
            DtgCalendario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DtgCalendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgCalendario.BackgroundColor = Color.FromArgb(76, 117, 163);
            DtgCalendario.BorderStyle = BorderStyle.None;
            DtgCalendario.Cursor = Cursors.Hand;
            DtgCalendario.GridColor = Color.FromArgb(10, 102, 194);
            DtgCalendario.Location = new Point(64, 92);
            DtgCalendario.Margin = new Padding(0);
            DtgCalendario.Name = "DtgCalendario";
            DtgCalendario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DtgCalendario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DtgCalendario.RowHeadersVisible = false;
            DtgCalendario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DtgCalendario.RowTemplate.Height = 25;
            DtgCalendario.RowTemplate.Resizable = DataGridViewTriState.False;
            DtgCalendario.ShowEditingIcon = false;
            DtgCalendario.Size = new Size(1250, 750);
            DtgCalendario.TabIndex = 7;
            // 
            // LblMesActual
            // 
            LblMesActual.AutoSize = true;
            LblMesActual.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            LblMesActual.Location = new Point(580, 9);
            LblMesActual.Name = "LblMesActual";
            LblMesActual.Size = new Size(228, 54);
            LblMesActual.TabIndex = 8;
            LblMesActual.Text = "JULIO 2023";
            // 
            // BtnMesSiguiente
            // 
            BtnMesSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMesSiguiente.BackColor = Color.Transparent;
            BtnMesSiguiente.Cursor = Cursors.Hand;
            BtnMesSiguiente.FlatStyle = FlatStyle.Flat;
            BtnMesSiguiente.ForeColor = Color.Transparent;
            BtnMesSiguiente.Image = Properties.Resources.flecha_derecha_recta;
            BtnMesSiguiente.Location = new Point(1242, 0);
            BtnMesSiguiente.Name = "BtnMesSiguiente";
            BtnMesSiguiente.Size = new Size(72, 80);
            BtnMesSiguiente.TabIndex = 36;
            BtnMesSiguiente.UseVisualStyleBackColor = false;
            BtnMesSiguiente.Click += BtnMesSiguiente_Click;
            // 
            // BtnMesAnterior
            // 
            BtnMesAnterior.BackColor = Color.Transparent;
            BtnMesAnterior.Cursor = Cursors.Hand;
            BtnMesAnterior.FlatStyle = FlatStyle.Flat;
            BtnMesAnterior.ForeColor = Color.Transparent;
            BtnMesAnterior.Image = Properties.Resources.flecha_izquierda_recta;
            BtnMesAnterior.Location = new Point(64, 0);
            BtnMesAnterior.Name = "BtnMesAnterior";
            BtnMesAnterior.Size = new Size(72, 80);
            BtnMesAnterior.TabIndex = 37;
            BtnMesAnterior.UseVisualStyleBackColor = false;
            BtnMesAnterior.Click += BtnMesAnterior_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(55, 949);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 41;
            label4.Text = "Cerrar sesion";
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.ForeColor = Color.Transparent;
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.Location = new Point(64, 866);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(72, 80);
            BtnCerrarSesion.TabIndex = 40;
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(944, 878);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(173, 47);
            BtnCancelar.TabIndex = 39;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptarFecha
            // 
            BtnAceptarFecha.BackColor = Color.FromArgb(192, 255, 192);
            BtnAceptarFecha.Cursor = Cursors.Hand;
            BtnAceptarFecha.FlatStyle = FlatStyle.Popup;
            BtnAceptarFecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAceptarFecha.ForeColor = SystemColors.WindowText;
            BtnAceptarFecha.Location = new Point(1130, 878);
            BtnAceptarFecha.Name = "BtnAceptarFecha";
            BtnAceptarFecha.Size = new Size(184, 47);
            BtnAceptarFecha.TabIndex = 38;
            BtnAceptarFecha.Text = "Continuar";
            BtnAceptarFecha.UseVisualStyleBackColor = false;
            BtnAceptarFecha.Click += BtnAceptarFecha_Click;
            // 
            // FrmCalendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1384, 977);
            Controls.Add(label4);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptarFecha);
            Controls.Add(BtnMesAnterior);
            Controls.Add(BtnMesSiguiente);
            Controls.Add(LblMesActual);
            Controls.Add(DtgCalendario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCalendario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCalendario";
            Load += FrmCalendario_Load;
            ((System.ComponentModel.ISupportInitialize)DtgCalendario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DtgCalendario;
        private Label LblMesActual;
        private Button BtnMesSiguiente;
        private Button BtnMesAnterior;
        private Label label4;
        private Button BtnCerrarSesion;
        private Button BtnCancelar;
        private Button BtnAceptarFecha;
    }
}