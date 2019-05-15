using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clase_15_frmPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void listVisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "C:\\Users\\alumno\\Desktop\\miArchivo.txt";
                //string path = AppDomain.CurrentDomain.BaseDirectory + "miArchivo.txt";
                StreamWriter sw = new StreamWriter(path);
                string datos = this.txtValor.Text; 
                sw.WriteLine(datos);
                
                sw.Close();

            }
            catch(Exception b)
            {
                this.listVisor.Items.Add ( b.Message);
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            try
            {
                //string path = AppDomain.CurrentDomain.BaseDirectory + "miArchivo.txt";     1ero
                //string path = "C:\\Users\\alumno\\Desktop\\miArchivo.txt";                 2do
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.txt"; //acceso al Escritorio de la pc
                StreamReader sr = new StreamReader(path);
                string lectura=sr.ReadToEnd();
                DialogResult newResult = this.openFileDialog1.ShowDialog();

                do
                {        
                    this.listVisor.Items.Add(lectura);
                       lectura = sr.ReadLine();

                } while (lectura != null);

                 sr.Close();
            }
            catch (Exception b)
            {
                this.listVisor.Items.Add(b.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Uno = new OpenFileDialog(); //abre los archivos que tenemos de texto
                //Uno.ShowDialog(); //muestra los que tengo

                DialogResult newResult = this.openFileDialog1.ShowDialog(); //Uno.ShowDialog();

                if(newResult != DialogResult.Cancel)
                {
                    MessageBox.Show(Uno.FileName);
                    //this.listVisor.Items.Add(Uno.FileName);
                }

                string path = "\\miArchivo.txt";


            }
            catch (Exception b)
            {
                this.listVisor.Items.Add(b.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            this.openFileDialog1.Title= "Seleccione un titulo: ";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.Filter = "Archivo (*.txt) | *.txt" ;
            
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
