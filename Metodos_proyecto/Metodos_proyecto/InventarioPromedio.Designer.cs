
namespace Metodos_proyecto
{
    partial class InventarioPromedio
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
            this.btInventarioProm = new System.Windows.Forms.Button();
            this.lPiezasOrdenar = new System.Windows.Forms.Label();
            this.lProduccion = new System.Windows.Forms.Label();
            this.lDemandaDiaria = new System.Windows.Forms.Label();
            this.tbDemandaDiaria = new System.Windows.Forms.TextBox();
            this.tbProduccion = new System.Windows.Forms.TextBox();
            this.tbPiezas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btInventarioProm
            // 
            this.btInventarioProm.Location = new System.Drawing.Point(293, 252);
            this.btInventarioProm.Name = "btInventarioProm";
            this.btInventarioProm.Size = new System.Drawing.Size(171, 23);
            this.btInventarioProm.TabIndex = 0;
            this.btInventarioProm.Text = "Calcular inventario promedio";
            this.btInventarioProm.UseVisualStyleBackColor = true;
            this.btInventarioProm.Click += new System.EventHandler(this.btInventarioProm_Click);
            this.btInventarioProm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btInventarioProm_MouseClick);
            // 
            // lPiezasOrdenar
            // 
            this.lPiezasOrdenar.AutoSize = true;
            this.lPiezasOrdenar.Location = new System.Drawing.Point(86, 63);
            this.lPiezasOrdenar.Name = "lPiezasOrdenar";
            this.lPiezasOrdenar.Size = new System.Drawing.Size(86, 13);
            this.lPiezasOrdenar.TabIndex = 1;
            this.lPiezasOrdenar.Text = "Piezas a ordenar";
            // 
            // lProduccion
            // 
            this.lProduccion.AutoSize = true;
            this.lProduccion.Location = new System.Drawing.Point(571, 63);
            this.lProduccion.Name = "lProduccion";
            this.lProduccion.Size = new System.Drawing.Size(61, 13);
            this.lProduccion.TabIndex = 2;
            this.lProduccion.Text = "Produccion";
            // 
            // lDemandaDiaria
            // 
            this.lDemandaDiaria.AutoSize = true;
            this.lDemandaDiaria.Location = new System.Drawing.Point(337, 63);
            this.lDemandaDiaria.Name = "lDemandaDiaria";
            this.lDemandaDiaria.Size = new System.Drawing.Size(81, 13);
            this.lDemandaDiaria.TabIndex = 3;
            this.lDemandaDiaria.Text = "Demanda diaria";
            // 
            // tbDemandaDiaria
            // 
            this.tbDemandaDiaria.Location = new System.Drawing.Point(328, 91);
            this.tbDemandaDiaria.Name = "tbDemandaDiaria";
            this.tbDemandaDiaria.Size = new System.Drawing.Size(100, 20);
            this.tbDemandaDiaria.TabIndex = 4;
            // 
            // tbProduccion
            // 
            this.tbProduccion.Location = new System.Drawing.Point(545, 91);
            this.tbProduccion.Name = "tbProduccion";
            this.tbProduccion.Size = new System.Drawing.Size(100, 20);
            this.tbProduccion.TabIndex = 5;
            // 
            // tbPiezas
            // 
            this.tbPiezas.Location = new System.Drawing.Point(72, 91);
            this.tbPiezas.Name = "tbPiezas";
            this.tbPiezas.Size = new System.Drawing.Size(100, 20);
            this.tbPiezas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 199);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Resultado";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(357, 219);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(16, 13);
            this.lResult.TabIndex = 8;
            this.lResult.Text = "...";
            // 
            // InventarioPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPiezas);
            this.Controls.Add(this.tbProduccion);
            this.Controls.Add(this.tbDemandaDiaria);
            this.Controls.Add(this.lDemandaDiaria);
            this.Controls.Add(this.lProduccion);
            this.Controls.Add(this.lPiezasOrdenar);
            this.Controls.Add(this.btInventarioProm);
            this.Name = "InventarioPromedio";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.InventarioPromedio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInventarioProm;
        private System.Windows.Forms.Label lPiezasOrdenar;
        private System.Windows.Forms.Label lProduccion;
        private System.Windows.Forms.Label lDemandaDiaria;
        private System.Windows.Forms.TextBox tbDemandaDiaria;
        private System.Windows.Forms.TextBox tbProduccion;
        private System.Windows.Forms.TextBox tbPiezas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lResult;
    }
}