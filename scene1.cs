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

                    T.Falar("...",
                        "\u001b[38;5;118mDepois de um longo caminho...\u001b[0m",
                        "Você chega \u001b[94ma capital do Império\u001b[0m...",
                        "Proucurando por uma estalagem, para descansar da viagem de \u001b[3m2 meses\u001b[0m...",
                        "Chegando na estalagem, você pega o quarto mais barato...",
                        "Então você desce e senta no balcão do bar...",
                        "Pede uma cerveja e escuta atentamente o que está sendo conversado no bar...",
                        "\u001b[34m'Ficou sabendo o que aconteceu com o grande sábio?...'\u001b[0m",
                        "\u001b[32m'Que esposa dele foi assassinada? ...'\u001b[0m",
                        "\u001b[34m'Não porra, essa parte todo mundo sabe, você nunca parou para pensar...'\u001b[0m",
                        "\u001b[34m'Como a maga mais poderosa do império foi morta tão facilmente?'\u001b[0m",
                        "\u001b[32m'Nunca tinha pensado nesse bagulho ...'\u001b[0m",
                        "\u001b[34m'É por isso, que o velho sábio Getúlio está esperando por alguém na torre...'\u001b[0m",
                        "\u001b[34m'Tão falando que é a pessoa que vai encontrar o assassino...'\u001b[0m",
                        "\u001b[32m'Mas ela não morreu há mais de 10 anos?'\u001b[0m",
                        "\u001b[34m'É disso que eu tô falando, esse velho ficou gagá...'\u001b[0m",
                        "\u001b[32m'Aquele velho não deve estar reconhecendo nem a mulher morta dele kkkkk...'\u001b[0m",
                        "\u001b[34m'É aí que podemos pegar um bom dinheiro, só dar algumas informações falsas aquele velho maluco...'\u001b[0m",
                        "\u001b[34m'Pegamos a recompensa e vamos para zona kkkkkkk ...'\u001b[0m");

                    T.borda("Depois de ouvir a conversa, você descobriu algo importante, o que vai fazer?",
                        "\n------------------------------------------------------------------------------\n",
                        "\u001b[91m\u001b[5m1. Confrontar os bandidos e tentar tirar mais informações.\u001b[0m\u001b[0m",
                        "\u001b[96m\u001b[5m2. Sair do bar e seguir eles até o destino\u001b[0m\u001b[0m");

                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Datag.va = Datag.villain[0];

                            T.Falar("Você decide confrontar os bandidos e tentar tirar mais informações...",
                                "Você se aproxima deles e pergunta onde fica a torre...",
                                "Eles ficam surpresos com a sua ousadia, mandando \u001b[5mvocê se fuder\u001b[0m...",
                                "Vocês discutem...",
                                "Um deles \u001b[38;5;88msaca a espada\u001b[0m...",
                                "O outro \u001b[38;5;88msegura a empunhura atrás de você\u001b[0m...",
                                "\u001b[31mUma luta é inevitável...\u001b[0m"
                                );

                            while (Datag.va.Health > 0 && Datag.ha.Health > 0)
                            {
                                T.borda($"Sua vida: \u001b[32m{Datag.ha.Health}\u001b[0m\n",
                                      $"Vida dos Bandidos: \u001b[38;5;160m{Datag.va.Health}\u001b[0m",
                                      "\n-------------------------\n",
                                      "Escolha uma ação:",
                                      "\u001b[5m\u001b[38;5;159m1. Corte rápido diagonal (+vel)\u001b[0m\u001b[0m",
                                      "\u001b[5m\u001b[34m2. Corte forte forte vertical (+for)\u001b[0m\u001b[0m",
                                      "\u001b[5m\u001b[38;5;33m3. Estocada\u001b[0m\u001b[0m");

                                var action = Convert.ToInt16(Console.ReadLine());
                                switch (action)
                                {
                                    case 1:
                                        T.Falar("Você foi \u001b[38;5;159m mais rápido\u001b[0m que eles...",
                                              "faz um \u001b[38;5;159m corte rápido\u001b[0m na diagonal em ambos...",
                                              "\u001b[38;5;160mCausando 20 de dano...\u001b[0m");


                                        Datag.va.Health -= 20;
                                        Datag.s++;
                                        break;

                                    case 2:
                                        T.Falar("Você foi \u001b[34m mais forte\u001b[0m que eles...",
                                              "faz um \u001b[34m corte forte vertical\u001b[0m em ambos...",
                                              "\u001b[31mCausando 50 de dano...\u001b[0m");

                                        Datag.va.Health -= 50;
                                        Datag.p++;
                                        break;

                                    case 3:
                                        T.Falar("\u001b[38;5;33mVocê fez uma estocada precisa...\u001b[0m",
                                              "\u001b[31mCausando 35 de dano...\u001b[0m");

                                        Datag.va.Health -= 35;
                                        break;

                                    default:
                                        T.borda("Opção inválida.");
                                        if (Datag.va.Health > 0)
                                        {
                                            T.Falar("\u001b[97mVocê errou o ataque e ficou vulnerável...\u001b[0m",
                                                "\u001b[97mOs inimigos aproveitam a oportunidade e te atacam...\u001b[0m",
                                                "\u001b[31mVocê sente a dor... \n- 30 de vida\u001b[0m");
                                            Datag.ha.Health -= 30;
                                        }
                                        break;
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
                            T.Falar("\u001b[92mVocê derrotou os bandidos!\u001b[0m", "Agora \u001b[91ma vida\u001b[0m deles está nas suas mãos...");
                            T.borda("\u001b[31mVocê vai matá-los (1)\u001b[0m ou \u001b[96mdeixá-los viver (2)?\u001b[0m");
                            int decision = Convert.ToInt16(Console.ReadLine());
                            switch (decision)
                            {
                                case 1:
                                    Console.Clear();
                                   T.Falar("Você coloca um em cima do outro...",
                                            "\u001b[38;5;240mPega a sua espada...\u001b[0m",
                                            "\u001b[31mE perfura o peito do primeiro bandido...\u001b[0m",
                                            "\u001b[38;5;124mVocê sente a carne se rompendo e a vida se esvaindo...\u001b[0m",
                                            "Mesmo assim você continua...",
                                            "\u001b[38;5;124mAté a lâmina alcançar o coração do segundo bandido...\u001b[0m",
                                            "\u001b[38;5;124mVocê não mostrou piedade, nem mesmo quando eles imploraram por suas vidas...\u001b[0m",
                                            "\u001b[31mAqueles homens nunca mais vão pensar, respirar, sentir...\u001b[0m",
                                            "\u001b[31mAssim como a vida era antes de nascerem...\u001b[0m",
                                            "\u001b[31mtudo o que viram e sentiram não servirá de nada...\u001b[0m",
                                            "\u001b[31mSe serão lembrados ou esquecidos, isso de nada importa para eles agora...\u001b[0m",
                                            "\u001b[38;5;124mTudo o que eles tinham foi tirado \u001b[5m\u001b[1mpor você\u001b[0m\u001b[0m...\u001b[0m",
                                            "\u001b[31mSendo eles bons ou maus, agora são apenas carne morta...\u001b[0m",
                                            "\u001b[38;5;124mIsso irá te condenar até você encontrar o mesmo destino que eles...\u001b[0m",
                                            "\u001b[35m- 15 de sanidade\u001b[0m",
                                            "Você pega \u001b[92mo mapa\u001b[0m que estava no bolso de um deles...",
                                            "Parece ser \u001b[92mo mapa do caminho\u001b[0m até \u001b[35ma torre\u001b[0m...",
                                            "Mesmo pertubado, você segue em frente...",
                                            "Enfim chega até\u001b[35m a torre\u001b[0m...",
                                            "Ela não parece tão assustadora...", "Ou será que você perdeu \u001b[38;5;55mo senso de perigo?\u001b[0m...",
                                            "\u001b[38;5;208mCoisas assim não importam agora...\u001b[0m",
                                            "\u001b[32mEntão você entra na torre\u001b[0m");
                                    Datag.va.Sanity -= 15;
                                    break;
                                case 2:
                                    T.Falar("Você decide poupar a vida dos bandidos...",
                                        "Eles te agradecem de joelhos...",
                                        "E te dão o mapa da torre, como forma de agradecimento...",
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
                            T.Falar("Você segue eles...",
                                "Eles te levam até a base de uma torre na floresta...",
                                "Depois de montar os mantimentos, eles vão embora...",
                                "Você está de frente para a torre...",
                                "A sensação de perigo é intensa...",
                                "Mas ainda assim, você decide avançar...");
                            break;
                        default:
                            T.borda("Opção inválida. A vida não tem replay.");
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
