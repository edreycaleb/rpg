using System;
using System.Collections.Generic;
using System.Text;

namespace rpg
{
    internal class scene1
    {
        public void cena1()
        {
            backend T = new backend();
            switch (Datag.clas)
            {
                case 1:
                     Datag.ha = Datag.hero[0];

                    T.Falar("Você chega na capital do império...",
                        "Proucurando por uma estalagem, para descansar da viagem de 2 meses...",
                        "Chegando na estalagem, você pega o quarto mais barato...",
                        "Então você desce e senta no balcão do bar...",
                        "Pede uma cerveja e escuta atentamente o que está sendo comentado...",
                        "'Ficou sabendo o que aconteceu com o grande sábio?...'",
                        "'Sim, que a esposa dele foi assassinada...'",
                        "'Essa parte todo mundo sabe, mas você nunca parou para pensar que...'",
                        "'Como a maga mais poderosa do império foi morta tão facilmente?'",
                        "'Não faz sentido....'",
                        "'Exatamente. Por isso, parece que o grande sábio Getúlio está esperando por alguém na torre...'",
                        "'Dizem que é a pessoa que vai encontrar o assassino...'",
                        "'Mas ela não morreu há 10 anos?'",
                        "'Sim, mas estão dizendo por aí que o sábio enlouqueceu...'",
                        "'Então ele não tá diferenciando ninguém...'",
                        "'Isso, é aí que podemos pegar um bom dinheiro, se dermos informações falsas aquele velho maluco kkkk ...'");

                    T.borda("Depois de ouvir a conversa, você descobriu algo importante, o que vai fazer?",
                        "\n------------------------------------------------------------------------------\n",
                        "1. Confrontar os bandidos e tentar tirar mais informações.",
                        "2. Sair do bar e seguir eles até o destino");

                    var option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Datag.va = Datag.villain[0];

                            T.Falar("Você decide confrontar os bandidos e tentar tirar mais informações...",
                                "Você se aproxima deles e pergunta onde fica a torre...",
                                "Eles ficam surpresos com a sua ousadia, mandando você se fuder...",
                                "Vocês discutem...",
                                "Um deles saca a espada...",
                                "O outro segura a empunhura atrás de você...",
                                "Uma luta é inevitável..."
                                );

                            while (Datag.va.Health > 0 && Datag.ha.Health > 0)
                            {
                                T.borda($"Sua vida: {Datag.ha.Health}\n",
                                      $"Vida dos inimigos: {Datag.va.Health}",
                                      "\n-------------------------\n",
                                      "Escolha uma ação:",
                                      "1. Corte rápido diagonal (+vel)",
                                      "2. Corte forte forte vertical (+for)",
                                      "3. Estocada");

                                var action = Convert.ToInt16(Console.ReadLine());
                                switch (action)
                                {
                                    case 1:
                                        T.Falar("Você foi mais rápido que eles...",
                                              "faz um corte rápido na diagonal em ambos...",
                                              "Causando 35 de dano...");


                                        Datag.va.Health -= 35;
                                        Datag.s++;
                                        break;

                                    case 2:
                                        T.Falar("Você foi mais forte que eles...",
                                              "faz um corte forte vertical em ambos...",
                                              "Causando 75 de dano...");

                                        Datag.va.Health -= 75;
                                        Datag.p++;
                                        break;

                                    case 3:
                                        T.Falar("Você fez uma estocada precisa...",
                                              "Causando 50 de dano...");

                                        Datag.va.Health -= 50;
                                        break;

                                    default:
                                        T.borda("Opção inválida. Por favor, reinicie o jogo e escolha uma opção válida.");
                                        return;
                                }


                            }

                            if (Datag.s >= 3)
                            {
                                T.Falar("Você testou sua velocidade muitas vezes, agora seu corpo está mais acostumado e ficando mais leve...",
                                    "+10 de velocidade...");
                                Datag.ha.Speed += 10;
                            }

                            if (Datag.p >= 3)
                            {
                                T.Falar("Você testou sua força muitas vezes, agora seu corpo está mais rígido e ficando mais forte...",
                                    "+10 de força...");
                                Datag.ha.Power += 10;
                            }
                            Console.Clear();
                            T.Falar("Você derrotou os bandidos...", "Agora a vida deles está em suas mãos...");
                            T.borda("Você vai mata-lós (1) ou deixá-los viver (2)?");
                            int decision = Convert.ToInt16(Console.ReadLine());
                            switch (decision)
                            {
                                case 1:
                                    Console.Clear();
                                   T.Falar("Você coloca um em cima do outro...",
                                            "Pega a sua espada...",
                                            "Perfura o peito do primeiro...",
                                            "Você sente a carne se rompendo e a vida se esvaindo...",
                                            "Mesmo assim você continua...",
                                            "E perfura o coração do segundo...",
                                            "Aqueles homens nunca mais vão pensar, respirar, sentir...",
                                            "Assim como a vida era antes de nascerem...",
                                            "tudo o que viram e sentiram não serviu de nada...",
                                            "Se serão lembrados ou esquecidos, isso de nada importa para eles agora...",
                                            "Tudo o que eles tinham foi tirado por você...",
                                            "Sendo eles bons ou maus, agora são apenas carne morta...",
                                            "Isso irá te condenar até você encontrar o mesmo destino que eles...",
                                            "- 15 de sanidade",
                                            "Você pega o mapa que estava no bolso de um deles...",
                                            "Parece ser o mapa do caminho até a torre...",
                                            "Mesmo pertubado, você segue em frente...",
                                            "Enfim chega até a torre...",
                                            "Ela não parece tão assustadora...", "Ou será que você perdeu o senso de perigo?...",
                                            "Coisas assim não importam agora...",
                                            "Então você entra na torre");
                                    Datag.va.Sanity -= 15;
                                    break;
                                case 2:
                                    T.Falar("Você decide poupar a vida dos bandidos...",
                                        "Ele te dão o mapa do caminho até a torre...",
                                        "Com ele, você pode encontrar o caminho para a torre e descobrir o que aconteceu com esse tal Getúlio...",
                                        "Então você vai imediatamente para a torre...",
                                        "Você chega até a torre",
                                        "Sente uma sensação de perigo...",
                                        "Mas ao mesmo tempo sente que está mais forte que antes...",
                                        "Com confiança, você entra na torre...");
                                    break;
                                default:
                                 T.borda("Opção inválida. Por favor, reinicie o jogo e escolha uma opção válida.");
                                    return;

                            }
                            break;
                        case 2:
                            T.borda("Você segue eles...",
                                "Eles te levam até a base de uma torre na floresta...",
                                "Depois de montar os mantimentos, eles vão embora...",
                                "Você está de frente para a torre...",
                                "A sensação de perigo é intensa...",
                                "Mas ainda assim, você decide avançar...");
                            break;
                        default:
                            T.borda("Opção inválida. Por favor, reinicie o jogo e escolha uma opção válida.");
                            return;
                    }
                    break;
                case 2:
                    T.borda("Você é um Mago, e sua jornada começa agora...");
                    break;
                case 3:
                    T.borda("Você é um Arqueiro, e sua jornada começa agora...");
                    break;
            }
        }
    }
}
