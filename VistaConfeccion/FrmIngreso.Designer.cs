namespace Vista
{
    partial class FrmIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngreso));
            TxtPassword = new TextBox();
            TxtUsuario = new TextBox();
            BtnSubmit = new Button();
            LblTitulo = new Label();
            PcbLogo = new PictureBox();
            label7 = new Label();
            LnkAlternarModo = new LinkLabel();
            LblUsuario = new Label();
            LblClave = new Label();
            ((System.ComponentModel.ISupportInitialize)PcbLogo).BeginInit();
            SuspendLayout();
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(688, 487);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(154, 23);
            TxtPassword.TabIndex = 48;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(688, 429);
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
            BtnSubmit.Location = new Point(569, 560);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(237, 54);
            BtnSubmit.TabIndex = 42;
            BtnSubmit.Text = "Ingresar al sistema";
            BtnSubmit.UseVisualStyleBackColor = false;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitulo.ForeColor = Color.DarkBlue;
            LblTitulo.ImeMode = ImeMode.NoControl;
            LblTitulo.Location = new Point(569, 357);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(237, 23);
            LblTitulo.TabIndex = 46;
            LblTitulo.Text = "Confecciones Alcatraz - Login";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PcbLogo
            // 
            PcbLogo.BackgroundImageLayout = ImageLayout.Center;
            PcbLogo.Image = (Image)resources.GetObject("PcbLogo.Image");
            PcbLogo.ImeMode = ImeMode.NoControl;
            PcbLogo.Location = new Point(612, 170);
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
            label7.Location = new Point(676, 639);
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
            LnkAlternarModo.Location = new Point(612, 671);
            LnkAlternarModo.Name = "LnkAlternarModo";
            LnkAlternarModo.Size = new Size(140, 20);
            LnkAlternarModo.TabIndex = 43;
            LnkAlternarModo.TabStop = true;
            LnkAlternarModo.Text = "Crear nuevo usuario";
            LnkAlternarModo.LinkClicked += LnkAlternarModo_LinkClicked;
            // 
            // LblUsuario
            // 
            LblUsuario.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.ImeMode = ImeMode.NoControl;
            LblUsuario.Location = new Point(543, 408);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(112, 58);
            LblUsuario.TabIndex = 40;
            LblUsuario.Text = "Usuario";
            LblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblClave
            // 
            LblClave.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblClave.ImeMode = ImeMode.NoControl;
            LblClave.Location = new Point(543, 466);
            LblClave.Name = "LblClave";
            LblClave.Size = new Size(112, 58);
            LblClave.TabIndex = 41;
            LblClave.Text = "Contraseña";
            LblClave.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1384, 861);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsuario);
            Controls.Add(BtnSubmit);
            Controls.Add(LblTitulo);
            Controls.Add(PcbLogo);
            Controls.Add(label7);
            Controls.Add(LnkAlternarModo);
            Controls.Add(LblUsuario);
            Controls.Add(LblClave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de ingreso";
            Load += FrmIngreso_Load;
            ((System.ComponentModel.ISupportInitialize)PcbLogo).EndInit();
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
        private Label LblClave;
    }
}