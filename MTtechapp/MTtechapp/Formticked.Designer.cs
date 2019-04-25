namespace MTtechapp
{
    partial class Formticked
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
            this.btnticket = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnreporte = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(135, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "¿Ticket o reporte?";
            // 
            // btnticket
            // 
            this.btnticket.AutoSize = true;
            this.btnticket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnticket.Depth = 0;
            this.btnticket.Icon = null;
            this.btnticket.Location = new System.Drawing.Point(77, 104);
            this.btnticket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnticket.Name = "btnticket";
            this.btnticket.Primary = true;
            this.btnticket.Size = new System.Drawing.Size(67, 36);
            this.btnticket.TabIndex = 1;
            this.btnticket.Text = "ticket";
            this.btnticket.UseVisualStyleBackColor = true;
            this.btnticket.Click += new System.EventHandler(this.btnticket_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.AutoSize = true;
            this.btnreporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnreporte.Depth = 0;
            this.btnreporte.Icon = null;
            this.btnreporte.Location = new System.Drawing.Point(243, 104);
            this.btnreporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Primary = true;
            this.btnreporte.Size = new System.Drawing.Size(80, 36);
            this.btnreporte.TabIndex = 2;
            this.btnreporte.Text = "reporte";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // Formticked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 150);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btnticket);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formticked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formticked";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnticket;
        private MaterialSkin.Controls.MaterialRaisedButton btnreporte;
    }
}