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
            SuspendLayout();
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSistema.ImeMode = ImeMode.NoControl;
            lblSistema.Location = new Point(242, 42);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(306, 23);
            lblSistema.TabIndex = 18;
            lblSistema.Text = "Ingrese el horario de la jornada laboral";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(295, 233);
            label1.Name = "label1";
            label1.Size = new Size(207, 23);
            label1.TabIndex = 19;
            label1.Text = "Elija los dias de la semana";
            // 
            // CmbCierre
            // 
            CmbCierre.FormattingEnabled = true;
            CmbCierre.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            CmbCierre.Location = new Point(427, 145);
            CmbCierre.Name = "CmbCierre";
            CmbCierre.Size = new Size(121, 23);
            CmbCierre.TabIndex = 20;
            // 
            // CmbApertura
            // 
            CmbApertura.FormattingEnabled = true;
            CmbApertura.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            CmbApertura.Location = new Point(242, 145);
            CmbApertura.Name = "CmbApertura";
            CmbApertura.Size = new Size(121, 23);
            CmbApertura.TabIndex = 21;
            // 
            // ChkLunes
            // 
            ChkLunes.AutoSize = true;
            ChkLunes.CheckAlign = ContentAlignment.TopCenter;
            ChkLunes.Cursor = Cursors.Hand;
            ChkLunes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChkLunes.Location = new Point(161, 294);
            ChkLunes.Name = "ChkLunes";
            ChkLunes.Size = new Size(50, 38);
            ChkLunes.TabIndex = 22;
            ChkLunes.Text = "Lunes";
            ChkLunes.UseVisualStyleBackColor = true;
            // 
            // ChkMartes
            // 
            ChkMartes.AutoSize = true;
            ChkMartes.CheckAlign = ContentAlignment.TopCenter;
            ChkMartes.Cursor = Cursors.Hand;
            ChkMartes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChkMartes.Location = new Point(221, 294);
            ChkMartes.Name = "ChkMartes";
            ChkMartes.Size = new Size(58, 38);
            ChkMartes.TabIndex = 23;
            ChkMartes.Text = "Martes";
            ChkMartes.UseVisualStyleBackColor = true;
            // 
            // ChkMiercoles
            // 
            ChkMiercoles.AutoSize = true;
            ChkMiercoles.CheckAlign = ContentAlignment.TopCenter;
            ChkMiercoles.Cursor = Cursors.Hand;
            ChkMiercoles.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChkMiercoles.Location = new Point(285, 294);
            ChkMiercoles.Name = "ChkMiercoles";
            ChkMiercoles.Size = new Size(77, 38);
            ChkMiercoles.TabIndex = 24;
            ChkMiercoles.Text = "Miercoles";
            ChkMiercoles.UseVisualStyleBackColor = true;
            // 
            // ChkJueves
            // 
            ChkJueves.AutoSize = true;
            ChkJueves.CheckAlign = ContentAlignment.TopCenter;
            ChkJueves.Cursor = Cursors.Hand;
            ChkJueves.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChkJueves.Location = new Point(368, 294);
            ChkJueves.Name = "ChkJueves";
            ChkJueves.Size = new Size(55, 38);
            ChkJueves.TabIndex = 25;
            ChkJueves.Text = "Jueves";
            ChkJueves.UseVisualStyleBackColor = true;
            // 
            // ChkViernes
            // 
            ChkViernes.AutoSize = true;
            ChkViernes.CheckAlign = ContentAlignment.TopCenter;
            ChkViernes.Cursor = Cursors.Hand;
            ChkViernes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChkViernes.Location = new Point(429, 294);
            ChkViernes.Name = "ChkViernes";
            ChkViernes.Size = new Size(61, 38);
            ChkViernes.TabIndex = 26;
            ChkViernes.Text = "Viernes";
            ChkViernes.UseVisualStyleBackColor = true;
            // 
            // ChkSabado
            // 
            ChkSabado.AutoSize = true;
            ChkSabado.CheckAlign = ContentAlignment.TopCenter;
            ChkSabado.Cursor = Cursors.Hand;
            ChkSabado.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChkSabado.Location = new Point(496, 294);
            ChkSabado.Name = "ChkSabado";
            ChkSabado.Size = new Size(64, 38);
            ChkSabado.TabIndex = 27;
            ChkSabado.Text = "Sabado";
            ChkSabado.UseVisualStyleBackColor = true;
            // 
            // ChkDomingo
            // 
            ChkDomingo.AutoSize = true;
            ChkDomingo.CheckAlign = ContentAlignment.TopCenter;
            ChkDomingo.Cursor = Cursors.Hand;
            ChkDomingo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChkDomingo.Location = new Point(566, 294);
            ChkDomingo.Name = "ChkDomingo";
            ChkDomingo.Size = new Size(76, 38);
            ChkDomingo.TabIndex = 28;
            ChkDomingo.Text = "Domingo";
            ChkDomingo.UseVisualStyleBackColor = true;
            // 
            // LblApertura
            // 
            LblApertura.AutoSize = true;
            LblApertura.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblApertura.ImeMode = ImeMode.NoControl;
            LblApertura.Location = new Point(267, 122);
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
            LblCierre.Location = new Point(463, 122);
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
            BtnGuardarCambios.Location = new Point(429, 389);
            BtnGuardarCambios.Name = "BtnGuardarCambios";
            BtnGuardarCambios.Size = new Size(160, 39);
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
            BtnCancelar.Location = new Point(221, 388);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(160, 39);
            BtnCancelar.TabIndex = 33;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmEdicionJornada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
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
    }
}