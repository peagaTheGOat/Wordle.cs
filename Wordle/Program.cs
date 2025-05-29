using System;
using System.Collections.Generic;

class Termo
{
    static void Main()
    {
        string[] palavras = { "carro", "manga", "livro", "terra", "piano", "vazio", "nuvem", "porta" };
        Random rnd = new Random();
        string palavraSecreta = palavras[rnd.Next(palavras.Length)];
        int tentativasRestantes = 6;

        Console.WriteLine("Tente adivinhar a palavra de 5 letras. Você tem 6 tentativas.\n");

        while (tentativasRestantes > 0)
        {
            Console.Write($"Tentativa ({7 - tentativasRestantes}/6): ");
            string tentativa = Console.ReadLine().ToLower();

            if (tentativa.Length != 5)
            {
                Console.WriteLine(" 5 letras seu burro");
                continue;
            }

            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < 5; i++)
            {
                char letra = tentativa[i];
                if (letra == palavraSecreta[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Letra certa no lugar certo
                }
                else if (palavraSecreta.Contains(letra))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // Letra certa no lugar errado
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray; // Letra errada
                }

                Console.Write(letra);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine();

            if (tentativa == palavraSecreta)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n GG");
                Console.ResetColor();
                return;
            }

            tentativasRestantes--;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n Aiai ce sabeeeee, a palavra era: {palavraSecreta}");
        Console.ResetColor();
    }
}
