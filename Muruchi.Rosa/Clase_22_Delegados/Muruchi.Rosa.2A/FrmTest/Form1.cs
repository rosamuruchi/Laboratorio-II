using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
            Manejadora m = new Manejadora();
            this.btnBoton.Click += new EventHandler(Manejadora.Manejador);
            this.lblEtiqueta.Click += new EventHandler(Manejadora.Manejador);
            this.txtCuadroTexto.TextChanged += new EventHandler(Manejadora.Manejador);

            this.btnBoton.Click += new EventHandler(m.Manejador2);
            this.lblEtiqueta.Click += new EventHandler(m.Manejador2);
            this.txtCuadroTexto.TextChanged += new EventHandler(m.Manejador2);
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {

        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            //MessageBox.Show("Uso el manejador de eventos");
            //this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click); //suma una vez mas un metodo o accion del evento
            //this.txtCuadroTexto.TextChanged += new System.EventHandler(this.txtCuadroTexto_TextChanged);
            
        }

        private void lblEtiqueta_Click(object sender, EventArgs e)
        {
            //this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click); //suma una vez mas un metodo o accion del evento
            //this.txtCuadroTexto.TextChanged -= new System.EventHandler(this.txtCuadroTexto_TextChanged);
            //MessageBox.Show("Click en label");
        }

        private void txtCuadroTexto_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("click en cuadro de Texto");
        }
    }
}
