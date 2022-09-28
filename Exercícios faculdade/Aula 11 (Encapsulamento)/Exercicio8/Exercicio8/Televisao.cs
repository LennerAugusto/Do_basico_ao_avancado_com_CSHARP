using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Televisao
    {
        private string marca, modelo;
        private DateTime data_lancamento;
        private double preco;
        private string lcd;
        private int polegadas;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public DateTime Data_lancamento { get => data_lancamento; set => data_lancamento = value; }
        public double Preco { get => preco; set => preco = value; }
        public string Lcd { get => lcd; set => lcd = value; }
        public int Polegadas { get => polegadas; set => polegadas = value; }


        public double precoVenda()
        {
            return preco + (preco * 10 / 100);
        }

      
        public string imprime()
        {
            return "Marca: " + marca + "\nModelo: " + modelo + "\nData de lançamento: " + data_lancamento +
                    "\nPreço de custo: " + preco + "\nPreço de venda: " + precoVenda() + "\nLCD: " + lcd + "\nPolegadas: " + polegadas;

        }
    }                             
}
