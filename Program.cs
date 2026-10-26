namespace rpg;

public class Program
{
    public static void Main()
    {
        borda("Qual é o seu nome?");
        string name = Console.ReadLine();
        Console.Clear();

        borda($"Escolha a sua classe, {name}:\n 1 - Guerreiro\n 2 - Mago\n 3 - Arqueiro");
        int clas = Convert.ToInt16(Console.ReadLine());
        Console.Clear();

        switch (clas)
        {
            case 1:
                borda("Você nasceu em um vilareijo no interior do Império de Pindorama...");
                pause();
                borda("Cresceu no orfanato...");
                pause();
                borda($"Recebeu o nome {name} daquele que era o dono do orfanato...");
                pause();
                borda("O qual foi um guerreiro muito poderoso no passado, porém teve que se aposentar após perder um dedo na guerra...");
                pause();
                borda("Assim criou o orfanato, para compensar as milhares de vidas que tirou enquanto caveleiro...");
                pause();
                borda($"Ele viu potencial em você {name} e decidiu te treinar...");
                pause();
                borda("Assim foi a sua infância, treinando todos os dias com o dono do orfanato...");
                pause();
                borda("Aprendendo a lutar e a sobreviver...");
                pause();
                borda("Até que um dia, algo inesperado aconteceu...");
                pause();
                borda("O dono do orfanato faleceu, deixando uma carta para você...");
                pause();
                borda("Nela dizia:");
                pause();
                borda("'Algo sombrio está correndo no império...'");
                pause();
                borda("'Eu, com o pouco poder que me restava, atrasei o desastre...'");
                pause();
                borda("'Mas agora, você é a única pessoa que pode salvar o império...'");
                pause();
                borda("'Eu te treinei para isso, e sei que você é capaz...'");
                pause();
                borda("'Vá até a capital do império, a cidade da Guanabara, e proucure um homem chamado Getúlio, ele te guiará...'");
                pause();
                borda("'Você não herda meu \u001b[31msangue\u001b[0m, mas te dou \u001b[33mminha vida\u001b[0m...'");
                pause();
                borda($"'\u001b[91mEu te amo, {name}...\u001b[0m'");
                pause();
                break;
            case 2:
                borda("Você nasceu na capital do império de Pindorama, a cidade da Guanabara...");
                pause();
                borda("A cidade da Guanabara é conhecida por ser o centro comercial e intelectual do império...");
                pause();
                borda("É lá que você passou a sua juventude, aprendendo com os maiores intelectuais do império...");
                pause();
                borda("Seus pais eram magos muito poderosos, e te incentivaram a seguir o caminho da magia..."); 
                pause();
                borda("Porém...");
                pause();
                borda("\u001b[31mSua mãe foi assassinada...\u001b[0m");
                pause();
                borda("Seu pai ficou desvastado...");
                pause();
                borda("Sua mãe era a maga mais forte do império, ela não poderia ser morta por qualquer um...");
                pause();
                borda("Getúlio, seu pai, não pôde sair da capital. Por um pedido de um velho companheiro...");
                pause();
                borda("Então você precisa agir...");
                pause();
                borda($"\u001b[32m{name}, vingue a sua mãe!\u001b[0m");
                pause();
                break;
            case 3:
                borda("Você nasceu na cidade do carvão e do ferro, as Minas Gerais...");
                pause();
                borda("A cidade das Minas Gerais é conhecida por ser o centro da indústria mineral do império de Pindorama...");
                pause();
                borda("Você cresceu em uma família de ferreiros...");
                pause();
                borda("Mas, nunca teve talento para ferraria...");
                pause();
                borda("Entretanto, você sempre amou testar os arcos que seu pai fazia...");
                pause();
                borda("Até que durante uma viagem comercial...");
                pause();
                borda("Que destinava-se a entregar um arco ao imperador Flávio...");
                pause();
                borda("A carruagem que estavam você e a sua família, \u001b[31mfoi atacada por uma quadrilha debandidos...\u001b[0m");
                pause();
                borda("Você por reflexo pegou \u001b[97m o arco\u001b[0m e atirou contra os bandidos...");
                pause();
                borda("\u001b[31mMatando todos eles...\u001b[0m");
                pause();
                borda("Ao mesmo tempo que alguns te \u001b[36mlouvavam\u001b[0m, outros sentiam \u001b[34mmedo\u001b[0m de você...");
                pause();
                borda($"'Como {name}, quem nunca praticou arqueria verdadeiramente, apenas testava os arcos de seu pai...'");
                pause();
                borda("'Conseguiu matar uma quadrilha de bandidos, com apenas um arco, sem a ajuda de mais ninguém...'");
                pause();
                borda("Esses eram os pensamentos que dividiam a opinião sobre você...");
                pause();
                borda("Uns viram em você o nascimento de um \u001b[33simbolo mrevolucionário\u001b[0m, que lutaria contra as \u001b[35msombras0m que ansolavam o império...\u001b[");
                pause();
                borda("Outros...");
                pause();
                borda("Um perigo para o império, que agora era governado pelas \u001b[35msombras...\u001b[0m");
                pause();
                borda("E assim, você precisa decidir o seu destino...");
                pause();
                borda($"{name}, você se tornará um \u001b[33mrevolucionário\u001b[0m?");
                pause();
                borda("Ou será parte das \u001b[35msombras\u001b[0m que governam o império?");
                pause();
                borda("\u001b[32mA decisão é sua...\u001b[0m");
                pause();
                break;
            default:
                borda("\u001b[32mClasse inválida. Por favor, reinicie o jogo e escolha uma classe válida.\u001b[0m");
                break;
        }



    }

    static void borda(params string[] linhas)
    {
        // Separa caso alguma string tenha '\n' dentro dela
        var todasAsLinhas = linhas
            .SelectMany(l => l.Split('\n'))
            .Select(l => l.Trim('\r'))
            .ToList();

        // Encontra o tamanho da maior linha de texto
        int tamanhoMaximo = 0;
        foreach (var linha in todasAsLinhas)
        {
            if (linha.Length > tamanhoMaximo)
                tamanhoMaximo = linha.Length;
        }

        // Adiciona uma margem nas laterais para o texto não colar nas bordas
        int margem = 4;
        int larguraCaixa = tamanhoMaximo + (margem * 2);

        // Constrói a borda superior e inferior dinamica
        string bordaHorizontal = "╔" + new string('═', larguraCaixa) + "╗";
        string bordaInferior = "╚" + new string('═', larguraCaixa) + "╝";

        Console.WriteLine(bordaHorizontal);

        foreach (var linha in todasAsLinhas)
        {
            // Centraliza o texto calculando os espaços restantes
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
