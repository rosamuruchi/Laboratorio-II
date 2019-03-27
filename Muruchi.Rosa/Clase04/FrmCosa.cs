using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase04
{
    public partial class FrmCosa : Form
    {
        public FrmCosa()
        {
            InitializeComponent();
            //this.Text = "";
            
        }
        private void FrmCosa_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text= "Crear una Cosa Bonita"; //escrita en tiempo de ejecucion
            //MessageBox.Show("Hello world 2!");
            this.button1.BackColor = Color.Aqua;
        }
    }
}
