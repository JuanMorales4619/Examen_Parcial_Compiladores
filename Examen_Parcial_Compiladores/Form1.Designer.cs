﻿namespace Examen_Parcial_Compiladores
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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Cargar desde archivo",
            "Insertar texto"});
            this.comboBox1.Location = new System.Drawing.Point(108, 79);
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
            this.comboBox2.Location = new System.Drawing.Point(529, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(277, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingreso de texto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de compilacion:";
            // 
            // EntradaManual
            // 
            this.EntradaManual.Enabled = false;
            this.EntradaManual.Location = new System.Drawing.Point(108, 182);
            this.EntradaManual.Multiline = true;
            this.EntradaManual.Name = "EntradaManual";
            this.EntradaManual.Size = new System.Drawing.Size(255, 182);
            this.EntradaManual.TabIndex = 4;
            this.EntradaManual.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(529, 182);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(277, 347);
            this.textBox2.TabIndex = 5;
            // 
            // btnCargar1
            // 
            this.btnCargar1.Enabled = false;
            this.btnCargar1.Location = new System.Drawing.Point(180, 243);
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
            this.label3.Location = new System.Drawing.Point(156, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // btnCompilar
            // 
            this.btnCompilar.Location = new System.Drawing.Point(406, 243);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(89, 48);
            this.btnCompilar.TabIndex = 8;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 605);
            this.Controls.Add(this.btnCompilar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCargar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.EntradaManual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Compilador de clase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

