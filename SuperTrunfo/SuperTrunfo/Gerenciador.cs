using System;
using System.Collections.Generic;
using System.Text;

namespace SuperTrunfo
{
    class Gerenciador
    {

        //FUNCAO- inicializador -criacao de cada carta e vetor de cartas
        public Carta[] LoadCartas()
        {
            Carta a1 = new Carta("1A", "1Litre", 120, 300, 16.1, 9, 3.65, 290);
            Carta a2 = new Carta("2A", "Concept_T", 228, 3198, 6.9, 265, 4.12, 1300);
            Carta a3 = new Carta("3A", "Fox_Sportline", 186, 1599, 10.8, 101, 3.804, 1040);
            Carta a4 = new Carta("4A", "Iroc", 242, 1390, 7.0, 210, 4.24, 1360);
            Carta a5 = new Carta("5A", "New_Beetle", 185, 1984, 10.9, 116, 4.129, 1246);
            Carta a6 = new Carta("6A", "Phaeton", 250, 4921, 6.9, 313, 5.055, 2447);
            Carta a7 = new Carta("7A", "Saveiro_Crossover", 175, 1781, 10.2, 103, 4.529, 1044);
            Carta a8 = new Carta("8A", "Touareg_V8", 218, 4172, 8.1, 310, 4.754, 2317);

            Carta b1 = new Carta("1B", "Bora", 195, 1984, 11.0, 116, 4.376, 1240);
            Carta b2 = new Carta("2B", "CrossFox", 175, 1599, 11, 101, 4.08, 1129);
            Carta b3 = new Carta("3B", "Golf_GTI", 227, 1781, 7.8, 180, 4.147, 1251);
            Carta b4 = new Carta("4B", "Jetta", 280, 2480, 9.6, 150, 4.554, 1462);
            Carta b5 = new Carta("5B", "New_Beetle_Cabriolet", 179, 1896, 12, 107, 4.129, 1350);
            Carta b6 = new Carta("6B", "Polo", 187, 1599, 11.4, 101, 3.915, 1115);
            Carta b7 = new Carta("7B", "Saveiro_SuperSurf", 164, 1596, 12, 97, 4.451, 1002);
            Carta b8 = new Carta("8B", "Touareg_W12_Sport", 250, 5998, 5.9, 450, 4.754, 2542);

            Carta c1 = new Carta("1C", "Bora_Stockcar", 280, 5700, 5.3, 450, 4.7, 1250);
            Carta c2 = new Carta("2C", "Eco_Racer", 230, 1484, 6.3, 136, 3.77, 850);
            Carta c3 = new Carta("3C", "Golf_Power", 189, 1781, 10.1, 103, 3.931, 988);
            Carta c4 = new Carta("4C", "Kombi", 130, 1390, 16.1, 57, 4.505, 1297);
            Carta c5 = new Carta("5C", "ParatiTrack&_Field", 190, 1781, 10.1, 103, 4.189, 1069);
            Carta c6 = new Carta("6C", "Polo_GTI", 216, 1781, 8.2, 150, 3.916, 1164);
            Carta c7 = new Carta("7C", "Sharan", 192, 1968, 12.2, 144, 4.634, 1752);
            Carta c8 = new Carta("8C", "Touran", 212, 1968, 9.1, 172, 4.391, 1497);

            Carta d1 = new Carta("1D", "Concept_R", 268, 3189, 5.3, 265, 4.12, 1300);
            Carta d2 = new Carta("2D", "EOS", 232, 1984, 7.8, 200, 4.407, 1536);
            Carta d3 = new Carta("3D", "GX3", 230, 1600, 5.7, 125, 3.754, 570);
            Carta d4 = new Carta("4D", "Nardo", 349, 5998, 3.5, 600, 4.55, 1200);
            Carta d5 = new Carta("5D", "Passat_Turbo", 230, 1984, 7.8, 200, 4.765, 1463);
            Carta d6 = new Carta("6D", "Polo_Sedan", 201, 1984, 10.3, 116, 4.198, 1171);
            Carta d7 = new Carta("7D", "SpaceFox", 173, 1599, 11.1, 101, 4.180, 1095);
            Carta d8 = new Carta("8D", "Varian_Turbo", 227, 1984, 7.9, 200, 4.774, 1518);

            //colocando cartas no vetor de todas
            Carta[] allCards = new Carta[32] {a1, a2, a3, a4, a5, a6, a7, a8, b1, b2, b3, b4, b5, b6, b7, b8,
            c1, c2, c3, c4, c5, c6, c7, c8, d1, d2, d3, d4, d5, d6, d7, d8};

            return allCards;
        }


