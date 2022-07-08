
namespace Metodos_proyecto
{
    partial class CostoAnualAlmacenamiento
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
            this.bCalcular = new System.Windows.Forms.Button();
            this.lCostoAnualAlmacenar = new System.Windows.Forms.Label();
            this.tbPiezas = new System.Windows.Forms.TextBox();
            this.tbProduccion = new System.Windows.Forms.TextBox();
            this.tbDemandaDiaria = new System.Windows.Forms.TextBox();
            this.lDemandaDiaria = new System.Windows.Forms.Label();
            this.lProduccion = new System.Windows.Forms.Label();
            this.lPiezasOrdenar = new System.Windows.Forms.Label();
            this.tbCostoAnualAlmacenar = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(348, 299);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(75, 23);
            this.bCalcular.TabIndex = 0;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lCostoAnualAlmacenar
            // 
            this.lCostoAnualAlmacenar.AutoSize = true;
            this.lCostoAnualAlmacenar.Location = new System.Drawing.Point(627, 99);
            this.lCostoAnualAlmacenar.Name = "lCostoAnualAlmacenar";
            this.lCostoAnualAlmacenar.Size = new System.Drawing.Size(133, 13);
            this.lCostoAnualAlmacenar.TabIndex = 1;
            this.lCostoAnualAlmacenar.Text = "Costo anual por almacenar";
            this.lCostoAnualAlmacenar.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPiezas
            // 
            this.tbPiezas.Location = new System.Drawing.Point(28, 127);
            this.tbPiezas.Name = "tbPiezas";
            this.tbPiezas.Size = new System.Drawing.Size(100, 20);
            this.tbPiezas.TabIndex = 18;
            // 
            // tbProduccion
            // 
            this.tbProduccion.Location = new System.Drawing.Point(501, 127);
            this.tbProduccion.Name = "tbProduccion";
            this.tbProduccion.Size = new System.Drawing.Size(100, 20);
            this.tbProduccion.TabIndex = 17;
            // 
            // tbDemandaDiaria
            // 
            this.tbDemandaDiaria.Location = new System.Drawing.Point(284, 127);
            this.tbDemandaDiaria.Name = "tbDemandaDiaria";
            this.tbDemandaDiaria.Size = new System.Drawing.Size(100, 20);
            this.tbDemandaDiaria.TabIndex = 16;
            // 
            // lDemandaDiaria
            // 
            this.lDemandaDiaria.AutoSize = true;
            this.lDemandaDiaria.Location = new System.Drawing.Point(293, 99);
            this.lDemandaDiaria.Name = "lDemandaDiaria";
            this.lDemandaDiaria.Size = new System.Drawing.Size(81, 13);
            this.lDemandaDiaria.TabIndex = 15;
            this.lDemandaDiaria.Text = "Demanda diaria";
            // 
            // lProduccion
            // 
            this.lProduccion.AutoSize = true;
            this.lProduccion.Location = new System.Drawing.Point(527, 99);
            this.lProduccion.Name = "lProduccion";
            this.lProduccion.Size = new System.Drawing.Size(61, 13);
            this.lProduccion.TabIndex = 14;
            this.lProduccion.Text = "Produccion";
            // 
            // lPiezasOrdenar
            // 
            this.lPiezasOrdenar.AutoSize = true;
            this.lPiezasOrdenar.Location = new System.Drawing.Point(42, 99);
            this.lPiezasOrdenar.Name = "lPiezasOrdenar";
            this.lPiezasOrdenar.Size = new System.Drawing.Size(86, 13);
            this.lPiezasOrdenar.TabIndex = 13;
            this.lPiezasOrdenar.Text = "Piezas a ordenar";
            // 
            // tbCostoAnualAlmacenar
            // 
            this.tbCostoAnualAlmacenar.Location = new System.Drawing.Point(639, 127);
            this.tbCostoAnualAlmacenar.Name = "tbCostoAnualAlmacenar";
            this.tbCostoAnualAlmacenar.Size = new System.Drawing.Size(100, 20);
            this.tbCostoAnualAlmacenar.TabIndex = 19;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(373, 263);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(16, 13);
            this.lResult.TabIndex = 21;
            this.lResult.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 243);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Resultado";
            // 
            // CostoAnualAlmacenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCostoAnualAlmacenar);
            this.Controls.Add(this.tbPiezas);
            this.Controls.Add(this.tbProduccion);
            this.Controls.Add(this.tbDemandaDiaria);
            this.Controls.Add(this.lDemandaDiaria);
            this.Controls.Add(this.lProduccion);
            this.Controls.Add(this.lPiezasOrdenar);
            this.Controls.Add(this.lCostoAnualAlmacenar);
            this.Controls.Add(this.bCalcular);
            this.Name = "CostoAnualAlmacenamiento";
            this.Text = "CostoAnualAlmacenamiento";
            this.Load += new System.EventHandler(this.CostoAnualAlmacenamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Label lCostoAnualAlmacenar;
        private System.Windows.Forms.TextBox tbPiezas;
        private System.Windows.Forms.TextBox tbProduccion;
        private System.Windows.Forms.TextBox tbDemandaDiaria;
        private System.Windows.Forms.Label lDemandaDiaria;
        private System.Windows.Forms.Label lProduccion;
        private System.Windows.Forms.Label lPiezasOrdenar;
        private System.Windows.Forms.TextBox tbCostoAnualAlmacenar;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label1;
    }
}