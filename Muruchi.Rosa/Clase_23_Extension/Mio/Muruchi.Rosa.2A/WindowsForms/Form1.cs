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
using TestEntidades;
using System.IO;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbManejador.Items.Add (TipoManejador.Ambos);
            cmbManejador.Items.Add(TipoManejador.LimiteSueldo);
            cmbManejador.Items.Add(TipoManejador.Log);

        }

        private void btnObjeto_Click(object sender, EventArgs e)
        {
            EmpleadoMejorado em = new EmpleadoMejorado();
            if((TipoManejador)cmbManejador.SelectedValue == TipoManejador.Log)
            {
                em._limiteSueldo += new DelSueldoMejoradoArgs(LimiteSueldoEmpleado);
            }
            else if((TipoManejador)cmbManejador.SelectedValue == TipoManejador.LimiteSueldo)
            {

            }
            else
            {

            }
            em.Nombre = txtNombre.Text;
            em.Sueldo = float.Parse (txtSueldo.Text);
            em.Lejago = int.Parse(txtLegajo.Text);
        }

        private void cmbManejador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static void LimiteSueldoEmpleado(EmpleadoSueldoArgs e, float f)
        {
            string cadena = "Empleado: " + e.Nombre + "\nLejago: " + e.Lejago.ToString() + "\nAsig.Sueldo: " + f.ToString() + "\n";
            Console.WriteLine(cadena);
        }

        public static void GuardarLog(EmpleadoSueldoArgs e, float f)
        {
            string direccion = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\\";
            string archivo = "incidentes.log";
            try
            {
                using (StreamWriter sw = new StreamWriter(direccion + archivo, true))
                {
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine(e.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
