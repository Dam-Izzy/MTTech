namespace MTtechapp
{
    partial class FormReporteMensualidad
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
            this.components = new System.ComponentModel.Container();
            this.pagosfechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MunicipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClasedatosinformepagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pagosfechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClasedatosinformepagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pagosfechasBindingSource
            // 
            this.pagosfechasBindingSource.DataSource = typeof(MTtechapp.pagosfechas);
            // 
            // MunicipioBindingSource
            // 
            this.MunicipioBindingSource.DataSource = typeof(MTtechapp.Municipio);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MTtechapp.ReporteMensualidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(787, 435);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClasedatosinformepagoBindingSource
            // 
            this.ClasedatosinformepagoBindingSource.DataSource = typeof(MTtechapp.Clasedatosinformepago);
            // 
            // FormReporteMensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteMensualidad";
            this.Text = "ReporteMensualidad";
            this.Load += new System.EventHandler(this.FormReporteMensualidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagosfechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClasedatosinformepagoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClasedatosinformepagoBindingSource;
        private System.Windows.Forms.BindingSource MunicipioBindingSource;
        private System.Windows.Forms.BindingSource pagosfechasBindingSource;
    }
}