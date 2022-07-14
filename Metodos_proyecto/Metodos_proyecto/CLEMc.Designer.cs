
namespace Metodos_proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbDemandaAnual = new System.Windows.Forms.Label();
            this.tbDemandaAnual = new System.Windows.Forms.TextBox();
            this.tbCostoAnualAlmacenar = new System.Windows.Forms.TextBox();
            this.lCostoAlmacenar = new System.Windows.Forms.Label();
            this.tbCostoOrden = new System.Windows.Forms.TextBox();
            this.lCostoOrden = new System.Windows.Forms.Label();
            this.lRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(355, 348);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbDemandaAnual
            // 
            this.lbDemandaAnual.AutoSize = true;
            this.lbDemandaAnual.Location = new System.Drawing.Point(63, 69);
            this.lbDemandaAnual.Name = "lbDemandaAnual";
            this.lbDemandaAnual.Size = new System.Drawing.Size(82, 13);
            this.lbDemandaAnual.TabIndex = 1;
            this.lbDemandaAnual.Text = "Demanda anual";
            this.lbDemandaAnual.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbDemandaAnual
            // 
            this.tbDemandaAnual.Location = new System.Drawing.Point(66, 90);
            this.tbDemandaAnual.Name = "tbDemandaAnual";
            this.tbDemandaAnual.Size = new System.Drawing.Size(100, 20);
            this.tbDemandaAnual.TabIndex = 2;
            // 
            // tbCostoAnualAlmacenar
            // 
            this.tbCostoAnualAlmacenar.Location = new System.Drawing.Point(306, 90);
            this.tbCostoAnualAlmacenar.Name = "tbCostoAnualAlmacenar";
            this.tbCostoAnualAlmacenar.Size = new System.Drawing.Size(100, 20);
            this.tbCostoAnualAlmacenar.TabIndex = 4;
            // 
            // lCostoAlmacenar
            // 
            this.lCostoAlmacenar.AutoSize = true;
            this.lCostoAlmacenar.Location = new System.Drawing.Point(303, 74);
            this.lCostoAlmacenar.Name = "lCostoAlmacenar";
            this.lCostoAlmacenar.Size = new System.Drawing.Size(139, 13);
            this.lCostoAlmacenar.TabIndex = 3;
            this.lCostoAlmacenar.Text = "Costo anual por alamacenar";
            // 
            // tbCostoOrden
            // 
            this.tbCostoOrden.Location = new System.Drawing.Point(574, 90);
            this.tbCostoOrden.Name = "tbCostoOrden";
            this.tbCostoOrden.Size = new System.Drawing.Size(100, 20);
            this.tbCostoOrden.TabIndex = 6;
            // 
            // lCostoOrden
            // 
            this.lCostoOrden.AutoSize = true;
            this.lCostoOrden.Location = new System.Drawing.Point(571, 74);
            this.lCostoOrden.Name = "lCostoOrden";
            this.lCostoOrden.Size = new System.Drawing.Size(116, 13);
            this.lCostoOrden.TabIndex = 5;
            this.lCostoOrden.Text = "Costo de orden/pedido";
            // 
            // lRespuesta
            // 
            this.lRespuesta.AutoSize = true;
            this.lRespuesta.Location = new System.Drawing.Point(371, 207);
            this.lRespuesta.Name = "lRespuesta";
            this.lRespuesta.Size = new System.Drawing.Size(55, 13);
            this.lRespuesta.TabIndex = 7;
            this.lRespuesta.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lRespuesta);
            this.Controls.Add(this.tbCostoOrden);
            this.Controls.Add(this.lCostoOrden);
            this.Controls.Add(this.tbCostoAnualAlmacenar);
            this.Controls.Add(this.lCostoAlmacenar);
            this.Controls.Add(this.tbDemandaAnual);
            this.Controls.Add(this.lbDemandaAnual);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbDemandaAnual;
        private System.Windows.Forms.TextBox tbDemandaAnual;
        private System.Windows.Forms.TextBox tbCostoAnualAlmacenar;
        private System.Windows.Forms.Label lCostoAlmacenar;
        private System.Windows.Forms.TextBox tbCostoOrden;
        private System.Windows.Forms.Label lCostoOrden;
        private System.Windows.Forms.Label lRespuesta;
    }
}

