namespace FrmTest
{
    partial class FrmTest2
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
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.btnBoton2 = new System.Windows.Forms.Button();
            this.btnBoton3 = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoton1
            // 
            this.btnBoton1.Location = new System.Drawing.Point(12, 12);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(119, 54);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "button1";
            this.btnBoton1.UseVisualStyleBackColor = true;
            // 
            // btnBoton2
            // 
            this.btnBoton2.Location = new System.Drawing.Point(153, 12);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Size = new System.Drawing.Size(115, 54);
            this.btnBoton2.TabIndex = 1;
            this.btnBoton2.Text = "button2";
            this.btnBoton2.UseVisualStyleBackColor = true;
            // 
            // btnBoton3
            // 
            this.btnBoton3.Location = new System.Drawing.Point(290, 12);
            this.btnBoton3.Name = "btnBoton3";
            this.btnBoton3.Size = new System.Drawing.Size(124, 54);
            this.btnBoton3.TabIndex = 2;
            this.btnBoton3.Text = "button3";
            this.btnBoton3.UseVisualStyleBackColor = true;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(65, 114);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(311, 46);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // FrmTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 237);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnBoton3);
            this.Controls.Add(this.btnBoton2);
            this.Controls.Add(this.btnBoton1);
            this.Name = "FrmTest2";
            this.Text = "FrmTest2";
            this.Load += new System.EventHandler(this.FrmTest2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoton1;
        private System.Windows.Forms.Button btnBoton2;
        private System.Windows.Forms.Button btnBoton3;
        private System.Windows.Forms.Button btnOperar;
    }
}