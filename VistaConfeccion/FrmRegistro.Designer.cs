namespace Vista
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            TxtPassword = new TextBox();
            TxtUsuario = new TextBox();
            BtnSubmit = new Button();
            LblTitulo = new Label();
            PcbLogo = new PictureBox();
            label7 = new Label();
            LnkAlternarModo = new LinkLabel();
            LblUsuario = new Label();
            LblPassword = new Label();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            LblNombre = new Label();
            LblApellido = new Label();
            LblRolUsuario = new Label();
            LblDni = new Label();
            NumDni = new NumericUpDown();
            CmbRolUsuario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumDni).BeginInit();
            SuspendLayout();
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(686, 604);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(154, 23);
            TxtPassword.TabIndex = 48;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(686, 546);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(154, 23);
            TxtUsuario.TabIndex = 47;
            // 
            // BtnSubmit
            // 
            BtnSubmit.BackColor = Color.FromArgb(192, 255, 192);
            BtnSubmit.Cursor = Cursors.Hand;
            BtnSubmit.FlatStyle = FlatStyle.Popup;
            BtnSubmit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSubmit.ForeColor = SystemColors.Desktop;
            BtnSubmit.ImeMode = ImeMode.NoControl;
            BtnSubmit.Location = new Point(569, 672);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(237, 54);
            BtnSubmit.TabIndex = 42;
            BtnSubmit.Text = "+Crear nuevo usuario";
            BtnSubmit.UseVisualStyleBackColor = false;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitulo.ForeColor = Color.DarkBlue;
            LblTitulo.ImeMode = ImeMode.NoControl;
            LblTitulo.Location = new Point(541, 220);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(310, 23);
            LblTitulo.TabIndex = 46;
            LblTitulo.Text = "Confecciones Alcatraz - Alta de usuario";
            // 
            // PcbLogo
            // 
            PcbLogo.BackgroundImageLayout = ImageLayout.Center;
            PcbLogo.Image = (Image)resources.GetObject("PcbLogo.Image");
            PcbLogo.ImeMode = ImeMode.NoControl;
            PcbLogo.Location = new Point(612, 35);
            PcbLogo.Name = "PcbLogo";
            PcbLogo.Size = new Size(164, 164);
            PcbLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            PcbLogo.TabIndex = 45;
            PcbLogo.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(676, 751);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 44;
            label7.Text = "ó";
            // 
            // LnkAlternarModo
            // 
            LnkAlternarModo.AutoSize = true;
            LnkAlternarModo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LnkAlternarModo.ImeMode = ImeMode.NoControl;
            LnkAlternarModo.Location = new Point(581, 792);
            LnkAlternarModo.Name = "LnkAlternarModo";
            LnkAlternarModo.Size = new Size(205, 20);
            LnkAlternarModo.TabIndex = 43;
            LnkAlternarModo.TabStop = true;
            LnkAlternarModo.Text = "Ingresar con usuario existente";
            LnkAlternarModo.LinkClicked += LnkAlternarModo_LinkClicked;
            // 
            // LblUsuario
            // 
            LblUsuario.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.ImeMode = ImeMode.NoControl;
            LblUsuario.Location = new Point(541, 525);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(112, 58);
            LblUsuario.TabIndex = 40;
            LblUsuario.Text = "Usuario";
            LblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblPassword
            // 
            LblPassword.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblPassword.ImeMode = ImeMode.NoControl;
            LblPassword.Location = new Point(541, 583);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(112, 58);
            LblPassword.TabIndex = 41;
            LblPassword.Text = "Contraseña";
            LblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(686, 426);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(154, 23);
            TxtApellido.TabIndex = 52;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(686, 368);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(154, 23);
            TxtNombre.TabIndex = 51;
            // 
            // LblNombre
            // 
            LblNombre.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblNombre.ImeMode = ImeMode.NoControl;
            LblNombre.Location = new Point(541, 347);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(112, 58);
            LblNombre.TabIndex = 49;
            LblNombre.Text = "Nombre";
            LblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblApellido
            // 
            LblApellido.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblApellido.ImeMode = ImeMode.NoControl;
            LblApellido.Location = new Point(541, 405);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(112, 58);
            LblApellido.TabIndex = 50;
            LblApellido.Text = "Apellido";
            LblApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblRolUsuario
            // 
            LblRolUsuario.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblRolUsuario.ImeMode = ImeMode.NoControl;
            LblRolUsuario.Location = new Point(541, 289);
            LblRolUsuario.Name = "LblRolUsuario";
            LblRolUsuario.Size = new Size(112, 58);
            LblRolUsuario.TabIndex = 53;
            LblRolUsuario.Text = "Rol";
            LblRolUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblDni
            // 
            LblDni.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblDni.ImeMode = ImeMode.NoControl;
            LblDni.Location = new Point(541, 467);
            LblDni.Name = "LblDni";
            LblDni.Size = new Size(112, 58);
            LblDni.TabIndex = 54;
            LblDni.Text = "Dni";
            LblDni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NumDni
            // 
            NumDni.Location = new Point(685, 485);
            NumDni.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            NumDni.Name = "NumDni";
            NumDni.Size = new Size(154, 23);
            NumDni.TabIndex = 55;
            NumDni.ThousandsSeparator = true;
            // 
            // CmbRolUsuario
            // 
            CmbRolUsuario.FormattingEnabled = true;
            CmbRolUsuario.Location = new Point(685, 310);
            CmbRolUsuario.Name = "CmbRolUsuario";
            CmbRolUsuario.Size = new Size(155, 23);
            CmbRolUsuario.TabIndex = 56;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1384, 861);
            Controls.Add(CmbRolUsuario);
            Controls.Add(NumDni);
            Controls.Add(LblDni);
            Controls.Add(LblRolUsuario);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Controls.Add(LblNombre);
            Controls.Add(LblApellido);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsuario);
            Controls.Add(BtnSubmit);
            Controls.Add(LblTitulo);
            Controls.Add(PcbLogo);
            Controls.Add(label7);
            Controls.Add(LnkAlternarModo);
            Controls.Add(LblUsuario);
            Controls.Add(LblPassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistro";
            Load += FrmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)PcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumDni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPassword;
        private TextBox TxtUsuario;
        private Button BtnSubmit;
        private Label LblTitulo;
        private PictureBox PcbLogo;
        private Label label7;
        private LinkLabel LnkAlternarModo;
        private Label LblUsuario;
        private Label LblPassword;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private Label LblNombre;
        private Label LblApellido;
        private Label LblRolUsuario;
        private Label LblDni;
        private NumericUpDown NumDni;
        private ComboBox CmbRolUsuario;
    }
}