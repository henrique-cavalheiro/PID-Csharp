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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_comeca_Click(object sender, EventArgs e)
        {
            progressBar1.Value = Int32.Parse(txtbx_Kd.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(progressBar1.Value*0.98);
        }
    }
}
