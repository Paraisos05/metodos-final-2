
namespace Project_Metodos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPiezas = new System.Windows.Forms.TextBox();
            this.tbCostoAnualAlmacenar = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costo anual por almacenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de piezas a ordenar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo anual por almacenar";
            // 
            // tbPiezas
            // 
            this.tbPiezas.Location = new System.Drawing.Point(351, 76);
            this.tbPiezas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPiezas.Name = "tbPiezas";
            this.tbPiezas.Size = new System.Drawing.Size(155, 23);
            this.tbPiezas.TabIndex = 3;
            // 
            // tbCostoAnualAlmacenar
            // 
            this.tbCostoAnualAlmacenar.Location = new System.Drawing.Point(351, 132);
            this.tbCostoAnualAlmacenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCostoAnualAlmacenar.Name = "tbCostoAnualAlmacenar";
            this.tbCostoAnualAlmacenar.Size = new System.Drawing.Size(155, 23);
            this.tbCostoAnualAlmacenar.TabIndex = 4;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(533, 197);
            this.tbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(142, 23);
            this.tbResult.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(351, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CostoAnualAlmacenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbCostoAnualAlmacenar);
            this.Controls.Add(this.tbPiezas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CostoAnualAlmacenar";
            this.Text = "CostoAnualAlmacenar";
            this.Load += new System.EventHandler(this.CostoAnualAlmacenar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPiezas;
        private System.Windows.Forms.TextBox tbCostoAnualAlmacenar;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button button1;
    }
}