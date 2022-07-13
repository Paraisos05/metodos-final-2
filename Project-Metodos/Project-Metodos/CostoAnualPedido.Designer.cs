
namespace Project_Metodos
{
    partial class CostoAnualPedido
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Demanda = new System.Windows.Forms.TextBox();
            this.tb_piezas = new System.Windows.Forms.TextBox();
            this.tb_CostoOrdenar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costo anual pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(175, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Demanda anual";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de piezas a ordenar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo de ordenar";
            // 
            // tb_Demanda
            // 
            this.tb_Demanda.Location = new System.Drawing.Point(401, 86);
            this.tb_Demanda.Name = "tb_Demanda";
            this.tb_Demanda.Size = new System.Drawing.Size(161, 27);
            this.tb_Demanda.TabIndex = 4;
            // 
            // tb_piezas
            // 
            this.tb_piezas.Location = new System.Drawing.Point(401, 157);
            this.tb_piezas.Name = "tb_piezas";
            this.tb_piezas.Size = new System.Drawing.Size(161, 27);
            this.tb_piezas.TabIndex = 5;
            // 
            // tb_CostoOrdenar
            // 
            this.tb_CostoOrdenar.Location = new System.Drawing.Point(401, 229);
            this.tb_CostoOrdenar.Name = "tb_CostoOrdenar";
            this.tb_CostoOrdenar.Size = new System.Drawing.Size(161, 27);
            this.tb_CostoOrdenar.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(401, 293);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(161, 42);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txResult
            // 
            this.txResult.Location = new System.Drawing.Point(604, 301);
            this.txResult.Name = "txResult";
            this.txResult.Size = new System.Drawing.Size(184, 27);
            this.txResult.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(654, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CostoAnualPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tb_CostoOrdenar);
            this.Controls.Add(this.tb_piezas);
            this.Controls.Add(this.tb_Demanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CostoAnualPedido";
            this.Text = "CostoAnualPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Demanda;
        private System.Windows.Forms.TextBox tb_piezas;
        private System.Windows.Forms.TextBox tb_CostoOrdenar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txResult;
        private System.Windows.Forms.Label label5;
    }
}