namespace GestorBD
{
    partial class frmTables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgAtributos = new MetroFramework.Controls.MetroGrid();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxTablas = new MetroFramework.Controls.MetroComboBox();
            this.dgRegistros = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new MetroFramework.Controls.MetroTile();
            this.btnBorrar = new MetroFramework.Controls.MetroTile();
            this.btnGuardar = new MetroFramework.Controls.MetroTile();
            this.btnBusqueda = new MetroFramework.Controls.MetroTile();
            this.btnModificacion = new MetroFramework.Controls.MetroTile();
            this.btnEliminar = new MetroFramework.Controls.MetroTile();
            this.txtCriterio = new MetroFramework.Controls.MetroTextBox();
            this.cbxCampo = new MetroFramework.Controls.MetroComboBox();
            this.cbxCondicion = new MetroFramework.Controls.MetroComboBox();
            this.txtReemplazo = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.cbxCampoM = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dgAtributos);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 98);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(250, 250);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgAtributos
            // 
            this.dgAtributos.AllowUserToResizeRows = false;
            this.dgAtributos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAtributos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgAtributos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAtributos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgAtributos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAtributos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAtributos.ColumnHeadersHeight = 20;
            this.dgAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgAtributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna,
            this.Tipo,
            this.Longitud});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAtributos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgAtributos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAtributos.EnableHeadersVisualStyles = false;
            this.dgAtributos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgAtributos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgAtributos.Location = new System.Drawing.Point(0, 0);
            this.dgAtributos.Name = "dgAtributos";
            this.dgAtributos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAtributos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgAtributos.RowHeadersWidth = 10;
            this.dgAtributos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgAtributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAtributos.Size = new System.Drawing.Size(250, 250);
            this.dgAtributos.Style = MetroFramework.MetroColorStyle.Lime;
            this.dgAtributos.TabIndex = 2;
            this.dgAtributos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgCampos_KeyDown);
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            // 
            // Tipo
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Items.AddRange(new object[] {
            "Entero",
            "Decimal",
            "Texto",
            "Fecha"});
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Longitud
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Longitud.DefaultCellStyle = dataGridViewCellStyle3;
            this.Longitud.HeaderText = "Longitud";
            this.Longitud.Name = "Longitud";
            // 
            // cbxTablas
            // 
            this.cbxTablas.FormattingEnabled = true;
            this.cbxTablas.ItemHeight = 23;
            this.cbxTablas.Location = new System.Drawing.Point(23, 63);
            this.cbxTablas.Name = "cbxTablas";
            this.cbxTablas.Size = new System.Drawing.Size(250, 29);
            this.cbxTablas.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxTablas.TabIndex = 1;
            this.cbxTablas.UseSelectable = true;
            this.cbxTablas.SelectionChangeCommitted += new System.EventHandler(this.cbxTablas_SelectionChangeCommitted);
            // 
            // dgRegistros
            // 
            this.dgRegistros.AllowUserToResizeRows = false;
            this.dgRegistros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRegistros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRegistros.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgRegistros.EnableHeadersVisualStyles = false;
            this.dgRegistros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgRegistros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgRegistros.Location = new System.Drawing.Point(23, 354);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgRegistros.RowHeadersWidth = 10;
            this.dgRegistros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRegistros.Size = new System.Drawing.Size(462, 153);
            this.dgRegistros.Style = MetroFramework.MetroColorStyle.Lime;
            this.dgRegistros.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveControl = null;
            this.btnAgregar.Location = new System.Drawing.Point(279, 63);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 70);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ActiveControl = null;
            this.btnBorrar.Location = new System.Drawing.Point(385, 63);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 70);
            this.btnBorrar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseSelectable = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveControl = null;
            this.btnGuardar.Location = new System.Drawing.Point(279, 139);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 70);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.ActiveControl = null;
            this.btnBusqueda.Location = new System.Drawing.Point(280, 215);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(99, 40);
            this.btnBusqueda.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnBusqueda.TabIndex = 12;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseSelectable = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.ActiveControl = null;
            this.btnModificacion.Location = new System.Drawing.Point(280, 261);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(99, 40);
            this.btnModificacion.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnModificacion.TabIndex = 13;
            this.btnModificacion.Text = "Modificacion";
            this.btnModificacion.UseSelectable = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ActiveControl = null;
            this.btnEliminar.Location = new System.Drawing.Point(279, 308);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 40);
            this.btnEliminar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminacion";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCriterio
            // 
            // 
            // 
            // 
            this.txtCriterio.CustomButton.Image = null;
            this.txtCriterio.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtCriterio.CustomButton.Name = "";
            this.txtCriterio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCriterio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCriterio.CustomButton.TabIndex = 1;
            this.txtCriterio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCriterio.CustomButton.UseSelectable = true;
            this.txtCriterio.CustomButton.Visible = false;
            this.txtCriterio.Lines = new string[] {
        "Criterio Busqueda"};
            this.txtCriterio.Location = new System.Drawing.Point(385, 226);
            this.txtCriterio.MaxLength = 32767;
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.PasswordChar = '\0';
            this.txtCriterio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCriterio.SelectedText = "";
            this.txtCriterio.SelectionLength = 0;
            this.txtCriterio.SelectionStart = 0;
            this.txtCriterio.ShortcutsEnabled = true;
            this.txtCriterio.Size = new System.Drawing.Size(107, 23);
            this.txtCriterio.TabIndex = 15;
            this.txtCriterio.Text = "Criterio Busqueda";
            this.txtCriterio.UseSelectable = true;
            this.txtCriterio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCriterio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxCampo
            // 
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.ItemHeight = 23;
            this.cbxCampo.Location = new System.Drawing.Point(385, 139);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(107, 29);
            this.cbxCampo.TabIndex = 16;
            this.cbxCampo.UseSelectable = true;
            // 
            // cbxCondicion
            // 
            this.cbxCondicion.FormattingEnabled = true;
            this.cbxCondicion.ItemHeight = 23;
            this.cbxCondicion.Items.AddRange(new object[] {
            "==",
            ">=",
            "<=",
            "!=",
            "<",
            ">"});
            this.cbxCondicion.Location = new System.Drawing.Point(385, 174);
            this.cbxCondicion.Name = "cbxCondicion";
            this.cbxCondicion.Size = new System.Drawing.Size(107, 29);
            this.cbxCondicion.TabIndex = 17;
            this.cbxCondicion.UseSelectable = true;
            // 
            // txtReemplazo
            // 
            // 
            // 
            // 
            this.txtReemplazo.CustomButton.Image = null;
            this.txtReemplazo.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtReemplazo.CustomButton.Name = "";
            this.txtReemplazo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReemplazo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReemplazo.CustomButton.TabIndex = 1;
            this.txtReemplazo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReemplazo.CustomButton.UseSelectable = true;
            this.txtReemplazo.CustomButton.Visible = false;
            this.txtReemplazo.Lines = new string[] {
        "Valor Nuevo"};
            this.txtReemplazo.Location = new System.Drawing.Point(384, 325);
            this.txtReemplazo.MaxLength = 32767;
            this.txtReemplazo.Name = "txtReemplazo";
            this.txtReemplazo.PasswordChar = '\0';
            this.txtReemplazo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReemplazo.SelectedText = "";
            this.txtReemplazo.SelectionLength = 0;
            this.txtReemplazo.SelectionStart = 0;
            this.txtReemplazo.ShortcutsEnabled = true;
            this.txtReemplazo.Size = new System.Drawing.Size(107, 23);
            this.txtReemplazo.TabIndex = 18;
            this.txtReemplazo.Text = "Valor Nuevo";
            this.txtReemplazo.UseSelectable = true;
            this.txtReemplazo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReemplazo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(440, 22);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(45, 35);
            this.metroTile1.TabIndex = 19;
            this.metroTile1.Text = "?";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // cbxCampoM
            // 
            this.cbxCampoM.FormattingEnabled = true;
            this.cbxCampoM.ItemHeight = 23;
            this.cbxCampoM.Items.AddRange(new object[] {
            "==",
            ">=",
            "<=",
            "!=",
            "<",
            ">"});
            this.cbxCampoM.Location = new System.Drawing.Point(385, 290);
            this.cbxCampoM.Name = "cbxCampoM";
            this.cbxCampoM.Size = new System.Drawing.Size(107, 29);
            this.cbxCampoM.TabIndex = 20;
            this.cbxCampoM.UseSelectable = true;
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 530);
            this.Controls.Add(this.cbxCampoM);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txtReemplazo);
            this.Controls.Add(this.cbxCondicion);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgRegistros);
            this.Controls.Add(this.cbxTablas);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "frmTables";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "BASE DE DATOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTables_FormClosing);
            this.Load += new System.EventHandler(this.frmTables_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgAtributos;
        private MetroFramework.Controls.MetroComboBox cbxTablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroTile btnAgregar;
        private MetroFramework.Controls.MetroTile btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitud;
        private MetroFramework.Controls.MetroTile btnGuardar;
        public MetroFramework.Controls.MetroGrid dgRegistros;
        private MetroFramework.Controls.MetroTile btnBusqueda;
        private MetroFramework.Controls.MetroTile btnModificacion;
        private MetroFramework.Controls.MetroTile btnEliminar;
        private MetroFramework.Controls.MetroTextBox txtCriterio;
        private MetroFramework.Controls.MetroComboBox cbxCampo;
        private MetroFramework.Controls.MetroComboBox cbxCondicion;
        private MetroFramework.Controls.MetroTextBox txtReemplazo;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroComboBox cbxCampoM;
    }
}