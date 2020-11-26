using System;
using System.Collections.Generic;
using System.Text;

namespace SuperTrunfo
{
    class Carta
    {

        //atributos 

        protected string id, nome;

        protected int velocidadeMaxima, cilindradas;
        protected double zeroCem;
        protected int potencia;
        protected double comprimento;
        protected int peso;

        //iniciar variaveis
        
        public Carta() { }
        

        public Carta(string id, string nome, int velocidadeMaxima,
            int cilindradas, double zeroCem, int potencia, double comprimento, int peso)
        {
            this.id = id;
            this.nome = nome;
            this.velocidadeMaxima = velocidadeMaxima;
            this.cilindradas = cilindradas;
            this.zeroCem = zeroCem;
            this.potencia = potencia;
            this.comprimento = comprimento;
            this.peso = peso;
        }

        public int GetVelocidadeMaxima()
        {
            return velocidadeMaxima;
        }

        public int GetCilindradas()
        {
            return cilindradas;
        }

        public double GetZeroCem()
        {
            return zeroCem;
        }

        public int GetPotencia()
        {
            return potencia;
        }

        public double GetComprimento()
        {
            return comprimento;
        }

        public int GetPeso()
        {
            return peso;
        }


        public override string ToString() { return "\n Id = "  +  id  + "\n Nome = " + nome + "\n 1(Velocidade Maxima)= " + velocidadeMaxima + "\n 2(Cilindradas)= " + cilindradas + "\n 3(Zero a cem)= " + zeroCem + "\n 4(Potencia)= " + potencia + "\n 5(Comprimento)= " + comprimento + "\n 6(Peso)= " + peso; }
    }

}

