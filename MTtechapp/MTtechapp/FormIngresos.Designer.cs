namespace MTtechapp
{
    partial class FormIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresos));
            this.label1 = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFiltro = new System.Windows.Forms.DateTimePicker();
            this.btnfiltrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnImprimir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregarIng = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtmonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.txtDescrip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CheckEstado = new MaterialSkin.Controls.MaterialCheckBox();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbid = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 88);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ingresos de MTNetwork\'s";
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Socios",
            "Fichas",
            "Gastos"});
            this.cbtipo.Location = new System.Drawing.Point(30, 161);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(317, 21);
            this.cbtipo.TabIndex = 64;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 142);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(207, 19);
            this.materialLabel1.TabIndex = 65;
            this.materialLabel1.Text = "Seleccione el tipo de ingreso.";
            // 
            // dtpFiltro
            // 
            this.dtpFiltro.Location = new System.Drawing.Point(30, 211);
            this.dtpFiltro.Name = "dtpFiltro";
            this.dtpFiltro.Size = new System.Drawing.Size(317, 20);
            this.dtpFiltro.TabIndex = 66;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.AutoSize = true;
            this.btnfiltrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnfiltrar.Depth = 0;
            this.btnfiltrar.Icon = null;
            this.btnfiltrar.Location = new System.Drawing.Point(354, 205);
            this.btnfiltrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnfiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Primary = false;
            this.btnfiltrar.Size = new System.Drawing.Size(74, 36);
            this.btnfiltrar.TabIndex = 68;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(435, 142);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(671, 385);
            this.materialListView1.TabIndex = 69;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.materialListView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 222;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Localidad";
            this.columnHeader3.Width = 309;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 232;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1090, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(30, 189);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(140, 19);
            this.materialLabel2.TabIndex = 71;
            this.materialLabel2.Text = "Seleccione la fecha";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.AutoSize = true;
            this.BtnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnImprimir.Depth = 0;
            this.BtnImprimir.Icon = null;
            this.BtnImprimir.Location = new System.Drawing.Point(225, 477);
            this.BtnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Primary = true;
            this.BtnImprimir.Size = new System.Drawing.Size(158, 36);
            this.BtnImprimir.TabIndex = 84;
            this.BtnImprimir.Text = "Imprimir registros";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnAgregarIng
            // 
            this.btnAgregarIng.AutoSize = true;
            this.btnAgregarIng.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarIng.Depth = 0;
            this.btnAgregarIng.Icon = null;
            this.btnAgregarIng.Location = new System.Drawing.Point(50, 477);
            this.btnAgregarIng.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarIng.Name = "btnAgregarIng";
            this.btnAgregarIng.Primary = true;
            this.btnAgregarIng.Size = new System.Drawing.Size(143, 36);
            this.btnAgregarIng.TabIndex = 83;
            this.btnAgregarIng.Text = "Agregar ingreso";
            this.btnAgregarIng.UseVisualStyleBackColor = true;
            this.btnAgregarIng.Click += new System.EventHandler(this.btnAgregarIng_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(30, 353);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(53, 19);
            this.materialLabel5.TabIndex = 82;
            this.materialLabel5.Text = "Monto";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(30, 299);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 81;
            this.materialLabel4.Text = "Lugar";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(30, 252);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(89, 19);
            this.materialLabel3.TabIndex = 80;
            this.materialLabel3.Text = "Descripción";
            // 
            // txtmonto
            // 
            this.txtmonto.Depth = 0;
            this.txtmonto.Hint = "Monto";
            this.txtmonto.Location = new System.Drawing.Point(34, 375);
            this.txtmonto.MaxLength = 32767;
            this.txtmonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.PasswordChar = '\0';
            this.txtmonto.SelectedText = "";
            this.txtmonto.SelectionLength = 0;
            this.txtmonto.SelectionStart = 0;
            this.txtmonto.Size = new System.Drawing.Size(294, 23);
            this.txtmonto.TabIndex = 79;
            this.txtmonto.TabStop = false;
            this.txtmonto.UseSystemPasswordChar = false;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(34, 322);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(301, 21);
            this.cbLocalidad.TabIndex = 78;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Depth = 0;
            this.txtDescrip.Hint = "Descripción";
            this.txtDescrip.Location = new System.Drawing.Point(34, 273);
            this.txtDescrip.MaxLength = 32767;
            this.txtDescrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasswordChar = '\0';
            this.txtDescrip.SelectedText = "";
            this.txtDescrip.SelectionLength = 0;
            this.txtDescrip.SelectionStart = 0;
            this.txtDescrip.Size = new System.Drawing.Size(294, 23);
            this.txtDescrip.TabIndex = 77;
            this.txtDescrip.TabStop = false;
            this.txtDescrip.UseSystemPasswordChar = false;
            // 
            // CheckEstado
            // 
            this.CheckEstado.AutoSize = true;
            this.CheckEstado.Depth = 0;
            this.CheckEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckEstado.Location = new System.Drawing.Point(34, 405);
            this.CheckEstado.Margin = new System.Windows.Forms.Padding(0);
            this.CheckEstado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckEstado.Name = "CheckEstado";
            this.CheckEstado.Ripple = true;
            this.CheckEstado.Size = new System.Drawing.Size(113, 30);
            this.CheckEstado.TabIndex = 85;
            this.CheckEstado.Text = "item revisado";
            this.CheckEstado.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(50, 477);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 86;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Visible = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Depth = 0;
            this.lbid.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbid.Location = new System.Drawing.Point(395, 99);
            this.lbid.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(0, 19);
            this.lbid.TabIndex = 87;
            this.lbid.Visible = false;
            // 
            // FormIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 539);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.CheckEstado);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.btnAgregarIng);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.cbLocalidad);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.dtpFiltro);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.FormIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtipo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpFiltro;
        private MaterialSkin.Controls.MaterialFlatButton btnfiltrar;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton BtnImprimir;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarIng;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtmonto;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescrip;
        public MaterialSkin.Controls.MaterialCheckBox CheckEstado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialLabel lbid;
    }
}