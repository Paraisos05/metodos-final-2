﻿namespace Project_Metodos
{
    partial class EOQ_Con_CH_comoporcentaje
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
            this.ostras = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lDemandaDiaria = new System.Windows.Forms.Label();
            this.lProduccion = new System.Windows.Forms.Label();
            this.lPiezasOrdenar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ostras
            // 
            this.ostras.BackColor = System.Drawing.Color.MediumOrchid;
            this.ostras.Location = new System.Drawing.Point(351, 231);
            this.ostras.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ostras.Name = "ostras";
            this.ostras.Size = new System.Drawing.Size(201, 40);
            this.ostras.TabIndex = 34;
            this.ostras.Text = "Calcular Costo Total Anual";
            this.ostras.UseVisualStyleBackColor = false;
            this.ostras.Click += new System.EventHandler(this.ostras_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(347, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Costo Anual por Almacenar";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lResult.Location = new System.Drawing.Point(440, 184);
            this.lResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(18, 20);
            this.lResult.TabIndex = 28;
            this.lResult.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(419, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Resultado";
            // 
            // lDemandaDiaria
            // 
            this.lDemandaDiaria.AutoSize = true;
            this.lDemandaDiaria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lDemandaDiaria.Location = new System.Drawing.Point(69, 151);
            this.lDemandaDiaria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDemandaDiaria.Name = "lDemandaDiaria";
            this.lDemandaDiaria.Size = new System.Drawing.Size(120, 20);
            this.lDemandaDiaria.TabIndex = 26;
            this.lDemandaDiaria.Text = "Piezas a Ordenar";
            this.lDemandaDiaria.Click += new System.EventHandler(this.lDemandaDiaria_Click);
            // 
            // lProduccion
            // 
            this.lProduccion.AutoSize = true;
            this.lProduccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lProduccion.Location = new System.Drawing.Point(69, 237);
            this.lProduccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lProduccion.Name = "lProduccion";
            this.lProduccion.Size = new System.Drawing.Size(167, 20);
            this.lProduccion.TabIndex = 25;
            this.lProduccion.Text = "Costo de Orden/pedido";
            // 
            // lPiezasOrdenar
            // 
            this.lPiezasOrdenar.AutoSize = true;
            this.lPiezasOrdenar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lPiezasOrdenar.Location = new System.Drawing.Point(69, 57);
            this.lPiezasOrdenar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lPiezasOrdenar.Name = "lPiezasOrdenar";
            this.lPiezasOrdenar.Size = new System.Drawing.Size(114, 20);
            this.lPiezasOrdenar.TabIndex = 24;
            this.lPiezasOrdenar.Text = "Demanda anual";
            this.lPiezasOrdenar.Click += new System.EventHandler(this.lPiezasOrdenar_Click);
            // 
            // EOQ_Con_CH_comoporcentaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(615, 339);
            this.Controls.Add(this.ostras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lDemandaDiaria);
            this.Controls.Add(this.lProduccion);
            this.Controls.Add(this.lPiezasOrdenar);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EOQ_Con_CH_comoporcentaje";
            this.Text = "EOQ_Con_CH_comoporcentaje";
            this.Load += new System.EventHandler(this.EOQ_Con_CH_comoporcentaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ostras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDemandaDiaria;
        private System.Windows.Forms.Label lProduccion;
        private System.Windows.Forms.Label lPiezasOrdenar;
    }
}