namespace Vista
{
    partial class FrmCalendario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalendario));
            DtgCalendario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DtgCalendario).BeginInit();
            SuspendLayout();
            // 
            // DtgCalendario
            // 
            DtgCalendario.AllowUserToAddRows = false;
            DtgCalendario.AllowUserToDeleteRows = false;
            DtgCalendario.AllowUserToResizeColumns = false;
            DtgCalendario.AllowUserToResizeRows = false;
            DtgCalendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgCalendario.BackgroundColor = Color.FromArgb(76, 117, 163);
            DtgCalendario.BorderStyle = BorderStyle.None;
            DtgCalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgCalendario.Cursor = Cursors.Hand;
            DtgCalendario.Dock = DockStyle.Fill;
            DtgCalendario.GridColor = Color.FromArgb(10, 102, 194);
            DtgCalendario.Location = new Point(0, 0);
            DtgCalendario.Margin = new Padding(0);
            DtgCalendario.Name = "DtgCalendario";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtgCalendario.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtgCalendario.RowHeadersVisible = false;
            DtgCalendario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DtgCalendario.RowTemplate.Height = 25;
            DtgCalendario.RowTemplate.Resizable = DataGridViewTriState.False;
            DtgCalendario.ShowEditingIcon = false;
            DtgCalendario.Size = new Size(1384, 861);
            DtgCalendario.TabIndex = 7;
            // 
            // FrmCalendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1384, 861);
            Controls.Add(DtgCalendario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCalendario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCalendario";
            Load += FrmCalendario_Load;
            ((System.ComponentModel.ISupportInitialize)DtgCalendario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DtgCalendario;
    }
}