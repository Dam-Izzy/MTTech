namespace MTtechapp
{
    partial class FormDialogo
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnreporte = new MaterialSkin.Controls.MaterialFlatButton();
            this.btncancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btncalendario = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbid = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(223, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "¿Qué desea hacer?";
            // 
            // btnreporte
            // 
            this.btnreporte.AutoSize = true;
            this.btnreporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnreporte.Depth = 0;
            this.btnreporte.Icon = null;
            this.btnreporte.Location = new System.Drawing.Point(59, 158);
            this.btnreporte.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnreporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Primary = false;
            this.btnreporte.Size = new System.Drawing.Size(145, 36);
            this.btnreporte.TabIndex = 1;
            this.btnreporte.Text = "Imprimir reporte";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSize = true;
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Depth = 0;
            this.btncancelar.Icon = null;
            this.btncancelar.Location = new System.Drawing.Point(464, 158);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Primary = false;
            this.btncancelar.Size = new System.Drawing.Size(91, 36);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btncalendario
            // 
            this.btncalendario.AutoSize = true;
            this.btncalendario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncalendario.Depth = 0;
            this.btncalendario.Icon = null;
            this.btncalendario.Location = new System.Drawing.Point(245, 158);
            this.btncalendario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncalendario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncalendario.Name = "btncalendario";
            this.btncalendario.Primary = false;
            this.btncalendario.Size = new System.Drawing.Size(169, 36);
            this.btncalendario.TabIndex = 3;
            this.btncalendario.Text = "Imprimir calendario";
            this.btncalendario.UseVisualStyleBackColor = true;
            this.btncalendario.Click += new System.EventHandler(this.btncalendario_Click);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Depth = 0;
            this.lbid.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbid.Location = new System.Drawing.Point(567, 77);
            this.lbid.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(17, 19);
            this.lbid.TabIndex = 4;
            this.lbid.Text = "--";
            // 
            // FormDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 226);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.btncalendario);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogo";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImprimir2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnreporte;
        private MaterialSkin.Controls.MaterialFlatButton btncancelar;
        private MaterialSkin.Controls.MaterialFlatButton btncalendario;
        public MaterialSkin.Controls.MaterialLabel lbid;
    }
}