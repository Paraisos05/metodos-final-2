
namespace Project_Metodos
{
    partial class InventarioSeguridad
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
            this.label5 = new System.Windows.Forms.Label();
            this.txResultIS = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tb_Demanda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Desviaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_DesviacionEstandar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Percent = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txResultROP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(523, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Resultado inventario seguridad";
            // 
            // txResultIS
            // 
            this.txResultIS.Location = new System.Drawing.Point(523, 234);
            this.txResultIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txResultIS.Name = "txResultIS";
            this.txResultIS.Size = new System.Drawing.Size(162, 23);
            this.txResultIS.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(346, 228);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 32);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tb_Demanda
            // 
            this.tb_Demanda.Location = new System.Drawing.Point(346, 32);
            this.tb_Demanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Demanda.Name = "tb_Demanda";
            this.tb_Demanda.Size = new System.Drawing.Size(141, 23);
            this.tb_Demanda.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(148, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Demanda Promedio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventario Seguridad";
            // 
            // tb_Desviaciones
            // 
            this.tb_Desviaciones.Location = new System.Drawing.Point(346, 86);
            this.tb_Desviaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Desviaciones.Name = "tb_Desviaciones";
            this.tb_Desviaciones.Size = new System.Drawing.Size(141, 23);
            this.tb_Desviaciones.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Desviaciones";
            // 
            // tb_DesviacionEstandar
            // 
            this.tb_DesviacionEstandar.Location = new System.Drawing.Point(346, 145);
            this.tb_DesviacionEstandar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_DesviacionEstandar.Name = "tb_DesviacionEstandar";
            this.tb_DesviacionEstandar.Size = new System.Drawing.Size(141, 23);
            this.tb_DesviacionEstandar.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(148, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Desviación Estándar";
            // 
            // cb_Percent
            // 
            this.cb_Percent.AutoSize = true;
            this.cb_Percent.ForeColor = System.Drawing.Color.White;
            this.cb_Percent.Location = new System.Drawing.Point(346, 115);
            this.cb_Percent.Name = "cb_Percent";
            this.cb_Percent.Size = new System.Drawing.Size(110, 19);
            this.cb_Percent.TabIndex = 20;
            this.cb_Percent.Text = "nivel de servicio";
            this.cb_Percent.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(538, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Resultado punto reorden";
            // 
            // txResultROP
            // 
            this.txResultROP.Location = new System.Drawing.Point(523, 158);
            this.txResultROP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txResultROP.Name = "txResultROP";
            this.txResultROP.Size = new System.Drawing.Size(162, 23);
            this.txResultROP.TabIndex = 21;
            // 
            // InventarioSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(700, 291);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txResultROP);
            this.Controls.Add(this.cb_Percent);
            this.Controls.Add(this.tb_DesviacionEstandar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Desviaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txResultIS);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tb_Demanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "InventarioSeguridad";
            this.Text = "InventarioSeguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txResultIS;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tb_Demanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Desviaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_DesviacionEstandar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_Percent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txResultROP;
    }
}