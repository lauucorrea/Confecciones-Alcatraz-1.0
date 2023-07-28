namespace Vista
{
    partial class FrmAltaCorte
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaCorte));
            label2 = new Label();
            lblSistema = new Label();
            LblErrores = new Label();
            DtgPrendasCorte = new DataGridView();
            BtnAgregarPrenda = new Button();
            NumUnidades = new NumericUpDown();
            LblUnidades = new Label();
            LblTalle = new Label();
            CmbTalle = new ComboBox();
            DtgPrendasSistema = new DataGridView();
            BtnCancelar = new Button();
            BtnCrearCorte = new Button();
            BtnCerrarSesion = new Button();
            label4 = new Label();
            BtnQuitarPrenda = new Button();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasCorte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUnidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(32, 414);
            label2.Name = "label2";
            label2.Size = new Size(247, 23);
            label2.TabIndex = 32;
            label2.Text = "Listado prendas a confeccionar";
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSistema.ImeMode = ImeMode.NoControl;
            lblSistema.Location = new Point(31, 20);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(216, 23);
            lblSistema.TabIndex = 31;
            lblSistema.Text = "Listado prendas en sistema";
            // 
            // LblErrores
            // 
            LblErrores.AutoSize = true;
            LblErrores.ImeMode = ImeMode.NoControl;
            LblErrores.Location = new Point(782, 802);
            LblErrores.Name = "LblErrores";
            LblErrores.Size = new Size(0, 15);
            LblErrores.TabIndex = 30;
            // 
            // DtgPrendasCorte
            // 
            DtgPrendasCorte.AllowUserToAddRows = false;
            DtgPrendasCorte.AllowUserToDeleteRows = false;
            DtgPrendasCorte.AllowUserToResizeColumns = false;
            DtgPrendasCorte.AllowUserToResizeRows = false;
            DtgPrendasCorte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgPrendasCorte.BackgroundColor = Color.FromArgb(76, 117, 163);
            DtgPrendasCorte.BorderStyle = BorderStyle.None;
            DtgPrendasCorte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgPrendasCorte.Cursor = Cursors.Hand;
            DtgPrendasCorte.GridColor = Color.FromArgb(10, 102, 194);
            DtgPrendasCorte.Location = new Point(32, 440);
            DtgPrendasCorte.Name = "DtgPrendasCorte";
            DtgPrendasCorte.RowHeadersVisible = false;
            DtgPrendasCorte.RowTemplate.Height = 25;
            DtgPrendasCorte.ShowEditingIcon = false;
            DtgPrendasCorte.Size = new Size(1322, 300);
            DtgPrendasCorte.TabIndex = 29;
            DtgPrendasCorte.CellClick += DtgPrendasCorte_CellClick;
            // 
            // BtnAgregarPrenda
            // 
            BtnAgregarPrenda.BackColor = Color.FromArgb(192, 255, 192);
            BtnAgregarPrenda.Cursor = Cursors.Hand;
            BtnAgregarPrenda.FlatStyle = FlatStyle.Popup;
            BtnAgregarPrenda.ForeColor = SystemColors.Desktop;
            BtnAgregarPrenda.ImeMode = ImeMode.NoControl;
            BtnAgregarPrenda.Location = new Point(1134, 366);
            BtnAgregarPrenda.Name = "BtnAgregarPrenda";
            BtnAgregarPrenda.Size = new Size(220, 39);
            BtnAgregarPrenda.TabIndex = 28;
            BtnAgregarPrenda.Text = "+ Añadir prenda";
            BtnAgregarPrenda.UseVisualStyleBackColor = false;
            BtnAgregarPrenda.Click += BtnAgregarPrenda_Click;
            // 
            // NumUnidades
            // 
            NumUnidades.Location = new Point(997, 376);
            NumUnidades.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            NumUnidades.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumUnidades.Name = "NumUnidades";
            NumUnidades.Size = new Size(98, 23);
            NumUnidades.TabIndex = 27;
            NumUnidades.TextAlign = HorizontalAlignment.Center;
            NumUnidades.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LblUnidades
            // 
            LblUnidades.AutoSize = true;
            LblUnidades.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblUnidades.ImeMode = ImeMode.NoControl;
            LblUnidades.Location = new Point(913, 377);
            LblUnidades.Name = "LblUnidades";
            LblUnidades.Size = new Size(78, 21);
            LblUnidades.TabIndex = 26;
            LblUnidades.Text = "Unidades";
            // 
            // LblTalle
            // 
            LblTalle.AutoSize = true;
            LblTalle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTalle.ImeMode = ImeMode.NoControl;
            LblTalle.Location = new Point(757, 377);
            LblTalle.Name = "LblTalle";
            LblTalle.Size = new Size(42, 21);
            LblTalle.TabIndex = 25;
            LblTalle.Text = "Talle";
            // 
            // CmbTalle
            // 
            CmbTalle.BackColor = SystemColors.MenuBar;
            CmbTalle.FormattingEnabled = true;
            CmbTalle.Location = new Point(805, 375);
            CmbTalle.Name = "CmbTalle";
            CmbTalle.Size = new Size(98, 23);
            CmbTalle.TabIndex = 24;
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
            DtgPrendasSistema.Location = new Point(32, 46);
            DtgPrendasSistema.Name = "DtgPrendasSistema";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DtgPrendasSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DtgPrendasSistema.RowHeadersVisible = false;
            DtgPrendasSistema.RowTemplate.Height = 25;
            DtgPrendasSistema.ShowEditingIcon = false;
            DtgPrendasSistema.Size = new Size(1322, 300);
            DtgPrendasSistema.TabIndex = 23;
            DtgPrendasSistema.CellContentClick += DtgPrendasSistema_CellClick;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.ImeMode = ImeMode.NoControl;
            BtnCancelar.Location = new Point(997, 802);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(160, 39);
            BtnCancelar.TabIndex = 22;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnCrearCorte
            // 
            BtnCrearCorte.BackColor = Color.FromArgb(192, 255, 192);
            BtnCrearCorte.FlatStyle = FlatStyle.Popup;
            BtnCrearCorte.ForeColor = SystemColors.WindowText;
            BtnCrearCorte.ImeMode = ImeMode.NoControl;
            BtnCrearCorte.Location = new Point(1194, 802);
            BtnCrearCorte.Name = "BtnCrearCorte";
            BtnCrearCorte.Size = new Size(160, 39);
            BtnCrearCorte.TabIndex = 21;
            BtnCrearCorte.Text = "Crear confeccion";
            BtnCrearCorte.UseVisualStyleBackColor = false;
            BtnCrearCorte.Click += BtnCrearCorte_Click;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.ForeColor = Color.Transparent;
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.Location = new Point(37, 757);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(72, 80);
            BtnCerrarSesion.TabIndex = 34;
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(31, 835);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 38;
            label4.Text = "Cerrar sesion";
            // 
            // BtnQuitarPrenda
            // 
            BtnQuitarPrenda.BackColor = SystemColors.ButtonShadow;
            BtnQuitarPrenda.FlatStyle = FlatStyle.Flat;
            BtnQuitarPrenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnQuitarPrenda.ForeColor = Color.DarkBlue;
            BtnQuitarPrenda.ImeMode = ImeMode.NoControl;
            BtnQuitarPrenda.Location = new Point(1134, 746);
            BtnQuitarPrenda.Name = "BtnQuitarPrenda";
            BtnQuitarPrenda.Size = new Size(220, 28);
            BtnQuitarPrenda.TabIndex = 39;
            BtnQuitarPrenda.Text = "- Quitar prenda";
            BtnQuitarPrenda.UseVisualStyleBackColor = false;
            BtnQuitarPrenda.Click += BtnQuitarPrenda_Click;
            // 
            // FrmAltaCorte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1384, 861);
            Controls.Add(BtnQuitarPrenda);
            Controls.Add(label4);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(label2);
            Controls.Add(lblSistema);
            Controls.Add(LblErrores);
            Controls.Add(DtgPrendasCorte);
            Controls.Add(BtnAgregarPrenda);
            Controls.Add(NumUnidades);
            Controls.Add(LblUnidades);
            Controls.Add(LblTalle);
            Controls.Add(CmbTalle);
            Controls.Add(DtgPrendasSistema);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnCrearCorte);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAltaCorte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta de cortes";
            Load += FrmAltaCorte_Load;
            ((System.ComponentModel.ISupportInitialize)DtgPrendasCorte).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUnidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblSistema;
        private Label LblErrores;
        private DataGridView DtgPrendasCorte;
        private Button BtnAgregarPrenda;
        private NumericUpDown NumUnidades;
        private Label LblUnidades;
        private Label LblTalle;
        private ComboBox CmbTalle;
        private DataGridView DtgPrendasSistema;
        private Button BtnCancelar;
        private Button BtnCrearCorte;
        private Button BtnCerrarSesion;
        private Label label4;
        private Button BtnQuitarPrenda;
    }
}