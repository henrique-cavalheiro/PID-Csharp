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
        ControladorPID pid = new ControladorPID(0, 0, 0, 100D, 10D);
        TimeSpan tempoDaUltimaAtt = new TimeSpan();
        Planta planta = new Planta();
        Atuador atuador = new Atuador();
        public int contador = 0;
        double saidaPlanta = 0, saidaAtuador = 0;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Controle PID de uma planta com uma função de transferência F=5/(s^2 + 4*s + 3) para uma entrada degrau.");
        }

        private void btn_comeca_Click(object sender, EventArgs e)
        {
            pid.Kp = Convert.ToDouble(txtbx_Kp.Text);
            pid.Ki = Convert.ToDouble(txtbx_Ki.Text);
            pid.Kd = Convert.ToDouble(txtbx_Kd.Text);
            pid.ValorDesejado = Convert.ToDouble(txtbx_valorDesejado.Text);
            pid.VariavelProcesso = 0;
            pid.TermoIntegral = 0;
            progressBar1.Value = 0;
            planta.ResetaTempo();
            atuador.ResetaTempo();
            atuador.Saida = 1000D;
            saidaPlanta = 0;
            saidaAtuador = 0;

            labelBarra.Text = Convert.ToString(progressBar1.Value);

            tempoDaUltimaAtt = TimeSpan.FromSeconds(0.100);
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pid.VariavelProcesso = saidaPlanta;
            atuador.EntradaAtual =pid.VariavelControle(tempoDaUltimaAtt);
            saidaAtuador=atuador.Atuar(tempoDaUltimaAtt);
            saidaPlanta = planta.AtualizaPlanta(saidaAtuador, tempoDaUltimaAtt);
            
            progressBar1.Value = Convert.ToInt32(saidaPlanta);
            labelBarra.Text = Convert.ToString(progressBar1.Value);
            txtbxTempoDecorrido.Text = Convert.ToString(planta.TempoDecorrido);
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

        private void Form1_Load(object sender, EventArgs e)
        {

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
