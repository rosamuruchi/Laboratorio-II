namespace FrmPaleta
{
    partial class FrmTempera
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 84);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 170);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(12, 34);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(161, 20);
            this.textMarca.TabIndex = 3;
            this.textMarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(15, 112);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(158, 21);
            this.cboColor.TabIndex = 4;
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(15, 206);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(158, 20);
            this.textCantidad.TabIndex = 5;
            this.textCantidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(12, 243);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(98, 243);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmTempera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 271);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMarca);
            this.Name = "FrmTempera";
            this.Text = "Label";
            this.Load += new System.EventHandler(this.Label_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}