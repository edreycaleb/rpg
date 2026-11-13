using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace rpg
{
    public class backend
    {
        public void Fala(params string[] frases)
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


            int tamanhoMaximo = todasAsLinhas.Max(l => Regex.Replace(l, @"\x1B\[[0-9;]*[mK]", "").Length);

            int margem = 4;
            int larguraCaixa = tamanhoMaximo + margem;

            string bordaHorizontal = "╔" + new string('═', larguraCaixa) + "╗";
            string bordaInferior = "╚" + new string('═', larguraCaixa) + "╝";

            Console.WriteLine(bordaHorizontal);

            foreach (var linha in todasAsLinhas)
            {

                string linhaLimpa = Regex.Replace(linha, @"\x1B\[[0-9;]*[mK]", "");
                int espacosTotais = larguraCaixa - linhaLimpa.Length;
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
                Console.WriteLine(bordaUp(frase));
                Console.Write("║  ");
                foreach (char letra in frase)
                {
                    Console.Write($"{letra}");
                    Thread.Sleep(50);
                }
                Console.Write("  ║");
                Console.WriteLine("");
                Console.WriteLine(bordaDown(frase));
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

        
        public static string bordaUp(params string[] linhas)
        {
            int larguraCaixa = CalcularLarguraCaixa(linhas);
            return "╔" + new string('═', larguraCaixa) + "╗";
        }

        
        public static string bordaDown(params string[] linhas)
        {
            int larguraCaixa = CalcularLarguraCaixa(linhas);
            return "╚" + new string('═', larguraCaixa) + "╝";
        }
    


}
}

