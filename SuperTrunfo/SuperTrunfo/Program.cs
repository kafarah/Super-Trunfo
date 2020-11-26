using System;

namespace SuperTrunfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciar o gerenciador
            Gerenciador b = new Gerenciador();

            int menu = 0;
            while (menu == 0)
            {
                Console.Clear();
                Console.WriteLine("---- SuperTrunfo 3000. O melhor Trunfo do Brasil ----");
                Console.WriteLine("--------------------- 1-Jogar -----------------------");
                Console.WriteLine("--------------------- 2-Regras ----------------------");
                Console.WriteLine("--------------------- 3-Cartas ----------------------");
                Console.WriteLine("--------------------- 0-Sair ------------------------");
                Console.WriteLine();
                Console.Write("O que voce deseja fazer? ");
                int select = int.Parse(Console.ReadLine());

                //JOGAR
                if (select == 1)
                {
                    //tirar o menu
                    Console.Clear();

                    Jogador[] jogadores = b.CriarJogadores();

                    Console.Clear();

                    //carregar cartas-vetor
                    Carta[] baralho = b.LoadCartas();
                    //funcao de embaralhar as cartas do vetor
                    baralho = b.Embaralhar(baralho);


                    for (int i = 0; i < jogadores.Length; i++)
                    {
                        Jogador temporario = jogadores[i];
                        temporario.PegarCartas(baralho, jogadores.Length);
                        jogadores[i] = temporario;

                    }

                    bool jogando = true;
                    int vez = 0;
                    int moreCards = 0;
                    //enquanto player == jogando 
                    //se ganhar-recebr cartas
                    //se perder-dar a carta e perder ela
                    while (jogando == true)
                    {


                        Carta[] temp = jogadores[vez].GetCartasMao();

                        int loses = 0;
                        for (int i = 0; i < jogadores.Length; i++)
                        {
                            Carta[] analise = jogadores[i].GetCartasMao();
                            Carta[] comparador = new Carta[0];

                            if (analise.Length < 1)
                            {

                                loses++;

                            }
                            else if (comparador.Length < analise.Length)
                            {

                                comparador = analise;
                                moreCards = i;
                            }

                        }

                        if (temp.Length == baralho.Length || (loses >= jogadores.Length - 1))
                        {

                            jogando = false;

                        }


                        b.Escolher(jogadores, vez);

                        vez++;

                        if (vez == jogadores.Length)
                        {
                            vez = 0;
                        }


                    }

                    Console.WriteLine("O Jogador " + jogadores[moreCards]);
                    Console.ReadLine();
                }

                //REGRAS
                else if (select == 2)
                {
                    Console.Clear();
                    Console.WriteLine("REGRAS:");
                    Console.WriteLine("");
                    Console.WriteLine("Objetivo: ganhar todas as cartas");
                    Console.WriteLine("");
                    Console.WriteLine("Escolha um atributo na sua vez para comparar com o do adversário,");
                    Console.WriteLine("o maior ganha a(s) carta(s) e mantem ela(s) em seu baralho");
                    Console.WriteLine("");


                    Console.ReadLine();


                }

                //CARTAS
                else if (select == 3)
                {
                    Console.Clear();
                    Console.WriteLine("CARTAS: ");
                    Console.WriteLine();

                    Carta[] baralho = b.LoadCartas();

                    baralho = b.Embaralhar(baralho);

                    for (int i = 0; i < 32; i++)
                    {
                        Console.WriteLine(baralho[i]);
                    }


                    Console.ReadLine();

                }

                else if (select == 0)
                {

                    menu = 1;

                }

                else
                {
                    Console.WriteLine("Opcao invalida!");
                    Console.ReadLine();
                }

            }

            Console.Clear();
            Console.WriteLine("Obrigado por jogar");
            Console.ReadLine();
        }
    }
}
