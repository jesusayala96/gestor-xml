namespace GestorBD
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgBD = new MetroFramework.Controls.MetroGrid();
            this.cBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMod = new MetroFramework.Controls.MetroTile();
            this.btnUsar = new MetroFramework.Controls.MetroTile();
            this.btnDes = new MetroFramework.Controls.MetroTile();
            this.btnDel = new MetroFramework.Controls.MetroTile();
            this.btnCrear = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBD)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dgBD);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 298);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgBD
            // 
            this.dgBD.AllowUserToAddRows = false;
            this.dgBD.AllowUserToDeleteRows = false;
            this.dgBD.AllowUserToResizeRows = false;
            this.dgBD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgBD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgBD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgBD.ColumnHeadersHeight = 20;
            this.dgBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBD});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBD.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBD.EnableHeadersVisualStyles = false;
            this.dgBD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgBD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgBD.Location = new System.Drawing.Point(0, 0);
            this.dgBD.MultiSelect = false;
            this.dgBD.Name = "dgBD";
            this.dgBD.ReadOnly = true;
            this.dgBD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBD.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgBD.RowHeadersWidth = 10;
            this.dgBD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgBD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBD.Size = new System.Drawing.Size(200, 298);
            this.dgBD.Style = MetroFramework.MetroColorStyle.Lime;
            this.dgBD.TabIndex = 4;
            this.dgBD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBD_CellContentClick);
            // 
            // cBD
            // 
            this.cBD.HeaderText = "Bases de Datos";
            this.cBD.Name = "cBD";
            this.cBD.ReadOnly = true;
            // 
            // btnMod
            // 
            this.btnMod.ActiveControl = null;
            this.btnMod.Location = new System.Drawing.Point(330, 63);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(200, 298);
            this.btnMod.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "Modificar BD";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMod.UseSelectable = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnUsar
            // 
            this.btnUsar.ActiveControl = null;
            this.btnUsar.Location = new System.Drawing.Point(229, 139);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(95, 70);
            this.btnUsar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnUsar.TabIndex = 2;
            this.btnUsar.Text = "Usar BD";
            this.btnUsar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnUsar.UseSelectable = true;
            this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
            // 
            // btnDes
            // 
            this.btnDes.ActiveControl = null;
            this.btnDes.Location = new System.Drawing.Point(229, 63);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(95, 70);
            this.btnDes.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDes.TabIndex = 4;
            this.btnDes.Text = "DesUsar BD";
            this.btnDes.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDes.UseSelectable = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnDel
            // 
            this.btnDel.ActiveControl = null;
            this.btnDel.Location = new System.Drawing.Point(229, 291);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(95, 70);
            this.btnDel.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Borrar";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDel.UseSelectable = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.ActiveControl = null;
            this.btnCrear.Location = new System.Drawing.Point(229, 215);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(95, 70);
            this.btnCrear.Style = MetroFramework.MetroColorStyle.Green;
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCrear.UseSelectable = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(483, 22);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(45, 35);
            this.metroTile1.TabIndex = 20;
            this.metroTile1.Text = "?";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 380);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnMod;
        private MetroFramework.Controls.MetroTile btnUsar;
        private MetroFramework.Controls.MetroTile btnDes;
        private MetroFramework.Controls.MetroGrid dgBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBD;
        private MetroFramework.Controls.MetroTile btnDel;
        private MetroFramework.Controls.MetroTile btnCrear;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

