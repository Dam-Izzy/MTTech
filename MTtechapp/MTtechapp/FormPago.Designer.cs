namespace MTtechapp
{
    partial class FormPago
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
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtArticulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LvPagos = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lvDireccion = new System.Windows.Forms.Label();
            this.lvtel = new System.Windows.Forms.Label();
            this.lvcomment = new System.Windows.Forms.Label();
            this.btnBuscarFecha = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtcantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbpago = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizarpago = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtiva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(12, 102);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(265, 21);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbCliente_MouseDoubleClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Seleccione el cliente";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(284, 129);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Precio";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Depth = 0;
            this.txtArticulo.Hint = "Nombre del artículo";
            this.txtArticulo.Location = new System.Drawing.Point(12, 151);
            this.txtArticulo.MaxLength = 32767;
            this.txtArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.PasswordChar = '\0';
            this.txtArticulo.SelectedText = "";
            this.txtArticulo.SelectionLength = 0;
            this.txtArticulo.SelectionStart = 0;
            this.txtArticulo.Size = new System.Drawing.Size(260, 23);
            this.txtArticulo.TabIndex = 4;
            this.txtArticulo.TabStop = false;
            this.txtArticulo.UseSystemPasswordChar = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "Precio";
            this.txtPrecio.Location = new System.Drawing.Point(288, 151);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(178, 23);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TabStop = false;
            this.txtPrecio.UseSystemPasswordChar = false;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(964, 96);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Agregar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(964, 139);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButton2.TabIndex = 8;
            this.materialRaisedButton2.Text = "Imprimir";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // LvPagos
            // 
            this.LvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvPagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LvPagos.Depth = 0;
            this.LvPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LvPagos.FullRowSelect = true;
            this.LvPagos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvPagos.HideSelection = false;
            this.LvPagos.Location = new System.Drawing.Point(12, 191);
            this.LvPagos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LvPagos.MouseState = MaterialSkin.MouseState.OUT;
            this.LvPagos.Name = "LvPagos";
            this.LvPagos.OwnerDraw = true;
            this.LvPagos.Size = new System.Drawing.Size(1057, 324);
            this.LvPagos.TabIndex = 9;
            this.LvPagos.UseCompatibleStateImageBehavior = false;
            this.LvPagos.View = System.Windows.Forms.View.Details;
            this.LvPagos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvPagos_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 241;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nombre cliente";
            this.columnHeader7.Width = 254;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Descripción";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 180;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            this.columnHeader2.Width = 218;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "pago";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "pagos";
            this.columnHeader4.Width = 0;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(481, 151);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 10;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(477, 129);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(49, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Fecha";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 129);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Artículo";
            // 
            // lvDireccion
            // 
            this.lvDireccion.AutoSize = true;
            this.lvDireccion.Location = new System.Drawing.Point(295, 75);
            this.lvDireccion.Name = "lvDireccion";
            this.lvDireccion.Size = new System.Drawing.Size(52, 13);
            this.lvDireccion.TabIndex = 13;
            this.lvDireccion.Text = "Dirección";
            // 
            // lvtel
            // 
            this.lvtel.AutoSize = true;
            this.lvtel.Location = new System.Drawing.Point(295, 105);
            this.lvtel.Name = "lvtel";
            this.lvtel.Size = new System.Drawing.Size(49, 13);
            this.lvtel.TabIndex = 14;
            this.lvtel.Text = "Teléfono";
            // 
            // lvcomment
            // 
            this.lvcomment.AutoSize = true;
            this.lvcomment.Location = new System.Drawing.Point(478, 105);
            this.lvcomment.Name = "lvcomment";
            this.lvcomment.Size = new System.Drawing.Size(60, 13);
            this.lvcomment.TabIndex = 15;
            this.lvcomment.Text = "Comentario";
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.AutoSize = true;
            this.btnBuscarFecha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarFecha.Depth = 0;
            this.btnBuscarFecha.Icon = null;
            this.btnBuscarFecha.Location = new System.Drawing.Point(884, 138);
            this.btnBuscarFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Primary = true;
            this.btnBuscarFecha.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarFecha.TabIndex = 16;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Depth = 0;
            this.txtcantidad.Hint = "Cantidad";
            this.txtcantidad.Location = new System.Drawing.Point(700, 148);
            this.txtcantidad.MaxLength = 32767;
            this.txtcantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.PasswordChar = '\0';
            this.txtcantidad.SelectedText = "";
            this.txtcantidad.SelectionLength = 0;
            this.txtcantidad.SelectionStart = 0;
            this.txtcantidad.Size = new System.Drawing.Size(85, 23);
            this.txtcantidad.TabIndex = 18;
            this.txtcantidad.TabStop = false;
            this.txtcantidad.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(696, 126);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(68, 19);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Cantidad";
            // 
            // lbpago
            // 
            this.lbpago.AutoSize = true;
            this.lbpago.Depth = 0;
            this.lbpago.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbpago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbpago.Location = new System.Drawing.Point(827, 75);
            this.lbpago.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbpago.Name = "lbpago";
            this.lbpago.Size = new System.Drawing.Size(54, 19);
            this.lbpago.TabIndex = 19;
            this.lbpago.Text = "idpago";
            this.lbpago.Visible = false;
            // 
            // btnActualizarpago
            // 
            this.btnActualizarpago.AutoSize = true;
            this.btnActualizarpago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarpago.Depth = 0;
            this.btnActualizarpago.Icon = null;
            this.btnActualizarpago.Location = new System.Drawing.Point(964, 75);
            this.btnActualizarpago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarpago.Name = "btnActualizarpago";
            this.btnActualizarpago.Primary = true;
            this.btnActualizarpago.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarpago.TabIndex = 20;
            this.btnActualizarpago.Text = "Actualizar";
            this.btnActualizarpago.UseVisualStyleBackColor = true;
            this.btnActualizarpago.Visible = false;
            this.btnActualizarpago.Click += new System.EventHandler(this.btnActualizarpago_Click);
            // 
            // txtiva
            // 
            this.txtiva.Depth = 0;
            this.txtiva.Hint = "I.V.A";
            this.txtiva.Location = new System.Drawing.Point(791, 148);
            this.txtiva.MaxLength = 32767;
            this.txtiva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtiva.Name = "txtiva";
            this.txtiva.PasswordChar = '\0';
            this.txtiva.SelectedText = "";
            this.txtiva.SelectionLength = 0;
            this.txtiva.SelectionStart = 0;
            this.txtiva.Size = new System.Drawing.Size(85, 23);
            this.txtiva.TabIndex = 23;
            this.txtiva.TabStop = false;
            this.txtiva.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(787, 126);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(56, 19);
            this.materialLabel6.TabIndex = 22;
            this.materialLabel6.Text = "I.V.A %";
            // 
            // FormPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 527);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btnActualizarpago);
            this.Controls.Add(this.lbpago);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.lvcomment);
            this.Controls.Add(this.lvtel);
            this.Controls.Add(this.lvDireccion);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.LvPagos);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbCliente);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FormPago";
            this.Opacity = 0.95D;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.FormPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialListView LvPagos;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        public System.Windows.Forms.ComboBox cmbCliente;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtArticulo;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        public System.Windows.Forms.DateTimePicker dtpFechaPago;
        public System.Windows.Forms.Label lvDireccion;
        public System.Windows.Forms.Label lvtel;
        public System.Windows.Forms.Label lvcomment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarFecha;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtcantidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        public MaterialSkin.Controls.MaterialRaisedButton btnActualizarpago;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtiva;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        public MaterialSkin.Controls.MaterialLabel lbpago;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}