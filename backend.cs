namespace rpg
{
    public class backend
    {
        public void Falar(params string[] frases)
        {
            foreach (var frase in frases)
            {
                this.borda(frase);
                this.pause();
            }
        }

        public void borda(params string[] linhas)
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

        public void pause()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
