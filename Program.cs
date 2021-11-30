using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade, contador = 0;
            bool realQuantidade, realNumeroDigitado;
            decimal numeroDigitado, media, maiorNumero = 0, menorNumero = 0, soma = 0;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n-------- Média Decimal --------\n");
            Console.ResetColor();

            Console.WriteLine(" * Insira a quantidade de      \n   números a serem digitados,");
            Console.WriteLine("   os número a serem analisados,\n   e receba a soma e a média");
            Console.WriteLine("   entre eles, além de qual o  \n   maior e o menor número.\n");

            Console.Write("Indique a quantidade de\nnúmeros a serem digitados: ");
            realQuantidade = Int32.TryParse(Console.ReadLine(), out quantidade);

            if (realQuantidade)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nInsira os números:\n");
                Console.ResetColor();

                while (contador < quantidade)
                {
                    contador += 1;
                    
                    Console.Write($"Número #{contador}: ");
                    realNumeroDigitado = Decimal.TryParse(Console.ReadLine(), out numeroDigitado);

                    if (!realNumeroDigitado)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n * Insira apenas números!\n");
                        Console.ResetColor();
                        
                        Environment.Exit(-1);
                    }

                    if (contador == 1)
                    {
                        maiorNumero = numeroDigitado;
                        menorNumero = numeroDigitado;
                    }
                    if (contador > 1)
                    {
                        if (numeroDigitado > maiorNumero)
                        {
                            maiorNumero = numeroDigitado;
                        }
                        if (numeroDigitado < menorNumero)
                        {
                            menorNumero = numeroDigitado;
                        }
                    }

                    soma += numeroDigitado;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n * Insira apenas números inteiros!\n");
                Console.ResetColor();

                Environment.Exit(-1);
            }
            
            media = soma / quantidade;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nResultado:\n");
            Console.ResetColor();
        
            Console.WriteLine($"Soma...: {soma:N2}");
            Console.WriteLine($"Média..: {media:N2}");
            Console.WriteLine($"Maior..: {maiorNumero}");
            Console.WriteLine($"Menor..: {menorNumero}\n");
        }
    }
}
