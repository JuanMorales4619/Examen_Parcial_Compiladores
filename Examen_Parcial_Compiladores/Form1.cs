using Examen_Parcial_Compiladores.AnalizadorLexico;
using Examen_Parcial_Compiladores.Cache;
using Examen_Parcial_Compiladores.Traduccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Examen_Parcial_Compiladores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {
                EntradaManual.Enabled = false;
                EntradaManual.Visible = false;

                btnCargar1.Enabled = false;
                btnCargar1.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                EntradaManual.Enabled = true;
                EntradaManual.Visible = true;

                btnCargar1.Enabled = false;
                btnCargar1.Visible = false;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                EntradaManual.Enabled = false;
                EntradaManual.Visible = false;

                btnCargar1.Enabled = true;
                btnCargar1.Visible = true;

            }
        }

        private void btnCargar(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                try
                {
                    string[] contenido = File.ReadAllLines(rutaArchivo);

                    DataCache.AgregarLienas(contenido);
                    label3.Text = "Archivo cargado correctamente";
                    label3.Enabled = true;
                    label3.Visible = true;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if(comboBox1.SelectedIndex == 2)
            {
                string[] lineas = EntradaManual.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                DataCache.Limpiar();
                DataCache.AgregarLienas(lineas);
            }
            
            if(comboBox2.SelectedIndex == 1){ TextoPunto(); }
            else if (comboBox2.SelectedIndex == 2) { TextoNumero();}
            else if (comboBox2.SelectedIndex == 3) { PuntoTexto(); }
            else if (comboBox2.SelectedIndex == 4) { PuntoNumero(); }
            else if (comboBox2.SelectedIndex == 5) { NumeroTexto(); }
            else if (comboBox2.SelectedIndex == 6) { NumeroPunto(); }
        }
        private void TextoPunto()
        {
            try
            {
                AnalizadorTextoNumero anaLex = new AnalizadorTextoNumero();
                string lexema = anaLex.DevolverSiguienteComponente();
                do
                {
                    textBox2.Text = textBox2.Text + " " + Texto.TraducirTextoPunto(lexema);
                    lexema = anaLex.DevolverSiguienteComponente();

                } while (!"FIN ARCHIVO".Equals(lexema));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex);
            }
        }
        private void TextoNumero()
        {
            try
            {
                AnalizadorTextoNumero anaLex = new AnalizadorTextoNumero();
                string lexema = anaLex.DevolverSiguienteComponente();
                do
                {
                    textBox2.Text = textBox2.Text +" "+ Texto.TraducirTextoNumero(lexema);
                    lexema = anaLex.DevolverSiguienteComponente();
                    
                } while (!"FIN ARCHIVO".Equals(lexema));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex);
            }
        }
        private  void PuntoTexto()
        {

        }
        private  void PuntoNumero()
        {

        }
        private  void NumeroTexto()
        {

        }
        private  void NumeroPunto()
        {

        }
    }
}