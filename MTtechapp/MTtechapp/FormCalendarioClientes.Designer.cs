namespace MTtechapp
{
    partial class FormCalendarioClientes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnprox = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbcomment = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MTtechapp.ReporteMensualidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(562, 420);
            this.reportViewer1.TabIndex = 0;
            // 
            // Dtpfecha
            // 
            this.Dtpfecha.Location = new System.Drawing.Point(12, 47);
            this.Dtpfecha.Name = "Dtpfecha";
            this.Dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.Dtpfecha.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(144, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Fecha pago proxima";
            // 
            // btnprox
            // 
            this.btnprox.AutoSize = true;
            this.btnprox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnprox.Depth = 0;
            this.btnprox.Icon = null;
            this.btnprox.Location = new System.Drawing.Point(230, 33);
            this.btnprox.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnprox.Name = "btnprox";
            this.btnprox.Primary = true;
            this.btnprox.Size = new System.Drawing.Size(103, 36);
            this.btnprox.TabIndex = 3;
            this.btnprox.Text = "Actualizar";
            this.btnprox.UseVisualStyleBackColor = true;
            this.btnprox.Click += new System.EventHandler(this.btnprox_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(164, -2);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Comentario:";
            // 
            // lbcomment
            // 
            this.lbcomment.AutoSize = true;
            this.lbcomment.Depth = 0;
            this.lbcomment.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbcomment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbcomment.Location = new System.Drawing.Point(252, -2);
            this.lbcomment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbcomment.Name = "lbcomment";
            this.lbcomment.Size = new System.Drawing.Size(23, 19);
            this.lbcomment.TabIndex = 5;
            this.lbcomment.Text = "¿?";
            // 
            // FormCalendarioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 591);
            this.Controls.Add(this.lbcomment);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnprox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Dtpfecha);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormCalendarioClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVistaClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVistaClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker Dtpfecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnprox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lbcomment;
    }
}