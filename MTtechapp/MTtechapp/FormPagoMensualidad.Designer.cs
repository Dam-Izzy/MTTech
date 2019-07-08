namespace MTtechapp
{
    partial class FormPagoMensualidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoMensualidad));
            this.txtmonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new MaterialSkin.Controls.MaterialFlatButton();
            this.dtpmensualidad = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label2 = new System.Windows.Forms.Label();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtdescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComentario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbRestar = new MaterialSkin.Controls.MaterialLabel();
            this.lbsumar = new MaterialSkin.Controls.MaterialLabel();
            this.lbidid = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmonto
            // 
            this.txtmonto.BackColor = System.Drawing.Color.White;
            this.txtmonto.Depth = 0;
            this.txtmonto.ForeColor = System.Drawing.Color.Silver;
            this.txtmonto.Hint = "Monto a pagar";
            this.txtmonto.Location = new System.Drawing.Point(18, 371);
            this.txtmonto.MaxLength = 32767;
            this.txtmonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.PasswordChar = '\0';
            this.txtmonto.SelectedText = "";
            this.txtmonto.SelectionLength = 0;
            this.txtmonto.SelectionStart = 0;
            this.txtmonto.Size = new System.Drawing.Size(104, 23);
            this.txtmonto.TabIndex = 0;
            this.txtmonto.TabStop = false;
            this.txtmonto.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 349);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Monto";
            // 
            // cbCliente
            // 
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(18, 201);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(308, 21);
            this.cbCliente.TabIndex = 2;
            this.cbCliente.Click += new System.EventHandler(this.cbCliente_Click);
            this.cbCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCliente_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(18, 179);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Cliente";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.Red;
            this.materialLabel3.Location = new System.Drawing.Point(14, 236);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(142, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "* Selecciona el mes";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(101, 461);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(84, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Guardar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pago mensualidad";
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(18, 258);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(308, 21);
            this.cbMes.TabIndex = 19;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(18, 120);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Lugar";
            // 
            // cmbLugar
            // 
            this.cmbLugar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLugar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(18, 142);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(308, 21);
            this.cmbLugar.TabIndex = 20;
            this.cmbLugar.SelectionChangeCommitted += new System.EventHandler(this.cmbLugar_SelectionChangeCommitted);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Icon = null;
            this.btnImprimir.Location = new System.Drawing.Point(818, 80);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = false;
            this.btnImprimir.Size = new System.Drawing.Size(83, 36);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dtpmensualidad
            // 
            this.dtpmensualidad.Location = new System.Drawing.Point(18, 313);
            this.dtpmensualidad.Name = "dtpmensualidad";
            this.dtpmensualidad.Size = new System.Drawing.Size(308, 20);
            this.dtpmensualidad.TabIndex = 23;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(18, 286);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(140, 19);
            this.materialLabel5.TabIndex = 24;
            this.materialLabel5.Text = "Selecciona la fecha";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(353, 91);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 366);
            this.materialDivider1.TabIndex = 25;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pagos";
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader3});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(382, 119);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(717, 378);
            this.materialListView1.TabIndex = 27;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.DoubleClick += new System.EventHandler(this.materialListView1_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "id";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cliente";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lugar";
            this.columnHeader2.Width = 452;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "idPagos";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "idMensualidades";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "idmeses";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "idCliente";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(944, 80);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButton2.TabIndex = 28;
            this.materialRaisedButton2.Text = "Eliminar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1033, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtdescuento
            // 
            this.txtdescuento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescuento.BackColor = System.Drawing.Color.White;
            this.txtdescuento.Depth = 0;
            this.txtdescuento.ForeColor = System.Drawing.Color.Silver;
            this.txtdescuento.Hint = "Descuento";
            this.txtdescuento.Location = new System.Drawing.Point(163, 371);
            this.txtdescuento.MaxLength = 32767;
            this.txtdescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.PasswordChar = '\0';
            this.txtdescuento.SelectedText = "";
            this.txtdescuento.SelectionLength = 0;
            this.txtdescuento.SelectionStart = 0;
            this.txtdescuento.Size = new System.Drawing.Size(104, 23);
            this.txtdescuento.TabIndex = 30;
            this.txtdescuento.TabStop = false;
            this.txtdescuento.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(159, 349);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(123, 19);
            this.materialLabel6.TabIndex = 31;
            this.materialLabel6.Text = "Descuento / otro";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(18, 403);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(88, 19);
            this.materialLabel7.TabIndex = 33;
            this.materialLabel7.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentario.BackColor = System.Drawing.Color.White;
            this.txtComentario.Depth = 0;
            this.txtComentario.Enabled = false;
            this.txtComentario.ForeColor = System.Drawing.Color.Silver;
            this.txtComentario.Hint = "Comentario";
            this.txtComentario.Location = new System.Drawing.Point(22, 425);
            this.txtComentario.MaxLength = 32767;
            this.txtComentario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.PasswordChar = '\0';
            this.txtComentario.SelectedText = "";
            this.txtComentario.SelectionLength = 0;
            this.txtComentario.SelectionStart = 0;
            this.txtComentario.Size = new System.Drawing.Size(288, 23);
            this.txtComentario.TabIndex = 32;
            this.txtComentario.TabStop = false;
            this.txtComentario.UseSystemPasswordChar = false;
            // 
            // lbRestar
            // 
            this.lbRestar.AutoSize = true;
            this.lbRestar.BackColor = System.Drawing.Color.Transparent;
            this.lbRestar.Depth = 0;
            this.lbRestar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbRestar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbRestar.Location = new System.Drawing.Point(281, 376);
            this.lbRestar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRestar.Name = "lbRestar";
            this.lbRestar.Size = new System.Drawing.Size(13, 19);
            this.lbRestar.TabIndex = 34;
            this.lbRestar.Text = "-";
            this.lbRestar.Click += new System.EventHandler(this.lbRestar_Click);
            // 
            // lbsumar
            // 
            this.lbsumar.AutoSize = true;
            this.lbsumar.BackColor = System.Drawing.Color.Transparent;
            this.lbsumar.Depth = 0;
            this.lbsumar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbsumar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbsumar.Location = new System.Drawing.Point(281, 356);
            this.lbsumar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbsumar.Name = "lbsumar";
            this.lbsumar.Size = new System.Drawing.Size(18, 19);
            this.lbsumar.TabIndex = 35;
            this.lbsumar.Text = "+";
            this.lbsumar.Click += new System.EventHandler(this.lbsumar_Click);
            // 
            // lbidid
            // 
            this.lbidid.AutoSize = true;
            this.lbidid.BackColor = System.Drawing.Color.Transparent;
            this.lbidid.Depth = 0;
            this.lbidid.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbidid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbidid.Location = new System.Drawing.Point(281, 66);
            this.lbidid.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbidid.Name = "lbidid";
            this.lbidid.Size = new System.Drawing.Size(21, 19);
            this.lbidid.TabIndex = 36;
            this.lbidid.Text = "id";
            this.lbidid.Visible = false;
            // 
            // FormPagoMensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 525);
            this.Controls.Add(this.lbidid);
            this.Controls.Add(this.lbsumar);
            this.Controls.Add(this.lbRestar);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dtpmensualidad);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.cmbLugar);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtmonto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPagoMensualidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensualidad";
            this.Load += new System.EventHandler(this.FormPagoMensualidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton btnImprimir;
        public System.Windows.Forms.ComboBox cbCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdescuento;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComentario;
        private MaterialSkin.Controls.MaterialLabel lbRestar;
        private MaterialSkin.Controls.MaterialLabel lbsumar;
        internal MaterialSkin.Controls.MaterialLabel lbidid;
        internal MaterialSkin.Controls.MaterialSingleLineTextField txtmonto;
        internal System.Windows.Forms.ComboBox cbMes;
        internal System.Windows.Forms.DateTimePicker dtpmensualidad;
        public System.Windows.Forms.ComboBox cmbLugar;
    }
}