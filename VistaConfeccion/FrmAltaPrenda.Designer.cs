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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaPrenda));
            BtnAgregar = new Button();
            BtnCancelar = new Button();
            CmbCategoria = new ComboBox();
            NumPrendasHora = new NumericUpDown();
            TxtDistintivo = new TextBox();
            RchDescripcion = new RichTextBox();
            LblCategoriaPrenda = new Label();
            LblDistintivo = new Label();
            LblPrendasHora = new Label();
            LblDescripcion = new Label();
            LblErrores = new Label();
            DtgPrendasSistema = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)NumPrendasHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).BeginInit();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            BtnAgregar.FlatStyle = FlatStyle.Popup;
            BtnAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.ForeColor = SystemColors.WindowText;
            BtnAgregar.Location = new Point(813, 451);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(160, 39);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "Agregar prenda";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += btnAgregar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(616, 451);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(160, 39);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // CmbCategoria
            // 
            CmbCategoria.FormattingEnabled = true;
            CmbCategoria.Location = new Point(766, 39);
            CmbCategoria.Name = "CmbCategoria";
            CmbCategoria.Size = new Size(166, 23);
            CmbCategoria.TabIndex = 2;
            // 
            // NumPrendasHora
            // 
            NumPrendasHora.Location = new Point(767, 103);
            NumPrendasHora.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NumPrendasHora.Name = "NumPrendasHora";
            NumPrendasHora.Size = new Size(87, 23);
            NumPrendasHora.TabIndex = 3;
            // 
            // TxtDistintivo
            // 
            TxtDistintivo.Location = new Point(767, 173);
            TxtDistintivo.Name = "TxtDistintivo";
            TxtDistintivo.Size = new Size(165, 23);
            TxtDistintivo.TabIndex = 4;
            // 
            // RchDescripcion
            // 
            RchDescripcion.Location = new Point(632, 264);
            RchDescripcion.Name = "RchDescripcion";
            RchDescripcion.Size = new Size(354, 159);
            RchDescripcion.TabIndex = 5;
            RchDescripcion.Text = "";
            // 
            // LblCategoriaPrenda
            // 
            LblCategoriaPrenda.AutoSize = true;
            LblCategoriaPrenda.Location = new Point(632, 47);
            LblCategoriaPrenda.Name = "LblCategoriaPrenda";
            LblCategoriaPrenda.Size = new Size(98, 15);
            LblCategoriaPrenda.TabIndex = 6;
            LblCategoriaPrenda.Text = "Categoria prenda";
            // 
            // LblDistintivo
            // 
            LblDistintivo.AutoSize = true;
            LblDistintivo.Location = new Point(632, 181);
            LblDistintivo.Name = "LblDistintivo";
            LblDistintivo.Size = new Size(57, 15);
            LblDistintivo.TabIndex = 7;
            LblDistintivo.Text = "Distintivo";
            // 
            // LblPrendasHora
            // 
            LblPrendasHora.AutoSize = true;
            LblPrendasHora.Location = new Point(632, 111);
            LblPrendasHora.Name = "LblPrendasHora";
            LblPrendasHora.Size = new Size(86, 15);
            LblPrendasHora.TabIndex = 8;
            LblPrendasHora.Text = "Prendas / Hora";
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Location = new Point(632, 237);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(137, 15);
            LblDescripcion.TabIndex = 9;
            LblDescripcion.Text = "Descripcion de la prenda";
            // 
            // LblErrores
            // 
            LblErrores.AutoSize = true;
            LblErrores.Location = new Point(577, 426);
            LblErrores.Name = "LblErrores";
            LblErrores.Size = new Size(0, 15);
            LblErrores.TabIndex = 10;
            // 
            // DtgPrendasSistema
            // 
            DtgPrendasSistema.AllowUserToAddRows = false;
            DtgPrendasSistema.AllowUserToDeleteRows = false;
            DtgPrendasSistema.AllowUserToResizeColumns = false;
            DtgPrendasSistema.AllowUserToResizeRows = false;
            DtgPrendasSistema.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgPrendasSistema.BackgroundColor = Color.FromArgb(76, 117, 163);
            DtgPrendasSistema.BorderStyle = BorderStyle.None;
            DtgPrendasSistema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgPrendasSistema.Cursor = Cursors.Hand;
            DtgPrendasSistema.GridColor = Color.FromArgb(10, 102, 194);
            DtgPrendasSistema.Location = new Point(9, 39);
            DtgPrendasSistema.Name = "DtgPrendasSistema";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtgPrendasSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtgPrendasSistema.RowHeadersVisible = false;
            DtgPrendasSistema.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DtgPrendasSistema.RowTemplate.Height = 25;
            DtgPrendasSistema.ShowEditingIcon = false;
            DtgPrendasSistema.Size = new Size(562, 384);
            DtgPrendasSistema.TabIndex = 11;
            // 
            // FrmAltaPrenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1014, 529);
            Controls.Add(DtgPrendasSistema);
            Controls.Add(LblErrores);
            Controls.Add(LblDescripcion);
            Controls.Add(LblPrendasHora);
            Controls.Add(LblDistintivo);
            Controls.Add(LblCategoriaPrenda);
            Controls.Add(RchDescripcion);
            Controls.Add(TxtDistintivo);
            Controls.Add(NumPrendasHora);
            Controls.Add(CmbCategoria);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregar);
            ForeColor = Color.DarkBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAltaPrenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAltaPrenda";
            Load += FrmAltaPrenda_Load;
            ((System.ComponentModel.ISupportInitialize)NumPrendasHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView DtgPrendasSistema;
    }
}