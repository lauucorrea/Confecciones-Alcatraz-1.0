namespace Vista
{
    partial class FrmTareaDiaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareaDiaria));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label4 = new Label();
            BtnCerrarSesion = new Button();
            BtnCancelar = new Button();
            DtgTareaDiaria = new DataGridView();
            dtgCortes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DtgTareaDiaria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgCortes).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 934);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 46;
            label4.Text = "Cerrar sesion";
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.ForeColor = Color.Transparent;
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.Location = new Point(72, 851);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(72, 80);
            BtnCerrarSesion.TabIndex = 45;
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(1174, 884);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(173, 47);
            BtnCancelar.TabIndex = 44;
            BtnCancelar.Text = "Volver al menu";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // DtgTareaDiaria
            // 
            DtgTareaDiaria.AllowUserToAddRows = false;
            DtgTareaDiaria.AllowUserToDeleteRows = false;
            DtgTareaDiaria.AllowUserToResizeColumns = false;
            DtgTareaDiaria.AllowUserToResizeRows = false;
            DtgTareaDiaria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DtgTareaDiaria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgTareaDiaria.BackgroundColor = Color.FromArgb(76, 117, 163);
            DtgTareaDiaria.BorderStyle = BorderStyle.None;
            DtgTareaDiaria.Cursor = Cursors.Hand;
            DtgTareaDiaria.GridColor = Color.FromArgb(10, 102, 194);
            DtgTareaDiaria.Location = new Point(771, 77);
            DtgTareaDiaria.Margin = new Padding(0);
            DtgTareaDiaria.Name = "DtgTareaDiaria";
            DtgTareaDiaria.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtgTareaDiaria.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtgTareaDiaria.RowHeadersVisible = false;
            DtgTareaDiaria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DtgTareaDiaria.RowTemplate.Height = 25;
            DtgTareaDiaria.RowTemplate.Resizable = DataGridViewTriState.False;
            DtgTareaDiaria.ShowEditingIcon = false;
            DtgTareaDiaria.Size = new Size(576, 750);
            DtgTareaDiaria.TabIndex = 42;
            // 
            // dtgCortes
            // 
            dtgCortes.AllowUserToAddRows = false;
            dtgCortes.AllowUserToDeleteRows = false;
            dtgCortes.AllowUserToResizeColumns = false;
            dtgCortes.AllowUserToResizeRows = false;
            dtgCortes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgCortes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCortes.BackgroundColor = Color.FromArgb(76, 117, 163);
            dtgCortes.BorderStyle = BorderStyle.None;
            dtgCortes.Cursor = Cursors.Hand;
            dtgCortes.GridColor = Color.FromArgb(10, 102, 194);
            dtgCortes.Location = new Point(28, 79);
            dtgCortes.Margin = new Padding(0);
            dtgCortes.Name = "dtgCortes";
            dtgCortes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgCortes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgCortes.RowHeadersVisible = false;
            dtgCortes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgCortes.RowTemplate.Height = 25;
            dtgCortes.RowTemplate.Resizable = DataGridViewTriState.False;
            dtgCortes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCortes.ShowEditingIcon = false;
            dtgCortes.Size = new Size(665, 750);
            dtgCortes.TabIndex = 47;
            dtgCortes.CellClick += dtgCortes_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(312, 23);
            label1.TabIndex = 48;
            label1.Text = "Listado de cortes en fecha seleccioanda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(784, 31);
            label2.Name = "label2";
            label2.Size = new Size(155, 23);
            label2.TabIndex = 49;
            label2.Text = "Curvatura de talles";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.impresora1;
            button1.Location = new Point(212, 851);
            button1.Name = "button1";
            button1.Size = new Size(72, 80);
            button1.TabIndex = 50;
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 934);
            label3.Name = "label3";
            label3.Size = new Size(125, 17);
            label3.TabIndex = 51;
            label3.Text = "Imprimir contenido";
            // 
            // FrmTareaDiaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1384, 1011);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgCortes);
            Controls.Add(label4);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(BtnCancelar);
            Controls.Add(DtgTareaDiaria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTareaDiaria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarea diaria";
            Load += FrmTareaDiaria_Load;
            ((System.ComponentModel.ISupportInitialize)DtgTareaDiaria).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgCortes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button BtnCerrarSesion;
        private Button BtnCancelar;
        private DataGridView DtgTareaDiaria;
        private DataGridView dtgCortes;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}