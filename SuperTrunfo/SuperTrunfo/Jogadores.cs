using System;
using System.Collections.Generic;
using System.Text;

namespace SuperTrunfo
{
    class Jogador
    {
        //variaveis para os playes
        protected int id;
        protected string nome;
        protected bool human;
        protected Carta[] mao;

        public Jogador(int id, string nome, bool human)
        {
            this.id = id;
            this.nome = nome;
            this.human = human;
            this.mao = new Carta[32];
        }

        //BOTS
        public string[] BotsNomes()
        {
            string[] bot = new string[7];

            bot[0] = "Bot cario";
            bot[1] = "Usain Bot";
            bot[2] = "Botolomeu";
            bot[3] = "Rebot";
            bot[4] = "Trombote";
            bot[5] = "Oooliiimeee";
            bot[6] = "Bot inas";

            return bot;
        }

        //parte desnecessaria mas realista <3
        //entregar apos embaralhada a primeira carta do baralho para cada jogador(como eh feito na realidade)
        public void PegarCartas(Carta[] baralho, int num_player)
        {
            int j = 0;
            for (int i = 0; i < baralho.Length; i++)
            {
                if (i % num_player == this.id)
                {
                    Carta[] temp = new Carta[j+1];
                    for (int k = 0; k < temp.Length - 1; k++)
                    {
                        temp[k] = this.mao[k];
                    }

                    this.mao = new Carta[j + 1];
                    this.mao = temp;
                    this.mao[j] = baralho[i];

                }

                if (i % num_player == 0 && i > 0)
                {
                    j++;
                }

            }

        }

        //arrumar o vetor da mao pra nao ficar nulo
        public Carta[] FixVoid(Carta[] mao)
        {
            for (int i = 0; i < mao.Length-1; i++)
            { 
                mao[i] = mao[(i + 1)];
            }

            return mao;
        }

        //FUNCAO-ganhar carta dos outros jogadores
        public Carta[] Ganhar(Carta[] mao, Jogador[] jogadores)
        {
            int minus = 0;

            if (mao.Length > 0)
            {

                int tam = mao.Length + (jogadores.Length - 1) - minus;
                Carta[] temp = new Carta[tam];

                temp[(mao.Length - 1)] = mao[0];


                for (int i = 0; i < mao.Length - 1; i++)
                {
                    temp[i] = mao[i + 1];
                }

                for (int k = 0; k <= (jogadores.Length - 1); k++)
                {

                    if (k < this.id)
                    {
                        Carta[] cards = jogadores[k].GetCartasMao();
                        if (cards.Length > 0 && cards[0] == new Carta()) 
                        {
                            Carta card = jogadores[k].GetCarta();

                            temp[(mao.Length) + k] = card;
                        }

                    }

                    if (k > this.id)
                    {
                        Carta[] cards = jogadores[k].GetCartasMao();
                        if (cards.Length > 0 && cards[0] == new Carta())
                        {
                            Carta card = jogadores[k].GetCarta();

                            temp[(mao.Length) + (k-1)] = card;
                        }

                    }

                }

                return temp;
            }

            else { return mao; }
        }

        //FUNCAO-perder carta
        public Carta[] Perder(Carta[] mao)
        {
            int tam = mao.Length - 1;

            if (tam > 0)
            {
                Carta[] temp = new Carta[tam];

                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = mao[i + 1];
                }
                return temp;
            }

            else 
            {
                return new Carta[0];
            }
        }

        //imprimir mao do jogador
        public void ImprimirMao()
        {
            for (int i = 0; i < mao.Length; i++)
            {
                Console.WriteLine(mao[i]);

            }
        }


        //SETS E GETS
        public Carta[] GetCartasMao()
        {
            return mao;
        }

        public Carta GetCarta()
        {
            return mao[0];
        }

        public int GetId()
        {
            return id;
        }

        public bool GetHuman()
        {
            return human;
        }

        public void SetMao(Carta[] mao)
        {
            this.mao = mao;
        }

        public override string ToString()
        {
            return "Jogador " + (id + 1) + " " + nome;
        }

    }
}
