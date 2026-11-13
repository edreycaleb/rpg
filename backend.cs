using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace rpg
{
    public class backend
    {
        public void borda(params string[] linhas)
        {
            var todasAsLinhas = linhas
                .SelectMany(l => l.Split('\n'))
                .Select(l => l.Trim('\r'))
                .ToList();

            int tamanhoMaximo = todasAsLinhas.Max(l => Regex.Replace(l, @"\x1B\[[0-9;]*[mK]", "").Length);

            int margem = 4;
            int larguraCaixa = tamanhoMaximo + margem;

            int larguraTotalVisual = larguraCaixa + 2;
            int alturaTotalCaixa = todasAsLinhas.Count + 2;

            
            int posX = Math.Max(0, (Console.WindowWidth - larguraTotalVisual) / 2);
            int posY = Math.Max(0, (Console.WindowHeight / 3) - (alturaTotalCaixa / 2));

            int linhaAtual = posY;

            
            Console.SetCursorPosition(posX, linhaAtual++);
            string bordaHorizontal = "╔" + new string('═', larguraCaixa) + "╗";
            Console.Write(bordaHorizontal);

            
            foreach (var linha in todasAsLinhas)
            {
                Console.SetCursorPosition(posX, linhaAtual++);

                string linhaLimpa = Regex.Replace(linha, @"\x1B\[[0-9;]*[mK]", "");
                int espacosTotais = larguraCaixa - linhaLimpa.Length;
                int espacosEsquerda = espacosTotais / 2;
                int espacosDireita = espacosTotais - espacosEsquerda;

                string linhaCentralizada = new string(' ', espacosEsquerda) + linha + new string(' ', espacosDireita);
                Console.Write($"║{linhaCentralizada}║");
            }

            
            Console.SetCursorPosition(posX, linhaAtual++);
            string bordaInferior = "╚" + new string('═', larguraCaixa) + "╝";
            Console.Write(bordaInferior);

            
            Console.SetCursorPosition(posX, linhaAtual + 1);
            Console.Write("> ");

        }

        public void pause()
        {
            Console.ReadKey();
            Console.Clear();
        }

        public string rb(string texto)
        {
            string[] cores = {
        "\u001b[38;2;255;0;0m",     // Vermelho
        "\u001b[38;2;255;127;0m",   // Laranja
        "\u001b[38;2;255;255;0m",   // Amarelo
        "\u001b[38;2;0;255;0m",     // Verde
        "\u001b[38;2;0;150;255m",   // Azul
        "\u001b[38;2;50;205;50m",    // verde claro
        "\u001b[95m"    // roxo claro
    };

            string resultado = "";
            int indiceCor = 0;

            foreach (char letra in texto)
            {
                if (letra != ' ')
                {
                    resultado += cores[indiceCor % cores.Length] + letra;
                    indiceCor++;
                }
                else
                {
                    resultado += letra;
                }
            }

            return resultado + "\u001b[0m";
        }

        public void tremor(params string[] frases)
        {
            foreach (var frase in frases)
            {
                Random rng = new Random();

                while (!Console.KeyAvailable)
                {
                    
                    int cursorLeft = Console.CursorLeft;
                    int cursorTop = Console.CursorTop;

                   
                    char[] chars = frase.ToCharArray();
                    for (int c = 0; c < chars.Length; c++)
                    {
                        if (rng.Next(0, 3) == 0 && char.IsLetter(chars[c]))
                            chars[c] = char.IsUpper(chars[c]) ? char.ToLower(chars[c]) : char.ToUpper(chars[c]);
                    }
                    string fraseTremida = new string(chars);

                    
                    Console.WriteLine(fraseTremida);

                    Thread.Sleep(200);

                    
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                }

                
                Console.Clear();
                Console.WriteLine(frase);

                
                this.pause();
            }
        }

        public void Falar(params string[] frases)
        {
            foreach (var frase in frases)
            {
                
                int larguraCaixa = CalcularLarguraCaixa(frase);

                
                int larguraTotalVisual = larguraCaixa + 2;
                int alturaTotalCaixa = 3; 

                int posX = Math.Max(0, (Console.WindowWidth - larguraTotalVisual) / 2);
                int posY = Math.Max(0, (Console.WindowHeight / 3) - (alturaTotalCaixa / 2));

                
                Console.SetCursorPosition(posX, posY);
                Console.Write(new string(' ', larguraTotalVisual));

                
                Console.SetCursorPosition(posX, posY + 1);
                Console.Write("  "); 

                foreach (char letra in frase)
                {
                    Console.Write($"{letra}");
                    Thread.Sleep(70);
                }

                Console.Write("  ");
                Console.WriteLine(); 

                
                Console.SetCursorPosition(posX, posY + 2);
                Console.Write(new string(' ', larguraTotalVisual));

                this.pause();
            }
        }

        public static int CalcularLarguraCaixa(params string[] linhas)
        {
            var todasAsLinhas = linhas
                .SelectMany(l => l.Split('\n'))
                .Select(l => l.Trim('\r'))
                .ToList();

            int tamanhoMaximo = todasAsLinhas.Max(l => Regex.Replace(l, @"\x1B\[[0-9;]*[mK]", "").Length);
            int margem = 4;
            return tamanhoMaximo + margem;
        }
}
}

