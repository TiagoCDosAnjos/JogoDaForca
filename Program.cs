namespace JogoDaForca
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras =
            {
                "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA", "BACURI",
                "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA",
                "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", "MARACUJÁ", "MURICI", "PEQUI", "PITANGA",
                "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"
            };

            Random escolha = new Random();
            string palavraEscolhida = palavras[escolha.Next(palavras.Length)];

            char[] letrasDescobertas = new char[palavraEscolhida.Length];
            {
                for (int i = 0; i < letrasDescobertas.Length; i++)
                {
                    letrasDescobertas[i] = '_';
                }
            }

            int erros = 0;

            while (true)
            {
                Boneco(erros);
                Console.WriteLine("Palavra: " + string.Join(" ", letrasDescobertas));

                Console.Write("Qual o seu chute: ");
                char letra = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();
                Console.Clear();

                bool letraEncontrada = false;
                for (int i = 0; i < palavraEscolhida.Length; i++)
                {
                    if (palavraEscolhida[i] == letra)
                    {
                        letrasDescobertas[i] = letra;
                        letraEncontrada = true;
                    }
                }

                if (!letraEncontrada)
                {
                    erros++;
                }

                if (erros == 5)
                {
                    Boneco(erros);
                    Console.WriteLine("Você perdeu, a palavra era: " + palavraEscolhida);
                    break;
                }

                if (!letrasDescobertas.Contains('_'))
                {
                    Boneco(erros);
                    Console.WriteLine("Parabéns! você acertou a palavra: " + palavraEscolhida);
                    break;
                }
            }

            void Boneco(int erros)
            {
                switch (erros)
                {
                    case 0:
                        Console.WriteLine("  _______");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 1:
                        Console.WriteLine("  _______");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |       0");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 2:
                        Console.WriteLine("  _______");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |       0");
                        Console.WriteLine(" |      / ");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 3:
                        Console.WriteLine("  _______");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |       0");
                        Console.WriteLine(" |      /x");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 4:
                        Console.WriteLine("  _______");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |       0");
                        Console.WriteLine(" |      /x\\");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                    case 5:
                        Console.WriteLine("  _______");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |       0");
                        Console.WriteLine(" |      /x\\");
                        Console.WriteLine(" |       x");
                        Console.WriteLine(" |");
                        Console.WriteLine("_|___");
                        break;
                }
            }
        }
    }
}