using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest
{
    public class Manejadora
    {
        public static void Manejador(object sender, EventArgs e)
        {
            if(sender is TextBox)
            {
                MessageBox.Show("Uso el manejador Estatico de eventos: TEXTBOX");
            }
            else if(sender is Label)
            {
                MessageBox.Show("Uso el manejador Estatico de eventos: LABEL");
            }
            else if (sender is Button)
            {
                MessageBox.Show("Uso el manejador Estatico de eventos: BUTTON");
            }

        }
        public void Manejador2(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                MessageBox.Show("Uso el manejador Instancia de eventos: TEXTBOX");
            }
            else if (sender is Label)
            {
                MessageBox.Show("Uso el manejador Instancia de eventos: LABEL");

            }
            else if (sender is Button)
            {
                MessageBox.Show("Uso el manejador Instancia de eventos: BUTTON");

            }
            //MessageBox.Show("Estoy en la clase de Instancia de Manejadora");
        }
        public static void Sumar(int a, int b)
        {
            int sumar = a + b;
            MessageBox.Show(sumar.ToString());
        }
        public void Restar (int a, int b)
        {
            int restar = a - b;
            MessageBox.Show(restar.ToString());
        }
        public void Multiplicar (int a, int b)
        {
            MessageBox.Show((a - b).ToString());
        }
        public void OtraSuma (MiDelegado d, int a, int b)
        {
           d.Invoke(a, b);
        }
    }
}
