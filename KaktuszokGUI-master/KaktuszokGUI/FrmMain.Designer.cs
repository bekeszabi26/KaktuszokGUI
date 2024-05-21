namespace KaktuszokGUI
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
            dgvCactus = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            koznapi_nev = new DataGridViewTextBoxColumn();
            vizigeny = new DataGridViewTextBoxColumn();
            fenyigeny = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCactus).BeginInit();
            SuspendLayout();
            // 
            // dgvCactus
            // 
            dgvCactus.AllowUserToAddRows = false;
            dgvCactus.AllowUserToDeleteRows = false;
            dgvCactus.AllowUserToResizeColumns = false;
            dgvCactus.AllowUserToResizeRows = false;
            dgvCactus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCactus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCactus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCactus.Columns.AddRange(new DataGridViewColumn[] { id, koznapi_nev, vizigeny, fenyigeny });
            dgvCactus.Location = new Point(14, 16);
            dgvCactus.Margin = new Padding(3, 4, 3, 4);
            dgvCactus.MultiSelect = false;
            dgvCactus.Name = "dgvCactus";
            dgvCactus.RowHeadersVisible = false;
            dgvCactus.RowHeadersWidth = 51;
            dgvCactus.RowTemplate.Height = 25;
            dgvCactus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCactus.Size = new Size(887, 453);
            dgvCactus.TabIndex = 0;
            // 
            // id
            // 
            id.FillWeight = 20.30457F;
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // koznapi_nev
            // 
            koznapi_nev.FillWeight = 126.56514F;
            koznapi_nev.HeaderText = "Köznapi név";
            koznapi_nev.MinimumWidth = 6;
            koznapi_nev.Name = "koznapi_nev";
            // 
            // vizigeny
            // 
            vizigeny.FillWeight = 126.56514F;
            vizigeny.HeaderText = "Vízigény";
            vizigeny.MinimumWidth = 6;
            vizigeny.Name = "vizigeny";
            // 
            // fenyigeny
            // 
            fenyigeny.FillWeight = 126.56514F;
            fenyigeny.HeaderText = "Fényigény";
            fenyigeny.MinimumWidth = 6;
            fenyigeny.Name = "fenyigeny";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(14, 489);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(887, 95);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Törlés";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnDelete);
            Controls.Add(dgvCactus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            Text = "Kaktuszok";
            ((System.ComponentModel.ISupportInitialize)dgvCactus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCactus;
        private Button btnDelete;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn koznapi_nev;
        private DataGridViewTextBoxColumn vizigeny;
        private DataGridViewTextBoxColumn fenyigeny;
    }
}
