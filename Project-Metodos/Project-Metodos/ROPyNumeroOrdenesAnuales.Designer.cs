namespace Project_Metodos
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
            this.ostras.Location = new System.Drawing.Point(57, 225);
            this.ostras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ostras.Name = "ostras";
            this.ostras.Size = new System.Drawing.Size(223, 30);
            this.ostras.TabIndex = 34;
            this.ostras.Text = "Calcular Num Ordenes Anuales";
            this.ostras.UseVisualStyleBackColor = true;
            this.ostras.Click += new System.EventHandler(this.ostras_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(608, 117);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 23);
            this.textBox4.TabIndex = 33;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(409, 117);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 23);
            this.textBox3.TabIndex = 32;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 111);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 23);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DAnual
            // 
            this.DAnual.Location = new System.Drawing.Point(20, 111);
            this.DAnual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DAnual.Name = "DAnual";
            this.DAnual.Size = new System.Drawing.Size(103, 23);
            this.DAnual.TabIndex = 30;
            this.DAnual.TextChanged += new System.EventHandler(this.DAnual_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(624, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tiempo De entrega";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lResult.Location = new System.Drawing.Point(135, 191);
            this.lResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(16, 15);
            this.lResult.TabIndex = 28;
            this.lResult.Text = "...";
            this.lResult.Click += new System.EventHandler(this.lResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(116, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Resultado";
            // 
            // lDemandaDiaria
            // 
            this.lDemandaDiaria.AutoSize = true;
            this.lDemandaDiaria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lDemandaDiaria.Location = new System.Drawing.Point(193, 56);
            this.lDemandaDiaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDemandaDiaria.Name = "lDemandaDiaria";
            this.lDemandaDiaria.Size = new System.Drawing.Size(94, 15);
            this.lDemandaDiaria.TabIndex = 26;
            this.lDemandaDiaria.Text = "Piezas a Ordenar";
            // 
            // lProduccion
            // 
            this.lProduccion.AutoSize = true;
            this.lProduccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lProduccion.Location = new System.Drawing.Point(422, 62);
            this.lProduccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProduccion.Name = "lProduccion";
            this.lProduccion.Size = new System.Drawing.Size(99, 15);
            this.lProduccion.TabIndex = 25;
            this.lProduccion.Text = "Demanda por Dia";
            this.lProduccion.Click += new System.EventHandler(this.lProduccion_Click);
            // 
            // lPiezasOrdenar
            // 
            this.lPiezasOrdenar.AutoSize = true;
            this.lPiezasOrdenar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lPiezasOrdenar.Location = new System.Drawing.Point(28, 56);
            this.lPiezasOrdenar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPiezasOrdenar.Name = "lPiezasOrdenar";
            this.lPiezasOrdenar.Size = new System.Drawing.Size(90, 15);
            this.lPiezasOrdenar.TabIndex = 24;
            this.lPiezasOrdenar.Text = "Demanda anual";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 30);
            this.button1.TabIndex = 37;
            this.button1.Text = "Calcular Costo Total Anual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(589, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "...";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(570, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(41, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Num Ordenes Anuales";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(548, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "ROP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ROPyNumeroOrdenesAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(801, 293);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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