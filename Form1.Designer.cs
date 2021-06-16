
namespace Trabalho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelKi = new System.Windows.Forms.Label();
            this.labelKd = new System.Windows.Forms.Label();
            this.txtbx_Kp = new System.Windows.Forms.TextBox();
            this.txtbx_Ki = new System.Windows.Forms.TextBox();
            this.txtbx_Kd = new System.Windows.Forms.TextBox();
            this.btn_comeca = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelKp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_para = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelBarra = new System.Windows.Forms.Label();
            this.txtbx_valorDesejado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbx_ValorInicial = new System.Windows.Forms.TextBox();
            this.labelValorInicial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKi
            // 
            this.labelKi.AutoSize = true;
            this.labelKi.Location = new System.Drawing.Point(6, 64);
            this.labelKi.Name = "labelKi";
            this.labelKi.Size = new System.Drawing.Size(17, 15);
            this.labelKi.TabIndex = 1;
            this.labelKi.Text = "Ki";
            // 
            // labelKd
            // 
            this.labelKd.AutoSize = true;
            this.labelKd.Location = new System.Drawing.Point(6, 103);
            this.labelKd.Name = "labelKd";
            this.labelKd.Size = new System.Drawing.Size(21, 15);
            this.labelKd.TabIndex = 2;
            this.labelKd.Text = "Kd";
            // 
            // txtbx_Kp
            // 
            this.txtbx_Kp.Location = new System.Drawing.Point(39, 22);
            this.txtbx_Kp.Name = "txtbx_Kp";
            this.txtbx_Kp.Size = new System.Drawing.Size(100, 23);
            this.txtbx_Kp.TabIndex = 3;
            this.txtbx_Kp.Text = "0";
            this.txtbx_Kp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_Kp_KeyPress);
            // 
            // txtbx_Ki
            // 
            this.txtbx_Ki.Location = new System.Drawing.Point(39, 61);
            this.txtbx_Ki.Name = "txtbx_Ki";
            this.txtbx_Ki.Size = new System.Drawing.Size(100, 23);
            this.txtbx_Ki.TabIndex = 4;
            this.txtbx_Ki.Text = "0";
            this.txtbx_Ki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_Ki_KeyPress);
            // 
            // txtbx_Kd
            // 
            this.txtbx_Kd.Location = new System.Drawing.Point(39, 100);
            this.txtbx_Kd.Name = "txtbx_Kd";
            this.txtbx_Kd.Size = new System.Drawing.Size(100, 23);
            this.txtbx_Kd.TabIndex = 5;
            this.txtbx_Kd.Text = "0";
            this.txtbx_Kd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_Kd_KeyPress);
            // 
            // btn_comeca
            // 
            this.btn_comeca.Location = new System.Drawing.Point(60, 174);
            this.btn_comeca.Name = "btn_comeca";
            this.btn_comeca.Size = new System.Drawing.Size(75, 23);
            this.btn_comeca.TabIndex = 6;
            this.btn_comeca.Text = "Iniciar";
            this.btn_comeca.UseVisualStyleBackColor = true;
            this.btn_comeca.Click += new System.EventHandler(this.btn_comeca_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(135, 227);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Step = -1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 200;
            // 
            // labelKp
            // 
            this.labelKp.AutoSize = true;
            this.labelKp.Location = new System.Drawing.Point(6, 25);
            this.labelKp.Name = "labelKp";
            this.labelKp.Size = new System.Drawing.Size(21, 15);
            this.labelKp.TabIndex = 11;
            this.labelKp.Text = "Kp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbx_Kp);
            this.groupBox1.Controls.Add(this.labelKp);
            this.groupBox1.Controls.Add(this.txtbx_Ki);
            this.groupBox1.Controls.Add(this.labelKd);
            this.groupBox1.Controls.Add(this.txtbx_Kd);
            this.groupBox1.Controls.Add(this.labelKi);
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 141);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ganhos PID";
            // 
            // btn_para
            // 
            this.btn_para.Location = new System.Drawing.Point(244, 174);
            this.btn_para.Name = "btn_para";
            this.btn_para.Size = new System.Drawing.Size(75, 23);
            this.btn_para.TabIndex = 13;
            this.btn_para.Text = "Parar";
            this.btn_para.UseVisualStyleBackColor = true;
            this.btn_para.Click += new System.EventHandler(this.btn_para_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Controle PID de progressão da barra";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(6, 34);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(83, 15);
            this.labelValor.TabIndex = 12;
            this.labelValor.Text = "Valor desejado";
            // 
            // labelBarra
            // 
            this.labelBarra.AutoSize = true;
            this.labelBarra.Location = new System.Drawing.Point(175, 209);
            this.labelBarra.Name = "labelBarra";
            this.labelBarra.Size = new System.Drawing.Size(25, 15);
            this.labelBarra.TabIndex = 15;
            this.labelBarra.Text = "200";
            // 
            // txtbx_valorDesejado
            // 
            this.txtbx_valorDesejado.Location = new System.Drawing.Point(98, 34);
            this.txtbx_valorDesejado.Name = "txtbx_valorDesejado";
            this.txtbx_valorDesejado.Size = new System.Drawing.Size(44, 23);
            this.txtbx_valorDesejado.TabIndex = 13;
            this.txtbx_valorDesejado.Text = "0";
            this.txtbx_valorDesejado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_valorDesejado_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbx_ValorInicial);
            this.groupBox2.Controls.Add(this.labelValorInicial);
            this.groupBox2.Controls.Add(this.txtbx_valorDesejado);
            this.groupBox2.Controls.Add(this.labelValor);
            this.groupBox2.Location = new System.Drawing.Point(204, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 141);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parâmetros Planta";
            // 
            // txtbx_ValorInicial
            // 
            this.txtbx_ValorInicial.Location = new System.Drawing.Point(98, 86);
            this.txtbx_ValorInicial.Name = "txtbx_ValorInicial";
            this.txtbx_ValorInicial.Size = new System.Drawing.Size(44, 23);
            this.txtbx_ValorInicial.TabIndex = 15;
            this.txtbx_ValorInicial.Text = "0";
            this.txtbx_ValorInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_ValorInicial_KeyPress);
            // 
            // labelValorInicial
            // 
            this.labelValorInicial.AutoSize = true;
            this.labelValorInicial.Location = new System.Drawing.Point(6, 89);
            this.labelValorInicial.Name = "labelValorInicial";
            this.labelValorInicial.Size = new System.Drawing.Size(67, 15);
            this.labelValorInicial.TabIndex = 14;
            this.labelValorInicial.Text = "Valor inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelBarra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_para);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_comeca);
            this.Name = "Form1";
            this.Text = "Controle PID";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelKi;
        private System.Windows.Forms.Label labelKd;
        private System.Windows.Forms.TextBox txtbx_Kp;
        private System.Windows.Forms.TextBox txtbx_Ki;
        private System.Windows.Forms.TextBox txtbx_Kd;
        private System.Windows.Forms.Button btn_comeca;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelKp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_para;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelBarra;
        private System.Windows.Forms.TextBox txtbx_valorDesejado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbx_ValorInicial;
        private System.Windows.Forms.Label labelValorInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