        //FUNCOES-METODOS
        public Carta[] Embaralhar(Carta[] numeros)
        {


            //looping onde tu vai substituir cada valor de uma posição por um valor de outra posição aleatoria

            for (int i = 0; i < numeros.Length; i++)
            {
                //cada vez q o looping repetir, o int "shuffle" vai receber um valor aleatorio entre 0 e o tamanho maximo do vetor
                var rnd = new Random();
                int shuffle = rnd.Next(numeros.Length);

                //o int temp (de temporario) armazena o valor da posição equivalente a volta do loop, porque logo 
                //em seguida nós mudamos o valor dessa posição pelo valor da posição aleatoria 
                //essa logica se repete pra todas as cartas q tem no baralho. em ordem da primeira a ultima.

                Carta temp = numeros[i];
                numeros[i] = numeros[shuffle];
                numeros[shuffle] = temp;
            }

            //vai retornar o vetor embaralhado.
            return numeros;
        }

        //FUNCAO de escolhas de que atributos
        public void Escolher(Jogador[] jogadores, int vez)
        {
            int caseSwitch;
            Console.Clear();
            Carta[] analise = jogadores[vez].GetCartasMao();

            if (analise.Length > 0) 
            {
                //se jogador eh humano- dar possibilidade de escolha de atributo
                if (jogadores[vez].GetHuman() == true)
                {
                    Carta a = jogadores[vez].GetCarta();
                    Console.WriteLine(jogadores[vez]);
                    Console.WriteLine("Carta :" + a);
                    Console.WriteLine();
          
                    Console.WriteLine("Escolha um atributo para tentar ganhar do seu oponente!");
                     caseSwitch = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                //se nao- bot faz escolha aleatoria
                else
                {
                    //iniciando variavel random
                    var rnd = new Random();
                    //escolhando aleatoriamente entre entre os 6 atributos
                    caseSwitch = rnd.Next(7);
                }

                //possiveis escolhas do humano
                switch (caseSwitch)
                {
                    //VELOCIDADE MAXIMA
                    case 1:
                        Console.WriteLine(jogadores[vez]+" Escolheu: Velocidade maxima");
                        int maiorVel = 0;
                        int vencedor = 0;

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            analise = jogadores[i].GetCartasMao();
                            if (analise.Length > 0)
                            {
                                Carta analiseCard = jogadores[i].GetCarta();
                               
                                if(analiseCard == null)
                                {                      
                                    Carta[] arm = jogadores[i].FixVoid(jogadores[i].GetCartasMao());
                                    jogadores[i].SetMao(arm);
                                } 

                                if (analiseCard != null)
                                {
                                    Console.WriteLine(jogadores[i] + " Carta: ");
                                    Console.WriteLine(analiseCard);
                                    Console.WriteLine("Velocidade Maxima = " + analiseCard.GetVelocidadeMaxima());
                                    Console.WriteLine();
                                    Carta temp = jogadores[i].GetCarta();
                                    int velTemp = temp.GetVelocidadeMaxima();

                                    if (velTemp > maiorVel)
                                    {
                                        maiorVel = velTemp;
                                        vencedor = jogadores[i].GetId();
                                    }

                                }
                            }
                        }

                        Console.WriteLine("Vencedor: " + jogadores[vencedor]);

                        Carta[] cards = jogadores[vencedor].GetCartasMao();
                        cards = jogadores[vencedor].Ganhar(cards, jogadores);
                        jogadores[vencedor].SetMao(cards);

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                                if (jogadores[vencedor].GetId() != jogadores[i].GetId())
                                {
                                    cards = jogadores[i].GetCartasMao();
                                    cards = jogadores[i].Perder(cards);
                                    jogadores[i].SetMao(cards);
                                }
                        }
                        Console.WriteLine("Aperte Enter para continuar");
                        Console.ReadLine();      
                    break;
                   
                    //CILINDRADAS
                    case 2:
                        Console.WriteLine(jogadores[vez] + " Escolheu: Cilidradas");

                        maiorVel = 0;
                        vencedor = 0;

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            analise = jogadores[i].GetCartasMao();
                            if (analise.Length > 0)
                            {
                                Carta analiseCard = jogadores[i].GetCarta();

                                if (analiseCard != null)
                                {

                                    Console.WriteLine(jogadores[i] + " Carta: ");
                                    Console.WriteLine(analiseCard);
                                    Console.WriteLine("Cilindradas = " + analiseCard.GetCilindradas());
                                    Console.WriteLine();
                                    Carta temp = jogadores[i].GetCarta();
                                    int velTemp = temp.GetCilindradas();
                                    if (velTemp > maiorVel)
                                    {
                                        maiorVel = velTemp;
                                        vencedor = jogadores[i].GetId();
                                    }

                                }
                            }
                        }

                        Console.WriteLine("Vencedor: " + jogadores[vencedor]);

                        cards = jogadores[vencedor].GetCartasMao();
                        cards = jogadores[vencedor].Ganhar(cards, jogadores);
                        jogadores[vencedor].SetMao(cards);

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            if (jogadores[vencedor].GetId() != jogadores[i].GetId())
                            {
                                cards = jogadores[i].GetCartasMao();
                                cards = jogadores[i].Perder(cards);
                                jogadores[i].SetMao(cards);
                            }

                        }

