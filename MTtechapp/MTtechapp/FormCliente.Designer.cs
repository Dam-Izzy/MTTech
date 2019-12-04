namespace MTtechapp
{
    partial class FormCliente
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtcodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpInstalacion = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbActivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtcomentario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtdireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtnombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbEquipo = new MaterialSkin.Controls.MaterialCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcliente = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(94, 336);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(103, 36);
            this.materialFlatButton1.TabIndex = 33;
            this.materialFlatButton1.Text = "Actualizar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Visible = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(43, 336);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(84, 36);
            this.materialRaisedButton1.TabIndex = 10;
            this.materialRaisedButton1.Text = "Guardar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(350, 256);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(46, 19);
            this.materialLabel14.TabIndex = 31;
            this.materialLabel14.Text = "Clave";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.White;
            this.txtcodigo.Depth = 0;
            this.txtcodigo.Hint = "Clave";
            this.txtcodigo.Location = new System.Drawing.Point(350, 278);
            this.txtcodigo.MaxLength = 32767;
            this.txtcodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PasswordChar = '\0';
            this.txtcodigo.SelectedText = "";
            this.txtcodigo.SelectionLength = 0;
            this.txtcodigo.SelectionStart = 0;
            this.txtcodigo.Size = new System.Drawing.Size(295, 23);
            this.txtcodigo.TabIndex = 9;
            this.txtcodigo.TabStop = false;
            this.txtcodigo.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(346, 210);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(147, 19);
            this.materialLabel13.TabIndex = 29;
            this.materialLabel13.Text = "Fecha de instalación";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(346, 147);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(169, 19);
            this.materialLabel12.TabIndex = 28;
            this.materialLabel12.Text = "Seleccione el municipio";
            // 
            // dtpInstalacion
            // 
            this.dtpInstalacion.Location = new System.Drawing.Point(350, 232);
            this.dtpInstalacion.Name = "dtpInstalacion";
            this.dtpInstalacion.Size = new System.Drawing.Size(258, 20);
            this.dtpInstalacion.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(350, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.BackColor = System.Drawing.Color.White;
            this.cbActivo.Depth = 0;
            this.cbActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbActivo.Location = new System.Drawing.Point(350, 117);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(0);
            this.cbActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Ripple = true;
            this.cbActivo.Size = new System.Drawing.Size(82, 30);
            this.cbActivo.TabIndex = 5;
            this.cbActivo.Text = "¿Activo?";
            this.cbActivo.UseVisualStyleBackColor = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(40, 256);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(88, 19);
            this.materialLabel11.TabIndex = 24;
            this.materialLabel11.Text = "Comentario";
            // 
            // txtcomentario
            // 
            this.txtcomentario.BackColor = System.Drawing.Color.White;
            this.txtcomentario.Depth = 0;
            this.txtcomentario.Hint = "Comentario";
            this.txtcomentario.Location = new System.Drawing.Point(40, 278);
            this.txtcomentario.MaxLength = 32767;
            this.txtcomentario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.PasswordChar = '\0';
            this.txtcomentario.SelectedText = "";
            this.txtcomentario.SelectionLength = 0;
            this.txtcomentario.SelectionStart = 0;
            this.txtcomentario.Size = new System.Drawing.Size(295, 23);
            this.txtcomentario.TabIndex = 4;
            this.txtcomentario.TabStop = false;
            this.txtcomentario.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(40, 207);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(73, 19);
            this.materialLabel10.TabIndex = 22;
            this.materialLabel10.Text = "Dirección";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.White;
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Hint = "Dirección";
            this.txtdireccion.Location = new System.Drawing.Point(40, 229);
            this.txtdireccion.MaxLength = 32767;
            this.txtdireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.SelectionLength = 0;
            this.txtdireccion.SelectionStart = 0;
            this.txtdireccion.Size = new System.Drawing.Size(295, 23);
            this.txtdireccion.TabIndex = 3;
            this.txtdireccion.TabStop = false;
            this.txtdireccion.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(40, 155);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(69, 19);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "Teléfono";
            this.txtTelefono.Location = new System.Drawing.Point(40, 177);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(295, 23);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(40, 102);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(131, 19);
            this.materialLabel8.TabIndex = 18;
            this.materialLabel8.Text = "Nombre completo";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Depth = 0;
            this.txtnombre.Hint = "Nombre completo";
            this.txtnombre.Location = new System.Drawing.Point(40, 124);
            this.txtnombre.MaxLength = 32767;
            this.txtnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.SelectedText = "";
            this.txtnombre.SelectionLength = 0;
            this.txtnombre.SelectionStart = 0;
            this.txtnombre.Size = new System.Drawing.Size(295, 23);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TabStop = false;
            this.txtnombre.UseSystemPasswordChar = false;
            // 
            // cbEquipo
            // 
            this.cbEquipo.AutoSize = true;
            this.cbEquipo.BackColor = System.Drawing.Color.White;
            this.cbEquipo.Depth = 0;
            this.cbEquipo.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbEquipo.Location = new System.Drawing.Point(487, 117);
            this.cbEquipo.Margin = new System.Windows.Forms.Padding(0);
            this.cbEquipo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbEquipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Ripple = true;
            this.cbEquipo.Size = new System.Drawing.Size(108, 30);
            this.cbEquipo.TabIndex = 6;
            this.cbEquipo.Text = "¿Comprado?";
            this.cbEquipo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(606, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbcliente
            // 
            this.lbcliente.AutoSize = true;
            this.lbcliente.Depth = 0;
            this.lbcliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbcliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbcliente.Location = new System.Drawing.Point(524, 336);
            this.lbcliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbcliente.Name = "lbcliente";
            this.lbcliente.Size = new System.Drawing.Size(0, 19);
            this.lbcliente.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 67);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Agregar cliente";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(636, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 72;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // FormCliente
            // 
            this.ClientSize = new System.Drawing.Size(709, 399);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEquipo);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.dtpInstalacion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtnombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtcodigo;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        public System.Windows.Forms.DateTimePicker dtpInstalacion;
        public System.Windows.Forms.ComboBox comboBox1;
        public MaterialSkin.Controls.MaterialCheckBox cbActivo;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtcomentario;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtdireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtnombre;
        public MaterialSkin.Controls.MaterialCheckBox cbEquipo;
        public System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialLabel lbcliente;
        public MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}