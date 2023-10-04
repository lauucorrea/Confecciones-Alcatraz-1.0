namespace Vista
{
    partial class FrmEdicionJornada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdicionJornada));
            lblSistema = new Label();
            label1 = new Label();
            CmbCierre = new ComboBox();
            CmbApertura = new ComboBox();
            ChkLunes = new CheckBox();
            ChkMartes = new CheckBox();
            ChkMiercoles = new CheckBox();
            ChkJueves = new CheckBox();
            ChkViernes = new CheckBox();
            ChkSabado = new CheckBox();
            ChkDomingo = new CheckBox();
            LblApertura = new Label();
            LblCierre = new Label();
            BtnGuardarCambios = new Button();
            BtnCancelar = new Button();
            lstUsuariosSistema = new ListBox();
            lblTituloUsuarios = new Label();
            SuspendLayout();
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSistema.ImeMode = ImeMode.NoControl;
            lblSistema.Location = new Point(912, 163);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(196, 23);
            lblSistema.TabIndex = 18;
            lblSistema.Text = "Modificacion de jornada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(909, 304);
            label1.Name = "label1";
            label1.Size = new Size(217, 23);
            label1.TabIndex = 19;
            label1.Text = "Modificacion dias laborales";
            // 
            // CmbCierre
            // 
            CmbCierre.FormattingEnabled = true;
            CmbCierre.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            CmbCierre.Location = new Point(1042, 232);
            CmbCierre.Name = "CmbCierre";
            CmbCierre.Size = new Size(121, 23);
            CmbCierre.TabIndex = 20;
            // 
            // CmbApertura
            // 
            CmbApertura.FormattingEnabled = true;
            CmbApertura.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            CmbApertura.Location = new Point(857, 232);
            CmbApertura.Name = "CmbApertura";
            CmbApertura.Size = new Size(121, 23);
            CmbApertura.TabIndex = 21;
            // 
            // ChkLunes
            // 
            ChkLunes.AutoSize = true;
            ChkLunes.CheckAlign = ContentAlignment.TopCenter;
            ChkLunes.Cursor = Cursors.Hand;
            ChkLunes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChkLunes.Location = new Point(721, 370);
            ChkLunes.Name = "ChkLunes";
            ChkLunes.Size = new Size(65, 43);
            ChkLunes.TabIndex = 22;
            ChkLunes.Text = "Lunes";
            ChkLunes.UseVisualStyleBackColor = true;
            // 
            // ChkMartes
            // 
            ChkMartes.AutoSize = true;
            ChkMartes.CheckAlign = ContentAlignment.TopCenter;
            ChkMartes.Cursor = Cursors.Hand;
            ChkMartes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChkMartes.Location = new Point(792, 370);
            ChkMartes.Name = "ChkMartes";
            ChkMartes.Size = new Size(74, 43);
            ChkMartes.TabIndex = 23;
            ChkMartes.Text = "Martes";
            ChkMartes.UseVisualStyleBackColor = true;
            // 
            // ChkMiercoles
            // 
            ChkMiercoles.AutoSize = true;
            ChkMiercoles.CheckAlign = ContentAlignment.TopCenter;
            ChkMiercoles.Cursor = Cursors.Hand;
            ChkMiercoles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChkMiercoles.Location = new Point(868, 370);
            ChkMiercoles.Name = "ChkMiercoles";
            ChkMiercoles.Size = new Size(98, 43);
            ChkMiercoles.TabIndex = 24;
            ChkMiercoles.Text = "Miercoles";
            ChkMiercoles.UseVisualStyleBackColor = true;
            // 
            // ChkJueves
            // 
            ChkJueves.AutoSize = true;
            ChkJueves.CheckAlign = ContentAlignment.TopCenter;
            ChkJueves.Cursor = Cursors.Hand;
            ChkJueves.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChkJueves.Location = new Point(968, 370);
            ChkJueves.Name = "ChkJueves";
            ChkJueves.Size = new Size(71, 43);
            ChkJueves.TabIndex = 25;
            ChkJueves.Text = "Jueves";
            ChkJueves.UseVisualStyleBackColor = true;
            // 
            // ChkViernes
            // 
            ChkViernes.AutoSize = true;
            ChkViernes.CheckAlign = ContentAlignment.TopCenter;
            ChkViernes.Cursor = Cursors.Hand;
            ChkViernes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChkViernes.Location = new Point(1039, 370);
            ChkViernes.Name = "ChkViernes";
            ChkViernes.Size = new Size(79, 43);
            ChkViernes.TabIndex = 26;
            ChkViernes.Text = "Viernes";
            ChkViernes.UseVisualStyleBackColor = true;
            // 
            // ChkSabado
            // 
            ChkSabado.AutoSize = true;
            ChkSabado.CheckAlign = ContentAlignment.TopCenter;
            ChkSabado.Cursor = Cursors.Hand;
            ChkSabado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChkSabado.Location = new Point(1125, 370);
            ChkSabado.Name = "ChkSabado";
            ChkSabado.Size = new Size(79, 43);
            ChkSabado.TabIndex = 27;
            ChkSabado.Text = "Sabado";
            ChkSabado.UseVisualStyleBackColor = true;
            // 
            // ChkDomingo
            // 
            ChkDomingo.AutoSize = true;
            ChkDomingo.CheckAlign = ContentAlignment.TopCenter;
            ChkDomingo.Cursor = Cursors.Hand;
            ChkDomingo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChkDomingo.Location = new Point(1210, 370);
            ChkDomingo.Name = "ChkDomingo";
            ChkDomingo.Size = new Size(94, 43);
            ChkDomingo.TabIndex = 28;
            ChkDomingo.Text = "Domingo";
            ChkDomingo.UseVisualStyleBackColor = true;
            // 
            // LblApertura
            // 
            LblApertura.AutoSize = true;
            LblApertura.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblApertura.ImeMode = ImeMode.NoControl;
            LblApertura.Location = new Point(882, 209);
            LblApertura.Name = "LblApertura";
            LblApertura.Size = new Size(67, 20);
            LblApertura.TabIndex = 30;
            LblApertura.Text = "Apertura";
            // 
            // LblCierre
            // 
            LblCierre.AutoSize = true;
            LblCierre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblCierre.ImeMode = ImeMode.NoControl;
            LblCierre.Location = new Point(1078, 209);
            LblCierre.Name = "LblCierre";
            LblCierre.Size = new Size(48, 20);
            LblCierre.TabIndex = 31;
            LblCierre.Text = "Cierre";
            // 
            // BtnGuardarCambios
            // 
            BtnGuardarCambios.BackColor = Color.FromArgb(192, 255, 192);
            BtnGuardarCambios.FlatStyle = FlatStyle.Popup;
            BtnGuardarCambios.ForeColor = SystemColors.WindowText;
            BtnGuardarCambios.ImeMode = ImeMode.NoControl;
            BtnGuardarCambios.Location = new Point(1050, 512);
            BtnGuardarCambios.Name = "BtnGuardarCambios";
            BtnGuardarCambios.Size = new Size(190, 59);
            BtnGuardarCambios.TabIndex = 32;
            BtnGuardarCambios.Text = "Guardar cambios";
            BtnGuardarCambios.UseVisualStyleBackColor = false;
            BtnGuardarCambios.Click += BtnGuardarCambios_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.ImeMode = ImeMode.NoControl;
            BtnCancelar.Location = new Point(778, 511);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(190, 59);
            BtnCancelar.TabIndex = 33;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // lstUsuariosSistema
            // 
            lstUsuariosSistema.Font = new Font("Cascadia Mono SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsuariosSistema.FormattingEnabled = true;
            lstUsuariosSistema.ItemHeight = 28;
            lstUsuariosSistema.Location = new Point(74, 119);
            lstUsuariosSistema.Name = "lstUsuariosSistema";
            lstUsuariosSistema.Size = new Size(577, 480);
            lstUsuariosSistema.TabIndex = 34;
            lstUsuariosSistema.SelectedIndexChanged += lstUsuariosSistema_SelectedIndexChanged;
            // 
            // lblTituloUsuarios
            // 
            lblTituloUsuarios.AutoSize = true;
            lblTituloUsuarios.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloUsuarios.ImeMode = ImeMode.NoControl;
            lblTituloUsuarios.Location = new Point(74, 85);
            lblTituloUsuarios.Name = "lblTituloUsuarios";
            lblTituloUsuarios.Size = new Size(259, 23);
            lblTituloUsuarios.TabIndex = 35;
            lblTituloUsuarios.Text = "Seleccion de usuarios en sistema";
            // 
            // FrmEdicionJornada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1384, 711);
            Controls.Add(lblTituloUsuarios);
            Controls.Add(lstUsuariosSistema);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardarCambios);
            Controls.Add(LblCierre);
            Controls.Add(LblApertura);
            Controls.Add(ChkDomingo);
            Controls.Add(ChkSabado);
            Controls.Add(ChkViernes);
            Controls.Add(ChkJueves);
            Controls.Add(ChkMiercoles);
            Controls.Add(ChkMartes);
            Controls.Add(ChkLunes);
            Controls.Add(CmbApertura);
            Controls.Add(CmbCierre);
            Controls.Add(label1);
            Controls.Add(lblSistema);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEdicionJornada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edicion de Jornada";
            Load += FrmEdicionJornada_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSistema;
        private Label label1;
        private ComboBox CmbCierre;
        private ComboBox CmbApertura;
        private CheckBox ChkLunes;
        private CheckBox ChkMartes;
        private CheckBox ChkMiercoles;
        private CheckBox ChkJueves;
        private CheckBox ChkViernes;
        private CheckBox ChkSabado;
        private CheckBox ChkDomingo;
        private Label LblApertura;
        private Label LblCierre;
        private Button BtnGuardarCambios;
        private Button BtnCancelar;
        private ListBox lstUsuariosSistema;
        private Label lblTituloUsuarios;
    }
}