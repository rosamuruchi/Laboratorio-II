using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        //string resultado;
        public LaCalculadora()
        {
            InitializeComponent();
            
            this.lblResultado.Text = "0";
            this.cmbOperador.SelectedIndex = 0;
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "0";
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double retorno=0;
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);
            retorno = Calculadora.Operar(numeroUno, numeroDos, operador);
            return retorno;
        }



        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text== "")
            {
                this.lblResultado.Text = "vacio";
            }
            else
            {
               this.lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text == "")
            {
                this.lblResultado.Text = "vacio";
            }
            else
            {
                this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
            }
        }
    }
}
