namespace Vista
{
    partial class FrmTareaDiaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareaDiaria));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label4 = new Label();
            BtnCerrarSesion = new Button();
            BtnCancelar = new Button();
            BtnAceptarFecha = new Button();
            DtgTareaDiaria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DtgTareaDiaria).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 934);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 46;
            label4.Text = "Cerrar sesion";
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.ForeColor = Color.Transparent;
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.Location = new Point(72, 851);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(72, 80);
            BtnCerrarSesion.TabIndex = 45;
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(952, 863);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(173, 47);
            BtnCancelar.TabIndex = 44;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnAceptarFecha
            // 
            BtnAceptarFecha.BackColor = Color.FromArgb(192, 255, 192);
            BtnAceptarFecha.Cursor = Cursors.Hand;
            BtnAceptarFecha.FlatStyle = FlatStyle.Popup;
            BtnAceptarFecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAceptarFecha.ForeColor = SystemColors.WindowText;
            BtnAceptarFecha.Location = new Point(1138, 863);
            BtnAceptarFecha.Name = "BtnAceptarFecha";
            BtnAceptarFecha.Size = new Size(184, 47);
            BtnAceptarFecha.TabIndex = 43;
            BtnAceptarFecha.Text = "Continuar";
            BtnAceptarFecha.UseVisualStyleBackColor = false;
            // 
            // DtgTareaDiaria
            // 
            DtgTareaDiaria.AllowUserToAddRows = false;
            DtgTareaDiaria.AllowUserToDeleteRows = false;
            DtgTareaDiaria.AllowUserToResizeColumns = false;
            DtgTareaDiaria.AllowUserToResizeRows = false;
            DtgTareaDiaria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DtgTareaDiaria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgTareaDiaria.BackgroundColor = Color.FromArgb(76, 117, 163);
            DtgTareaDiaria.BorderStyle = BorderStyle.None;
            DtgTareaDiaria.Cursor = Cursors.Hand;
            DtgTareaDiaria.GridColor = Color.FromArgb(10, 102, 194);
            DtgTareaDiaria.Location = new Point(72, 59);
            DtgTareaDiaria.Margin = new Padding(0);
            DtgTareaDiaria.Name = "DtgTareaDiaria";
            DtgTareaDiaria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DtgTareaDiaria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DtgTareaDiaria.RowHeadersVisible = false;
            DtgTareaDiaria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DtgTareaDiaria.RowTemplate.Height = 25;
            DtgTareaDiaria.RowTemplate.Resizable = DataGridViewTriState.False;
            DtgTareaDiaria.ShowEditingIcon = false;
            DtgTareaDiaria.Size = new Size(1250, 750);
            DtgTareaDiaria.TabIndex = 42;
            // 
            // FrmTareaDiaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1384, 1011);
            Controls.Add(label4);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptarFecha);
            Controls.Add(DtgTareaDiaria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTareaDiaria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarea diaria";
            Load += FrmTareaDiaria_Load;
            ((System.ComponentModel.ISupportInitialize)DtgTareaDiaria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button BtnCerrarSesion;
        private Button BtnCancelar;
        private Button BtnAceptarFecha;
        private DataGridView DtgTareaDiaria;
    }
}