using System;

namespace Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg, encrypt = "";
            int acertou = 0;

            Console.Write("ENTRE COM A MENSAGEM PARA SER CRIPTOGRAFADA: ");
            msg = Console.ReadLine().ToLower();

            for (int i = 0; i < msg.Length; i++)
            {
                int subst = 0;
                int letra = (int)msg[i];
                if (letra != 'a' && letra != 'b' && letra != 'c')
                {
                    subst = letra - 3;
                }
                else if (letra == 'a')
                {
                    char x = 'x';
                    subst = (int)x;
                }
                else if (letra == 'b')
                {
                    char y = 'y';
                    subst = (int)y;
                }
                else if (letra == 'c')
                {
                    char z = 'z';
                    subst = (int)z;
                }

                if (letra == ' ')
                {

                    encrypt += ' ';
                }
                else
                {
                    encrypt += Char.ConvertFromUtf32(subst);
                }
            }

            Console.WriteLine("RESULTADO: " + encrypt);
            Console.WriteLine("\nCIFRAS CRIPTOGRÁFICAS");
            Console.WriteLine("Cifra de transposição");
            Console.WriteLine("Cifra de substituição");
            Console.WriteLine("Cifra de César");
            Console.WriteLine("Cifra de Viginère");

            while (acertou == 0)
            {
                Console.WriteLine("\nQUAL FOI A CIFRA CRIPTOGRÁFICA UTILIZADA PARA CRIPTOGRAFAR OS DADOS?");
                string cifra = Console.ReadLine().ToLower();
                if (cifra == "cifra de cesar" || cifra == "cifra de césar")
                {
                    Console.WriteLine("SIM");
                    Console.WriteLine("PARABÉNS!");
                    acertou = 1;
                }
                else
                {
                    Console.WriteLine("NÃO, TENTE NOVAMENTE");
                }
            }
            Console.ReadKey();
        }
    }
}