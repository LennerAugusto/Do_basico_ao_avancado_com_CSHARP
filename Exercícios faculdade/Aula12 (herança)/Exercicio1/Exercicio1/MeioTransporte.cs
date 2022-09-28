using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class MeioTransporte
    {
        private string descricao;
        private int capacidade;

        public string Descricao { get => descricao; set => descricao = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }

        public string imprime()
        {
            return "Descrição: " + descricao + "\nCapacidade: " + capacidade;
        }
    }

    class Carro : MeioTransporte
    {
        private double quilometragem;

        public double Quilometragem { get => quilometragem; set => quilometragem = value; }

        public string imprimeCarro()
        {
            return "\nQuilometragem: " + quilometragem;
        }
    }

    class Aviao : MeioTransporte
    {
        private int horasVoo;

        public int HorasVoo { get => horasVoo; set => horasVoo = value; }

        public string imprimeAviao()
        {
            return "\nHoras de Voo: " + horasVoo;
        }
    }
}
