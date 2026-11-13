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
                                        Console.Clear();
                                        T.Falar("Você foi \u001b[38;5;159m mais rápido\u001b[0m que eles...",
                                              "faz um \u001b[38;5;159m corte rápido\u001b[0m na diagonal em ambos...",
                                              "\u001b[38;5;160mCausando 20 de dano...\u001b[0m");


                                        Datag.va.Health -= 20;
                                        Datag.s++;
                                        break;

                                    case 2:
                                        Console.Clear();
                                        T.Falar("Você foi \u001b[34m mais forte\u001b[0m que eles...",
                                              "faz um \u001b[34m corte forte vertical\u001b[0m em ambos...",
                                              "\u001b[31mCausando 50 de dano...\u001b[0m");

                                        Datag.va.Health -= 50;
                                        Datag.p++;
                                        break;

                                    case 3:
                                        Console.Clear();
                                        T.Falar("\u001b[38;5;33mVocê fez uma estocada precisa...\u001b[0m",
                                              "\u001b[31mCausando 35 de dano...\u001b[0m");

                                        Datag.va.Health -= 35;
                                        break;

                                    default:
                                        Console.Clear();
                                        T.borda("Opção inválida.");
                                        if (Datag.va.Health > 0)
                                        {
                                            Console.Clear();
                                            T.Falar("\u001b[38;5;195mVocê errou o ataque e ficou vulnerável...\u001b[0m",
                                                "\u001b[38;5;195mOs inimigos aproveitam a oportunidade e te atacam...\u001b[0m",
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
                            T.borda("\u001b[31m\u001b[5mVocê vai matá-los (1)\u001b[0m\u001b[0m ou \u001b[5m\u001b[96mdeixá-los viver (2)?\u001b[0m\u001b[0m");
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
                                            "\u001b[35mEntão você entra na torre\u001b[0m");
                                    Datag.va.Sanity -= 15;
                                    break;
                                case 2:
                                    T.Falar("Você decide poupar a vida dos bandidos...",
                                        "Eles te agradecem de joelhos...",
                                        "E te dão \u001b[38;5;220mo mapa da torre\u001b[0m, como forma de agradecimento...",
                                        "Com ele, você pode encontrar \u001b[32mo caminho para a torre\u001b[0m e descobrir o que aconteceu com esse tal \u001b[0mGetúlio\u001b[0m...",
                                        "Então você vai imediatamente para \u001b[35ma torre.\u001b[0m..",
                                        "Você chega até \u001b[35ma torre\u001b[0m",
                                        "Sente uma sensação de \u001b[31mperigo...\u001b[0m",
                                        "Mas ao mesmo tempo sente que está \u001b[38;5;159mmais forte que antes\u001b[0m...",
                                        "Com confiança, você \u001b[35mentra na torre...\u001b[0m");
                                    break;
                                default:
                                 T.borda("Opção inválida. Por favor, reinicie o jogo e escolha uma opção válida.");
                                    return;

                            }
                            break;
                        case 2:
                            T.Falar("Você segue eles...",
                                "Eles te levam até \u001b[32ma base de uma torre\u001b[0m na floresta...",
                                "Depois de montar os mantimentos, eles vão embora...",
                                "Você está de frente para \u001b[35ma torre\u001b[0m...",
                                "\u001b[31mA sensação de perigo é intensa...\u001b[0m",
                                "Mas ainda assim, \u001b[35mvocê decide avançar...\u001b[0m");
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
                        "Seu pai te dá \u001b[32mum mapa\u001b[0m e diz:",
                        "'Onde quer que sua mãe esteja, ela estará com \u001b[38;5;220mo colar\u001b[0m que eu dei a ela'...",
                        "'\u001b[38;2;255;20;147mEsse colar era especial'\u001b[0m...",
                        $"'Feito pelo {T.rb("Ferreiro Lendário e Rei dos Anões")}'...",
                        "'A pedra naquele colar é uma \u001b[38;2;255;55;95mjóia nasílica\u001b[0m'...",
                        "'Uma das \u001b[32múltimas que ainda existem\u001b[0m'...",
                        "'Ela tem uma \u001b[38;5;159mpropriedade especial\u001b[0m'...",
                        "'A jóia atrai outras joias para si'...",
                        $"'Mas apenas {T.rb("o Rei Anão")} possui outra dessa jóia'...",
                        "'\u001b[32mEncontre-o\u001b[0m e saberá o que fazer depois...'",
                        "'\u001b[38;5;33mBoa sorte, minha criança!'\u001b[0m",
                        "Você abraça seu pai...",
                        "E vai na direção das montanhas, onde os anões vivem...",
                        "...",
                        "Chegando à base das montanhas...",
                        "Você encontra \u001b[91mum bandido\u001b[0m ameaçando uma criança anã...",
                        "Você decide \u001b[92majudar a criança\u001b[0m...",
                        "\u001b[91mO bandido te vê...\u001b[0m",
                        "Joga a criança para trás dele...",
                        "E \u001b[91msaca a espada\u001b[0m para te matar...",
                        "\u001b[95mSurge uma luta entre um Mago e um Bandido...\u001b[0m");

                    while (Datag.va.Health > 0 && Datag.ha.Health > 0)
                    {
                        T.borda("O que você vai fazer?",
                       $"Sua vida: \u001b[92m{Datag.ha.Health}\u001b[0m        Vida do Bandido: \u001b[38;5;160m{Datag.va.Health}\u001b[0m",
                       $"Sua mana: \u001b[94m{Datag.ha.Mana}\u001b[0m            Mana do Bandido: \u001b[340m{Datag.va.Mana}\u001b[0m",
                       $"Sua sanidade: \u001b[38;2;210;105;30m{Datag.ha.Sanity}\u001b[0m      Sanidade do Bandido: \u001b[38;5;179m{Datag.va.Sanity}\u001b[0m",
                       "\n----------------------------------------------------------------\n",
                       "\u001b[5m\u001b[38;2;40;255;110m1.Magia Elemental\u001b[0m \u001b[38;2;255;60;60m(-10 mana)\u001b[0m \u001b[38;2;152;251;152m(+magia Elemental)\u001b[0m\u001b[0m",
                       "\u001b[5m\u001b[38;2;65;145;220m2.Magia Arcana\u001b[0m \u001b[38;2;255;60;60m(-20 mana)\u001b[0m \u001b[38;5;159m(+magia Arcana)\u001b[0m\u001b[0m",
                       "\u001b[5m\u001b[38;2;186;85;211m3.Feitiçaria\u001b[0m \u001b[38;2;255;60;60m(- 1 sanidade)\u001b[0m \u001b[38;2;210;150;255m(+feitiçaria)\u001b[0m - \u001b[1m\u001b[91mnão use\u001b[0m\u001b[0m\u001b[0m");
                        int option2 = Convert.ToInt32(Console.ReadLine());
                        switch (option2)
                        {
                            case 1:
                                Console.Clear();
                                T.Falar("Você utiliza \u001b[38;2;40;255;110mMagia Elemental\u001b[0m ...",
                                    "Você sente \u001b[38;2;40;255;110mo poder da natureza\u001b[0m se manifestando em sua mão...",
                                    "Então, você lança \u001b[38;2;152;251;152muma rajada de vento\u001b[0m no inimigo...",
                                    "\u001b[38;2;255;60;60mCausando 30 de dano no bandido\u001b[0m");
                                Datag.va.Health -= 30;
                                Datag.ha.Mana -= 10;
                                Datag.mae++;
                                break;
                            case 2:
                                Console.Clear();
                                T.Falar("Você utiliza \u001b[38;2;65;145;220mMagia Arcana\u001b[0m ...",
                                "Você sente \u001b[38;2;255;255;255mo poder dos ancestrais\u001b[0m percorrendo o seu corpo...",
                                "Então, você acumula o poder de\u001b[38;5;159m um raio de luz perfurante\u001b[0m na ponta dos seus dedos...",
                                "\u001b[38;2;255;60;60mCausando 60 de dano no bandido\u001b[0m");
                                Datag.va.Health -= 60;
                                Datag.ha.Mana -= 20;
                                Datag.maa++;
                                break;
                            case 3:
                                Console.Clear();
                                T.Falar("\u001b[38;2;186;85;211mVocê invoca um poder que não deveria existir...\u001b[0m",
                                "\u001b[38;2;186;85;211mO poder preenche a sua cabeça...\u001b[0m",
                                "####################################",
                                "\u001b[38;2;255;60;60mCausando 20 de dano no bandido\u001b[0m");
                                Datag.va.Health -= 20;
                                Datag.ha.Sanity -= 1;
                                Datag.fet++;
                                break;
                        }
                    }
                    T.Falar("...");

                    if (Datag.mae >= 3)
                    {
                        T.Falar("Você testou sua \u001b[38;2;152;251;152mmagia elemental\u001b[0m muitas vezes, agora a natureza preenche o seu corpo...",
                            "\u001b[1m+10 de magia e +5 de bônus elemental\u001b[0m");
                        T.Falar("...");
                        Datag.ha.Magic += 10;
                    }
                    if (Datag.maa >= 3)
                    {
                        T.Falar("Você testou sua \u001b[38;5;159mmagia arcana\u001b[0m muitas vezes, agora a energia dos ancestrais está comtigo...",
                            "\u001b[1m+10 de magia e +5 de bônus arcano\u001b[0m");
                        T.Falar("...");
                        Datag.ha.Magic += 10;
                    }
                    if (Datag.fet >= 1)
                    {
                        T.Falar("Você usou \u001b[38;2;186;85;211mfeitiçaria\u001b[0m, a \u001b[0m\u001b[0m#####\u001b[0m\u001b[0m está presente em você agora...",
                            "\u001b[1m+30 de bônus de feiticaria\u001b[0m");
                        T.Falar("...");
                    }

                    T.Falar("\u001b[38;2;240;255;45mVocê derrotou o bandido!\u001b[0m",
                        "\u001b[92mA vida dele\u001b[0m está \u001b[91mnas suas mãos\u001b[0m...");
                    T.borda("\u001b[38;5;195mO que você vai fazer?\u001b[0m",
                        "\u001b[5m\u001b[38;2;165;15;25m1. Matar o bandido\u001b[0m\u001b[0m",
                        "\u001b[5m\u001b[38;2;165;250;195m2. Deixa-lo viver\u001b[0m\u001b[0m");

                    int option3 = Convert.ToInt32(Console.ReadLine());

                    if (Datag.fet > 0 && option3 == 2) 
                    {
                        T.tremor("\u001b[91mA escolha não é mais sua\u001b[0m",
                            "\u001b[38;2;186;85;211mA ##### controla você\u001b[0m",
                            "\u001b[38;2;186;85;211mVocê não consegue evitar\u001b[0m",
                            "\u001b[38;2;255;60;60mPor que você usou feitiçaria?\u001b[0m",
                            "\u001b[38;2;255;60;60mEu tentei te avisar\u001b[0m",
                            "\u001b[38;2;255;60;60mAgora seu corpo vai sofrer as consequências\u001b[0m",
                            "\u001b[38;2;186;85;211mEle se mexe sozinho\u001b[0m",
                            "\u001b[38;2;186;85;211mEntão\u001b[0m");
                        option3 = 1;
                    }

                    
                    switch (option3)
                    {
                        case 1:
                            T.Falar("\u001b[38;2;255;60;60mVocê olha para o bandido caído no chão...\u001b[0m",
                                "\u001b[38;2;165;15;25mEle implora por sua vida...\u001b[0m",
                                "\u001b[38;2;165;15;25mDiz que fez isso para sobreviver...\u001b[0m",
                                "\u001b[38;2;165;15;25mChora por sua mulher e filhos...\u001b[0m",
                                "\u001b[38;2;255;60;60mVocê aproxima a sua mão da cabeça dele...\u001b[0m",
                                "\u001b[38;2;165;15;25mExplodindo o crânio do bandido...\u001b[0m",
                                "\u001b[38;2;165;15;25mNem a família dele iria o reconhecer...\u001b[0m",
                                "Assim que você termina, percebe que \u001b[38;2;255;60;60mtinha alguém olhando o tempo todo\u001b[0m...",
                                "\u001b[38;2;165;15;25mEra a criança...\u001b[0m",
                                "\u001b[38;2;165;15;25mEla sente nojo de você...\u001b[0m",
                                "\u001b[38;2;210;105;30m- 15 de sanidade\u001b[0m",
                                "...",
                                "Você tenta conversar com ela, \u001b[92mmas...\u001b[0m",
                                $"{T.rb("O pai")} dela chega...",
                                "Com uma comitiva...",    
                                "Nesse momento, você olha para ela...",
                                "\u001b[38;2;165;250;195mEntão ela se revela...\u001b[0m",
                                "'Sou Makala, \u001b[38;2;255;20;147ma princesa Anã\u001b[0m...'",
                                "'Pode vir, os anões sempre recompensam aqueles que os ajudam...'",
                                "\u001b[38;2;165;15;25m'Até mesmo os monstros...'\u001b[0m");
                            break;
                        case 2:
                            T.Falar("Você decide poupar o bandido...",
                                "Ele agradece e promete \u001b[38;2;40;255;110mnunca mais\u001b[0m fazer isso de novo...",
                                "Correndo para longe, \u001b[38;2;40;255;110matrás de sua família\u001b[0m...",
                                "Então você percebe a criança olhando para você...",
                                "\u001b[38;2;165;250;195mEla admira você...\u001b[0m",
                                "...",
                                "Você tenta conversar com ela, \u001b[92mmas...\u001b[0m",
                                $"{T.rb("O pai")} dela chega...",
                                "Com uma comitiva...",
                                "Nesse momento, você olha para ela...",
                                "\u001b[38;2;165;250;195mEntão ela se revela...\u001b[0m",
                                "'Sou Makala, \u001b[38;2;255;20;147ma princesa Anã\u001b[0m...'",
                                "'Venha! Os anões sempre recompensam aqueles que os ajudam...'",
                                "\u001b[38;2;165;15;25m'Ainda mais aqueles de bão coração...'\u001b[0m");
                            break;
                    }

                        break;
                case 3:  
                    Datag.va = Datag.villain[0];
                    Datag.ha = Datag.hero[2];
                    T.Falar("Então...",
                    "Com essa dúvida em mente, você decide \u001b[92mse aventurar pelo mundo...\u001b[0m",
                    "Assim, você cavalga por semanas...",
                    "Então chega \u001b[38;5;137ma uma vila\u001b[0m...",
                    "Vila essa que era \u001b[38;2;85;107;47mbem pobre\u001b[0m...",
                    "Você caminha pela vila...",
                    "Percebendo que ela estava \u001b[38;5;195mmuito vazia\u001b[0m...",
                    "Então você avista \u001b[38;2;255;60;60mum bandido\u001b[0m tentando roubar uma senhora...",
                    "Você grita:",
                    "\u001b[38;2;255;220;30m'EI! Deixa ela em paz!'\u001b[0m",
                    "\u001b[91mO bandido olha para você\u001b[0m, meio surpreso...",
                    "Confuso ele pergunta:",
                    "\u001b[38;2;250;145;145m'Quem é você?'\u001b[0m",
                    $"\u001b[38;2;255;220;30m'Eu sou {Datag.name},um viajante, agora deixe essa senhora ir...'\u001b[0m",
                    "\u001b[38;2;250;145;145m'Ata kkkk'\u001b[0m",
                    "\u001b[38;2;250;145;145m'Que susto...'\u001b[0m",
                    "\u001b[38;2;250;145;145m'Achei que você era alguém do império kkkkk'...\u001b[0m",
                    "\u001b[38;2;250;145;145m'Bom...'\u001b[0m",
                    "\u001b[38;2;250;145;145m'Já que não é o caso...'\u001b[0m",
                    "\u001b[38;2;250;145;145m'Você vai morrer hoje...'\u001b[0m",
                    "O bandido \u001b[31msaca a espada\u001b[0m...",
                    "\u001b[38;2;255;60;60mUma luta vai começar...\u001b[0m");
                    while (Datag.va.Health > 0 && Datag.ha.Health > 0)
                    {
                        T.borda("O que você vai fazer?",
                        $"Sua vida: \u001b[92m{Datag.ha.Health}\u001b[0m           Vida do Bandido: \u001b[38;5;160m{Datag.va.Health}\u001b[0m",
                        $"Sua velocidade: \u001b[96m{Datag.ha.Speed}\u001b[0m      Velocidade do Bandido: \u001b[94m{Datag.va.Speed}\u001b[0m",
                        "\n----------------------------------------------------------------\n",
                        "\u001b[5m\u001b[38;5;159m1. Atirar flechas rápidas (+vel)\u001b[0m\u001b[0m",
                        "\u001b[5m\u001b[38;5;196m2. Atirar flecha poderosa (+for)\u001b[0m\u001b[0m",
                        "\u001b[5m\u001b[38;5;231m3. Atirar flecha precisa\u001b[0m\u001b[0m");

                        int option4 = Convert.ToInt32(Console.ReadLine());

                        switch (option4)
                        {
                            case 1:
                                T.Falar("Você pega \u001b[38;5;159mas flechas curtas\u001b[0m...",
                                    "Dão menos dano, \u001b[38;5;195mmas são mais rápidas\u001b[0m...",
                                    "\u001b[38;2;165;15;25mCausando 20 de dano no bandido\u001b[0m");
                                Datag.va.Health -= 20;
                                Datag.s++;
                                break;
                            case 2:
                                T.Falar("Você pega uma \u001b[38;5;196mflecha longa e afiada\u001b[0m...",
                                    "Precisa de muita força, \u001b[91mmas causa mais dano\u001b[0m...",
                                    "\u001b[38;2;165;15;25mCausando 35 de dano no bandido\u001b[0m");
                                Datag.va.Health -= 35;
                                Datag.p++;
                                break;
                            case 3:
                                if (Datag.cont % 3 == 0)
                                {
                                    T.Falar("\u001b[38;2;255;60;60mVocê deu uma grande brecha para o bandido...\u001b[0m",
                                        "\u001b[97mAinda não é o momento de usar a flecha reforçada...\u001b[0m",
                                        "\u001b[38;5;221mTente outra flecha...\u001b[0m",
                                        "\u001b[38;2;165;15;25mVocê sofreu 15 de dano\u001b[0m");
                                    Datag.ha.Health -= 15;
                                    break;
                                }
                                T.Falar("Você pega uma \u001b[38;5;231mflecha reforçada\u001b[0m...",
                                    "\u001b[38;2;230;245;255mEla é única...\u001b[0m",
                                    "Feita mespecialmente pelo \u001b[38;5;159mseu pai\u001b[0m...",
                                    "Mas você precisa de \u001b[38;5;196mmais força\u001b[0m e \u001b[38;5;159mvelocidade\u001b[0m para conseguir usá-la...",
                                    "\u001b[38;2;250;145;145mUtilize outra flecha\u001b[0m");
                                Datag.cont++;

                                break;

                        }
                    }

                    T.Falar("...");

                    if (Datag.s >= 3)
                    {
                        T.Falar("Você testou sua \u001b[38;5;159mvelocidade muitas vezes\u001b[0m, agora seu \u001b[38;5;195mcorpo está mais leve\u001b[0m...",
                            "\u001b[94m+10 de velocidade\u001b[0m");
                        T.Falar("...");
                        Datag.ha.Speed += 10;
                    }
                    if (Datag.p >= 3)
                    {
                        T.Falar("Você testou sua \u001b[38;5;196mforça muitas vezes\u001b[0m, agora seu \u001b[91mcorpo está mais forte\u001b[0m...",
                            "\u001b[38;2;255;105;180m+10 de força\u001b[0m");
                        T.Falar("...");
                        Datag.ha.Power += 10;
                    }

                    T.Falar("\u001b[38;5;221mVocê derrotou o bandido!\u001b[0m",
                        "\u001b[38;2;255;60;60mA vida dele está nas suas mãos\u001b[0m");

                    T.borda("\u001b[38;5;195mO que você vai fazer?\u001b[0m",
                        "\u001b[5m\u001b[38;2;165;15;25m1. Matar o bandido\u001b[0m\u001b[0m",
                        "\u001b[5m\u001b[38;2;255;225;25m2. Deixa-lo viver\u001b[0m\u001b[0m");
                    int option5 = Convert.ToInt32(Console.ReadLine());
                    // 38;2;165;15;25 - vermelho escuro
                    // 38;2;255;60;60 - vermelho claro
                    switch (option5)
                    {
                        case 1:
                            T.Falar("Você olha para o bandido caído no chão...",
                                "\u001b[38;2;255;60;60mEle implora por sua vida...\u001b[0m",
                                "\u001b[38;2;255;60;60mDiz que foi obrigado a fazer isso...\u001b[0m",
                                "\u001b[38;2;255;60;60mChora pedindo piedade...\u001b[0m",
                                "\u001b[38;2;255;60;60mA senhora idosa diz que já foi o suficiente...\u001b[0m",
                                "\u001b[38;2;165;15;25mMas você não para...\u001b[0m",
                                "Você puxa a corda do arco e dispara...",
                                "\u001b[38;2;165;15;25mA ponta de ferro rasga os olhos e perfura o crânio do bandido\u001b[0m",
                                "\u001b[38;2;255;60;60mA vida dele se esvai...\u001b[0m",
                                "\u001b[38;2;165;15;25mEle nunca mais verá o Sol...\u001b[0m",
                                "\u001b[38;2;255;60;60mOu sentir a chuva\u001b[0m",
                                "\u001b[38;2;255;60;60mNunca mais conseguirá pensar...\u001b[0m",
                                "\u001b[38;2;255;60;60mA existência dele acabou...\u001b[0m",
                                "\u001b[38;2;165;15;25mVocê fez isso...\u001b[0m",
                                "...",
                                "A senhora diz:",
                                "\u001b[38;2;115;130;150m'ele era apenas um empregado...'\u001b[0m",
                                "\u001b[38;2;115;130;150m'Não tinha necessidade de matá-lo'\u001b[0m...",
                                "\u001b[38;2;115;130;150m'Se quer matar alguém, devia matar o chefe dele...'\u001b[0m",
                                "\u001b[38;2;115;130;150m'Esse sim merece a morte...'\u001b[0m",
                                "\u001b[38;2;115;130;150m'Você apenas matou um homem que seguia ordens para sobreviver...'\u001b[0m",
                                "\u001b[38;2;115;130;150m'Ele não iria me matar...'\u001b[0m",
                                "\u001b[38;2;115;130;150m'Faça algo direito e vá matar quem realmente merece...'\u001b[0m",
                                "\u001b[38;2;165;15;25m'Seu Assassino'\u001b[0m",
                                "\u001b[38;2;210;105;30m - 15 de sanidade\u001b[0m");
                            Datag.ha.Sanity -= 15;
                            break;
                        case 2:
                            T.Falar("Você decide poupar o bandido...",
                                "Ele chora e diz que \u001b[32mapenas seguia ordens\u001b[0m...",
                                "O verdadeiro bandido ali é \u001b[38;5;196mo chefe dele\u001b[0m...",
                                "Você sente que deveria conhecer esse tal \u001b[31mchefe dos bandidos\u001b[0m...",
                                "\u001b[38;2;255;220;30m'Me leve até ele'\u001b[0m...",
                                "\u001b[95m'Ok, me siga'\u001b[0m...");
                       
                            break;
                    }





                    break;   
            }
        }
    }
}
