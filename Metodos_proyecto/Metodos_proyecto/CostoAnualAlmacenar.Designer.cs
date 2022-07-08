
namespace Metodos_proyecto
{
    partial class CostoAnualAlmacenar
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
            this.tbCostoAnualAlmacenar = new System.Windows.Forms.TextBox();
            this.lCostoAnualAlmacenar = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.tbPiezas = new System.Windows.Forms.TextBox();
            this.lPiezasOrdenar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCostoAnualAlmacenar
            // 
            this.tbCostoAnualAlmacenar.Location = new System.Drawing.Point(363, 137);
            this.tbCostoAnualAlmacenar.Name = "tbCostoAnualAlmacenar";
            this.tbCostoAnualAlmacenar.Size = new System.Drawing.Size(100, 20);
            this.tbCostoAnualAlmacenar.TabIndex = 33;
            // 
            // lCostoAnualAlmacenar
            // 
            this.lCostoAnualAlmacenar.AutoSize = true;
            this.lCostoAnualAlmacenar.Location = new System.Drawing.Point(339, 109);
            this.lCostoAnualAlmacenar.Name = "lCostoAnualAlmacenar";
            this.lCostoAnualAlmacenar.Size = new System.Drawing.Size(133, 13);
            this.lCostoAnualAlmacenar.TabIndex = 32;
            this.lCostoAnualAlmacenar.Text = "Costo anual por almacenar";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(234, 221);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(16, 13);
            this.lResult.TabIndex = 36;
            this.lResult.Text = "...";
            this.lResult.Click += new System.EventHandler(this.lResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 201);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Resultado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(209, 257);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(92, 23);
            this.bCalcular.TabIndex = 34;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // tbPiezas
            // 
            this.tbPiezas.Location = new System.Drawing.Point(51, 137);
            this.tbPiezas.Name = "tbPiezas";
            this.tbPiezas.Size = new System.Drawing.Size(100, 20);
            this.tbPiezas.TabIndex = 38;
            // 
            // lPiezasOrdenar
            // 
            this.lPiezasOrdenar.AutoSize = true;
            this.lPiezasOrdenar.Location = new System.Drawing.Point(65, 109);
            this.lPiezasOrdenar.Name = "lPiezasOrdenar";
            this.lPiezasOrdenar.Size = new System.Drawing.Size(86, 13);
            this.lPiezasOrdenar.TabIndex = 37;
            this.lPiezasOrdenar.Text = "Piezas a ordenar";
            // 
            // CostoAnualAlmacenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.tbPiezas);
            this.Controls.Add(this.lPiezasOrdenar);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tbCostoAnualAlmacenar);
            this.Controls.Add(this.lCostoAnualAlmacenar);
            this.Name = "CostoAnualAlmacenar";
            this.Text = "CostoAnualAlmacenar";
            this.Load += new System.EventHandler(this.CostoAnualAlmacenar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCostoAnualAlmacenar;
        private System.Windows.Forms.Label lCostoAnualAlmacenar;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TextBox tbPiezas;
        private System.Windows.Forms.Label lPiezasOrdenar;
    }
}