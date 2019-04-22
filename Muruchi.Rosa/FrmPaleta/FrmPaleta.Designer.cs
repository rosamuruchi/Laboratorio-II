namespace FrmPaleta
{
    partial class FrmPaleta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMas = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMas
            // 
            this.buttonMas.Location = new System.Drawing.Point(64, 245);
            this.buttonMas.Name = "buttonMas";
            this.buttonMas.Size = new System.Drawing.Size(75, 43);
            this.buttonMas.TabIndex = 0;
            this.buttonMas.Text = "+";
            this.buttonMas.UseVisualStyleBackColor = true;
            this.buttonMas.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(48, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(195, 245);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(77, 43);
            this.btnMenos.TabIndex = 2;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // FrmPaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 287);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonMas);
            this.Name = "FrmPaleta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMenos;
    }
}

