namespace D12_ovn_1

{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Numerics;
    using System.Threading.Channels;
    using static System.Runtime.InteropServices.JavaScript.JSType;


    internal class Program
    {
        static int[] primtal = { };
        static bool[] bools = new bool[50]; 
        static void Main(string[] args)
        {

            static void reset()
            {
                Console.ResetColor();
                Console.Write(new string('\n', 3));
                Main(null);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tisdag övningar D12-ovn-1");
            Console.WriteLine("övningar static-metoder");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Välj ett övningsnummer:");
            Console.WriteLine("1. Beräknar cotangent");
            Console.WriteLine("2. Factorial");
            Console.WriteLine("3. SumSquars");
            Console.WriteLine("4. AltSumSquares");
            Console.WriteLine("D12-ovn-1.2 – arrayer\r\n");
            Console.WriteLine("5. Prod2");
            Console.WriteLine("6. En array av förnamn");
            Console.WriteLine("6. En array av förnamn foreach");
            Console.WriteLine("7. Array telefonnr");
            Console.WriteLine("8. Sök i Array");
            Console.WriteLine("9. Primtal Array");
            Console.WriteLine("10. Kvadraten på primtal");
            Console.WriteLine("11. Eratosthenes såll");
            Console.WriteLine("99. Avsluta");

            int val = Int32.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:

                    ovning1();
                    break;
                case 2:
                    ovning2();
                    break;
                case 3:
                    ovning3();
                    break;
                case 4:
                    ovning4();
                    break;
                case 5:
                    ovning5();
                    break;
                case 6:
                    ovning6();
                    break;
                case 7:
                    ovning7();
                    break;
                case 8:
                    ovning8();
                    break;
                case 9:
                    ovning9();
                    break;
                case 10:
                    ovning10();
                    break;
                case 11:
                    ovning11();
                    break;
                case 99:
                    Console.WriteLine("Tack för mig.");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Välj ett nummer mellan 1 och 10.");
                    break;

            }

            static void ovning1()
            {

                for (double x = 0.2; x <= 2.0; x += 0.2)
                {

                    Console.WriteLine("{0:0.0} {1}", x, Cot(x));

                }

                Console.ForegroundColor = ConsoleColor.Green;
                reset();
            }

            static void ovning2()
            {
                for (int i = 0; i <= 15; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{i} {Faktorial(i)}");
                }

                reset();

            }
            static void ovning3()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(SumSquares(i));
                }
                reset();
            }
            static void ovning4()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{i} {AltSumSquares(i)}");
                }
                reset();
            }
            static void ovning5()
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        int prod = Prod2(i, j);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{prod} ");
                        /*   if (j <= i)
                             {
                                 Console.Write(Prod2(j,i) + " ");
                             }
                             else
                             {
                                 Console.Write("  ");
                             }  */

                    }
                    reset();
                }

            }
            static void ovning6()
            {
                string[] namn = { "Adam", "Berith", "Caesar", "Deborah", "Erik", "Fanny" };
                /*  for (int i = 0; i < namn.Length; i++)
                  {
                      Console.WriteLine(namn[i]);
                  }*/
                foreach (string j in namn)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(j);
                }
                reset();

            }
            static void ovning7()
            {
                string[] namn = { "Adam", "Berith", "Caesar", "Deborah", "Erik", "Fanny" };
                string[] telefonnr = { "000011111", "1111010101", "22201020", "3333010101", "4444010101", "5555010101" };
                for (int i = 0; i < namn.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{namn[i]} {telefonnr[i]}");
                }
                reset();
            }
            static void ovning8()
            {
                string[] namn = { "Adam", "Berith", "Caesar", "Deborah", "Erik", "Fanny" };


                var stringsok = "Deborah";
                var resultat = Array.Find(namn, element => element == stringsok);
                var index = Array.FindIndex(namn, element => element == stringsok);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{resultat} {Arraytelefon(index)}");
                reset();
            }
            static void ovning9()
            {

                primearray();

                Console.WriteLine("Primtal mellan 10 och 20 i array:");

                foreach (int prime in primtal)
                {
                    if (prime >= 10 && prime <= 20)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(prime);
                    }
                }
                reset();

            }
            static void ovning10()
            {
                primearray();
                int tal1;
                for (int i = 2; i <= primtal.Length - 1; i++)
                {
                    tal1 = primtal[i];
                    int summa = tal1 * tal1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (i <= 10)
                    {
                        Console.WriteLine($"{tal1} * {tal1} = {summa}");
                    }
                }
                reset();
            }
            static void ovning11()
            {
                SetArrayTrue();

               /* for (int i = 0; i < bools.Length - 1; i++)
                {
                    i = i + 1;

                    bools[i] = true;
                    bools[i - 1] = false;

                }*/
                for (int n = 2; n < bools.Length; n++)
                {
                    for (int i = 2 * n; i < bools.Length; i += n)
                        bools[i] = false;
                }



                Console.ForegroundColor = ConsoleColor.Green;
                for (int j = 0; j <= bools.Length - 1; j++)
                {
                   
                    if (bools[j] == true)
                       
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{j}  {bools[j].ToString()}");
                        Console.ResetColor();
                    }
                   /*     else if (bools[j] == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{j}  {bools[j].ToString()}");
                        Console.ResetColor();
                    }*/

                }



                reset();
            }
        }

        static void SetArrayTrue()
        {
            bools = Enumerable.Repeat(true, 50).ToArray();
        }
        static void primearray()
        {
            Array.Clear(primtal, 0, primtal.Length);
            for (int i = 0; i <= 50; i++) //hur sätter jag i <= array.length
            {
                string p = IsPrime(i);
                if (p == "Primtal")
                {
                    primtal = primtal.Concat(new int[] { i }).ToArray();
                }
            }
        }

        static string IsPrime(int p)
        {
            for (int i = 2; i < p; i++)
                if (p % i == 0)
                    return "Sammansatt";
            return "Primtal";


        }
        static string Arraytelefon(int index)
        {
            string[] telefonnr = { "000011111", "1111010101", "22201020", "3333010101", "4444010101", "5555010101" };

            return telefonnr[index];
        }
        static int Prod2(int m, int n)
        {

            int p = 1;
            for (int i = m; i <= n; i++)
            {
                p *= i;
            }
            return p;

        }

        static int AltSumSquares(int s)
        {
            int sum = 0;
            for (int i = 1; i <= s; i++)
            {
                int sign;
                if (i % 2 == 0)
                {
                    sign = -1;
                }
                else
                {
                    sign = 1;
                }

                sum += sign * i * i;
            }
            return sum;
        }

        static int SumSquares(int s)
        {
            int sum = 0;
            for (int i = 1; i <= s; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        static double Cot(double x)
        {

            return 1 / Math.Tan(x);
        }
        static long Faktorial(int f)
        {

            long result = 1;
            for (int i = 1; i <= f; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}





