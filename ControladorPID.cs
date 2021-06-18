using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public sealed class ControladorPID{
        private double variavelProcesso = 0;

        public ControladorPID(double Kp, double Ki, double Kd, double SaidaMax, double SaidaMin)
        {
            this.Kp = Kp;
            this.Ki = Ki;
            this.Kd = Kd;
            this.SaidaMax = SaidaMax;
            this.SaidaMin = SaidaMin;
        }

        public double VariavelControle(TimeSpan tempoDaUltimaAtt)
        {
            double erro = ValorDesejado - VariavelProcesso;

            TermoIntegral += (Ki * erro * tempoDaUltimaAtt.TotalSeconds);
            TermoIntegral = Limita(TermoIntegral);

            double entradaD = VariavelProcesso - UltimaVariavelProcesso;
            double termoDerivativo = Kd * (entradaD / tempoDaUltimaAtt.TotalSeconds);

            double termoProporcional = Kp * erro;

            double saida = TermoIntegral + termoProporcional - termoDerivativo;
            saida = Limita(saida);

            return saida;
        }
        public double Kd { get; set; } = 0;

        public double Ki { get; set; } = 0;

        public double Kp { get; set; } = 0;

        public double SaidaMax { get; private set; } = 0;

        public double SaidaMin { get; private set; } = 0;

        public double TermoIntegral { get; set; } = 0;

        public double VariavelProcesso
        {
            get { return variavelProcesso; }

            set
            {
                UltimaVariavelProcesso = variavelProcesso;
                variavelProcesso = value;
            }
        }

        public double UltimaVariavelProcesso { get; private set; } = 0;

        public double ValorDesejado { get; set; } = 0;

        private double Limita(double variavelParaLimitar)
        {
            if(variavelParaLimitar < SaidaMin) { return SaidaMin; }
            if(variavelParaLimitar > SaidaMax) { return SaidaMax; }

            return variavelParaLimitar;
        }
    }
}
