using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase._06.Entidades;


namespace FrmPaleta
{
    public partial class FrmPaleta : Form
    {
        private Paleta _myPaleta;

        public Paleta MyPaleta
        {
            get { return _myPaleta;  }
            set { _myPaleta = value; }
        }


        public FrmPaleta()
        {
            InitializeComponent();
            this._myPaleta = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                this._myPaleta += frm.MiTempera;
                this.listBox1.Items.Clear();

                foreach (Tempera item in this.MyPaleta.MisTemperas)
                {
                    if(!Equals (item,null))
                    {
                        listBox1.Items.Add(Tempera.mostrar(item));
                    }
                }
            }
            
            //FrmPaleta.show()
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            FrmTempera frmTempera;
            int lugar = this.listBox1.SelectedIndex;
            frmTempera = new FrmTempera(MyPaleta.MisTemperas[lugar]);
            frmTempera.MiTempera = _myPaleta.MisTemperas[lugar];
            MessageBox.Show(Tempera.mostrar(frmTempera.MiTempera));
            

            frmTempera.ShowDialog();

            if(frmTempera.DialogResult == DialogResult.OK)
            {
                MyPaleta.MisTemperas.Remove(MyPaleta.MisTemperas[lugar]);
                this.listBox1.Items.Clear();
                foreach( Tempera item in this.MyPaleta.MisTemperas)
                {
                    if(!Equals(item, null))
                    {
                        listBox1.Items.Add(Tempera.mostrar(item));
                    }
                }
            }

        }
    }
}
