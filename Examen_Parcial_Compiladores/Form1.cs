using Examen_Parcial_Compiladores.AnalizadorLexico;
using Examen_Parcial_Compiladores.Cache;
using Examen_Parcial_Compiladores.GestorErrores;
using Examen_Parcial_Compiladores.TablaComponentes;
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
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
            TablaMaestra.ObtenerTablaMaestra().Limpiar();
            ManejadorErrores.ObtenerManejadorErrores().Limpiar();
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
                AnalizadorLexicoLetra anaLex = new AnalizadorLexicoLetra();
                ComponenteLexico componente = anaLex.DevolverSiguienteComponente();
                do
                {
                    textBox2.Text = textBox2.Text + " " + componente.ToString() + Environment.NewLine;
                    componente = anaLex.DevolverSiguienteComponente();

                } while (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex.Message);
            }
            finally
            {
                LlenarTablas();
                LlenarErrores();
            }
        }
        private void TextoNumero()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorLexicoLetra anaLex = new AnalizadorLexicoLetra();
                ComponenteLexico componente = anaLex.DevolverSiguienteComponente();
                do
                {
                    textBox2.Text = textBox2.Text + " " + componente.ToString() + Environment.NewLine;
                    componente = anaLex.DevolverSiguienteComponente();

                } while (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex.Message);
            }
            finally
            {
                LlenarTablas();
                LlenarErrores();
            }
        }
        private  void PuntoTexto()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorLexicoPunto anaLex = new AnalizadorLexicoPunto();
                ComponenteLexico componente = anaLex.DevolverSiguienteComponente();
                do
                {
                    textBox2.Text = textBox2.Text + " " + componente.ToString() + Environment.NewLine;
                    componente = anaLex.DevolverSiguienteComponente();

                } while (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex.Message);
            }
            finally
            {
                LlenarTablas();
                LlenarErrores();
            }

        }
        private  void PuntoNumero()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorLexicoPunto anaLex = new AnalizadorLexicoPunto();
                ComponenteLexico componente = anaLex.DevolverSiguienteComponente();
                do
                {
                    textBox2.Text = textBox2.Text + " " + componente.ToString() + Environment.NewLine;
                    componente = anaLex.DevolverSiguienteComponente();

                } while (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex.Message);
            }
            finally
            {
                LlenarTablas();
                LlenarErrores();
            }

        }
        private  void NumeroTexto()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorLexicoNumero anaLex = new AnalizadorLexicoNumero();
                ComponenteLexico componente = anaLex.DevolverSiguienteComponente();
                do
                {
                    textBox2.Text = textBox2.Text + " " + componente.ToString()+ Environment.NewLine;
                    componente = anaLex.DevolverSiguienteComponente();

                } while (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de compilacion: " + ex.Message);
            }
            finally
            {
                LlenarTablas();
                LlenarErrores();
            }

        }

        private  void NumeroPunto()
        {
            textBox2.Text = "";
            try
            {
                AnalizadorLexicoNumero anaLex = new AnalizadorLexicoNumero();
                ComponenteLexico componente = anaLex.DevolverSiguienteComponente();
                do
                {
                    textBox2.Text = textBox2.Text + " " + componente.ToString() + Environment.NewLine;
                    componente = anaLex.DevolverSiguienteComponente();

                } while (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria));
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            finally
            {
                LlenarTablas();
                LlenarErrores();
            }


        }

        private void LlenarErrores()
        {
            ImprimirErrores(TipoError.LEXICO, textBox7);
            ImprimirErrores(TipoError.SINTACTICO, textBox8);
            ImprimirErrores(TipoError.SEMANTICO, textBox9);
        }
        private void LlenarTablas()
        {
            ImprimirComponentes(TipoComponente.SIMBOLO, textBox3);
            ImprimirComponentes(TipoComponente.PALABRA_RESERVADA, textBox4);
            ImprimirComponentes(TipoComponente.DUMMY, textBox5);
            ImprimirComponentes(TipoComponente.LITERAL, textBox6);
        }
        private void ImprimirComponentes(TipoComponente tipo, System.Windows.Forms.TextBox box)
        {
            box.Text = "************INICIO COMPONENTES "+ tipo.ToString()+"*******************\r\n";

            List<ComponenteLexico> componentes = TablaMaestra.ObtenerTablaMaestra().ObtenerTodosSimbolo(tipo);
            foreach (ComponenteLexico componente in componentes)
            {
                box.Text = box.Text + " " + componente.ToString() + Environment.NewLine;
            }
            box.Text = box.Text + "\n************FIN COMPONENTES " + tipo.ToString() + "*******************\r\n";
        }


        private void ImprimirErrores(TipoError tipo, System.Windows.Forms.TextBox box)
        {
            box.Text = "************INICIO ERRORES " + tipo.ToString() + "*******************\r\n";

            List<Error> erroes = ManejadorErrores.ObtenerManejadorErrores().ObtenerErrores(tipo);
            foreach (Error error in erroes)
            {
                box.Text = box.Text + " " + error.ToString() + Environment.NewLine;
            }
            box.Text = box.Text + "\n************FIN ERRORRES " + tipo.ToString() + "*******************\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Visible = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}