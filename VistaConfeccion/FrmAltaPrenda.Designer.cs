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
            NumHoras = new NumericUpDown();
            TxtDistintivo = new TextBox();
            RchDescripcion = new RichTextBox();
            LblCategoriaPrenda = new Label();
            LblDistintivo = new Label();
            LblPrendasHora = new Label();
            LblDescripcion = new Label();
            LblErrores = new Label();
            DtgPrendasSistema = new DataGridView();
            label1 = new Label();
            NumUnidaes = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            BtnCerrarSesion = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUnidaes).BeginInit();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            BtnAgregar.FlatStyle = FlatStyle.Popup;
            BtnAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.ForeColor = SystemColors.WindowText;
            BtnAgregar.Location = new Point(968, 648);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(160, 39);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "Agregar prenda";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(771, 648);
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
            CmbCategoria.Location = new Point(915, 164);
            CmbCategoria.Name = "CmbCategoria";
            CmbCategoria.Size = new Size(166, 23);
            CmbCategoria.TabIndex = 2;
            // 
            // NumHoras
            // 
            NumHoras.Location = new Point(968, 264);
            NumHoras.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NumHoras.Name = "NumHoras";
            NumHoras.Size = new Size(87, 23);
            NumHoras.TabIndex = 3;
            // 
            // TxtDistintivo
            // 
            TxtDistintivo.Location = new Point(915, 208);
            TxtDistintivo.Name = "TxtDistintivo";
            TxtDistintivo.Size = new Size(165, 23);
            TxtDistintivo.TabIndex = 4;
            // 
            // RchDescripcion
            // 
            RchDescripcion.Location = new Point(781, 344);
            RchDescripcion.Name = "RchDescripcion";
            RchDescripcion.Size = new Size(319, 196);
            RchDescripcion.TabIndex = 5;
            RchDescripcion.Text = "";
            // 
            // LblCategoriaPrenda
            // 
            LblCategoriaPrenda.AutoSize = true;
            LblCategoriaPrenda.Location = new Point(781, 167);
            LblCategoriaPrenda.Name = "LblCategoriaPrenda";
            LblCategoriaPrenda.Size = new Size(98, 15);
            LblCategoriaPrenda.TabIndex = 6;
            LblCategoriaPrenda.Text = "Categoria prenda";
            // 
            // LblDistintivo
            // 
            LblDistintivo.AutoSize = true;
            LblDistintivo.Location = new Point(781, 211);
            LblDistintivo.Name = "LblDistintivo";
            LblDistintivo.Size = new Size(119, 15);
            LblDistintivo.TabIndex = 7;
            LblDistintivo.Text = "Distintivo(Requerido)";
            // 
            // LblPrendasHora
            // 
            LblPrendasHora.AutoSize = true;
            LblPrendasHora.Location = new Point(881, 266);
            LblPrendasHora.Name = "LblPrendasHora";
            LblPrendasHora.Size = new Size(71, 15);
            LblPrendasHora.TabIndex = 8;
            LblPrendasHora.Text = "unidades en";
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Location = new Point(781, 317);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(194, 15);
            LblDescripcion.TabIndex = 9;
            LblDescripcion.Text = "Descripcion de la prenda (opcional)";
            // 
            // LblErrores
            // 
            LblErrores.AutoSize = true;
            LblErrores.Location = new Point(616, 505);
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
            DtgPrendasSistema.Location = new Point(28, 67);
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
            DtgPrendasSistema.Size = new Size(702, 524);
            DtgPrendasSistema.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(240, 23);
            label1.TabIndex = 12;
            label1.Text = "Listado de prendas en sistema";
            // 
            // NumUnidaes
            // 
            NumUnidaes.Location = new Point(785, 262);
            NumUnidaes.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NumUnidaes.Name = "NumUnidaes";
            NumUnidaes.Size = new Size(87, 23);
            NumUnidaes.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1061, 266);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 15;
            label2.Text = "horas.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(841, 67);
            label3.Name = "label3";
            label3.Size = new Size(215, 23);
            label3.TabIndex = 16;
            label3.Text = "Ingreso datos de la prenda";
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.ForeColor = Color.Transparent;
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.Location = new Point(28, 607);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(72, 80);
            BtnCerrarSesion.TabIndex = 35;
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 690);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 36;
            label4.Text = "Cerrar sesion";
            // 
            // FrmAltaPrenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1159, 718);
            Controls.Add(label4);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NumUnidaes);
            Controls.Add(label1);
            Controls.Add(DtgPrendasSistema);
            Controls.Add(LblErrores);
            Controls.Add(LblDescripcion);
            Controls.Add(LblPrendasHora);
            Controls.Add(LblDistintivo);
            Controls.Add(LblCategoriaPrenda);
            Controls.Add(RchDescripcion);
            Controls.Add(TxtDistintivo);
            Controls.Add(NumHoras);
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
            ((System.ComponentModel.ISupportInitialize)NumHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUnidaes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregar;
        private Button BtnCancelar;
        private ComboBox CmbCategoria;
        private NumericUpDown NumHoras;
        private TextBox TxtDistintivo;
        private RichTextBox RchDescripcion;
        private Label LblCategoriaPrenda;
        private Label LblDistintivo;
        private Label LblPrendasHora;
        private Label LblDescripcion;
        private Label LblErrores;
        private DataGridView DtgPrendasSistema;
        private Label label1;
        private NumericUpDown NumUnidaes;
        private Label label2;
        private Label label3;
        private Button BtnCerrarSesion;
        private Label label4;
    }
}