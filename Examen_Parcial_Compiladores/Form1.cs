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

                label3.Visible = false;

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
            textBox2.Text = "";
            textBox1.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                

                try
                {
                    string[] contenido = File.ReadAllLines(rutaArchivo);
                    int lineNumber = 1;

                    foreach (string cadena in contenido)
                    {
                        textBox1.AppendText(lineNumber + ": " + cadena + Environment.NewLine);
                        lineNumber++;
                    }
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
            textBox1.Text = "";
            if(comboBox1.SelectedIndex == 2)
            {
                string[] lineas = EntradaManual.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                int lineNumber = 1;
                foreach (string cadena in lineas)
                {
                    textBox1.AppendText(lineNumber + ": " + cadena + Environment.NewLine);
                    lineNumber++;
                }
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
            textBox2.Text = "";
            try
            {
                AnalizadorTextoNumero anaLex = new AnalizadorTextoNumero();
                string lexema = anaLex.DevolverSiguienteComponente();
                textBox2.Text = textBox2.Text + lexema + Environment.NewLine;
                do
                {
                    lexema = anaLex.DevolverSiguienteComponente();
                    textBox2.Text = textBox2.Text + " " + lexema + Environment.NewLine;

                } while (!lexema.Contains("FIN ARCHIVO"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex);
            }
        }
        private void TextoNumero()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorTextoNumero anaLex = new AnalizadorTextoNumero();
                string lexema = anaLex.DevolverSiguienteComponente();
                textBox2.Text = textBox2.Text + lexema + Environment.NewLine;
                do
                {
                    lexema = anaLex.DevolverSiguienteComponente();
                    textBox2.Text = textBox2.Text + " " + lexema + Environment.NewLine;

                } while (!lexema.Contains("FIN ARCHIVO"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex);
            }
        }
        private  void PuntoTexto()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorLexicoPunto anaLex = new AnalizadorLexicoPunto();
                string lexema = anaLex.DevolverSiguienteComponente();
                textBox2.Text = textBox2.Text + " " + lexema + Environment.NewLine;
                do
                {
                    lexema = anaLex.DevolverSiguienteComponente() + Environment.NewLine;
                    textBox2.Text = textBox2.Text + " " + lexema;

                } while (!lexema.Contains("FIN ARCHIVO"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex);
            }

        }
        private  void PuntoNumero()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorLexicoPunto anaLex = new AnalizadorLexicoPunto();
                string lexema = anaLex.DevolverSiguienteComponente();
                textBox2.Text = textBox2.Text + " " + lexema + Environment.NewLine;
                do
                {
                    lexema = anaLex.DevolverSiguienteComponente() + Environment.NewLine;
                    textBox2.Text = textBox2.Text + " " + lexema;

                } while (!lexema.Contains("FIN ARCHIVO"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex);
            }

        }
        private  void NumeroTexto()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorLexicoNumero anaLex = new AnalizadorLexicoNumero();
                string lexema = anaLex.DevolverSiguienteComponente();
                textBox2.Text = textBox2.Text + " " + lexema + Environment.NewLine;
                do
                {                   
                    lexema = anaLex.DevolverSiguienteComponente() +Environment.NewLine;
                    textBox2.Text = textBox2.Text + " " + lexema;

                } while (!lexema.Contains("FIN ARCHIVO"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex);
            }

        }
        private  void NumeroPunto()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorLexicoNumero anaLex = new AnalizadorLexicoNumero();
                string lexema = anaLex.DevolverSiguienteComponente();
                textBox2.Text = textBox2.Text + " " + lexema + Environment.NewLine;
                do
                {
                    lexema = anaLex.DevolverSiguienteComponente() + Environment.NewLine;
                    textBox2.Text = textBox2.Text + " " + lexema;

                } while (!lexema.Contains("FIN ARCHIVO"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Visible = true;
        }
    }
}