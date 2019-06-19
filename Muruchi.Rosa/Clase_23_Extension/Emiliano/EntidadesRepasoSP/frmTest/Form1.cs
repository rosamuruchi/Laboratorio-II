using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesRepasoSP;
using TestEntidades;
using System.IO;

namespace frmTest
{
    public partial class Form1 : Form
    {
        EmpleadoMejorado empleado = new EmpleadoMejorado();
        
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add(TipoManejador.LimiteSueldo);
            this.comboBox1.Items.Add(TipoManejador.Log);
            this.comboBox1.Items.Add(TipoManejador.Ambos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch ((TipoManejador)this.comboBox1.SelectedItem)
            {
                case TipoManejador.LimiteSueldo:
                    empleado.LimiteSueldo += new DelegadoSueldoMejoradoArgs(LimiteSueldoEmpleado);
                    break;
                case TipoManejador.Log:
                    empleado.LimiteSueldo += new DelegadoSueldoMejoradoArgs(GuardarLog);
                    break;
                case TipoManejador.Ambos:
                    empleado.LimiteSueldo += new DelegadoSueldoMejoradoArgs(LimiteSueldoEmpleado);
                    empleado.LimiteSueldo += new DelegadoSueldoMejoradoArgs(GuardarLog);
                    break;
                default:
                    break;
            }
            this.empleado.Nombre = this.textBox1.ToString();
            this.empleado.Legajo = int.Parse(this.);
            this.empleado.Sueldo = float.Parse(this.textBox3.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public static void LimiteSueldoEmpleado(EmpleadoSueldoArgs empleado, float sueldo)
        {
            Console.WriteLine(empleado.ToString());
            Console.WriteLine(sueldo);
        }

        public static void GuardarLog(EmpleadoSueldoArgs empleado, float sueldo)
        {
            try
            {
                StreamWriter fichero = new StreamWriter("log");
                fichero.WriteLine(empleado.ToString());
                fichero.WriteLine(DateTime.Today);
                fichero.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
