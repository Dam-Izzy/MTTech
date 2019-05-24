namespace MTtechapp
{
    partial class FormVisualizadorIngresos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpentrefecha = new System.Windows.Forms.DateTimePicker();
            this.btnRevisar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "mensualidades";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "socios";
            reportDataSource2.Value = null;
            reportDataSource3.Name = "otros";
            reportDataSource3.Value = null;
            reportDataSource4.Name = "fichas";
            reportDataSource4.Value = null;
            reportDataSource5.Name = "gastos";
            reportDataSource5.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MTtechapp.ReporteCorte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportViewer1.Size = new System.Drawing.Size(951, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(275, 20);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 1;
            this.dtpfecha.CloseUp += new System.EventHandler(this.dtpfecha_CloseUp);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(133, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(132, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Actualizar reporte:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(481, 20);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(17, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "a";
            // 
            // dtpentrefecha
            // 
            this.dtpentrefecha.Location = new System.Drawing.Point(504, 18);
            this.dtpentrefecha.Name = "dtpentrefecha";
            this.dtpentrefecha.Size = new System.Drawing.Size(200, 20);
            this.dtpentrefecha.TabIndex = 4;
            // 
            // btnRevisar
            // 
            this.btnRevisar.AutoSize = true;
            this.btnRevisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRevisar.Depth = 0;
            this.btnRevisar.Icon = null;
            this.btnRevisar.Location = new System.Drawing.Point(741, 10);
            this.btnRevisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRevisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Primary = false;
            this.btnRevisar.Size = new System.Drawing.Size(74, 36);
            this.btnRevisar.TabIndex = 5;
            this.btnRevisar.Text = "Filtrar";
            this.btnRevisar.UseVisualStyleBackColor = true;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // FormVisualizadorIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 527);
            this.Controls.Add(this.btnRevisar);
            this.Controls.Add(this.dtpentrefecha);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormVisualizadorIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVisualizadorIngresos";
            this.Load += new System.EventHandler(this.FormVisualizadorIngresos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtpentrefecha;
        private MaterialSkin.Controls.MaterialFlatButton btnRevisar;
    }
}