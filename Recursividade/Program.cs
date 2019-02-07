using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    class Program
    {
        static int fatorial(int n)
        {
            int fat = 1;

            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            return (fat);
        }

        static int fatorialRec(int n)
        {
            if (n == 1 || n==0)
            {
                return (1);
            }
            else
            {
                return (n * fatorialRec(n - 1));
            }
            
        }

        static int somaIntPosIt(int n)
        {
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                soma = soma + i;
            }
            return (soma);
        }
        
        static int somaIntPosRec(int n)
        {
            if (n == 1)
            {
                return (1);
            }
            else
            {
                return (n + somaIntPosRec(n - 1));
            }
        }
        static int potencialIt(int a, int b)
        {
            int pot = 1;
            for (int i = 1; i <= b; i++)
            {
                pot = pot * a;
            }
            return pot;
        }
        static int potencialRec(int a, int b)
        {
            if (b == 0)
                return (1);
            else
                return (a * (potencialRec(a, b - 1)));
        }
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Fatorial Iterativo");
            Console.WriteLine("2 - Fatorial Recursivo");
            Console.WriteLine("3 - Soma Inteiros Positivos Iterativo");
            Console.WriteLine("4 - Soma Inteiros Positivos Recursivo");
            Console.WriteLine("5 - Soma Inteiros Positivos Pares Iterativo");
            Console.WriteLine("6 - Soma Inteiros Positivos Pares Recursivo");
            Console.WriteLine("7 - Soma Inteiros Positivos Ímpares Iterativo");
            Console.WriteLine("8 - Soma Inteiros Positivos Ímpares Recursivo");
            Console.WriteLine("9 - Potência Iterativo");
            Console.WriteLine("10 - Potência Recursivo");
            Console.WriteLine("11 - Maior Elemento");
            Console.WriteLine("12 - Palíndrome");
            Console.WriteLine("13 - Torres de Hanói");
            Console.WriteLine("14 - Mudança Base 2");
            Console.WriteLine("15 - Mudança Base B");
            Console.WriteLine("16 - Sair");
            Console.Write("Opção: ");

            return (int.Parse(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            int op,x;

            do
            {
                x = 0;
                op = menu();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Insira o fatorial a ser calculado: ");
                        x = int.Parse(Console.ReadLine());
                        if (x < 0)
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        else
                        {
                            Console.WriteLine($"O fatorial de: {x} é {fatorial(x)}");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Insira o fatorial a ser calculado: ");
                        x = int.Parse(Console.ReadLine());
                        if (x < 0)
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        else
                        {
                            Console.WriteLine($"O fatorial de: {x} é {fatorialRec(x)}");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Insira a quantidade de números inteiros a serem calculados: ");
                        x = int.Parse(Console.ReadLine());
                        if (x < 0)
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        else
                        {
                            Console.WriteLine($"A soma dos número inteiros é de: {x} é {somaIntPosIt(x)}");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Insira a quantidade de números inteiros a serem calculados: ");
                        x = int.Parse(Console.ReadLine());
                        if (x < 0)
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        else
                        {
                            Console.WriteLine($"A soma dos número inteiros é de: {x} é {somaIntPosRec(x)}");
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Insira a quantidade de números inteiros a serem calculados: ");
                        x = int.Parse(Console.ReadLine());
                        if (x < 0)
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        else
                        {
                            Console.WriteLine($"A soma dos número inteiros é de: {x} é {somaIntPosRec(x)}");
                        }
                        Console.ReadKey();
                        break;

                    case 6:
                        
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                    case 10:
                        break;

                    case 11:
                        break;

                    case 12:
                        break;

                    case 13:
                        break;

                    case 14:
                        break;

                    case 15:
                        break;
                }

            } while (op != 16);
        }
    }
}
