namespace Examen_Parcial_Compiladores
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EntradaManual = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCargar1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AnalisisLexico = new System.Windows.Forms.TabControl();
            this.Analisis_Lexico = new System.Windows.Forms.TabPage();
            this.Errores = new System.Windows.Forms.TabPage();
            this.Tablas = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.AnalisisLexico.SuspendLayout();
            this.Analisis_Lexico.SuspendLayout();
            this.Errores.SuspendLayout();
            this.Tablas.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Cargar desde archivo",
            "Insertar texto"});
            this.comboBox1.Location = new System.Drawing.Point(21, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "Texto a puntos",
            "Texto a numeros",
            "Punto a texto",
            "Puntos a numeros",
            "Numeros a texto",
            "Numeros a punto"});
            this.comboBox2.Location = new System.Drawing.Point(442, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(277, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingreso de texto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de compilacion:";
            // 
            // EntradaManual
            // 
            this.EntradaManual.Enabled = false;
            this.EntradaManual.Location = new System.Drawing.Point(21, 131);
            this.EntradaManual.Multiline = true;
            this.EntradaManual.Name = "EntradaManual";
            this.EntradaManual.Size = new System.Drawing.Size(255, 182);
            this.EntradaManual.TabIndex = 4;
            this.EntradaManual.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(442, 131);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(277, 347);
            this.textBox2.TabIndex = 5;
            // 
            // btnCargar1
            // 
            this.btnCargar1.Enabled = false;
            this.btnCargar1.Location = new System.Drawing.Point(93, 192);
            this.btnCargar1.Name = "btnCargar1";
            this.btnCargar1.Size = new System.Drawing.Size(116, 51);
            this.btnCargar1.TabIndex = 6;
            this.btnCargar1.Text = "Cargar Archivo";
            this.btnCargar1.UseVisualStyleBackColor = true;
            this.btnCargar1.Visible = false;
            this.btnCargar1.Click += new System.EventHandler(this.btnCargar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(90, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // btnCompilar
            // 
            this.btnCompilar.Location = new System.Drawing.Point(319, 192);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(89, 48);
            this.btnCompilar.TabIndex = 8;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(21, 319);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 182);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AnalisisLexico
            // 
            this.AnalisisLexico.Controls.Add(this.Analisis_Lexico);
            this.AnalisisLexico.Controls.Add(this.Errores);
            this.AnalisisLexico.Controls.Add(this.Tablas);
            this.AnalisisLexico.Location = new System.Drawing.Point(12, 12);
            this.AnalisisLexico.Name = "AnalisisLexico";
            this.AnalisisLexico.SelectedIndex = 0;
            this.AnalisisLexico.Size = new System.Drawing.Size(859, 558);
            this.AnalisisLexico.TabIndex = 10;
            // 
            // Analisis_Lexico
            // 
            this.Analisis_Lexico.Controls.Add(this.label1);
            this.Analisis_Lexico.Controls.Add(this.textBox1);
            this.Analisis_Lexico.Controls.Add(this.comboBox1);
            this.Analisis_Lexico.Controls.Add(this.btnCompilar);
            this.Analisis_Lexico.Controls.Add(this.comboBox2);
            this.Analisis_Lexico.Controls.Add(this.label3);
            this.Analisis_Lexico.Controls.Add(this.label2);
            this.Analisis_Lexico.Controls.Add(this.btnCargar1);
            this.Analisis_Lexico.Controls.Add(this.EntradaManual);
            this.Analisis_Lexico.Controls.Add(this.textBox2);
            this.Analisis_Lexico.Location = new System.Drawing.Point(4, 22);
            this.Analisis_Lexico.Name = "Analisis_Lexico";
            this.Analisis_Lexico.Padding = new System.Windows.Forms.Padding(3);
            this.Analisis_Lexico.Size = new System.Drawing.Size(851, 532);
            this.Analisis_Lexico.TabIndex = 0;
            this.Analisis_Lexico.Text = "Analisis lexico";
            this.Analisis_Lexico.UseVisualStyleBackColor = true;
            // 
            // Errores
            // 
            this.Errores.Controls.Add(this.textBox7);
            this.Errores.Location = new System.Drawing.Point(4, 22);
            this.Errores.Name = "Errores";
            this.Errores.Padding = new System.Windows.Forms.Padding(3);
            this.Errores.Size = new System.Drawing.Size(851, 532);
            this.Errores.TabIndex = 1;
            this.Errores.Text = "Errorres";
            this.Errores.UseVisualStyleBackColor = true;
            this.Errores.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Tablas
            // 
            this.Tablas.Controls.Add(this.tabControl1);
            this.Tablas.Location = new System.Drawing.Point(4, 22);
            this.Tablas.Name = "Tablas";
            this.Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tablas.Size = new System.Drawing.Size(851, 532);
            this.Tablas.TabIndex = 2;
            this.Tablas.Text = "Tablas";
            this.Tablas.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(19, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 489);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simbolo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Palabra reservada";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dummy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(791, 463);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Literal";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 60);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(473, 364);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 37);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(500, 386);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(136, 25);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(484, 415);
            this.textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(116, 30);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(490, 397);
            this.textBox6.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(127, 27);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(557, 471);
            this.textBox7.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 572);
            this.Controls.Add(this.AnalisisLexico);
            this.Name = "Form1";
            this.Text = "Compilador de clase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AnalisisLexico.ResumeLayout(false);
            this.Analisis_Lexico.ResumeLayout(false);
            this.Analisis_Lexico.PerformLayout();
            this.Errores.ResumeLayout(false);
            this.Errores.PerformLayout();
            this.Tablas.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EntradaManual;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCargar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCompilar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl AnalisisLexico;
        private System.Windows.Forms.TabPage Analisis_Lexico;
        private System.Windows.Forms.TabPage Errores;
        private System.Windows.Forms.TabPage Tablas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}