                        Console.WriteLine("Aperte Enter para continuar");
                        Console.ReadLine();
                        break;
                
                    //0-100KM
                    case 3:
                        Console.WriteLine(jogadores[vez] + " Escolheu: 0-100km/h");

                        double maiorDouble = 1000;
                        vencedor = 0;

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            analise = jogadores[i].GetCartasMao();
                            if (analise.Length > 0)
                            {
                                Carta analiseCard = jogadores[i].GetCarta();

                                if (analiseCard != null)
                                {

                                    Console.WriteLine(jogadores[i] + " Carta: ");
                                    Console.WriteLine(analiseCard);
                                    Console.WriteLine("0 a 100KM = " + analiseCard.GetZeroCem());
                                    Console.WriteLine();
                                    Carta temp = jogadores[i].GetCarta();
                                    double velTemp = temp.GetZeroCem();
                                    if (velTemp < maiorDouble)
                                    {
                                        maiorDouble = velTemp;
                                        vencedor = jogadores[i].GetId();
                                    }
                                }
                            }
                        }

                        Console.WriteLine("Vencedor: " + jogadores[vencedor]);

                        cards = jogadores[vencedor].GetCartasMao();
                        cards = jogadores[vencedor].Ganhar(cards, jogadores);
                        jogadores[vencedor].SetMao(cards);

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            if (jogadores[vencedor].GetId() != jogadores[i].GetId())
                            {
                                cards = jogadores[i].GetCartasMao();
                                cards = jogadores[i].Perder(cards);
                                jogadores[i].SetMao(cards);
                            }

                        }

                        Console.WriteLine("Aperte Enter para continuar");
                        Console.ReadLine();
                        break;
                    
                    //POTENCIA
                    case 4:
                        Console.WriteLine(jogadores[vez] + " Escolheu: Potencia");

                        maiorVel = 0;
                        vencedor = 0;

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            analise = jogadores[i].GetCartasMao();
                            if (analise.Length > 0)
                            {
                                Carta analiseCard = jogadores[i].GetCarta();

                                if (analiseCard != null)
                                {

                                    Console.WriteLine(jogadores[i] + " Carta: ");
                                    Console.WriteLine(analiseCard);
                                    Console.WriteLine("Cilindradas = " + analiseCard.GetPotencia());
                                    Console.WriteLine();
                                    Carta temp = jogadores[i].GetCarta();
                                    int velTemp = temp.GetPotencia();
                                    if (velTemp > maiorVel)
                                    {
                                        maiorVel = velTemp;
                                        vencedor = jogadores[i].GetId();
                                    }

                                }
                            }
                        }

                        Console.WriteLine("Vencedor: " + jogadores[vencedor]);

                        cards = jogadores[vencedor].GetCartasMao();
                        cards = jogadores[vencedor].Ganhar(cards, jogadores);
                        jogadores[vencedor].SetMao(cards);

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            if (jogadores[vencedor].GetId() != jogadores[i].GetId())
                            {
                                cards = jogadores[i].GetCartasMao();
                                cards = jogadores[i].Perder(cards);
                                jogadores[i].SetMao(cards);
                            }
                        }

                        Console.WriteLine("Aperte Enter para continuar");
                        Console.ReadLine();
                        break;
                
                    //COMPRIMENTO
                    case 5:
                        Console.WriteLine(jogadores[vez] + " Escolheu: Comprimento");

                        maiorDouble = 0;
                        vencedor = 0;

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            analise = jogadores[i].GetCartasMao();
                            if (analise.Length > 0)
                            {
                                Carta analiseCard = jogadores[i].GetCarta();

                                if (analiseCard != null)
                                {

                                    Console.WriteLine(jogadores[i] + " Carta: ");
                                    Console.WriteLine(analiseCard);
                                    Console.WriteLine("0 a 100KM = " + analiseCard.GetZeroCem());
                                    Console.WriteLine();
                                    Carta temp = jogadores[i].GetCarta();
                                    double velTemp = temp.GetZeroCem();
                                    if (velTemp > maiorDouble)
                                    {
                                        maiorDouble = velTemp;
                                        vencedor = jogadores[i].GetId();
                                    }
                                }
                            }
                        }

                        Console.WriteLine("Vencedor: " + jogadores[vencedor]);

                        cards = jogadores[vencedor].GetCartasMao();
                        cards = jogadores[vencedor].Ganhar(cards, jogadores);
                        jogadores[vencedor].SetMao(cards);

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            if (jogadores[vencedor].GetId() != jogadores[i].GetId())
                            {
                                cards = jogadores[i].GetCartasMao();
                                cards = jogadores[i].Perder(cards);
                                jogadores[i].SetMao(cards);
                            }
                        }

                        Console.WriteLine("Aperte Enter para continuar");
                        Console.ReadLine();
                        break;
             
                    //PESO
                    case 6:
                        Console.WriteLine(jogadores[vez] + " Escolheu: Peso");

                        maiorVel = 0;
                        vencedor = 0;

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            analise = jogadores[i].GetCartasMao();
                            if (analise.Length > 0)
                            {
                                Carta analiseCard = jogadores[i].GetCarta();

                                if (analiseCard != null)
                                {

                                    Console.WriteLine(jogadores[i] + " Carta: ");
                                    Console.WriteLine(analiseCard);
                                    Console.WriteLine("Cilindradas = " + analiseCard.GetPeso());
                                    Console.WriteLine();
                                    Carta temp = jogadores[i].GetCarta();
                                    int velTemp = temp.GetPeso();
                                    if (velTemp > maiorVel)
                                    {
                                        maiorVel = velTemp;
                                        vencedor = jogadores[i].GetId();
                                    }
                                }
                            }
                        }

                        Console.WriteLine("Vencedor: " + jogadores[vencedor]);

                        cards = jogadores[vencedor].GetCartasMao();
                        cards = jogadores[vencedor].Ganhar(cards, jogadores);
                        jogadores[vencedor].SetMao(cards);

                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            if (jogadores[vencedor].GetId() != jogadores[i].GetId())
                            {
                                cards = jogadores[i].GetCartasMao();
                                cards = jogadores[i].Perder(cards);
                                jogadores[i].SetMao(cards);
                            }
                        }
                        Console.WriteLine("Aperte Enter para continuar");
                        Console.ReadLine();
                        break;
                    
                    default:
                        Console.WriteLine("Escolher um numero valido");
                    break;
                 
                }
            }
        }

        //escolha de jogadores humanos e nao-humanos
        public Jogador[] CriarJogadores()
        {
            int num_players, num_hm;

            Console.Write("Quantos jogadores ao total? ");
            num_players = int.Parse(Console.ReadLine());

            while (num_players > 8 || num_players < 2)
            {
                Console.Clear();
                Console.WriteLine("Número de jogadores ínvalido.");
                Console.Write("Por favor, escolha de 2 até 8 jogadores: ");
                num_players = int.Parse(Console.ReadLine());
            }


            Console.Write("Quantos jogadores humanos? ");
            num_hm = int.Parse(Console.ReadLine());

            while (num_hm > num_players || num_hm < 1)
            {
                Console.Clear();
                Console.WriteLine("Número de jogadores: " + num_players);
                Console.WriteLine();
                Console.Write("Por favor, escolha um número de jogadores humanos válido: ");
                num_hm = int.Parse(Console.ReadLine());
            }

            Jogador[] players = new Jogador[num_players];

            for (int i = 0; i < num_players; i++)
            {
                if (i < num_hm)
                {
                    string nome;
                    Console.Write("Escolha o nome para o jogador " + (i + 1) + " : ");
                    nome = Console.ReadLine();

                    Jogador temp = new Jogador(i, nome, true);
                    players[i] = temp;
                }

                else
                {
                    Jogador botlist = new Jogador(99, "botlist", false);
                    string[] nomesbots = botlist.BotsNomes();
                    string nome = nomesbots[i - num_hm];
                    Jogador temp = new Jogador(i, nome, false);
                    players[i] = temp;
                }
            }

            return players;
        }

    }
}
