namespace MTtechapp
{
    partial class FormCambiar
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
            this.txtantigua = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnueva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btncambiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtantigua
            // 
            this.txtantigua.Depth = 0;
            this.txtantigua.Hint = "Antigua contraseña";
            this.txtantigua.Location = new System.Drawing.Point(36, 148);
            this.txtantigua.MaxLength = 32767;
            this.txtantigua.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtantigua.Name = "txtantigua";
            this.txtantigua.PasswordChar = '*';
            this.txtantigua.SelectedText = "";
            this.txtantigua.SelectionLength = 0;
            this.txtantigua.SelectionStart = 0;
            this.txtantigua.Size = new System.Drawing.Size(253, 23);
            this.txtantigua.TabIndex = 0;
            this.txtantigua.TabStop = false;
            this.txtantigua.UseSystemPasswordChar = false;
            // 
            // txtnueva
            // 
            this.txtnueva.Depth = 0;
            this.txtnueva.Hint = "Nueva contraseña";
            this.txtnueva.Location = new System.Drawing.Point(36, 200);
            this.txtnueva.MaxLength = 32767;
            this.txtnueva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.PasswordChar = '*';
            this.txtnueva.SelectedText = "";
            this.txtnueva.SelectionLength = 0;
            this.txtnueva.SelectionStart = 0;
            this.txtnueva.Size = new System.Drawing.Size(253, 23);
            this.txtnueva.TabIndex = 1;
            this.txtnueva.TabStop = false;
            this.txtnueva.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 126);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Antigua contraseña";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(32, 178);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(130, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Nueva contraseña";
            // 
            // btncambiar
            // 
            this.btncambiar.AutoSize = true;
            this.btncambiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncambiar.Depth = 0;
            this.btncambiar.Icon = null;
            this.btncambiar.Location = new System.Drawing.Point(70, 247);
            this.btncambiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Primary = true;
            this.btncambiar.Size = new System.Drawing.Size(84, 36);
            this.btncambiar.TabIndex = 4;
            this.btncambiar.Text = "Guardar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 85);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cambiar contraseña";
            // 
            // FormCambiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.txtantigua);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCambiar";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtantigua;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnueva;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btncambiar;
        private System.Windows.Forms.Label label1;
    }
}