﻿namespace Project_Metodos
{
    partial class CostoTotalAnual
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
            this.lResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lDemandaDiaria = new System.Windows.Forms.Label();
            this.lProduccion = new System.Windows.Forms.Label();
            this.lPiezasOrdenar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DAnual = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ostras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lResult.Location = new System.Drawing.Point(331, 212);
            this.lResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(16, 15);
            this.lResult.TabIndex = 17;
            this.lResult.Text = "...";
            this.lResult.Click += new System.EventHandler(this.lResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(312, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Resultado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lDemandaDiaria
            // 
            this.lDemandaDiaria.AutoSize = true;
            this.lDemandaDiaria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lDemandaDiaria.Location = new System.Drawing.Point(28, 112);
            this.lDemandaDiaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDemandaDiaria.Name = "lDemandaDiaria";
            this.lDemandaDiaria.Size = new System.Drawing.Size(94, 15);
            this.lDemandaDiaria.TabIndex = 12;
            this.lDemandaDiaria.Text = "Piezas a Ordenar";
            this.lDemandaDiaria.Click += new System.EventHandler(this.lDemandaDiaria_Click);
            // 
            // lProduccion
            // 
            this.lProduccion.AutoSize = true;
            this.lProduccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lProduccion.Location = new System.Drawing.Point(24, 160);
            this.lProduccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProduccion.Name = "lProduccion";
            this.lProduccion.Size = new System.Drawing.Size(132, 15);
            this.lProduccion.TabIndex = 11;
            this.lProduccion.Text = "Costo de Orden/pedido";
            this.lProduccion.Click += new System.EventHandler(this.lProduccion_Click);
            // 
            // lPiezasOrdenar
            // 
            this.lPiezasOrdenar.AutoSize = true;
            this.lPiezasOrdenar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lPiezasOrdenar.Location = new System.Drawing.Point(28, 58);
            this.lPiezasOrdenar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPiezasOrdenar.Name = "lPiezasOrdenar";
            this.lPiezasOrdenar.Size = new System.Drawing.Size(90, 15);
            this.lPiezasOrdenar.TabIndex = 10;
            this.lPiezasOrdenar.Text = "Demanda anual";
            this.lPiezasOrdenar.Click += new System.EventHandler(this.lPiezasOrdenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(24, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Costo Anual por Almacenar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DAnual
            // 
            this.DAnual.Location = new System.Drawing.Point(28, 86);
            this.DAnual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DAnual.Name = "DAnual";
            this.DAnual.Size = new System.Drawing.Size(103, 23);
            this.DAnual.TabIndex = 19;
            this.DAnual.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 130);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(24, 187);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 23);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(24, 252);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 23);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ostras
            // 
            this.ostras.Location = new System.Drawing.Point(253, 247);
            this.ostras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ostras.Name = "ostras";
            this.ostras.Size = new System.Drawing.Size(176, 30);
            this.ostras.TabIndex = 23;
            this.ostras.Text = "Calcular Costo Total Anual";
            this.ostras.UseVisualStyleBackColor = true;
            this.ostras.Click += new System.EventHandler(this.button1_Click);
            // 
            // CostoTotalAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(524, 343);
            this.Controls.Add(this.ostras);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DAnual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lDemandaDiaria);
            this.Controls.Add(this.lProduccion);
            this.Controls.Add(this.lPiezasOrdenar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CostoTotalAnual";
            this.Text = "CostoTotalAnual";
            this.Load += new System.EventHandler(this.CostoTotalAnual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDemandaDiaria;
        private System.Windows.Forms.Label lProduccion;
        private System.Windows.Forms.Label lPiezasOrdenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DAnual;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button ostras;
    }
}