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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BtnAgregarConfeccion = new Button();
            BtnCancelar = new Button();
            DtgPrendasSistema = new DataGridView();
            CmbTalle = new ComboBox();
            LblTalle = new Label();
            LblUnidades = new Label();
            NumUnidades = new NumericUpDown();
            McFechaEntrega = new MiCalendario();
            label1 = new Label();
            BtnAgregarPrenda = new Button();
            DtgPrendasConfeccion = new DataGridView();
            DtgFechasPrevistas = new DataGridView();
            LblErrores = new Label();
            lblSistema = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDiasEntrega = new Label();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUnidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasConfeccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgFechasPrevistas).BeginInit();
            SuspendLayout();
            // 
            // BtnAgregarConfeccion
            // 
            BtnAgregarConfeccion.BackColor = Color.FromArgb(192, 255, 192);
            resources.ApplyResources(BtnAgregarConfeccion, "BtnAgregarConfeccion");
            BtnAgregarConfeccion.ForeColor = SystemColors.WindowText;
            BtnAgregarConfeccion.Name = "BtnAgregarConfeccion";
            BtnAgregarConfeccion.UseVisualStyleBackColor = false;
            BtnAgregarConfeccion.Click += BtnAgregarConfeccion_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            resources.ApplyResources(BtnCancelar, "BtnCancelar");
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
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
            resources.ApplyResources(DtgPrendasSistema, "DtgPrendasSistema");
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
            DtgPrendasSistema.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DtgPrendasSistema.RowTemplate.Height = 25;
            DtgPrendasSistema.ShowEditingIcon = false;
            DtgPrendasSistema.CellClick += DtgPrendasSistema_CellClick;
            // 
            // CmbTalle
            // 
            CmbTalle.BackColor = SystemColors.MenuBar;
            CmbTalle.FormattingEnabled = true;
            resources.ApplyResources(CmbTalle, "CmbTalle");
            CmbTalle.Name = "CmbTalle";
            // 
            // LblTalle
            // 
            resources.ApplyResources(LblTalle, "LblTalle");
            LblTalle.Name = "LblTalle";
            // 
            // LblUnidades
            // 
            resources.ApplyResources(LblUnidades, "LblUnidades");
            LblUnidades.Name = "LblUnidades";
            // 
            // NumUnidades
            // 
            resources.ApplyResources(NumUnidades, "NumUnidades");
            NumUnidades.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            NumUnidades.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumUnidades.Name = "NumUnidades";
            NumUnidades.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // McFechaEntrega
            // 
            McFechaEntrega.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(McFechaEntrega, "McFechaEntrega");
            McFechaEntrega.Cursor = Cursors.Hand;
            McFechaEntrega.ForeColor = SystemColors.ControlText;
            McFechaEntrega.MaxSelectionCount = 800;
            McFechaEntrega.Name = "McFechaEntrega";
            McFechaEntrega.ShowToday = false;
            McFechaEntrega.TitleBackColor = Color.AliceBlue;
            McFechaEntrega.TitleForeColor = Color.Black;
            McFechaEntrega.TrailingForeColor = Color.DarkGoldenrod;
            McFechaEntrega.DateChanged += McFechaEntrega_DateChanged;
            McFechaEntrega.DateSelected += McFechaEntrega_DateSelected;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // BtnAgregarPrenda
            // 
            BtnAgregarPrenda.BackColor = Color.FromArgb(192, 255, 192);
            BtnAgregarPrenda.Cursor = Cursors.Hand;
            resources.ApplyResources(BtnAgregarPrenda, "BtnAgregarPrenda");
            BtnAgregarPrenda.ForeColor = SystemColors.Desktop;
            BtnAgregarPrenda.Name = "BtnAgregarPrenda";
            BtnAgregarPrenda.UseVisualStyleBackColor = false;
            BtnAgregarPrenda.Click += BtnAgregarPrenda_Click;
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
            resources.ApplyResources(DtgPrendasConfeccion, "DtgPrendasConfeccion");
            DtgPrendasConfeccion.Name = "DtgPrendasConfeccion";
            DtgPrendasConfeccion.RowHeadersVisible = false;
            DtgPrendasConfeccion.RowTemplate.Height = 25;
            DtgPrendasConfeccion.ShowEditingIcon = false;
            // 
            // DtgFechasPrevistas
            // 
            DtgFechasPrevistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgFechasPrevistas.BackgroundColor = Color.LightSteelBlue;
            DtgFechasPrevistas.BorderStyle = BorderStyle.None;
            DtgFechasPrevistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgFechasPrevistas.GridColor = Color.FromArgb(76, 117, 163);
            resources.ApplyResources(DtgFechasPrevistas, "DtgFechasPrevistas");
            DtgFechasPrevistas.Name = "DtgFechasPrevistas";
            DtgFechasPrevistas.RowHeadersVisible = false;
            DtgFechasPrevistas.RowTemplate.Height = 25;
            // 
            // LblErrores
            // 
            resources.ApplyResources(LblErrores, "LblErrores");
            LblErrores.Name = "LblErrores";
            // 
            // lblSistema
            // 
            resources.ApplyResources(lblSistema, "lblSistema");
            lblSistema.Name = "lblSistema";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // lblDiasEntrega
            // 
            resources.ApplyResources(lblDiasEntrega, "lblDiasEntrega");
            lblDiasEntrega.ForeColor = Color.MediumSeaGreen;
            lblDiasEntrega.Name = "lblDiasEntrega";
            // 
            // FrmAltaConfeccion
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(lblDiasEntrega);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSistema);
            Controls.Add(LblErrores);
            Controls.Add(DtgFechasPrevistas);
            Controls.Add(DtgPrendasConfeccion);
            Controls.Add(BtnAgregarPrenda);
            Controls.Add(label1);
            Controls.Add(McFechaEntrega);
            Controls.Add(NumUnidades);
            Controls.Add(LblUnidades);
            Controls.Add(LblTalle);
            Controls.Add(CmbTalle);
            Controls.Add(DtgPrendasSistema);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregarConfeccion);
            ForeColor = Color.DarkBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAltaConfeccion";
            Load += FrmAltaConfeccion_Load;
            ((System.ComponentModel.ISupportInitialize)DtgPrendasSistema).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUnidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgPrendasConfeccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgFechasPrevistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregarConfeccion;
        private Button BtnCancelar;
        private DataGridView DtgPrendasSistema;
        private ComboBox CmbTalle;
        private Label LblTalle;
        private Label LblUnidades;
        private NumericUpDown NumUnidades;
        private MiCalendario McFechaEntrega;
        private Label label1;
        private Button BtnAgregarPrenda;
        private DataGridView DtgPrendasConfeccion;
        private DataGridView DtgFechasPrevistas;
        private Label LblErrores;
        private Label lblSistema;
        private Label label2;
        private Label label3;
        private Label lblDiasEntrega;
    }
}