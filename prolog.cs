namespace rpg
{
    public class prolog
    {
        public void start()
        {
            backend talk = new backend();

            talk.borda("Qual é o seu nome?");
            Datag.name = Console.ReadLine();
            
            Console.Clear();
            if (Datag.name == "Ana Julia")
            {
                talk.borda($"Oii momo, escolhe a classe que você quiser mo:\n \u001b[38;5;166m1 - Guerreiro\u001b[0m \n \u001b[95m2 - Mago\u001b[0m \n \u001b[38;5;28m3 - Arqueiro\u001b[0m");
                Datag.clas = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            else
            {
                talk.borda($"Escolha a sua classe, {Datag.name}:\n \u001b[38;5;166m1 - Guerreiro\u001b[0m \n \u001b[95m2 - Mago\u001b[0m \n \u001b[38;5;28m3 - Arqueiro\u001b[0m");
                Datag.clas = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            switch (Datag.clas)
            { 
                case 1:
                    talk.Falar(
                        "\u001b[38;5;166mGuerreiro\u001b[0m",
                        "Você nasceu em um vilareijo no interior do \u001b[93mImpério de Pindorama\u001b[0m...",
                        "Passou a infância num \u001b[38;2;210;105;30morfanato\u001b[0m...",
                        $"Recebeu o nome de \u001b[38;5;195m{Datag.name}\u001b[0m daquele que era o dono do orfanato...",
                        "O qual foi um guerreiro \u001b[38;5;219mmuito poderoso\u001b[0m no passado, porém teve que se aposentar após \u001b[38;5;124mperder um dedo na guerra\u001b[0m...",
                        "Assim ele criou \u001b[38;2;210;105;30mo orfanato\u001b[0m, para compensar as\u001b[38;5;124m milhares de vidas\u001b[0m que ele tirou enquanto caveleiro...",
                        $"Ele viu potencial em você \u001b[38;5;195m{Datag.name}\u001b[0m e decidiu te treinar...",
                        "Assim foi a sua infância, treinando \u001b[33mtodos os dias\u001b[0m com o dono do orfanato...",
                        "Aprendendo \u001b[31ma lutar\u001b[0m e \u001b[92ma sobreviver\u001b[0m...",
                        "Até que um dia, algo \u001b[95minesperado aconteceu\u001b[0m...",
                        "Você encontra \u001b[92muma carta\u001b[0m, com a letra do dono...",
                        "Nela dizia:",
                        $"\u001b[3m'\u001b[35mAlgo sombrio\u001b[0m está corroendo o \u001b[93mImpério\u001b[0m...'\u001b[0m",
                        "\u001b[3m'Eu, com o \u001b[91mpouco poder\u001b[0m que me restava, atrasei o desastre...'\u001b[0m",
                        "\u001b[3m'Mas agora, \u001b[92mvocê\u001b[0m é a única pessoa que pode salvar o \u001b[93mImpério\u001b[0m...'\u001b[0m",
                        "\u001b[3m'Eu te treinei para isso, \u001b[38;5;195me sei que você é capaz\u001b[0m...'\u001b[0m",
                        "\u001b[3m'Vá até a \u001b[93mcapital do Império\u001b[0m, a \u001b[94mcidade da Guanabara\u001b[0m, e proucure um homem chamado \u001b[32mGetúlio\u001b[0m, ele te guiará...'\u001b[0m",
                        "\u001b[3m'Você não herda meu \u001b[31msangue\u001b[0m, mas herda a \u001b[33mminha vida\u001b[0m...'",
                        $"\u001b[91m'Eu te amo, {Datag.name}...'\u001b[0m"
                    );

                    break;

                case 2:
                    talk.Falar(
                        "\u001b[95mMago\u001b[0m",
                        "Você nasceu na capital do \u001b[93mImpério de Pindorama\u001b[0m, \u001b[94ma cidade da Guanabara\u001b[0m...",
                        "\u001b[94mA cidade da Guanabara\u001b[0m é conhecida por ser o \u001b[38;2;255;215;0mcentro comercial\u001b[0m e \u001b[38;5;81mintelectual\u001b[0m do \u001b[93mImpério\u001b[0m...",
                        "É lá que você passou \u001b[33ma sua juventude\u001b[0m, aprendendo com \u001b[38;5;129mos maiores intelectuais\u001b[0m do \u001b[93mImpério\u001b[0m...",
                        "Seus pais eram \u001b[38;5;93mmagos muito poderosos\u001b[0m, e te incentivaram a seguir o caminho da \u001b[95mmagia\u001b[0m...",
                        "Porém...", //efeito de lentidão - colocar
                        "\u001b[31mSua mãe foi assassinada...\u001b[0m",
                        "Depois disso, seu pai ficou \u001b[31mdesvastado\u001b[0m...",
                        "Sua mãe era a maga \u001b[38;5;93mmais forte do império\u001b[0m, ela não poderia ser morta por \u001b[92mqualquer um\u001b[0m...",
                        "\u001b[32mGetúlio\u001b[0m, seu pai, não pôde sair da capital. Por um pedido de \u001b[91mum velho companheiro\u001b[0m...",
                        "\u001b[38;5;195mEntão você precisa agir...\u001b[0m",
                        $"\u001b[32m{Datag.name}, vingue a sua mãe!\u001b[0m"
                    );
                    break;

                case 3:
                    talk.Falar(
                        "\u001b[38;5;28mArqueiro\u001b[0m",
                        "Você nasceu na cidade do carvão e do ferro, \u001b[90mas Minas Gerais\u001b[0m...",
                        "A cidade das \u001b[90mMinas Gerais\u001b[0m é conhecida por ser \u001b[38;5;159mo centro indústrial\u001b[0m do \u001b[93mImpério de Pindorama\u001b[0m...",
                        "Você cresceu em \u001b[38;5;195muma família de ferreiros\u001b[0m...",
                        "Mas, \u001b[9mnunca\u001b[0m teve talento para ferraria...",
                        "Entretanto, você sempre amou testar \u001b[0m\u001b[38;5;118mos arcos\u001b[0m\u001b[0m que seu pai fazia...",
                        "Até que durante uma viagem comercial...",
                        "Que destinava-se a entregar um arco ao \u001b[93mImperador Flávio\u001b[0m...",
                        "A carruagem que estavam você e a sua família, \u001b[31mfoi atacada por uma quadrilha de bandidos...\u001b[0m",
                        "Você por reflexo pegou \u001b[38;5;195m o arco\u001b[0m e atirou contra os bandidos...",
                        "\u001b[31mMatando todos eles...\u001b[0m",
                        "Ao mesmo tempo que alguns te \u001b[36mlouvavam\u001b[0m, outros sentiam \u001b[34mmedo\u001b[0m de você...",
                        $"'\u001b[38;5;195m{Datag.name}\u001b[0m, quem nunca praticou arqueria verdadeiramente, apenas testava os arcos de seu pai...'",
                        "'Conseguiu matar uma quadrilha de bandidos, com apenas um arco, sem a ajuda de mais ninguém...'",
                        "Esses eram os pensamentos que se dividiam sobre você...",
                        "Uns viram em você o nascimento de um \u001b[33msímbolo revolucionário\u001b[0m, que lutaria contra as \u001b[35msombras\u001b[0m...",
                        "Outros...",
                        "Um perigo para o império, que agora era governado pelas \u001b[35msombras...\u001b[0m",
                        "E assim, você precisará decidir o seu destino...",
                        $"\u001b[38;5;195m{Datag.name}\u001b[0m, você se tornará um \u001b[33mrevolucionário\u001b[0m?",
                        "Ou será parte das \u001b[35msombras\u001b[0m que governam o império?",
                        "\u001b[32mA decisão é sua...\u001b[0m"
                    );
                    break;

                default:
                    talk.borda("\u001b[32mClasse inválida. A vida não tem replay.\u001b[0m");
                    return;
            }
        }
    }
}
