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
    public partial class FrmTempera : Form
    {
        private Tempera _myTempera;

        public Tempera MiTempera
        {
            get { return _myTempera; }
            set { _myTempera = value; }
        }

        public FrmTempera()
        {
            InitializeComponent();



            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor))) //seleccionar los colores
            {
                this.cboColor.Items.Add(c);
            }
            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboColor.SelectedItem = ConsoleColor.Black;
            this.textMarca.SelectedText = "Bic";
            this.textCantidad.Text = "5";

        }

        public FrmTempera (Tempera temp1): this()
        {
            sbyte cantidad = temp1;
            textCantidad.Text = cantidad.ToString();

            textMarca.Text = temp1.Marca;
            cboColor.SelectedItem = temp1.Color;
        }

        private void Label_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this._myTempera = new Tempera((ConsoleColor)this.cboColor.SelectedItem, textMarca.Text, sbyte.Parse(textCantidad.Text));

            this.DialogResult = DialogResult.OK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //comboBox1.Items.Add;
            //Enum.GetValues(typeof(ConsoleColor));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // this.comboBox1.SelectedItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
