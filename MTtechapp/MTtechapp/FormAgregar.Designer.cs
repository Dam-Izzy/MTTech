namespace MTtechapp
{
    using MaterialSkin;
    using MaterialSkin.Controls;
    partial class FormAgregar
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
            this.txtIp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCometarioip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.idsegmentacion = new MaterialSkin.Controls.MaterialLabel();
            this.txtrouter = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.lbborrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.Color.White;
            this.txtIp.Depth = 0;
            this.txtIp.ForeColor = System.Drawing.Color.White;
            this.txtIp.Hint = "Ip o usuario(PPPoe)";
            this.txtIp.Location = new System.Drawing.Point(66, 185);
            this.txtIp.MaxLength = 32767;
            this.txtIp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIp.Name = "txtIp";
            this.txtIp.PasswordChar = '\0';
            this.txtIp.SelectedText = "";
            this.txtIp.SelectionLength = 0;
            this.txtIp.SelectionStart = 0;
            this.txtIp.Size = new System.Drawing.Size(353, 23);
            this.txtIp.TabIndex = 2;
            this.txtIp.TabStop = false;
            this.txtIp.UseSystemPasswordChar = false;
            // 
            // txtCometarioip
            // 
            this.txtCometarioip.BackColor = System.Drawing.Color.White;
            this.txtCometarioip.Depth = 0;
            this.txtCometarioip.ForeColor = System.Drawing.Color.White;
            this.txtCometarioip.Hint = "Comentario";
            this.txtCometarioip.Location = new System.Drawing.Point(66, 238);
            this.txtCometarioip.MaxLength = 32767;
            this.txtCometarioip.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCometarioip.Name = "txtCometarioip";
            this.txtCometarioip.PasswordChar = '\0';
            this.txtCometarioip.SelectedText = "";
            this.txtCometarioip.SelectionLength = 0;
            this.txtCometarioip.SelectionStart = 0;
            this.txtCometarioip.Size = new System.Drawing.Size(249, 23);
            this.txtCometarioip.TabIndex = 3;
            this.txtCometarioip.TabStop = false;
            this.txtCometarioip.UseSystemPasswordChar = false;
            // 
            // txtGuardar
            // 
            this.txtGuardar.AutoSize = true;
            this.txtGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtGuardar.Depth = 0;
            this.txtGuardar.Icon = null;
            this.txtGuardar.Location = new System.Drawing.Point(0, 0);
            this.txtGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Primary = true;
            this.txtGuardar.Size = new System.Drawing.Size(16, 36);
            this.txtGuardar.TabIndex = 21;
            // 
            // cbCliente
            // 
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(66, 305);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(249, 21);
            this.cbCliente.TabIndex = 4;
            this.cbCliente.Click += new System.EventHandler(this.cbCliente_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(321, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "+";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(66, 281);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Selecciona un cliente";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(66, 107);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Ip router";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(66, 364);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(84, 36);
            this.materialRaisedButton1.TabIndex = 18;
            this.materialRaisedButton1.Text = "Guardar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(66, 163);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(21, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "ip";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(66, 216);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(88, 19);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "Comentario";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(156, 364);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(103, 36);
            this.materialRaisedButton2.TabIndex = 27;
            this.materialRaisedButton2.Text = "Actualizar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // idsegmentacion
            // 
            this.idsegmentacion.AutoSize = true;
            this.idsegmentacion.BackColor = System.Drawing.Color.Transparent;
            this.idsegmentacion.Depth = 0;
            this.idsegmentacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.idsegmentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idsegmentacion.Location = new System.Drawing.Point(399, 393);
            this.idsegmentacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.idsegmentacion.Name = "idsegmentacion";
            this.idsegmentacion.Size = new System.Drawing.Size(13, 19);
            this.idsegmentacion.TabIndex = 28;
            this.idsegmentacion.Text = ".";
            // 
            // txtrouter
            // 
            this.txtrouter.BackColor = System.Drawing.Color.White;
            this.txtrouter.Depth = 0;
            this.txtrouter.ForeColor = System.Drawing.Color.White;
            this.txtrouter.Hint = "Ip del router";
            this.txtrouter.Location = new System.Drawing.Point(66, 129);
            this.txtrouter.MaxLength = 32767;
            this.txtrouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtrouter.Name = "txtrouter";
            this.txtrouter.PasswordChar = '\0';
            this.txtrouter.SelectedText = "";
            this.txtrouter.SelectionLength = 0;
            this.txtrouter.SelectionStart = 0;
            this.txtrouter.Size = new System.Drawing.Size(249, 23);
            this.txtrouter.TabIndex = 1;
            this.txtrouter.TabStop = false;
            this.txtrouter.UseSystemPasswordChar = false;
            this.txtrouter.Leave += new System.EventHandler(this.txtrouter_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Agregar cliente";
            // 
            // lbborrar
            // 
            this.lbborrar.AutoSize = true;
            this.lbborrar.BackColor = System.Drawing.Color.White;
            this.lbborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbborrar.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbborrar.Location = new System.Drawing.Point(351, 300);
            this.lbborrar.Name = "lbborrar";
            this.lbborrar.Size = new System.Drawing.Size(23, 31);
            this.lbborrar.TabIndex = 6;
            this.lbborrar.Text = "-";
            this.lbborrar.Click += new System.EventHandler(this.lbborrar_Click);
            // 
            // FormAgregar
            // 
            this.AcceptButton = this.txtGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(460, 421);
            this.Controls.Add(this.lbborrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idsegmentacion);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtCometarioip);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.txtrouter);
            this.MaximizeBox = false;
            this.Name = "FormAgregar";
            this.Opacity = 0.95D;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialRaisedButton txtGuardar;
        public MaterialSingleLineTextField txtIp;
        public MaterialSingleLineTextField txtCometarioip;
        private MaterialLabel materialLabel2;
        public System.Windows.Forms.ComboBox cbCliente;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel5;
        public MaterialRaisedButton materialRaisedButton1;
        public System.Windows.Forms.Label label1;
        public MaterialRaisedButton materialRaisedButton2;
        public MaterialLabel idsegmentacion;
        public MaterialSingleLineTextField txtrouter;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbborrar;
    }
}