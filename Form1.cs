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

            tempoDaUltimaAtt = TimeSpan.FromSeconds(0.030);
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;

            if (contador >= 2)
            {
                progressBar1.PerformStep();
                contador = 0;
            }

            label2.Text = Convert.ToString(pid.Kp);
            label3.Text = Convert.ToString(pid.Ki);
            label4.Text = Convert.ToString(pid.Kd);

            progressBar1.Value = Convert.ToInt32(pid.VariavelControle(tempoDaUltimaAtt));
            labelBarra.Text = Convert.ToString(progressBar1.Value);

        }

        private void btn_para_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void txtbx_Kp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números reais.\nPor favor, use vírgula para separar os decimais.");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.");
            }
        }

        private void txtbx_Ki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números reais.\nPor favor, use vírgula para separar os decimais.");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.");
            }
        }

        private void txtbx_Kd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números reais.\nPor favor, use vírgula para separar os decimais.");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma vírgula.");
            }
        }

        private void txtbx_valorDesejado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números naturais.");
            }
        }

        private void txtbx_ValorInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números naturais.");
            }
        }
    }
}
