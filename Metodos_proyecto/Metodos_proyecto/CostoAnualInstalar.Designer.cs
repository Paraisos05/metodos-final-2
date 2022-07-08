
namespace Metodos_proyecto
{
    partial class CostoAnualInstalar
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
            this.tbDemandaAnual = new System.Windows.Forms.TextBox();
            this.tbCostoPreparar = new System.Windows.Forms.TextBox();
            this.tbPiezasOrdenar = new System.Windows.Forms.TextBox();
            this.lPiezasOrdenar = new System.Windows.Forms.Label();
            this.lCostoPreparar = new System.Windows.Forms.Label();
            this.lDemandaAnual = new System.Windows.Forms.Label();
            this.bCostoAnual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(399, 275);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(16, 13);
            this.lResult.TabIndex = 17;
            this.lResult.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 255);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Resultado";
            // 
            // tbDemandaAnual
            // 
            this.tbDemandaAnual.Location = new System.Drawing.Point(114, 147);
            this.tbDemandaAnual.Name = "tbDemandaAnual";
            this.tbDemandaAnual.Size = new System.Drawing.Size(100, 20);
            this.tbDemandaAnual.TabIndex = 15;
            // 
            // tbCostoPreparar
            // 
            this.tbCostoPreparar.Location = new System.Drawing.Point(587, 147);
            this.tbCostoPreparar.Name = "tbCostoPreparar";
            this.tbCostoPreparar.Size = new System.Drawing.Size(100, 20);
            this.tbCostoPreparar.TabIndex = 14;
            // 
            // tbPiezasOrdenar
            // 
            this.tbPiezasOrdenar.Location = new System.Drawing.Point(370, 147);
            this.tbPiezasOrdenar.Name = "tbPiezasOrdenar";
            this.tbPiezasOrdenar.Size = new System.Drawing.Size(100, 20);
            this.tbPiezasOrdenar.TabIndex = 13;
            // 
            // lPiezasOrdenar
            // 
            this.lPiezasOrdenar.AutoSize = true;
            this.lPiezasOrdenar.Location = new System.Drawing.Point(379, 119);
            this.lPiezasOrdenar.Name = "lPiezasOrdenar";
            this.lPiezasOrdenar.Size = new System.Drawing.Size(86, 13);
            this.lPiezasOrdenar.TabIndex = 12;
            this.lPiezasOrdenar.Text = "Piezas a ordenar";
            // 
            // lCostoPreparar
            // 
            this.lCostoPreparar.AutoSize = true;
            this.lCostoPreparar.Location = new System.Drawing.Point(613, 119);
            this.lCostoPreparar.Name = "lCostoPreparar";
            this.lCostoPreparar.Size = new System.Drawing.Size(91, 13);
            this.lCostoPreparar.TabIndex = 11;
            this.lCostoPreparar.Text = "Costo de preparar";
            // 
            // lDemandaAnual
            // 
            this.lDemandaAnual.AutoSize = true;
            this.lDemandaAnual.Location = new System.Drawing.Point(128, 119);
            this.lDemandaAnual.Name = "lDemandaAnual";
            this.lDemandaAnual.Size = new System.Drawing.Size(82, 13);
            this.lDemandaAnual.TabIndex = 10;
            this.lDemandaAnual.Text = "Demanda anual";
            // 
            // bCostoAnual
            // 
            this.bCostoAnual.Location = new System.Drawing.Point(335, 308);
            this.bCostoAnual.Name = "bCostoAnual";
            this.bCostoAnual.Size = new System.Drawing.Size(171, 23);
            this.bCostoAnual.TabIndex = 9;
            this.bCostoAnual.Text = "Calcular costo  anual de instalación";
            this.bCostoAnual.UseVisualStyleBackColor = true;
            this.bCostoAnual.Click += new System.EventHandler(this.bCostoAnual_Click);
            // 
            // CostoAnualInstalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDemandaAnual);
            this.Controls.Add(this.tbCostoPreparar);
            this.Controls.Add(this.tbPiezasOrdenar);
            this.Controls.Add(this.lPiezasOrdenar);
            this.Controls.Add(this.lCostoPreparar);
            this.Controls.Add(this.lDemandaAnual);
            this.Controls.Add(this.bCostoAnual);
            this.Name = "CostoAnualInstalar";
            this.Text = "CostoAnualInstalar";
            this.Load += new System.EventHandler(this.CostoAnualInstalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDemandaAnual;
        private System.Windows.Forms.TextBox tbCostoPreparar;
        private System.Windows.Forms.TextBox tbPiezasOrdenar;
        private System.Windows.Forms.Label lPiezasOrdenar;
        private System.Windows.Forms.Label lCostoPreparar;
        private System.Windows.Forms.Label lDemandaAnual;
        private System.Windows.Forms.Button bCostoAnual;
    }
}