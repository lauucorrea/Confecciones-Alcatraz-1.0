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
            this.DtgPrendasSistema = new System.Windows.Forms.DataGridView();
            this.CmbTalle = new System.Windows.Forms.ComboBox();
            this.LblTalle = new System.Windows.Forms.Label();
            this.LblUnidades = new System.Windows.Forms.Label();
            this.NumUnidades = new System.Windows.Forms.NumericUpDown();
            this.McFechaEntrega = new VistaConfeccion.MiCalendario();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregarPrenda = new System.Windows.Forms.Button();
            this.DtgPrendasConfeccion = new System.Windows.Forms.DataGridView();
            this.DtgFechasPrevistas = new System.Windows.Forms.DataGridView();
            this.LblErrores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPrendasSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPrendasConfeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFechasPrevistas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregarConfeccion
            // 
            this.BtnAgregarConfeccion.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.BtnAgregarConfeccion, "BtnAgregarConfeccion");
            this.BtnAgregarConfeccion.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarConfeccion.Name = "BtnAgregarConfeccion";
            this.BtnAgregarConfeccion.UseVisualStyleBackColor = false;
            this.BtnAgregarConfeccion.Click += new System.EventHandler(this.BtnAgregarConfeccion_Click);
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
            // DtgPrendasSistema
            // 
            this.DtgPrendasSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DtgPrendasSistema, "DtgPrendasSistema");
            this.DtgPrendasSistema.Name = "DtgPrendasSistema";
            this.DtgPrendasSistema.RowTemplate.Height = 25;
            this.DtgPrendasSistema.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPrendasSistema_CellClick);
            // 
            // CmbTalle
            // 
            this.CmbTalle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CmbTalle.FormattingEnabled = true;
            resources.ApplyResources(this.CmbTalle, "CmbTalle");
            this.CmbTalle.Name = "CmbTalle";
            // 
            // LblTalle
            // 
            resources.ApplyResources(this.LblTalle, "LblTalle");
            this.LblTalle.Name = "LblTalle";
            // 
            // LblUnidades
            // 
            resources.ApplyResources(this.LblUnidades, "LblUnidades");
            this.LblUnidades.Name = "LblUnidades";
            // 
            // NumUnidades
            // 
            resources.ApplyResources(this.NumUnidades, "NumUnidades");
            this.NumUnidades.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.NumUnidades.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUnidades.Name = "NumUnidades";
            this.NumUnidades.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // McFechaEntrega
            // 
            this.McFechaEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.McFechaEntrega, "McFechaEntrega");
            this.McFechaEntrega.MaxSelectionCount = 20;
            this.McFechaEntrega.Name = "McFechaEntrega";
            this.McFechaEntrega.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.McFechaEntrega_DateChanged);
            this.McFechaEntrega.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McFechaEntrega_DateSelected);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BtnAgregarPrenda
            // 
            this.BtnAgregarPrenda.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnAgregarPrenda.ForeColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.BtnAgregarPrenda, "BtnAgregarPrenda");
            this.BtnAgregarPrenda.Name = "BtnAgregarPrenda";
            this.BtnAgregarPrenda.UseVisualStyleBackColor = false;
            this.BtnAgregarPrenda.Click += new System.EventHandler(this.BtnAgregarPrenda_Click);
            // 
            // DtgPrendasConfeccion
            // 
            this.DtgPrendasConfeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgPrendasConfeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DtgPrendasConfeccion, "DtgPrendasConfeccion");
            this.DtgPrendasConfeccion.Name = "DtgPrendasConfeccion";
            this.DtgPrendasConfeccion.RowTemplate.Height = 25;
            // 
            // DtgFechasPrevistas
            // 
            this.DtgFechasPrevistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DtgFechasPrevistas, "DtgFechasPrevistas");
            this.DtgFechasPrevistas.Name = "DtgFechasPrevistas";
            this.DtgFechasPrevistas.RowTemplate.Height = 25;
            // 
            // LblErrores
            // 
            resources.ApplyResources(this.LblErrores, "LblErrores");
            this.LblErrores.Name = "LblErrores";
            // 
            // FrmAltaConfeccion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.LblErrores);
            this.Controls.Add(this.DtgFechasPrevistas);
            this.Controls.Add(this.DtgPrendasConfeccion);
            this.Controls.Add(this.BtnAgregarPrenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.McFechaEntrega);
            this.Controls.Add(this.NumUnidades);
            this.Controls.Add(this.LblUnidades);
            this.Controls.Add(this.LblTalle);
            this.Controls.Add(this.CmbTalle);
            this.Controls.Add(this.DtgPrendasSistema);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregarConfeccion);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "FrmAltaConfeccion";
            this.Load += new System.EventHandler(this.FrmAltaConfeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPrendasSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPrendasConfeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFechasPrevistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}