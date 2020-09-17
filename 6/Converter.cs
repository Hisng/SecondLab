using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _6
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double FromUahToUsd (int uah)
        {
            double result = uah / usd ;
            return result;
        }

        public double FromUahToEur(int uah)
        {
            double result = uah / eur;
            return result;
        }

        public double FromUahToRub(int uah)
        {
            double result = uah / rub;
            return result;
        }

        public double FromUsdToUah(int usd)
        {
            double result = this.usd * usd;
            return result;
        }

        public double FromEurToUah(int eur)
        {
            double result = this.eur * eur;
            return result;
        }

        public double FromRubToUah(int rub)
        {
            double result = this.rub * rub;
            return result;
        }
    }
}
