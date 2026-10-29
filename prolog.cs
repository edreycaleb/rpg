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

            talk.borda($"Escolha a sua classe, {Datag.name}:\n 1 - Guerreiro\n 2 - Mago\n 3 - Arqueiro");
            Datag.clas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (Datag.clas)
            {
                case 1:
                    talk.Falar(
                        "Você nasceu em um vilareijo no interior do Império de Pindorama...",
                        "Cresceu no orfanato...",
                        $"Recebeu o nome {Datag.name} daquele que era o dono do orfanato...",
                        "O qual foi um guerreiro muito poderoso no passado, porém teve que se aposentar após perder um dedo na guerra...",
                        "Assim criou o orfanato, para compensar as milhares de vidas que tirou enquanto caveleiro...",
                        $"Ele viu potencial em você {Datag.name} e decidiu te treinar...",
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
                        $"'\u001b[91mEu te amo, {Datag.name}...\u001b[0m'"
                    );

                    break;

                case 2:
                    talk.Falar(
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
                        $"\u001b[32m{Datag.name}, vingue a sua mãe!\u001b[0m"
                    );
                    break;

                case 3:
                    talk.Falar(
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
                        $"'{Datag.name}, quem nunca praticou arqueria verdadeiramente, apenas testava os arcos de seu pai...'",
                        "'Conseguiu matar uma quadrilha de bandidos, com apenas um arco, sem a ajuda de mais ninguém...'",
                        "Esses eram os pensamentos que dividiam a opinião sobre você...",
                        "Uns viram em você o nascimento de um \u001b[33msímbolo revolucionário\u001b[0m, que lutaria contra as \u001b[35msombras\u001b[0m...",
                        "Outros...",
                        "Um perigo para o império, que agora era governado pelas \u001b[35msombras...\u001b[0m",
                        "E assim, você precisará decidir o seu destino...",
                        $"{Datag.name}, você se tornará um \u001b[33mrevolucionário\u001b[0m?",
                        "Ou será parte das \u001b[35msombras\u001b[0m que governam o império?",
                        "\u001b[32mA decisão é sua...\u001b[0m"
                    );
                    break;

                default:
                    talk.borda("\u001b[32mClasse inválida. Por favor, reinicie o jogo e escolha uma classe válida.\u001b[0m");
                    return;
            }
        }
    }
}
