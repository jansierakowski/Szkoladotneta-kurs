using System;

namespace W2L8_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExercisesOne();
            //ExercisesTwo();
            //ExercisesThree();
            //ExercisesFour();
            //ExercisesFive();
            //ExercisesSix();
            //ExercisesSeven();
            //ExercisesEight();
            //ExercisesNine();
            ExercisesTen();
        }


        private static void ExercisesOne()
        {
            int primeCount = 0;

            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {

                        primeCount++;
                    }
                }
                if (primeCount == 2)
                {
                    Console.WriteLine($"{i}");
                }
                primeCount = 0;
            }
        }

        private static void ExercisesTwo()
        {
            int n = 0;
            do
            {
                n++;
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }


            } while (n <= 1000);

        }

        private static void ExercisesThree()
        {
            long a = 0, b = 1, t = 1;
            int n = 50;
            for (int i = 0; i < n; i++)
            {
                t = a;
                a = a + b;
                b = t;
                Console.WriteLine(a);
            }


        }

        private static void ExercisesFour()
        {
            Console.WriteLine("Enter number:");
            string numberString = Console.ReadLine();
            int maxnumber = int.Parse(numberString);
            int numbers = 1;

            for (int i = 1; i <= maxnumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($" {numbers}");
                    numbers++;
                }
                Console.WriteLine();

            }


        }

        private static void ExercisesFive()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }

        private static void ExercisesSix()
        {
            double actualValue = 0;
            double divider;
            for (int i = 0; i <= 20; i++)
            {
                if (i > 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        divider = 1.0 / (double)j;
                        actualValue += divider;
                    }

                    Console.WriteLine($"i: {i}, aktualna wartosc: {actualValue}");
                    actualValue = 0;
                }
                else
                {
                    Console.WriteLine($"i: {i}, aktualna wartosc: {actualValue}");
                    actualValue = 0;
                }
            }
        }

        private static void ExercisesSeven()
        {
            Console.Write("Enter the maximum number of middle line: ");
            int maxnumber = Convert.ToInt32(Console.ReadLine());
            int n = (maxnumber + 1) / 2;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void ExercisesEight()
        {
            Console.WriteLine("Enter text: ");
            string textString = Console.ReadLine();
            int textLength = textString.Length - 1;

            for (int i = textLength; i >= 0; i--)
            {
                Console.Write(textString[i]);
            }
        }

        private static void ExercisesNine()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int numberModulo;
            string binNumber = "";
            int i = 0;
            while (number != 0)
            {
                numberModulo = number % 2;
                number = number / 2;
                binNumber += numberModulo.ToString();
                i++;
            }

            int textLength = binNumber.Length - 1;

            for (int j = textLength; j >= 0; j--)
            {
                Console.Write(binNumber[j]);
            }








        }

        private static void ExercisesTen()
        {
            Console.Write("Enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int number1Modulo, number2Modulo, nww = 0, wynik;

            for (int i = 2; i <= 9; i++)
            {
                number1Modulo = number1 % i;
                number2Modulo = number2 % i;

                if (number1Modulo == 0 && number2Modulo == 0 && number1Modulo == number2Modulo)
                {
                    wynik = number1 * number2 / i;
                    Console.WriteLine(i);
                    return;
                }
            }


        }
    }
}

