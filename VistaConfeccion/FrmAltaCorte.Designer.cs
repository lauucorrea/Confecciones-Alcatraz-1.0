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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaCorte));
            lblDiasEntrega = new Label();
            label2 = new Label();
            lblSistema = new Label();
            LblErrores = new Label();
            DtgPrendasConfeccion = new DataGridView();
            BtnAgregarPrenda = new Button();
            NumUnidades = new NumericUpDown();
            LblUnidades = new Label();
            LblTalle = new Label();
            CmbTalle = new ComboBox();
            DtgPrendasSistema = new DataGridView();
            BtnCancelar = new Button();
            BtnCrearCorte = new Button();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasConfeccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUnidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).BeginInit();
            SuspendLayout();
            // 
            // lblDiasEntrega
            // 
            lblDiasEntrega.AutoSize = true;
            lblDiasEntrega.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiasEntrega.ForeColor = Color.MediumSeaGreen;
            lblDiasEntrega.ImeMode = ImeMode.NoControl;
            lblDiasEntrega.Location = new Point(1115, 439);
            lblDiasEntrega.Name = "lblDiasEntrega";
            lblDiasEntrega.Size = new Size(239, 23);
            lblDiasEntrega.TabIndex = 33;
            lblDiasEntrega.Text = "x dias estimados para entrega";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(32, 439);
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
            // DtgPrendasConfeccion
            // 
            DtgPrendasConfeccion.AllowUserToAddRows = false;
            DtgPrendasConfeccion.AllowUserToDeleteRows = false;
            DtgPrendasConfeccion.AllowUserToResizeColumns = false;
            DtgPrendasConfeccion.AllowUserToResizeRows = false;
            DtgPrendasConfeccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgPrendasConfeccion.BackgroundColor = Color.FromArgb(76, 117, 163);
            DtgPrendasConfeccion.BorderStyle = BorderStyle.None;
            DtgPrendasConfeccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgPrendasConfeccion.Cursor = Cursors.Hand;
            DtgPrendasConfeccion.GridColor = Color.FromArgb(10, 102, 194);
            DtgPrendasConfeccion.Location = new Point(32, 465);
            DtgPrendasConfeccion.Name = "DtgPrendasConfeccion";
            DtgPrendasConfeccion.RowHeadersVisible = false;
            DtgPrendasConfeccion.RowTemplate.Height = 25;
            DtgPrendasConfeccion.ShowEditingIcon = false;
            DtgPrendasConfeccion.Size = new Size(1322, 300);
            DtgPrendasConfeccion.TabIndex = 29;
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
            NumUnidades.Location = new Point(1007, 375);
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
            LblUnidades.Location = new Point(923, 376);
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
            LblTalle.Location = new Point(767, 376);
            LblTalle.Name = "LblTalle";
            LblTalle.Size = new Size(42, 21);
            LblTalle.TabIndex = 25;
            LblTalle.Text = "Talle";
            // 
            // CmbTalle
            // 
            CmbTalle.BackColor = SystemColors.MenuBar;
            CmbTalle.FormattingEnabled = true;
            CmbTalle.Location = new Point(815, 374);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtgPrendasSistema.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtgPrendasSistema.RowHeadersVisible = false;
            DtgPrendasSistema.RowTemplate.Height = 25;
            DtgPrendasSistema.ShowEditingIcon = false;
            DtgPrendasSistema.Size = new Size(1322, 300);
            DtgPrendasSistema.TabIndex = 23;
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
            BtnCrearCorte.Click += BtnAgregarConfeccion_Click;
            // 
            // FrmAltaCorte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1384, 861);
            Controls.Add(lblDiasEntrega);
            Controls.Add(label2);
            Controls.Add(lblSistema);
            Controls.Add(LblErrores);
            Controls.Add(DtgPrendasConfeccion);
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
            ((System.ComponentModel.ISupportInitialize)DtgPrendasConfeccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUnidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiasEntrega;
        private Label label2;
        private Label lblSistema;
        private Label LblErrores;
        private DataGridView DtgPrendasConfeccion;
        private Button BtnAgregarPrenda;
        private NumericUpDown NumUnidades;
        private Label LblUnidades;
        private Label LblTalle;
        private ComboBox CmbTalle;
        private DataGridView DtgPrendasSistema;
        private Button BtnCancelar;
        private Button BtnCrearCorte;
    }
}