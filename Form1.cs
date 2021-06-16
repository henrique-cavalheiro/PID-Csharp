using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        ControladorPID pid = new ControladorPID(0, 0, 0, 1000D, 0);
        TimeSpan tempoDaUltimaAtt = new TimeSpan();
        public int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_comeca_Click(object sender, EventArgs e)
        {
            pid.Kp = Convert.ToDouble(txtbx_Kp.Text);
            pid.Ki = Convert.ToDouble(txtbx_Ki.Text);
            pid.Kd = Convert.ToDouble(txtbx_Kd.Text);
            pid.ValorDesejado = Convert.ToDouble(txtbx_valorDesejado.Text);
            pid.VariavelProcesso = Convert.ToDouble(txtbx_ValorInicial.Text);
            pid.TermoIntegral = 0;
            progressBar1.Value = Int32.Parse(txtbx_ValorInicial.Text);

            labelBarra.Text = Convert.ToString(progressBar1.Value);

            tempoDaUltimaAtt = TimeSpan.FromSeconds(0.100);
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;

            if (contador >= 4)
            {
                progressBar1.PerformStep();
                contador = 0;
            }

            label2.Text = Convert.ToString(pid.TermoIntegral);
            label3.Text = Convert.ToString(pid.VariavelProcesso);
            label4.Text = Convert.ToString(pid.VariavelControle(tempoDaUltimaAtt));

            progressBar1.Value = Convert.ToInt32(pid.VariavelControle(tempoDaUltimaAtt));
            labelBarra.Text = Convert.ToString(progressBar1.Value);

        }

        private void btn_para_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
