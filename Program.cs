using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public sealed class Planta
    {
        //Esta planta tem a funcão de transferência 5/(s^2 + 4*s + 3)

        private double t;

        public Planta(){
            t = 0;
        }
        public double AtualizaPlanta(double entrada, TimeSpan tempoDaUltimaAtt)
        {
            double saida;

            t += tempoDaUltimaAtt.TotalSeconds;

            saida = entrada * ((-2.5  * Math.Exp(-t)) + (0.8333 * Math.Exp(-3 * t)) + 1.6667);

            saida = Limita(saida);

            return saida;

        }

        public double TempoDecorrido 
        {
            get { return t; }
        }

        public void ResetaTempo()
        {
            t = 0;
        }
        private double Limita(double variavelParaLimitar)
        {
            if (variavelParaLimitar < 0) { return 0; }
            if (variavelParaLimitar > 1000) { return 1000; }

            return variavelParaLimitar;
        }


    }

    public sealed class Atuador
    {
        private double t, entradaAtual, saida;
        private bool flag1 = false, flag2 = false;

        public Atuador()
        {
            t = 0;
            entradaAtual = 0;
            saida = 1000D;
        }
        public double Atuar(TimeSpan tempoDaUltimaAtt)
        {
            t += tempoDaUltimaAtt.TotalSeconds;

            if (EntradaAtual > EntradaAnterior)
            {
                if (flag1 == false)
                {
                    flag1 = true;
                    flag2 = false;
                    t = 0;
                }
                saida = saida * Math.Exp((EntradaAtual / 1000D) * t);
            }

            if (EntradaAtual <= EntradaAnterior)
            {
                if (flag2 == false)
                {
                    flag1 = false;
                    flag2 = true;
                    t = 0;
                }
                saida = saida * Math.Exp((-EntradaAtual / 1000D) * t);
            }

            return saida;
        }

        public double Saida
        {
            get
            {
                return saida;
            }
            set
            {
                saida = value;
            }
        }

        public double EntradaAtual
        {
            get
            {
                return entradaAtual;
            }
            set
            {
                EntradaAnterior = entradaAtual;
                entradaAtual = value;
            }
        }

        private double EntradaAnterior { get; set; } = 0;

        public void ResetaTempo()
        {
            t = 0;
        }
    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }


}
