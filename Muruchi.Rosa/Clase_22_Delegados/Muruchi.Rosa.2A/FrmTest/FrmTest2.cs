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
    public partial class FrmTest2 : Form
    {
        public FrmTest2()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.Inicializar);
        }
        private void FrmTest2_Load(object sender, EventArgs e)
        {
            
        }
        private void Inicializar(object sender, EventArgs e)
        {
            this.btnBoton1.Click += new EventHandler(this.MiManejador);
        }
        private void MiManejador(object sender, EventArgs e)
        {
            string c = ((Control)sender).Name;
            MessageBox.Show(((Button)sender).Name);

            if (c == "btnBoton1")
            {
                this.btnBoton1.Click -= new EventHandler(this.MiManejador);
                this.btnBoton2.Click += new EventHandler(this.MiManejador);
            }
            else if (c == "btnBoton2")
            {
                this.btnBoton2.Click -= new EventHandler(this.MiManejador);
                this.btnBoton3.Click += new EventHandler(this.MiManejador);
            }
            else if (c == "btnBoton3")
            {
                this.btnBoton3.Click -= new EventHandler(this.MiManejador);
                this.btnBoton1.Click += new EventHandler(this.MiManejador);
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            MiDelegado delegado1 = new MiDelegado(Manejadora.Sumar);
            //delegado1.Invoke(8, 2);
            //delegado1(5, 2);
            //------------------------------------
            Manejadora a = new Manejadora();
            MiDelegado delegado2 = new MiDelegado(a.Restar);
            //delegado2.Invoke(3, 2);
            //-------------------------------------
            MiDelegado delegado3 = (MiDelegado) MiDelegado.Combine(delegado1, delegado2);
            delegado3.Invoke(5, 5);
            //-------------------------------------
            MessageBox.Show (delegado3.Method.ToString()); //indica cual metodo esta usando
            //------------------------------------
            MessageBox.Show(delegado3.Target.ToString()); //indica cual es la instancia del metodo de invocacion
            //-----------------------------------
            string s = "";
            foreach( Delegate d in delegado3.GetInvocationList())
            {
                s += (d.Method).ToString() + "\n";
            }
            //---------------------
            MiDelegado delegado4 = (MiDelegado)MiDelegado.Combine(delegado3,new MiDelegado(a.Multiplicar));

            a.OtraSuma(delegado1, 7, 7);
        }
        

    }
}
