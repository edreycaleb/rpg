using System;
using System.Collections.Generic;
using System.Text;

namespace rpg
{
    public class scene1
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

                    int option = Convert.ToInt32(Console.ReadLine());
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
                                              "Causando 20 de dano...");


                                        Datag.va.Health -= 20;
                                        Datag.s++;
                                        break;

                                    case 2:
                                        T.Falar("Você foi mais forte que eles...",
                                              "faz um corte forte vertical em ambos...",
                                              "Causando 50 de dano...");

                                        Datag.va.Health -= 50;
                                        Datag.p++;
                                        break;

                                    case 3:
                                        T.Falar("Você fez uma estocada precisa...",
                                              "Causando 35 de dano...");

                                        Datag.va.Health -= 35;
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
                    Datag.ha = Datag.hero[1];
                    Datag.va = Datag.villain[0];
                    T.Falar("Antes de você ir embora...",
                        "Seu pai te dá um mapa e diz:",
                        "'Onde quer que sua mãe esteja, ela estará com o colar que eu dei a ela'...",
                        "'Esse colar era especial'...",
                        "'Feito pelo lendário ferreiro e Rei dos Anões'...",
                        "'A pedra naquele colar é uma jóia nasílica'...",
                        "'Uma das últimas que ainda existem'...",
                        "'Ela tem uma propriedade especial'...",
                        "'A jóia atrai outras joias para si'...",
                        "'Mas apenas o Rei Anão possui outra dessa jóia'...",
                        "'Encontre-o e saberá o que fazer depois...'",
                        "'Boa sorte, minha criança!'...",
                        "Você abraça seu pai...",
                        "E vai na direção das montanhas, onde os anões vivem...",
                        "...",
                        "Chegando à base das montanhas...",
                        "Você encontra um bandido ameaçando uma criança anã...",
                        "Você decide ajudar a criança...",
                        "O bandido te vê...",
                        "Joga a criança para trás dele...",
                        "E saca a espada para te matar...",
                        "Surge uma luta entre um Mago e um Bandido...");

                    while (Datag.va.Health > 0 && Datag.ha.Health > 0)
                    {
                        T.borda("O que você vai fazer?",
                       $"Sua vida: {Datag.ha.Health}          Vida do Bandido: {Datag.va.Health}",
                       $"Sua mana: {Datag.ha.Mana}            Mana do Bandido: {Datag.va.Mana}",
                       $"Sua sanidade: {Datag.ha.Sanity}      Sanidade do Bandido: {Datag.va.Sanity}",
                       "\n----------------------------------------------------------------\n",
                       "1.Magia Elemental (-10 mana)(+magia Elemental)",
                       "2.Magia Arcana (-20 mana)(+magia Arcana)",
                       "3.Feitiçaria (- 1 sanidade)(+feitiçaria) - não use");
                        int option2 = Convert.ToInt32(Console.ReadLine());
                        switch (option2)
                        {
                            case 1:
                                Console.Clear();
                                T.Falar("Você utiliza Magia Elemental ...",
                                    "Você sente o poder da natureza se manifestando em sua mão...",
                                    "Então, você lança uma rajada de vento no inimigo...",
                                    "Causando 30 de dano no bandido.");
                                Datag.va.Health -= 30;
                                Datag.ha.Mana -= 10;
                                Datag.mae++;
                                break;
                            case 2:
                                Console.Clear();
                                T.Falar("Você utiliza Magia Arcana ...",
                                "Você sente o poder dos ancestrais percorrendo o seu corpo...",
                                "Então, você acumula o poder de um raio de luz perfurante dos seus dedos...",
                                "Causando 60 de dano no bandido.");
                                Datag.va.Health -= 60;
                                Datag.ha.Mana -= 20;
                                Datag.maa++;
                                break;
                            case 3:
                                Console.Clear();
                                T.Falar("Você é invoca um poder que não deveria existir...",
                                "O poder preenche a sua cabeça...",
                                "####################################",
                                "Causando 20 de dano no bandido.");
                                Datag.va.Health -= 20;
                                Datag.ha.Sanity -= 1;
                                Datag.fet++;
                                break;
                        }
                    }
                    T.Falar("...");

                    if (Datag.mae >= 3)
                    {
                        T.Falar("Você testou sua magia elemental muitas vezes, agora a natureza preenche o seu corpo...",
                            "+10 de magia e +5 de bônus elemental...");
                        T.Falar("...");
                        Datag.ha.Magic += 10;
                    }
                    if (Datag.maa >= 3)
                    {
                        T.Falar("Você testou sua magia arcana muitas vezes, agora a energia dos ancestrais está comtigo...",
                            "+10 de magia e +5 de bônus arcano...");
                        T.Falar("...");
                        Datag.ha.Magic += 10;
                    }
                    if (Datag.fet >= 1)
                    {
                        T.Falar("Você usou feitiçaria, a ##### está presente em você agora...",
                            "+30 de bônus de feiticaria...");
                        T.Falar("...");
                    }

                    T.Falar("Você derrotou o bandido...",
                        "A vida dele está nas suas mãos...");
                    T.borda("O que você vai fazer?",
                        "1. Matar o bandido",
                        "2. Deixa-lo viver");

                    int option3 = Convert.ToInt32(Console.ReadLine());

                    if (Datag.fet > 0 && option3 == 2)
                    {
                        T.Falar("A escolha não é mais sua...",
                            "A ##### controla você...",
                            "Você não consegue evitar...",
                            "Por que você usou feitiçaria?...",
                            "Mesmo como o alerta...",
                            "Agora seu corpo sofre as consequências...",
                            "Ele se mexe sozinho...",
                            "Então...");
                        option3 = 1;
                    }

                    switch (option3)
                    {
                        case 1:
                            T.Falar("Você olha para o bandido caído no chão...",
                                "Ele implora por sua vida...",
                                "Diz que fez isso para sobreviver...",
                                "Chora por sua mulher e filhos...",
                                "Você aproxima a sua mão da cabeça dele...",
                                "Você explode o crânio do bandido...",
                                "Nem a família iria o reconhecer...",
                                "Assim que você termina, percebe que tinha alguém olhando o tempo todo...",
                                "Era a criança...",
                                "Ela tem medo de você...",
                                "- 15 de sanidade",
                                "...",
                                "Você tenta conversar com ela, mas...",
                                "O pai dela chega...",
                                "Com uma comitiva...",
                                "Nesse momento, você olha para ela...",
                                "Então ela se revela...",
                                "'Sou Makala, a princesa Anã...'",
                                "'Venha! Os anões sempre recompensam aqueles que os ajudam...'",
                                "'Até mesmo os monstros...'");
                            break;
                        case 2:
                            T.Falar("Você decide poupar o bandido...",
                                "Ele agradece e promete nunca mais fazer isso de novo...",
                                "Correndo para longe, atrás de sua família...",
                                "Então você percebe a criança olhando para você...",
                                "Ela admira você...",
                                "...",
                                "Você tenta conversar com ela, mas...",
                                "O pai dela chega...",
                                "Com uma comitiva...",
                                "Nesse momento, você olha para ela...",
                                "Então ela se revela...",
                                "'Sou Makala, a princesa Anã...'",
                                "'Venha! Os anões sempre recompensam aqueles que os ajudam...'",
                                "'Ainda mais aqueles bondosos...'");
                            break;
                    }

                        break;
                case 3:
                    Datag.va = Datag.villain[0];
                    Datag.ha = Datag.hero[2];
                    T.Falar("Então...",
                    "Com essa dúvida em mente, você decide se aventurar pelo mundo...",
                    "Assim, você cavalga por semanas...",
                    "Então chega a uma vila...",
                    "Vila essa que era bem pobre...",
                    "Você caminha pela vila...",
                    "Percebendo que ela estava muito vazia...",
                    "Então você avista um bandido tentando roubar uma senhora...",
                    "Você grita:",
                    "'EI! Deixa ela em paz!'",
                    "O bandido olha para você, meio surpreso...",
                    "Confuso ele pergunta:",
                    "'Quem é você?'",
                    $"'Eu sou {Datag.name},um viajante, agora deixe essa senhora ir...'",
                    "'Ata kkkk'",
                    "'Que susto...'",
                    "'Achei que você era alguém do império kkkkk'...",
                    "'Bom...'",
                    "'Já que não é o caso...'",
                    "'Você vai morrer hoje...'",
                    "O bandido saca a espada...",
                    "Uma luta vai começar...");
                    while (Datag.va.Health > 0 && Datag.ha.Health > 0)
                    {
                        T.borda("O que você vai fazer?",
                        $"Sua vida: {Datag.ha.Health}           Vida do Bandido: {Datag.va.Health}",
                        $"Sua velocidade: {Datag.ha.Speed}      Velocidade do Bandido: {Datag.va.Speed}",
                        "\n----------------------------------------------------------------\n",
                        "1. Atirar flechas rápidas (+vel)",
                        "2. Atirar flecha poderosa (+for)",
                        "3. Atirar flecha precisa");

                        int option4 = Convert.ToInt32(Console.ReadLine());

                        switch (option4)
                        {
                            case 1:
                                T.Falar("Você pega flechas curtas...",
                                    "Dão menos dano, mas são mais rápidas...",
                                    "Causando 20 de dano no bandido...");
                                Datag.va.Health -= 20;
                                Datag.s++;
                                break;
                            case 2:
                                T.Falar("Você pega uma flecha longa e afiada...",
                                    "Precisa de muita força, mas causa mais dano...",
                                    "Causando 35 de dano no bandido...");
                                Datag.va.Health -= 35;
                                Datag.p++;
                                break;
                            case 3:
                                if (Datag.cont % 3 == 0)
                                {
                                    T.Falar("Você deu uma grande brecha para o bandido...",
                                        "Ainda não é o momento de usar a flecha reforçada...",
                                        "Tente outra flecha...",
                                        "Sofreu 15 de dano...");
                                    Datag.ha.Health -= 15;
                                    break;
                                }
                                T.Falar("Você pega uma flecha reforçada...",
                                    "Ela é única...",
                                    "Feita especialmente pelo seu pai...",
                                    "Mas você precisa de mais força e velocidade para conseguir usá-la...",
                                    "Utilize outra flecha...");
                                Datag.cont++;

                                break;

                        }
                    }

                    T.Falar("...");

                    if (Datag.s >= 3)
                    {
                        T.Falar("Você testou sua velocidade muitas vezes, agora seu corpo está mais leve...",
                            "+10 de velocidade...");
                        T.Falar("...");
                        Datag.ha.Speed += 10;
                    }
                    if (Datag.p >= 3)
                    {
                        T.Falar("Você testou sua força muitas vezes, agora seu corpo está mais forte...",
                            "+10 de força...");
                        T.Falar("...");
                        Datag.ha.Power += 10;
                    }

                    T.Falar("Você derrotou o bandido...",
                        "A vida dele está nas suas mãos...");

                    T.borda("O que você vai fazer?",
                        "1. Matar o bandido",
                        "2. Deixa-lo viver");
                    int option5 = Convert.ToInt32(Console.ReadLine());

                    switch (option5)
                    {
                        case 1:
                            T.Falar("Você olha para o bandido caído no chão...",
                                "Ele implora por sua vida...",
                                "Diz que foi obrigado a fazer isso...",
                                "Chora pedindo piedade...",
                                "A senhora idosa diz que já foi o suficiente...",
                                "Mas você não para...",
                                "Você pega uma flecha...",
                                "E enfia na cabeça do bandido...",
                                "A vida dele se esvai...",
                                "Ele nunca mais verá o Sol...",
                                "Ou sentir a chuva",
                                "Nunca mais conseguirá pensar...",
                                "A existência dele acabou...",
                                "Você fez isso...",
                                "...",
                                "A senhora diz:",
                                "'ele era apenas um empregado...'",
                                "'Não tinha necessidade de matá-lo'...",
                                "'Se quer matar alguém, deveria matar o chefe dele...'",
                                "'Esse sim merece a morte...'",
                                "'Você matou apenas um homem que seguia ordens para sobreviver...'",
                                "'Ele não me mataria...'",
                                "'Faça algo direito e vá matar quem realmente merece...'",
                                "'Seu Assassino'",
                                " - 15 de sanidade");
                            Datag.ha.Sanity -= 15;
                            break;
                        case 2:
                            T.Falar("Você decide poupar o bandido...",
                                "Ele agradece e diz que apenas seguia ordens...",
                                "O verdadeiro bandido ali é o chefe dele...",
                                "Você sente que deveria conhecer esse tal chefe bandido...",
                                "'Me leve até ele'...",
                                "'Ok, me siga'...");
                       
                            break;
                    }





                    break;   
            }
        }
    }
}
