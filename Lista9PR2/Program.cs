using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor
{
    internal class Program
    {
        public static void exec1()
        {
            int[] vet2;
            Console.WriteLine("qual o tamanho do vetor?");
            int t = int.Parse(Console.ReadLine());
            double valor = 0;


            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(0, 10);

                valor += vet2[i];


            }
            for (int i = 0; i < t; i++)
            {
                Console.Write("[{0}]\t", i);
            }
            Console.WriteLine();
            for (int i = 0; i < t; i++)
            {
                Console.Write(vet2[i] + "\t");

            }
            Console.WriteLine("\nvalor da media aritmetica : " + valor / t);

        }
        public static void exec2()
        {
            int[] vet2;
            Console.WriteLine("qual o tamanho do vetor?");
            int t = int.Parse(Console.ReadLine());
            int valorpar = 0;
            int valorimpar = 0;


            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(0, 10);

                if (vet2[i] % 2 == 0)
                {
                     valorpar += vet2[i];
                }
                if (vet2[i] % 3 == 0)
                {
                    valorimpar += vet2[i];
                }
            }
            for (int i = 0; i < t; i++)
            {
                Console.Write("[{0}]\t", i);
            }
            Console.WriteLine();
            for (int i = 0; i < t; i++)
            {
                Console.Write(vet2[i] + "\t");

            }
            Console.WriteLine("a soma dos valores pares é: "+valorpar);
            Console.WriteLine("a soma dos valores impares é: " + valorimpar);
        }
        public static void exec3()
        {
            int[] vet2;
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);


            }
            Console.WriteLine();
            for (int i = t - 1; i >= 0; i--)
            {

                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);


            }


            Console.ReadKey();
        }
        public static void exec4()
        {
            float media = 0;
            int[] vet2;
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);
                if (vet2[i] % 3 == 0 && vet2[i] % 5 == 0)
                {
                    media = vet2[i] + media;
                }


            }

            media = media / (float)t;
            Console.WriteLine("a media aridimentica é" + media);

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("     Menu");
            Console.WriteLine("exercicio 1");
            Console.WriteLine("exercicio 2");
            Console.WriteLine("exercicio 3");
            Console.WriteLine("exercicio 4");
            int exec = int.Parse(Console.ReadLine());

            switch (exec)
            {
                case 1:
                    exec1();
                    break;
                case 2:
                    exec2();
                    break;
                case 3:
                    exec3();
                    break;
                case 4:
                    exec4();
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }

        }
    }
}
