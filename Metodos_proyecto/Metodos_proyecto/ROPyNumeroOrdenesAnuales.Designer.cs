namespace Metodos_proyecto
{
    partial class ROPyNumeroOrdenesAnuales
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DAnual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lDemandaDiaria = new System.Windows.Forms.Label();
            this.lProduccion = new System.Windows.Forms.Label();
            this.lPiezasOrdenar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ostras
            // 
            this.ostras.Location = new System.Drawing.Point(135, 314);
            this.ostras.Name = "ostras";
            this.ostras.Size = new System.Drawing.Size(191, 26);
            this.ostras.TabIndex = 34;
            this.ostras.Text = "Calcular Num Ordenes Anuales";
            this.ostras.UseVisualStyleBackColor = true;
            this.ostras.Click += new System.EventHandler(this.ostras_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(627, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 33;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(457, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 32;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DAnual
            // 
            this.DAnual.Location = new System.Drawing.Point(90, 166);
            this.DAnual.Name = "DAnual";
            this.DAnual.Size = new System.Drawing.Size(89, 20);
            this.DAnual.TabIndex = 30;
            this.DAnual.TextChanged += new System.EventHandler(this.DAnual_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tiempo De entrega";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(202, 284);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(16, 13);
            this.lResult.TabIndex = 28;
            this.lResult.Text = "...";
            this.lResult.Click += new System.EventHandler(this.lResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 262);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Resultado";
            // 
            // lDemandaDiaria
            // 
            this.lDemandaDiaria.AutoSize = true;
            this.lDemandaDiaria.Location = new System.Drawing.Point(238, 119);
            this.lDemandaDiaria.Name = "lDemandaDiaria";
            this.lDemandaDiaria.Size = new System.Drawing.Size(88, 13);
            this.lDemandaDiaria.TabIndex = 26;
            this.lDemandaDiaria.Text = "Piezas a Ordenar";
            // 
            // lProduccion
            // 
            this.lProduccion.AutoSize = true;
            this.lProduccion.Location = new System.Drawing.Point(468, 119);
            this.lProduccion.Name = "lProduccion";
            this.lProduccion.Size = new System.Drawing.Size(90, 13);
            this.lProduccion.TabIndex = 25;
            this.lProduccion.Text = "Demanda por Dia";
            this.lProduccion.Click += new System.EventHandler(this.lProduccion_Click);
            // 
            // lPiezasOrdenar
            // 
            this.lPiezasOrdenar.AutoSize = true;
            this.lPiezasOrdenar.Location = new System.Drawing.Point(97, 119);
            this.lPiezasOrdenar.Name = "lPiezasOrdenar";
            this.lPiezasOrdenar.Size = new System.Drawing.Size(82, 13);
            this.lPiezasOrdenar.TabIndex = 24;
            this.lPiezasOrdenar.Text = "Demanda anual";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 26);
            this.button1.TabIndex = 37;
            this.button1.Text = "Calcular Costo Total Anual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "...";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 262);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(130, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Num Ordenes Anuales";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(576, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "ROP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ROPyNumeroOrdenesAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
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
            this.Name = "ROPyNumeroOrdenesAnuales";
            this.Text = "ROPyNumeroOrdenesAnuales";
            this.Load += new System.EventHandler(this.ROPyNumeroOrdenesAnuales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ostras;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox DAnual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDemandaDiaria;
        private System.Windows.Forms.Label lProduccion;
        private System.Windows.Forms.Label lPiezasOrdenar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}