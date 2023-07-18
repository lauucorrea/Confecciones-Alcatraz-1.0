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
            MstGestion = new MenuStrip();
            GestionarInformacionToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            Sistema_CrearUsuario = new ToolStripMenuItem();
            Sistema_MostrarUsuarios = new ToolStripMenuItem();
            prendasToolStripMenuItem = new ToolStripMenuItem();
            agregarPrendaToolStripMenuItem = new ToolStripMenuItem();
            mostrarPrendasToolStripMenuItem = new ToolStripMenuItem();
            cortesToolStripMenuItem = new ToolStripMenuItem();
            crearNuevoCorteToolStripMenuItem = new ToolStripMenuItem();
            mostrarCortesToolStripMenuItem = new ToolStripMenuItem();
            confreccionesToolStripMenuItem = new ToolStripMenuItem();
            crearNuevaConfeccionToolStripMenuItem = new ToolStripMenuItem();
            mostrarConfeccionesToolStripMenuItem = new ToolStripMenuItem();
            terminacionToolStripMenuItem = new ToolStripMenuItem();
            crearNuevaTerminacionToolStripMenuItem = new ToolStripMenuItem();
            mostrarTerminacionesToolStripMenuItem = new ToolStripMenuItem();
            modificarJornadaToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            TsmiReportes = new ToolStripMenuItem();
            reporteDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            ordenarPorJerarquiaToolStripMenuItem = new ToolStripMenuItem();
            ordenarPorNombreToolStripMenuItem = new ToolStripMenuItem();
            ordenarPorDNIToolStripMenuItem = new ToolStripMenuItem();
            reportesDePrendasToolStripMenuItem = new ToolStripMenuItem();
            ordenarPorTalleToolStripMenuItem = new ToolStripMenuItem();
            ordenarPorTipoToolStripMenuItem = new ToolStripMenuItem();
            ordenarPorProduccionToolStripMenuItem = new ToolStripMenuItem();
            cortesToolStripMenuItem1 = new ToolStripMenuItem();
            porFechaToolStripMenuItem = new ToolStripMenuItem();
            porFechaDeEntregaToolStripMenuItem = new ToolStripMenuItem();
            porEtapaToolStripMenuItem = new ToolStripMenuItem();
            porTiempoDeProduccionToolStripMenuItem = new ToolStripMenuItem();
            porTallesDePrendasToolStripMenuItem = new ToolStripMenuItem();
            confreccionesToolStripMenuItem1 = new ToolStripMenuItem();
            terminacionesToolStripMenuItem = new ToolStripMenuItem();
            DtgMuestreoMain = new DataGridView();
            label4 = new Label();
            BtnCerrarSesion = new Button();
            MstGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgMuestreoMain).BeginInit();
            SuspendLayout();
            // 
            // MstGestion
            // 
            MstGestion.Items.AddRange(new ToolStripItem[] { GestionarInformacionToolStripMenuItem, mostrarToolStripMenuItem, TsmiReportes });
            MstGestion.Location = new Point(0, 0);
            MstGestion.Name = "MstGestion";
            MstGestion.Size = new Size(1384, 24);
            MstGestion.TabIndex = 5;
            MstGestion.Text = "menuStrip1";
            // 
            // GestionarInformacionToolStripMenuItem
            // 
            GestionarInformacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, prendasToolStripMenuItem, cortesToolStripMenuItem, confreccionesToolStripMenuItem, terminacionToolStripMenuItem, modificarJornadaToolStripMenuItem });
            GestionarInformacionToolStripMenuItem.Name = "GestionarInformacionToolStripMenuItem";
            GestionarInformacionToolStripMenuItem.Size = new Size(60, 20);
            GestionarInformacionToolStripMenuItem.Text = "Sistema";
            GestionarInformacionToolStripMenuItem.Click += GestionarInformacionToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Sistema_CrearUsuario, Sistema_MostrarUsuarios });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(180, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += UsuariosToolStripMenuItem_Click;
            // 
            // Sistema_CrearUsuario
            // 
            Sistema_CrearUsuario.Name = "Sistema_CrearUsuario";
            Sistema_CrearUsuario.Size = new Size(188, 22);
            Sistema_CrearUsuario.Text = "+Crear nuevo usuario";
            Sistema_CrearUsuario.Click += AgregToolStripMenuItem_Click;
            // 
            // Sistema_MostrarUsuarios
            // 
            Sistema_MostrarUsuarios.Name = "Sistema_MostrarUsuarios";
            Sistema_MostrarUsuarios.Size = new Size(188, 22);
            Sistema_MostrarUsuarios.Text = "Mostrar usuarios";
            Sistema_MostrarUsuarios.Click += MostrarUsuariosToolStripMenuItem_Click;
            // 
            // prendasToolStripMenuItem
            // 
            prendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPrendaToolStripMenuItem, mostrarPrendasToolStripMenuItem });
            prendasToolStripMenuItem.Name = "prendasToolStripMenuItem";
            prendasToolStripMenuItem.Size = new Size(180, 22);
            prendasToolStripMenuItem.Text = "Prendas";
            // 
            // agregarPrendaToolStripMenuItem
            // 
            agregarPrendaToolStripMenuItem.Name = "agregarPrendaToolStripMenuItem";
            agregarPrendaToolStripMenuItem.Size = new Size(188, 22);
            agregarPrendaToolStripMenuItem.Text = "+ Crear nueva prenda";
            agregarPrendaToolStripMenuItem.Click += AgregarPrendaToolStripMenuItem_Click;
            // 
            // mostrarPrendasToolStripMenuItem
            // 
            mostrarPrendasToolStripMenuItem.Name = "mostrarPrendasToolStripMenuItem";
            mostrarPrendasToolStripMenuItem.Size = new Size(188, 22);
            mostrarPrendasToolStripMenuItem.Text = "Mostrar prendas";
            mostrarPrendasToolStripMenuItem.Click += MostrarPrendasToolStripMenuItem_Click;
            // 
            // cortesToolStripMenuItem
            // 
            cortesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearNuevoCorteToolStripMenuItem, mostrarCortesToolStripMenuItem });
            cortesToolStripMenuItem.Name = "cortesToolStripMenuItem";
            cortesToolStripMenuItem.Size = new Size(180, 22);
            cortesToolStripMenuItem.Text = "Cortes";
            // 
            // crearNuevoCorteToolStripMenuItem
            // 
            crearNuevoCorteToolStripMenuItem.Name = "crearNuevoCorteToolStripMenuItem";
            crearNuevoCorteToolStripMenuItem.Size = new Size(180, 22);
            crearNuevoCorteToolStripMenuItem.Text = "+ Crear nuevo corte";
            crearNuevoCorteToolStripMenuItem.Click += CrearNuevoCorteToolStripMenuItem_Click;
            // 
            // mostrarCortesToolStripMenuItem
            // 
            mostrarCortesToolStripMenuItem.Name = "mostrarCortesToolStripMenuItem";
            mostrarCortesToolStripMenuItem.Size = new Size(180, 22);
            mostrarCortesToolStripMenuItem.Text = "Mostrar cortes";
            mostrarCortesToolStripMenuItem.Click += MostrarCortesToolStripMenuItem_Click;
            // 
            // confreccionesToolStripMenuItem
            // 
            confreccionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearNuevaConfeccionToolStripMenuItem, mostrarConfeccionesToolStripMenuItem });
            confreccionesToolStripMenuItem.Name = "confreccionesToolStripMenuItem";
            confreccionesToolStripMenuItem.Size = new Size(180, 22);
            confreccionesToolStripMenuItem.Text = "Confrecciones";
            // 
            // crearNuevaConfeccionToolStripMenuItem
            // 
            crearNuevaConfeccionToolStripMenuItem.Name = "crearNuevaConfeccionToolStripMenuItem";
            crearNuevaConfeccionToolStripMenuItem.Size = new Size(210, 22);
            crearNuevaConfeccionToolStripMenuItem.Text = "+ Crear nueva confeccion";
            // 
            // mostrarConfeccionesToolStripMenuItem
            // 
            mostrarConfeccionesToolStripMenuItem.Name = "mostrarConfeccionesToolStripMenuItem";
            mostrarConfeccionesToolStripMenuItem.Size = new Size(210, 22);
            mostrarConfeccionesToolStripMenuItem.Text = "Mostrar confecciones";
            // 
            // terminacionToolStripMenuItem
            // 
            terminacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearNuevaTerminacionToolStripMenuItem, mostrarTerminacionesToolStripMenuItem });
            terminacionToolStripMenuItem.Name = "terminacionToolStripMenuItem";
            terminacionToolStripMenuItem.Size = new Size(180, 22);
            terminacionToolStripMenuItem.Text = "Terminaciones";
            // 
            // crearNuevaTerminacionToolStripMenuItem
            // 
            crearNuevaTerminacionToolStripMenuItem.Name = "crearNuevaTerminacionToolStripMenuItem";
            crearNuevaTerminacionToolStripMenuItem.Size = new Size(215, 22);
            crearNuevaTerminacionToolStripMenuItem.Text = "+ Crear nueva terminacion";
            // 
            // mostrarTerminacionesToolStripMenuItem
            // 
            mostrarTerminacionesToolStripMenuItem.Name = "mostrarTerminacionesToolStripMenuItem";
            mostrarTerminacionesToolStripMenuItem.Size = new Size(215, 22);
            mostrarTerminacionesToolStripMenuItem.Text = "Mostrar terminaciones";
            // 
            // modificarJornadaToolStripMenuItem
            // 
            modificarJornadaToolStripMenuItem.Name = "modificarJornadaToolStripMenuItem";
            modificarJornadaToolStripMenuItem.Size = new Size(180, 22);
            modificarJornadaToolStripMenuItem.Text = "Modificar Jornada";
            modificarJornadaToolStripMenuItem.Click += ModificarJornadaToolStripMenuItem_Click;
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(60, 20);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += MostrarToolStripMenuItem_Click;
            // 
            // TsmiReportes
            // 
            TsmiReportes.DropDownItems.AddRange(new ToolStripItem[] { reporteDeUsuariosToolStripMenuItem, reportesDePrendasToolStripMenuItem, cortesToolStripMenuItem1, confreccionesToolStripMenuItem1, terminacionesToolStripMenuItem });
            TsmiReportes.Name = "TsmiReportes";
            TsmiReportes.Size = new Size(65, 20);
            TsmiReportes.Text = "Reportes";
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            reporteDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordenarPorJerarquiaToolStripMenuItem, ordenarPorNombreToolStripMenuItem, ordenarPorDNIToolStripMenuItem });
            reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            reporteDeUsuariosToolStripMenuItem.Size = new Size(180, 22);
            reporteDeUsuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // ordenarPorJerarquiaToolStripMenuItem
            // 
            ordenarPorJerarquiaToolStripMenuItem.Name = "ordenarPorJerarquiaToolStripMenuItem";
            ordenarPorJerarquiaToolStripMenuItem.Size = new Size(187, 22);
            ordenarPorJerarquiaToolStripMenuItem.Text = "Ordenar por jerarquia";
            ordenarPorJerarquiaToolStripMenuItem.Click += OrdenarPorJerarquiaToolStripMenuItem_Click;
            // 
            // ordenarPorNombreToolStripMenuItem
            // 
            ordenarPorNombreToolStripMenuItem.Name = "ordenarPorNombreToolStripMenuItem";
            ordenarPorNombreToolStripMenuItem.Size = new Size(187, 22);
            ordenarPorNombreToolStripMenuItem.Text = "Ordenar por nombre";
            ordenarPorNombreToolStripMenuItem.Click += OrdenarPorNombreToolStripMenuItem_Click;
            // 
            // ordenarPorDNIToolStripMenuItem
            // 
            ordenarPorDNIToolStripMenuItem.Name = "ordenarPorDNIToolStripMenuItem";
            ordenarPorDNIToolStripMenuItem.Size = new Size(187, 22);
            ordenarPorDNIToolStripMenuItem.Text = "Ordenar por DNI";
            ordenarPorDNIToolStripMenuItem.Click += OrdenarPorDNIToolStripMenuItem_Click;
            // 
            // reportesDePrendasToolStripMenuItem
            // 
            reportesDePrendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordenarPorTalleToolStripMenuItem, ordenarPorTipoToolStripMenuItem, ordenarPorProduccionToolStripMenuItem });
            reportesDePrendasToolStripMenuItem.Name = "reportesDePrendasToolStripMenuItem";
            reportesDePrendasToolStripMenuItem.Size = new Size(180, 22);
            reportesDePrendasToolStripMenuItem.Text = "Prendas";
            // 
            // ordenarPorTalleToolStripMenuItem
            // 
            ordenarPorTalleToolStripMenuItem.Name = "ordenarPorTalleToolStripMenuItem";
            ordenarPorTalleToolStripMenuItem.Size = new Size(202, 22);
            ordenarPorTalleToolStripMenuItem.Text = "Ordenar por talle";
            ordenarPorTalleToolStripMenuItem.Click += OrdenarPorTalleToolStripMenuItem_Click;
            // 
            // ordenarPorTipoToolStripMenuItem
            // 
            ordenarPorTipoToolStripMenuItem.Name = "ordenarPorTipoToolStripMenuItem";
            ordenarPorTipoToolStripMenuItem.Size = new Size(202, 22);
            ordenarPorTipoToolStripMenuItem.Text = "Ordenar por tipo";
            ordenarPorTipoToolStripMenuItem.Click += OrdenarPorTipoToolStripMenuItem_Click;
            // 
            // ordenarPorProduccionToolStripMenuItem
            // 
            ordenarPorProduccionToolStripMenuItem.Name = "ordenarPorProduccionToolStripMenuItem";
            ordenarPorProduccionToolStripMenuItem.Size = new Size(202, 22);
            ordenarPorProduccionToolStripMenuItem.Text = "Ordenar por produccion";
            ordenarPorProduccionToolStripMenuItem.Click += OrdenarPorProduccionToolStripMenuItem_Click;
            // 
            // cortesToolStripMenuItem1
            // 
            cortesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { porFechaToolStripMenuItem, porFechaDeEntregaToolStripMenuItem, porEtapaToolStripMenuItem, porTiempoDeProduccionToolStripMenuItem, porTallesDePrendasToolStripMenuItem });
            cortesToolStripMenuItem1.Name = "cortesToolStripMenuItem1";
            cortesToolStripMenuItem1.Size = new Size(180, 22);
            cortesToolStripMenuItem1.Text = "Cortes";
            // 
            // porFechaToolStripMenuItem
            // 
            porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            porFechaToolStripMenuItem.Size = new Size(213, 22);
            porFechaToolStripMenuItem.Text = "Por fecha de inicio";
            porFechaToolStripMenuItem.Click += PorFechaToolStripMenuItem_Click;
            // 
            // porFechaDeEntregaToolStripMenuItem
            // 
            porFechaDeEntregaToolStripMenuItem.Name = "porFechaDeEntregaToolStripMenuItem";
            porFechaDeEntregaToolStripMenuItem.Size = new Size(213, 22);
            porFechaDeEntregaToolStripMenuItem.Text = "Por fecha de entrega";
            porFechaDeEntregaToolStripMenuItem.Click += PorFechaDeEntregaToolStripMenuItem_Click;
            // 
            // porEtapaToolStripMenuItem
            // 
            porEtapaToolStripMenuItem.Name = "porEtapaToolStripMenuItem";
            porEtapaToolStripMenuItem.Size = new Size(213, 22);
            porEtapaToolStripMenuItem.Text = "Por etapa";
            porEtapaToolStripMenuItem.Click += PorEtapaToolStripMenuItem_Click;
            // 
            // porTiempoDeProduccionToolStripMenuItem
            // 
            porTiempoDeProduccionToolStripMenuItem.Name = "porTiempoDeProduccionToolStripMenuItem";
            porTiempoDeProduccionToolStripMenuItem.Size = new Size(213, 22);
            porTiempoDeProduccionToolStripMenuItem.Text = "Por tiempo de produccion";
            porTiempoDeProduccionToolStripMenuItem.Click += PorTiempoDeProduccionToolStripMenuItem_Click;
            // 
            // porTallesDePrendasToolStripMenuItem
            // 
            porTallesDePrendasToolStripMenuItem.Name = "porTallesDePrendasToolStripMenuItem";
            porTallesDePrendasToolStripMenuItem.Size = new Size(213, 22);
            porTallesDePrendasToolStripMenuItem.Text = "Por talles de prendas";
            porTallesDePrendasToolStripMenuItem.Click += PorTallesDePrendasToolStripMenuItem_Click;
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
            DtgMuestreoMain.Location = new Point(12, 37);
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
            DtgMuestreoMain.Size = new Size(1360, 705);
            DtgMuestreoMain.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(24, 834);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 43;
            label4.Text = "Cerrar sesion";
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.Cursor = Cursors.Hand;
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.ForeColor = Color.Transparent;
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.Location = new Point(30, 756);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(72, 80);
            BtnCerrarSesion.TabIndex = 42;
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1384, 861);
            Controls.Add(label4);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(DtgMuestreoMain);
            Controls.Add(MstGestion);
            ForeColor = Color.DarkBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MstGestion;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confecciones Alcatraz";
            Load += FrmConfecciones_Load;
            MstGestion.ResumeLayout(false);
            MstGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgMuestreoMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MstGestion;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem TsmiReportes;
        private ToolStripMenuItem GestionarInformacionToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem cortesToolStripMenuItem1;
        private ToolStripMenuItem porFechaToolStripMenuItem;
        private ToolStripMenuItem confreccionesToolStripMenuItem1;
        private ToolStripMenuItem prendasToolStripMenuItem;
        private ToolStripMenuItem agregarPrendaToolStripMenuItem;
        private ToolStripMenuItem cortesToolStripMenuItem;
        private ToolStripMenuItem confreccionesToolStripMenuItem;
        private ToolStripMenuItem Sistema_CrearUsuario;
        private ToolStripMenuItem Sistema_MostrarUsuarios;
        private ToolStripMenuItem mostrarPrendasToolStripMenuItem;
        private ToolStripMenuItem crearNuevoCorteToolStripMenuItem;
        private ToolStripMenuItem terminacionToolStripMenuItem;
        private ToolStripMenuItem terminacionesToolStripMenuItem;
        private DataGridView DtgMuestreoMain;
        private ToolStripMenuItem mostrarCortesToolStripMenuItem;
        private ToolStripMenuItem crearNuevaConfeccionToolStripMenuItem;
        private ToolStripMenuItem mostrarConfeccionesToolStripMenuItem;
        private ToolStripMenuItem crearNuevaTerminacionToolStripMenuItem;
        private ToolStripMenuItem mostrarTerminacionesToolStripMenuItem;
        private ToolStripMenuItem reportesDePrendasToolStripMenuItem;
        private ToolStripMenuItem ordenarPorTalleToolStripMenuItem;
        private ToolStripMenuItem ordenarPorTipoToolStripMenuItem;
        private ToolStripMenuItem ordenarPorProduccionToolStripMenuItem;
        private ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem ordenarPorJerarquiaToolStripMenuItem;
        private ToolStripMenuItem ordenarPorNombreToolStripMenuItem;
        private ToolStripMenuItem ordenarPorDNIToolStripMenuItem;
        private ToolStripMenuItem porFechaDeEntregaToolStripMenuItem;
        private ToolStripMenuItem porEtapaToolStripMenuItem;
        private ToolStripMenuItem porTiempoDeProduccionToolStripMenuItem;
        private ToolStripMenuItem porTallesDePrendasToolStripMenuItem;
        private ToolStripMenuItem modificarJornadaToolStripMenuItem;
        private Label label4;
        private Button BtnCerrarSesion;
    }
}