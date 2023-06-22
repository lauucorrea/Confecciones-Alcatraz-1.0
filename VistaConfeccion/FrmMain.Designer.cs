namespace VistaConfeccion
{
    partial class FrmMain
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            gestionarInformacionToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            agregToolStripMenuItem = new ToolStripMenuItem();
            buscarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            porNombreToolStripMenuItem = new ToolStripMenuItem();
            mostrarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            prendasToolStripMenuItem = new ToolStripMenuItem();
            agregarPrendaToolStripMenuItem = new ToolStripMenuItem();
            mostrarPrendasToolStripMenuItem = new ToolStripMenuItem();
            reportesDePrendasToolStripMenuItem = new ToolStripMenuItem();
            cortesToolStripMenuItem = new ToolStripMenuItem();
            crearNuevoCorteToolStripMenuItem = new ToolStripMenuItem();
            confreccionesToolStripMenuItem = new ToolStripMenuItem();
            terminacionToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            cortesToolStripMenuItem1 = new ToolStripMenuItem();
            porFechaToolStripMenuItem = new ToolStripMenuItem();
            confreccionesToolStripMenuItem1 = new ToolStripMenuItem();
            terminacionesToolStripMenuItem = new ToolStripMenuItem();
            DtgMuestreoMain = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgMuestreoMain).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionarInformacionToolStripMenuItem, mostrarToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1384, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionarInformacionToolStripMenuItem
            // 
            gestionarInformacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, prendasToolStripMenuItem, cortesToolStripMenuItem, confreccionesToolStripMenuItem, terminacionToolStripMenuItem });
            gestionarInformacionToolStripMenuItem.Name = "gestionarInformacionToolStripMenuItem";
            gestionarInformacionToolStripMenuItem.Size = new Size(60, 20);
            gestionarInformacionToolStripMenuItem.Text = "Sistema";
            gestionarInformacionToolStripMenuItem.Click += gestionarInformacionToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregToolStripMenuItem, buscarUsuarioToolStripMenuItem, mostrarUsuariosToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(180, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // agregToolStripMenuItem
            // 
            agregToolStripMenuItem.Name = "agregToolStripMenuItem";
            agregToolStripMenuItem.Size = new Size(188, 22);
            agregToolStripMenuItem.Text = "+Crear nuevo usuario";
            agregToolStripMenuItem.Click += agregToolStripMenuItem_Click;
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            buscarUsuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porNombreToolStripMenuItem });
            buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            buscarUsuarioToolStripMenuItem.Size = new Size(188, 22);
            buscarUsuarioToolStripMenuItem.Text = "Buscar usuario";
            // 
            // porNombreToolStripMenuItem
            // 
            porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            porNombreToolStripMenuItem.Size = new Size(137, 22);
            porNombreToolStripMenuItem.Text = "Por nombre";
            // 
            // mostrarUsuariosToolStripMenuItem
            // 
            mostrarUsuariosToolStripMenuItem.Name = "mostrarUsuariosToolStripMenuItem";
            mostrarUsuariosToolStripMenuItem.Size = new Size(188, 22);
            mostrarUsuariosToolStripMenuItem.Text = "Mostrar usuarios";
            // 
            // prendasToolStripMenuItem
            // 
            prendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPrendaToolStripMenuItem, mostrarPrendasToolStripMenuItem, reportesDePrendasToolStripMenuItem });
            prendasToolStripMenuItem.Name = "prendasToolStripMenuItem";
            prendasToolStripMenuItem.Size = new Size(180, 22);
            prendasToolStripMenuItem.Text = "Prendas";
            // 
            // agregarPrendaToolStripMenuItem
            // 
            agregarPrendaToolStripMenuItem.Name = "agregarPrendaToolStripMenuItem";
            agregarPrendaToolStripMenuItem.Size = new Size(188, 22);
            agregarPrendaToolStripMenuItem.Text = "+ Crear nueva prenda";
            // 
            // mostrarPrendasToolStripMenuItem
            // 
            mostrarPrendasToolStripMenuItem.Name = "mostrarPrendasToolStripMenuItem";
            mostrarPrendasToolStripMenuItem.Size = new Size(188, 22);
            mostrarPrendasToolStripMenuItem.Text = "Mostrar prendas";
            // 
            // reportesDePrendasToolStripMenuItem
            // 
            reportesDePrendasToolStripMenuItem.Name = "reportesDePrendasToolStripMenuItem";
            reportesDePrendasToolStripMenuItem.Size = new Size(188, 22);
            reportesDePrendasToolStripMenuItem.Text = "Reportes de prendas";
            // 
            // cortesToolStripMenuItem
            // 
            cortesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearNuevoCorteToolStripMenuItem });
            cortesToolStripMenuItem.Name = "cortesToolStripMenuItem";
            cortesToolStripMenuItem.Size = new Size(180, 22);
            cortesToolStripMenuItem.Text = "Cortes";
            // 
            // crearNuevoCorteToolStripMenuItem
            // 
            crearNuevoCorteToolStripMenuItem.Name = "crearNuevoCorteToolStripMenuItem";
            crearNuevoCorteToolStripMenuItem.Size = new Size(180, 22);
            crearNuevoCorteToolStripMenuItem.Text = "+ Crear nuevo corte";
            // 
            // confreccionesToolStripMenuItem
            // 
            confreccionesToolStripMenuItem.Name = "confreccionesToolStripMenuItem";
            confreccionesToolStripMenuItem.Size = new Size(180, 22);
            confreccionesToolStripMenuItem.Text = "Confrecciones";
            // 
            // terminacionToolStripMenuItem
            // 
            terminacionToolStripMenuItem.Name = "terminacionToolStripMenuItem";
            terminacionToolStripMenuItem.Size = new Size(180, 22);
            terminacionToolStripMenuItem.Text = "Terminaciones";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(60, 20);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cortesToolStripMenuItem1, confreccionesToolStripMenuItem1, terminacionesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cortesToolStripMenuItem1
            // 
            cortesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { porFechaToolStripMenuItem });
            cortesToolStripMenuItem1.Name = "cortesToolStripMenuItem1";
            cortesToolStripMenuItem1.Size = new Size(180, 22);
            cortesToolStripMenuItem1.Text = "Cortes";
            // 
            // porFechaToolStripMenuItem
            // 
            porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            porFechaToolStripMenuItem.Size = new Size(124, 22);
            porFechaToolStripMenuItem.Text = "Por fecha";
            // 
            // confreccionesToolStripMenuItem1
            // 
            confreccionesToolStripMenuItem1.Name = "confreccionesToolStripMenuItem1";
            confreccionesToolStripMenuItem1.Size = new Size(180, 22);
            confreccionesToolStripMenuItem1.Text = "Confrecciones";
            // 
            // terminacionesToolStripMenuItem
            // 
            terminacionesToolStripMenuItem.Name = "terminacionesToolStripMenuItem";
            terminacionesToolStripMenuItem.Size = new Size(180, 22);
            terminacionesToolStripMenuItem.Text = "Terminaciones";
            // 
            // DtgMuestreoMain
            // 
            DtgMuestreoMain.AllowUserToAddRows = false;
            DtgMuestreoMain.AllowUserToDeleteRows = false;
            DtgMuestreoMain.AllowUserToResizeColumns = false;
            DtgMuestreoMain.AllowUserToResizeRows = false;
            DtgMuestreoMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgMuestreoMain.BackgroundColor = Color.FromArgb(76, 117, 163);
            DtgMuestreoMain.BorderStyle = BorderStyle.None;
            DtgMuestreoMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgMuestreoMain.Cursor = Cursors.Hand;
            DtgMuestreoMain.GridColor = Color.FromArgb(10, 102, 194);
            DtgMuestreoMain.Location = new Point(12, 57);
            DtgMuestreoMain.Name = "DtgMuestreoMain";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DtgMuestreoMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DtgMuestreoMain.RowHeadersVisible = false;
            DtgMuestreoMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DtgMuestreoMain.RowTemplate.Height = 25;
            DtgMuestreoMain.ShowEditingIcon = false;
            DtgMuestreoMain.Size = new Size(1360, 792);
            DtgMuestreoMain.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1384, 861);
            Controls.Add(DtgMuestreoMain);
            Controls.Add(menuStrip1);
            ForeColor = Color.DarkBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confecciones Alcatraz";
            Load += FrmConfecciones_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgMuestreoMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem gestionarInformacionToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem cortesToolStripMenuItem1;
        private ToolStripMenuItem porFechaToolStripMenuItem;
        private ToolStripMenuItem confreccionesToolStripMenuItem1;
        private ToolStripMenuItem prendasToolStripMenuItem;
        private ToolStripMenuItem agregarPrendaToolStripMenuItem;
        private ToolStripMenuItem cortesToolStripMenuItem;
        private ToolStripMenuItem confreccionesToolStripMenuItem;
        private ToolStripMenuItem agregToolStripMenuItem;
        private ToolStripMenuItem buscarUsuarioToolStripMenuItem;
        private ToolStripMenuItem porNombreToolStripMenuItem;
        private ToolStripMenuItem mostrarUsuariosToolStripMenuItem;
        private ToolStripMenuItem mostrarPrendasToolStripMenuItem;
        private ToolStripMenuItem reportesDePrendasToolStripMenuItem;
        private ToolStripMenuItem crearNuevoCorteToolStripMenuItem;
        private ToolStripMenuItem terminacionToolStripMenuItem;
        private ToolStripMenuItem terminacionesToolStripMenuItem;
        private DataGridView DtgMuestreoMain;
    }
}