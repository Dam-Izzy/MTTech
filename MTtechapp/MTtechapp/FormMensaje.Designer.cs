namespace MTtechapp
{
    partial class FormMensaje
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
            this.txtnumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbclientem = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtmensaje = new System.Windows.Forms.RichTextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Depth = 0;
            this.txtnumero.Hint = "Teléfono";
            this.txtnumero.Location = new System.Drawing.Point(64, 228);
            this.txtnumero.MaxLength = 32767;
            this.txtnumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.PasswordChar = '\0';
            this.txtnumero.SelectedText = "";
            this.txtnumero.SelectionLength = 0;
            this.txtnumero.SelectionStart = 0;
            this.txtnumero.Size = new System.Drawing.Size(311, 23);
            this.txtnumero.TabIndex = 0;
            this.txtnumero.TabStop = false;
            this.txtnumero.UseSystemPasswordChar = false;
            // 
            // cbclientem
            // 
            this.cbclientem.FormattingEnabled = true;
            this.cbclientem.Location = new System.Drawing.Point(64, 165);
            this.cbclientem.Name = "cbclientem";
            this.cbclientem.Size = new System.Drawing.Size(311, 21);
            this.cbclientem.TabIndex = 1;
            this.cbclientem.Click += new System.EventHandler(this.cbclientem_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(60, 130);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Cliente";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(60, 206);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Numero";
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(64, 279);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(603, 134);
            this.txtmensaje.TabIndex = 4;
            this.txtmensaje.Text = "";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(246, 437);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(135, 36);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Enviar mensaje";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // FormMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 501);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbclientem);
            this.Controls.Add(this.txtnumero);
            this.Name = "FormMensaje";
            this.Text = "FormMensaje";
            this.Load += new System.EventHandler(this.FormMensaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialSingleLineTextField txtnumero;
        private System.Windows.Forms.ComboBox cbclientem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RichTextBox txtmensaje;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}