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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            tareaSemanalToolStripMenuItem = new ToolStripMenuItem();
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
            porJerarquiaToolStripMenuItem = new ToolStripMenuItem();
            porNombreToolStripMenuItem = new ToolStripMenuItem();
            porDNIToolStripMenuItem = new ToolStripMenuItem();
            reportesDePrendasToolStripMenuItem = new ToolStripMenuItem();
            porTalleToolStripMenuItem = new ToolStripMenuItem();
            porTipoToolStripMenuItem = new ToolStripMenuItem();
            porProduccionToolStripMenuItem = new ToolStripMenuItem();
            porFechaToolStripMenuItem = new ToolStripMenuItem();
            porFechaFinalToolStripMenuItem = new ToolStripMenuItem();
            cortesToolStripMenuItem1 = new ToolStripMenuItem();
            porEtapaToolStripMenuItem = new ToolStripMenuItem();
            porTiempoDeProduccionToolStripMenuItem = new ToolStripMenuItem();
            confreccionesToolStripMenuItem1 = new ToolStripMenuItem();
            terminacionesToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            DtgMuestreoMain = new DataGridView();
            label4 = new Label();
            BtnCerrarSesion = new Button();
            MstGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgMuestreoMain).BeginInit();
            SuspendLayout();
            // 
            // MstGestion
            // 
            MstGestion.AutoSize = false;
            MstGestion.BackColor = Color.Azure;
            MstGestion.Font = new Font("Yu Gothic UI Semilight", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MstGestion.Items.AddRange(new ToolStripItem[] { GestionarInformacionToolStripMenuItem, mostrarToolStripMenuItem, TsmiReportes });
            MstGestion.Location = new Point(0, 0);
            MstGestion.Name = "MstGestion";
            MstGestion.Size = new Size(1384, 50);
            MstGestion.TabIndex = 5;
            MstGestion.Text = "menuStrip1";
            // 
            // GestionarInformacionToolStripMenuItem
            // 
            GestionarInformacionToolStripMenuItem.BackColor = Color.Azure;
            GestionarInformacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, prendasToolStripMenuItem, cortesToolStripMenuItem, confreccionesToolStripMenuItem, terminacionToolStripMenuItem, modificarJornadaToolStripMenuItem });
            GestionarInformacionToolStripMenuItem.ForeColor = Color.Black;
            GestionarInformacionToolStripMenuItem.Name = "GestionarInformacionToolStripMenuItem";
            GestionarInformacionToolStripMenuItem.Size = new Size(82, 46);
            GestionarInformacionToolStripMenuItem.Text = "Sistema";
            GestionarInformacionToolStripMenuItem.Click += GestionarInformacionToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Sistema_CrearUsuario, Sistema_MostrarUsuarios });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(219, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += UsuariosToolStripMenuItem_Click;
            // 
            // Sistema_CrearUsuario
            // 
            Sistema_CrearUsuario.Name = "Sistema_CrearUsuario";
            Sistema_CrearUsuario.Size = new Size(248, 26);
            Sistema_CrearUsuario.Text = "+Crear nuevo usuario";
            Sistema_CrearUsuario.Click += AgregToolStripMenuItem_Click;
            // 
            // Sistema_MostrarUsuarios
            // 
            Sistema_MostrarUsuarios.Name = "Sistema_MostrarUsuarios";
            Sistema_MostrarUsuarios.Size = new Size(248, 26);
            Sistema_MostrarUsuarios.Text = "Mostrar usuarios";
            Sistema_MostrarUsuarios.Click += MostrarUsuariosToolStripMenuItem_Click;
            // 
            // prendasToolStripMenuItem
            // 
            prendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPrendaToolStripMenuItem, mostrarPrendasToolStripMenuItem });
            prendasToolStripMenuItem.Name = "prendasToolStripMenuItem";
            prendasToolStripMenuItem.Size = new Size(219, 26);
            prendasToolStripMenuItem.Text = "Prendas";
            // 
            // agregarPrendaToolStripMenuItem
            // 
            agregarPrendaToolStripMenuItem.Name = "agregarPrendaToolStripMenuItem";
            agregarPrendaToolStripMenuItem.Size = new Size(248, 26);
            agregarPrendaToolStripMenuItem.Text = "+ Crear nueva prenda";
            agregarPrendaToolStripMenuItem.Click += AgregarPrendaToolStripMenuItem_Click;
            // 
            // mostrarPrendasToolStripMenuItem
            // 
            mostrarPrendasToolStripMenuItem.Name = "mostrarPrendasToolStripMenuItem";
            mostrarPrendasToolStripMenuItem.Size = new Size(248, 26);
            mostrarPrendasToolStripMenuItem.Text = "Mostrar prendas";
            mostrarPrendasToolStripMenuItem.Click += MostrarPrendasToolStripMenuItem_Click;
            // 
            // cortesToolStripMenuItem
            // 
            cortesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearNuevoCorteToolStripMenuItem, mostrarCortesToolStripMenuItem, tareaSemanalToolStripMenuItem });
            cortesToolStripMenuItem.Name = "cortesToolStripMenuItem";
            cortesToolStripMenuItem.Size = new Size(219, 26);
            cortesToolStripMenuItem.Text = "Cortes";
            // 
            // crearNuevoCorteToolStripMenuItem
            // 
            crearNuevoCorteToolStripMenuItem.Name = "crearNuevoCorteToolStripMenuItem";
            crearNuevoCorteToolStripMenuItem.Size = new Size(234, 26);
            crearNuevoCorteToolStripMenuItem.Text = "+ Crear nuevo corte";
            crearNuevoCorteToolStripMenuItem.Click += CrearNuevoCorteToolStripMenuItem_Click;
            // 
            // mostrarCortesToolStripMenuItem
            // 
            mostrarCortesToolStripMenuItem.Name = "mostrarCortesToolStripMenuItem";
            mostrarCortesToolStripMenuItem.Size = new Size(234, 26);
            mostrarCortesToolStripMenuItem.Text = "Mostrar cortes";
            mostrarCortesToolStripMenuItem.Click += MostrarCortesToolStripMenuItem_Click;
            // 
            // tareaSemanalToolStripMenuItem
            // 
            tareaSemanalToolStripMenuItem.Name = "tareaSemanalToolStripMenuItem";
            tareaSemanalToolStripMenuItem.Size = new Size(234, 26);
            tareaSemanalToolStripMenuItem.Text = "Tarea semanal";
            tareaSemanalToolStripMenuItem.Click += tareaSemanalToolStripMenuItem_Click;
            // 
            // confreccionesToolStripMenuItem
            // 
            confreccionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearNuevaConfeccionToolStripMenuItem, mostrarConfeccionesToolStripMenuItem });
            confreccionesToolStripMenuItem.Name = "confreccionesToolStripMenuItem";
            confreccionesToolStripMenuItem.Size = new Size(219, 26);
            confreccionesToolStripMenuItem.Text = "Confrecciones";
            // 
            // crearNuevaConfeccionToolStripMenuItem
            // 
            crearNuevaConfeccionToolStripMenuItem.Name = "crearNuevaConfeccionToolStripMenuItem";
            crearNuevaConfeccionToolStripMenuItem.Size = new Size(278, 26);
            crearNuevaConfeccionToolStripMenuItem.Text = "+ Crear nueva confeccion";
            // 
            // mostrarConfeccionesToolStripMenuItem
            // 
            mostrarConfeccionesToolStripMenuItem.Name = "mostrarConfeccionesToolStripMenuItem";
            mostrarConfeccionesToolStripMenuItem.Size = new Size(278, 26);
            mostrarConfeccionesToolStripMenuItem.Text = "Mostrar confecciones";
            // 
            // terminacionToolStripMenuItem
            // 
            terminacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearNuevaTerminacionToolStripMenuItem, mostrarTerminacionesToolStripMenuItem });
            terminacionToolStripMenuItem.Name = "terminacionToolStripMenuItem";
            terminacionToolStripMenuItem.Size = new Size(219, 26);
            terminacionToolStripMenuItem.Text = "Terminaciones";
            // 
            // crearNuevaTerminacionToolStripMenuItem
            // 
            crearNuevaTerminacionToolStripMenuItem.Name = "crearNuevaTerminacionToolStripMenuItem";
            crearNuevaTerminacionToolStripMenuItem.Size = new Size(286, 26);
            crearNuevaTerminacionToolStripMenuItem.Text = "+ Crear nueva terminacion";
            // 
            // mostrarTerminacionesToolStripMenuItem
            // 
            mostrarTerminacionesToolStripMenuItem.Name = "mostrarTerminacionesToolStripMenuItem";
            mostrarTerminacionesToolStripMenuItem.Size = new Size(286, 26);
            mostrarTerminacionesToolStripMenuItem.Text = "Mostrar terminaciones";
            // 
            // modificarJornadaToolStripMenuItem
            // 
            modificarJornadaToolStripMenuItem.Name = "modificarJornadaToolStripMenuItem";
            modificarJornadaToolStripMenuItem.Size = new Size(219, 26);
            modificarJornadaToolStripMenuItem.Text = "Modificar Jornada";
            modificarJornadaToolStripMenuItem.Click += ModificarJornadaToolStripMenuItem_Click;
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.BackColor = Color.Azure;
            mostrarToolStripMenuItem.ForeColor = Color.Black;
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(82, 46);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += MostrarToolStripMenuItem_Click;
            // 
            // TsmiReportes
            // 
            TsmiReportes.BackColor = Color.Azure;
            TsmiReportes.DropDownItems.AddRange(new ToolStripItem[] { reporteDeUsuariosToolStripMenuItem, reportesDePrendasToolStripMenuItem, cortesToolStripMenuItem1, confreccionesToolStripMenuItem1, terminacionesToolStripMenuItem, usuariosToolStripMenuItem1 });
            TsmiReportes.ForeColor = Color.Black;
            TsmiReportes.Name = "TsmiReportes";
            TsmiReportes.Size = new Size(90, 46);
            TsmiReportes.Text = "Reportes";
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            reporteDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porJerarquiaToolStripMenuItem, porNombreToolStripMenuItem, porDNIToolStripMenuItem });
            reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            reporteDeUsuariosToolStripMenuItem.Size = new Size(190, 26);
            reporteDeUsuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // porJerarquiaToolStripMenuItem
            // 
            porJerarquiaToolStripMenuItem.Name = "porJerarquiaToolStripMenuItem";
            porJerarquiaToolStripMenuItem.Size = new Size(180, 26);
            porJerarquiaToolStripMenuItem.Text = "Por jerarquia";
            porJerarquiaToolStripMenuItem.Click += OrdenarPorJerarquiaToolStripMenuItem_Click;
            // 
            // porNombreToolStripMenuItem
            // 
            porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            porNombreToolStripMenuItem.Size = new Size(180, 26);
            porNombreToolStripMenuItem.Text = "Por nombre";
            porNombreToolStripMenuItem.Click += OrdenarPorNombreToolStripMenuItem_Click;
            // 
            // porDNIToolStripMenuItem
            // 
            porDNIToolStripMenuItem.Name = "porDNIToolStripMenuItem";
            porDNIToolStripMenuItem.Size = new Size(180, 26);
            porDNIToolStripMenuItem.Text = "Por DNI";
            porDNIToolStripMenuItem.Click += OrdenarPorDNIToolStripMenuItem_Click;
            // 
            // reportesDePrendasToolStripMenuItem
            // 
            reportesDePrendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porTalleToolStripMenuItem, porTipoToolStripMenuItem, porProduccionToolStripMenuItem, porFechaToolStripMenuItem, porFechaFinalToolStripMenuItem });
            reportesDePrendasToolStripMenuItem.Name = "reportesDePrendasToolStripMenuItem";
            reportesDePrendasToolStripMenuItem.Size = new Size(190, 26);
            reportesDePrendasToolStripMenuItem.Text = "Prendas";
            // 
            // porTalleToolStripMenuItem
            // 
            porTalleToolStripMenuItem.Name = "porTalleToolStripMenuItem";
            porTalleToolStripMenuItem.Size = new Size(201, 26);
            porTalleToolStripMenuItem.Text = "Por talle";
            porTalleToolStripMenuItem.Click += OrdenarPorTalleToolStripMenuItem_Click;
            // 
            // porTipoToolStripMenuItem
            // 
            porTipoToolStripMenuItem.Name = "porTipoToolStripMenuItem";
            porTipoToolStripMenuItem.Size = new Size(201, 26);
            porTipoToolStripMenuItem.Text = "Por tipo";
            porTipoToolStripMenuItem.Click += OrdenarPorTipoToolStripMenuItem_Click;
            // 
            // porProduccionToolStripMenuItem
            // 
            porProduccionToolStripMenuItem.Name = "porProduccionToolStripMenuItem";
            porProduccionToolStripMenuItem.Size = new Size(201, 26);
            porProduccionToolStripMenuItem.Text = "Por produccion";
            porProduccionToolStripMenuItem.Click += OrdenarPorProduccionToolStripMenuItem_Click;
            // 
            // porFechaToolStripMenuItem
            // 
            porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            porFechaToolStripMenuItem.Size = new Size(201, 26);
            porFechaToolStripMenuItem.Text = "Por fecha inicio";
            porFechaToolStripMenuItem.Click += PorFechaToolStripMenuItem_Click;
            // 
            // porFechaFinalToolStripMenuItem
            // 
            porFechaFinalToolStripMenuItem.Name = "porFechaFinalToolStripMenuItem";
            porFechaFinalToolStripMenuItem.Size = new Size(201, 26);
            porFechaFinalToolStripMenuItem.Text = "Por fecha final";
            porFechaFinalToolStripMenuItem.Click += PorFechaDeEntregaToolStripMenuItem_Click;
            // 
            // cortesToolStripMenuItem1
            // 
            cortesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { porEtapaToolStripMenuItem, porTiempoDeProduccionToolStripMenuItem });
            cortesToolStripMenuItem1.Name = "cortesToolStripMenuItem1";
            cortesToolStripMenuItem1.Size = new Size(190, 26);
            cortesToolStripMenuItem1.Text = "Cortes";
            // 
            // porEtapaToolStripMenuItem
            // 
            porEtapaToolStripMenuItem.Name = "porEtapaToolStripMenuItem";
            porEtapaToolStripMenuItem.Size = new Size(281, 26);
            porEtapaToolStripMenuItem.Text = "Por etapa";
            porEtapaToolStripMenuItem.Click += PorEtapaToolStripMenuItem_Click;
            // 
            // porTiempoDeProduccionToolStripMenuItem
            // 
            porTiempoDeProduccionToolStripMenuItem.Name = "porTiempoDeProduccionToolStripMenuItem";
            porTiempoDeProduccionToolStripMenuItem.Size = new Size(281, 26);
            porTiempoDeProduccionToolStripMenuItem.Text = "Por tiempo de produccion";
            porTiempoDeProduccionToolStripMenuItem.Click += PorTiempoDeProduccionToolStripMenuItem_Click;
            // 
            // confreccionesToolStripMenuItem1
            // 
            confreccionesToolStripMenuItem1.Name = "confreccionesToolStripMenuItem1";
            confreccionesToolStripMenuItem1.Size = new Size(190, 26);
            confreccionesToolStripMenuItem1.Text = "Confecciones";
            // 
            // terminacionesToolStripMenuItem
            // 
            terminacionesToolStripMenuItem.Name = "terminacionesToolStripMenuItem";
            terminacionesToolStripMenuItem.Size = new Size(190, 26);
            terminacionesToolStripMenuItem.Text = "Terminaciones";
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(190, 26);
            usuariosToolStripMenuItem1.Text = "Usuarios";
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
            DtgMuestreoMain.Location = new Point(12, 53);
            DtgMuestreoMain.Name = "DtgMuestreoMain";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtgMuestreoMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtgMuestreoMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DtgMuestreoMain.RowTemplate.Height = 25;
            DtgMuestreoMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgMuestreoMain.ShowEditingIcon = false;
            DtgMuestreoMain.Size = new Size(1360, 689);
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
        private ToolStripMenuItem prendasToolStripMenuItem;
        private ToolStripMenuItem agregarPrendaToolStripMenuItem;
        private ToolStripMenuItem cortesToolStripMenuItem;
        private ToolStripMenuItem confreccionesToolStripMenuItem;
        private ToolStripMenuItem Sistema_CrearUsuario;
        private ToolStripMenuItem Sistema_MostrarUsuarios;
        private ToolStripMenuItem mostrarPrendasToolStripMenuItem;
        private ToolStripMenuItem crearNuevoCorteToolStripMenuItem;
        private ToolStripMenuItem terminacionToolStripMenuItem;
        private DataGridView DtgMuestreoMain;
        private ToolStripMenuItem mostrarCortesToolStripMenuItem;
        private ToolStripMenuItem crearNuevaConfeccionToolStripMenuItem;
        private ToolStripMenuItem mostrarConfeccionesToolStripMenuItem;
        private ToolStripMenuItem crearNuevaTerminacionToolStripMenuItem;
        private ToolStripMenuItem mostrarTerminacionesToolStripMenuItem;
        private ToolStripMenuItem modificarJornadaToolStripMenuItem;
        private Label label4;
        private Button BtnCerrarSesion;
        private ToolStripMenuItem tareaSemanalToolStripMenuItem;
        private ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem reportesDePrendasToolStripMenuItem;
        private ToolStripMenuItem cortesToolStripMenuItem1;
        private ToolStripMenuItem confreccionesToolStripMenuItem1;
        private ToolStripMenuItem terminacionesToolStripMenuItem;
        private ToolStripMenuItem porJerarquiaToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private ToolStripMenuItem porNombreToolStripMenuItem;
        private ToolStripMenuItem porDNIToolStripMenuItem;
        private ToolStripMenuItem porTalleToolStripMenuItem;
        private ToolStripMenuItem porTipoToolStripMenuItem;
        private ToolStripMenuItem porProduccionToolStripMenuItem;
        private ToolStripMenuItem porFechaToolStripMenuItem;
        private ToolStripMenuItem porFechaFinalToolStripMenuItem;
        private ToolStripMenuItem porEtapaToolStripMenuItem;
        private ToolStripMenuItem porTiempoDeProduccionToolStripMenuItem;
    }
}