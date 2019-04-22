using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPaleta
{
    public partial class FrmPrincipal : Form
    {
        

        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void frmPrincipal_formClosing (object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show ("Seguro desea salir?","ATENCION", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                this.DialogResult = DialogResult.No;
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaleta paleta = new FrmPaleta();
            paleta.MdiParent = this;
            paleta.Show();

            //texto a la drecha -> text box o comboBox (predert.)
            //abajo ! dejar un lugar  
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmPrincipal_formClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, true));

            if(this.DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            

        }
    }
}
