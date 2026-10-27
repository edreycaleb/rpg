namespace rpg;

using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int s=0, p=0, m=0, b=0, ma=0, sa=0;

        var bpw = new List<battle>
        {
            new battle{health = 120, speed = 30, sanity = 100, power = 55, bow = 0, magic = 0, mana = 0}
        };

        var bpm = new List<battle>
        {
            new battle{health = 100, speed = 10, sanity = 60, power = 10, bow = 0, magic = 65, mana = 100}
        };

        var bpa = new List<battle>
        {
            new battle{health = 75, speed = 70, sanity = 100, power = 30, bow = 75, magic = 0, mana = 0}
        };


        var bpv = new List<battle>
        {
            new battle{health = 150, speed = 20, sanity = 30, power = 30, bow = 0, magic = 0, mana = 0}
        };



        borda("Qual é o seu nome?");
        string name = Console.ReadLine();
        Console.Clear();

        borda($"Escolha a sua classe, {name}:\n 1 - Guerreiro\n 2 - Mago\n 3 - Arqueiro");
        int clas = Convert.ToInt16(Console.ReadLine());
        Console.Clear();

        switch (clas)
        {
            case 1:
                Falar(
                    "Você nasceu em um vilareijo no interior do Império de Pindorama...",
                    "Cresceu no orfanato...",
                    $"Recebeu o nome {name} daquele que era o dono do orfanato...",
                    "O qual foi um guerreiro muito poderoso no passado, porém teve que se aposentar após perder um dedo na guerra...",
                    "Assim criou o orfanato, para compensar as milhares de vidas que tirou enquanto caveleiro...",
                    $"Ele viu potencial em você {name} e decidiu te treinar...",
                    "Assim foi a sua infância, treinando todos os dias com o dono do orfanato...",
                    "Aprendendo a lutar e a sobreviver...",
                    "Até que um dia, algo inesperado aconteceu...",
                    "O dono do orfanato faleceu, deixando uma carta para você...",
                    "Nela dizia:",
                    "'Algo sombrio está correndo no império...'",
                    "'Eu, com o pouco poder que me restava, atrasei o desastre...'",
                    "'Mas agora, você é a única pessoa que pode salvar o império...'",
                    "'Eu te treinei para isso, e sei que você é capaz...'",
                    "'Vá até a capital do império, a cidade da Guanabara, e proucure um homem chamado Getúlio, ele te guiará...'",
                    "'Você não herda meu \u001b[31msangue\u001b[0m, mas te dou \u001b[33mminha vida\u001b[0m...'",
                    $"'\u001b[91mEu te amo, {name}...\u001b[0m'"
                );
                
                break;

            case 2:
                Falar(
                    "Você nasceu na capital do império de Pindorama, a cidade da Guanabara...",
                    "A cidade da Guanabara é conhecida por ser o centro comercial e intelectual do império...",
                    "É lá que você passou a sua juventude, aprendendo com os maiores intelectuais do império...",
                    "Seus pais eram magos muito poderosos, e te incentivaram a seguir o caminho da magia...",
                    "Porém...",
                    "\u001b[31mSua mãe foi assassinada...\u001b[0m",
                    "Seu pai ficou desvastado...",
                    "Sua mãe era a maga mais forte do império, ela não poderia ser morta por qualquer um...",
                    "Getúlio, seu pai, não pôde sair da capital. Por um pedido de um velho companheiro...",
                    "Então você precisa agir...",
                    $"\u001b[32m{name}, vingue a sua mãe!\u001b[0m"
                );
                break;

            case 3:
                Falar(
                    "Você nasceu na cidade do carvão e do ferro, as Minas Gerais...",
                    "A cidade das Minas Gerais é conhecida por ser o centro da indústria mineral do império de Pindorama...",
                    "Você cresceu em uma família de ferreiros...",
                    "Mas, nunca teve talento para ferraria...",
                    "Entretanto, você sempre amou testar os arcos que seu pai fazia...",
                    "Até que durante uma viagem comercial...",
                    "Que destinava-se a entregar um arco ao imperador Flávio...",
                    "A carruagem que estavam você e a sua família, \u001b[31mfoi atacada por uma quadrilha de bandidos...\u001b[0m",
                    "Você por reflexo pegou \u001b[97m o arco\u001b[0m e atirou contra os bandidos...",
                    "\u001b[31mMatando todos eles...\u001b[0m",
                    "Ao mesmo tempo que alguns te \u001b[36mlouvavam\u001b[0m, outros sentiam \u001b[34mmedo\u001b[0m de você...",
                    $"'{name}, quem nunca praticou arqueria verdadeiramente, apenas testava os arcos de seu pai...'",
                    "'Conseguiu matar uma quadrilha de bandidos, com apenas um arco, sem a ajuda de mais ninguém...'",
                    "Esses eram os pensamentos que dividiam a opinião sobre você...",
                    "Uns viram em você o nascimento de um \u001b[33msímbolo revolucionário\u001b[0m, que lutaria contra as \u001b[35msombras\u001b[0m...",
                    "Outros...",
                    "Um perigo para o império, que agora era governado pelas \u001b[35msombras...\u001b[0m",
                    "E assim, você precisa decidir o seu destino...",
                    $"{name}, você se tornará um \u001b[33mrevolucionário\u001b[0m?",
                    "Ou será parte das \u001b[35msombras\u001b[0m que governam o império?",
                    "\u001b[32mA decisão é sua...\u001b[0m"
                );
                break;

            default:
                borda("\u001b[32mClasse inválida. Por favor, reinicie o jogo e escolha uma classe válida.\u001b[0m");
                return; 
        }

        switch (clas)
        {
            case 1:
                Falar("Você chega na capital do império...", 
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

                borda("Depois de ouvir a conversa, você descobriu algo importante, o que vai fazer?",
                    "\n------------------------------------------------------------------------------\n",
                    "1. Confrontar os bandidos e tentar tirar mais informações.",
                    "2. Sair do bar e seguir eles até o destino");

                var option = Convert.ToInt16(Console.ReadLine());
                 switch (option)
                {
                    case 1:
                        Falar("Você decide confrontar os bandidos e tentar tirar mais informações...",
                            "Você se aproxima deles e pergunta onde fica a torre...",
                            "Eles ficam surpresos com a sua ousadia, mandando você se fuder...",
                            "Vocês discutem...",
                            "Um deles saca a espada...",
                            "O outro segura a empunhura atrás de você...",
                            "Uma luta é inevitável..."
                            );

                        while ((bpw.Count > 0 && bpw[0].health > 0) && (bpv.Count > 0 && (bpv[0].health > 0 || (bpv.Count > 1 && bpv[0].health > 0))))
                        { 
                            borda($"Sua vida: {bpw[0].health}\n",
                                  $"Vida dos inimigos: {bpv[0].health}",
                                  "\n-------------------------\n",
                                  "Escolha uma ação:",
                                  "1. Corte rápido diagonal (+vel)",
                                  "2. Corte forte forte vertical (+for)",
                                  "3. Estocada");

                            var action = Convert.ToInt16(Console.ReadLine());
                            switch (action)
                            {
                                case 1:
                                    Falar("Você foi mais rápido que eles...",
                                          "faz um corte rápido na diagonal em ambos...",
                                          "Causando 35 de dano...");

                                    // Aplica dano aos inimigos existentes
                                    if (bpv.Count > 0) bpv[0].health -= 35;
                                    if (bpv.Count > 1) bpv[0].health -= 35;
                                    s++;
                                    break;

                                case 2:
                                    Falar("Você foi mais forte que eles...",
                                          "faz um corte forte vertical em ambos...",
                                          "Causando 75 de dano...");

                                    if (bpv.Count > 0) bpv[0].health -= 75;
                                    if (bpv.Count > 1) bpv[0].health -= 75;
                                    p++;
                                    break;

                                case 3:
                                    Falar("Você fez uma estocada precisa...",
                                          "Causando 50 de dano...");

                                    // Exemplo focando no primeiro inimigo ou ajustando conforme necessário
                                    if (bpv.Count > 0) bpv[0].health -= 50;
                                    break;

                                default:
                                    borda("Opção inválida. Por favor, reinicie o jogo e escolha uma opção válida.");
                                    return;
                            }

                            bpv.RemoveAll(inimigo => inimigo.health <= 0);
                        }

                            if (s >= 3)
                            {
                                Falar("Você testou sua velocidade muitas vezes, agora seu corpo está mais acostumado e ficando mais leve...",
                                    "+10 de velocidade...");
                                bpw[0].speed += 10;
                            }

                            if (p >= 3)
                            {
                                Falar("Você testou sua força muitas vezes, agora seu corpo está mais rígido e ficando mais forte...",
                                    "+10 de força...");
                                bpw[0].power += 10;
                            }
                            Console.Clear();
                            Falar("Você derrotou os bandidos...", "Agora a vida deles está em suas mãos...");
                            borda("Você vai mata-lós (1) ou deixá-los viver (2)?");
                            int decision = Convert.ToInt16(Console.ReadLine());
                            switch (decision)
                            {
                                case 1:
                                Console.Clear();
                                Falar("Você coloca um em cima do outro...",
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
                                    bpw[0].sanity -= 15;
                                    break;
                                case 2:
                                    Falar("Você decide poupar a vida dos bandidos...",
                                        "Ele te dão o mapa do caminho até a torre...",
                                        "Com ele, você pode encontrar o caminho para a torre e descobrir o que aconteceu com esse tal Getúlio...",
                                        "Então você vai imediatamente para a torre...",
                                        "Você chega até a torre",
                                        "Sente uma sensação de perigo...",
                                        "Mas ao mesmo tempo sente que está mais forte que antes...",
                                        "Com confiança, você entra na torre...");
                                    break;
                                default:
                                    borda("Opção inválida. Por favor, reinicie o jogo e escolha uma opção válida.");
                                return;

                        }
                        break;
                    case 2:
                        borda("Você segue eles...",
                            "Eles te levam até a base de uma torre na floresta...",
                            "Depois de montar os mantimentos, eles vão embora...",
                            "Você está de frente para a torre...",
                            "A sensação de perigo é intensa...",
                            "Mas ainda assim, você decide avançar...");
                        break;
                    default:
                        borda("Opção inválida. Por favor, reinicie o jogo e escolha uma opção válida.");
                        return;
                }
                break;
            case 2:
                borda("Você é um Mago, e sua jornada começa agora...");
                break;
            case 3:
                borda("Você é um Arqueiro, e sua jornada começa agora...");
                break;
        }

        
    }

    
    static void Falar(params string[] frases)
    {
        foreach (var frase in frases)
        {
            borda(frase);
            pause();
        }
    }

    static void borda(params string[] linhas)
    {
        var todasAsLinhas = linhas
            .SelectMany(l => l.Split('\n'))
            .Select(l => l.Trim('\r'))
            .ToList();

        int tamanhoMaximo = todasAsLinhas.Max(l => l.Length);

        int margem = 4;
        int larguraCaixa = tamanhoMaximo + margem;

        string bordaHorizontal = "╔" + new string('═', larguraCaixa) + "╗";
        string bordaInferior = "╚" + new string('═', larguraCaixa) + "╝";

        Console.WriteLine(bordaHorizontal);

        foreach (var linha in todasAsLinhas)
        {
            int espacosTotais = larguraCaixa - linha.Length;
            int espacosEsquerda = espacosTotais / 2;
            int espacosDireita = espacosTotais - espacosEsquerda;

            string linhaCentralizada = new string(' ', espacosEsquerda) + linha + new string(' ', espacosDireita);

            Console.WriteLine($"║{linhaCentralizada}║");
        }

        Console.WriteLine(bordaInferior);
    }

    static void pause()
    {
        Console.ReadKey();
        Console.Clear();
    }
}