namespace MTtechapp
{
    partial class FormMunicipio
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
            this.txtmunicipios = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lvmun = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbid = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtmunicipios
            // 
            this.txtmunicipios.Depth = 0;
            this.txtmunicipios.Hint = "Municipio";
            this.txtmunicipios.Location = new System.Drawing.Point(8, 124);
            this.txtmunicipios.MaxLength = 32767;
            this.txtmunicipios.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtmunicipios.Name = "txtmunicipios";
            this.txtmunicipios.PasswordChar = '\0';
            this.txtmunicipios.SelectedText = "";
            this.txtmunicipios.SelectionLength = 0;
            this.txtmunicipios.SelectionStart = 0;
            this.txtmunicipios.Size = new System.Drawing.Size(196, 23);
            this.txtmunicipios.TabIndex = 0;
            this.txtmunicipios.TabStop = false;
            this.txtmunicipios.UseSystemPasswordChar = false;
            // 
            // lvmun
            // 
            this.lvmun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvmun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvmun.Depth = 0;
            this.lvmun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lvmun.FullRowSelect = true;
            this.lvmun.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvmun.HideSelection = false;
            this.lvmun.Location = new System.Drawing.Point(12, 184);
            this.lvmun.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvmun.MouseState = MaterialSkin.MouseState.OUT;
            this.lvmun.Name = "lvmun";
            this.lvmun.OwnerDraw = true;
            this.lvmun.Size = new System.Drawing.Size(403, 258);
            this.lvmun.TabIndex = 1;
            this.lvmun.UseCompatibleStateImageBehavior = false;
            this.lvmun.View = System.Windows.Forms.View.Details;
            this.lvmun.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvmun_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 353;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(210, 111);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(83, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 71);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Municipio";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(210, 111);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(327, 71);
            this.lbid.Name = "lbid";
            this.lbid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbid.Size = new System.Drawing.Size(92, 24);
            this.lbid.TabIndex = 8;
            this.lbid.Text = "Municipio";
            this.lbid.Visible = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(319, 111);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(74, 36);
            this.materialRaisedButton1.TabIndex = 9;
            this.materialRaisedButton1.Text = "Borrar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Visible = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // FormMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 466);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvmun);
            this.Controls.Add(this.txtmunicipios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMunicipio";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMunicipio";
            this.Load += new System.EventHandler(this.FormMunicipio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView lvmun;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtmunicipios;
        private System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        public MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        public System.Windows.Forms.Label lbid;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}