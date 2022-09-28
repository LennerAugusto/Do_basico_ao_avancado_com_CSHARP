using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_bancaria
{
    internal class ContaBancaria
    {
        private double saldo;

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public ContaBancaria()
        {
            if(saldo <= 0)
            {
                setSaldo(0);

                MessageBox.Show("Erro, valor inválido");
            }
        }
      
        public double credito(double valorCredito)
        {
           return saldo = saldo + valorCredito;
        }

        public void debito(double valorDebito)
        {
            if (valorDebito <= saldo)
            {
                saldo = saldo - valorDebito;
            }
            else
            {
                MessageBox.Show("Não foi possível debitar de sua conta, pois seu saldo é insuficiente");
            }

        }

        public string consultaSaldo()
        {
            return "Saldo disponível: " + getSaldo();
        }
    }
}
