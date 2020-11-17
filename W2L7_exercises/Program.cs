using System;
using System.ComponentModel.DataAnnotations;

namespace W2L7_exercises
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
            //ExercisesTen();
            //ExercisesEleven(); 
            //ExercisesTwelve();
            ExercisesThirteen();




        }
        private static void ExercisesThirteen()

        {
            Console.WriteLine("Enter first number:");
            string firstNumberString = Console.ReadLine();
            int firstNumberInt = int.Parse(firstNumberString);
            
            Console.WriteLine("Enter second number:");
            string secondNumberString = Console.ReadLine();
            int secondNumberInt = int.Parse(secondNumberString);

            Console.WriteLine("Enter the number of the operation:");
                Console.WriteLine("1. Addition:");
                Console.WriteLine("2. Subtraction:");
                Console.WriteLine("3. Multiplication:");
                Console.WriteLine("4. Dividition:");
            
            string selectedOperationString = Console.ReadLine();
            int selectedOperationInt = int.Parse(selectedOperationString);

            int result;

            switch (selectedOperationInt)
            {
                case 1:
                    result = firstNumberInt + secondNumberInt;
                    Console.WriteLine($"Your result: {result}");
                    break;
                case 2:
                    result = firstNumberInt - secondNumberInt;
                    Console.WriteLine($"Your result: {result}");
                    break;
                case 3:
                    result = firstNumberInt * secondNumberInt;
                    Console.WriteLine($"Your result: {result}");
                    break;
                case 4:
                    result = firstNumberInt / secondNumberInt;
                    Console.WriteLine($"Your result: {result}");
                    break;
                default:
                    Console.WriteLine("Wrong operation number given");
                    break;

            }

        }
        private static void ExercisesTwelve()

        {
            Console.WriteLine("Enter day number 1-7:");
            string dayString = Console.ReadLine();
            int dayInt = int.Parse(dayString);

            switch (dayInt)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Wrong day number given");
                    break;

            }

        }

        private static void ExercisesEleven()

        {
            Console.WriteLine("Enter grade:");
            string gradeString = Console.ReadLine();
            int gradeInt = int.Parse(gradeString);
            
            switch (gradeInt)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Wrong number given");
                    break;

            }



        }

        private static void ExercisesTen()
        {
            int[] triangleLengthInt = new int[3];
            Console.WriteLine("Enter length of the 1 sides of the triangle");
            string triangleLength_1 = Console.ReadLine();
            triangleLengthInt[0] = int.Parse(triangleLength_1);
            Console.WriteLine("Enter length of the 2 sides of the triangle");
            string triangleLength_2 = Console.ReadLine();
            triangleLengthInt[1] = int.Parse(triangleLength_2);
            Console.WriteLine("Enter length of the 3 sides of the triangle");
            string triangleLength_3 = Console.ReadLine();
            triangleLengthInt[2] = int.Parse(triangleLength_3);

            int maxValue = triangleLengthInt[0];
            int triangleLengthSum = 0;
            for (int i = 0; i < triangleLengthInt.Length; i++)
            {

                if (triangleLengthInt[i] > maxValue)
                {
                    maxValue = triangleLengthInt[i];
                }
            }

            if (maxValue < (triangleLengthInt[0]+ triangleLengthInt[1]+ triangleLengthInt[2] - maxValue))
            {
                Console.WriteLine("The side lengths of the triangle are correct");
            }
            else
            {
                Console.WriteLine("The side lengths of the triangle are incorrect");
            }

        }

        private static void ExercisesNine()
        {
            Console.WriteLine("Temp:");
            string tempString = Console.ReadLine();
            int temp = int.Parse(tempString);
            switch (temp)
            {
                case int n when (n < 0):
                    Console.WriteLine("cholernie piździ");
                    break;
                case int n when (n < 10 && n > 0):
                    Console.WriteLine("zimno");
                    break;
                case int n when (n < 10 && n > 10):
                    Console.WriteLine("chłodno");
                    break;
                case int n when (n < 30 && n > 20):
                    Console.WriteLine("w sam raz");
                    break;
                case int n when (n < 40 && n > 30):
                    Console.WriteLine("zaczyna być słabo, bo gorąco");
                    break;
                case int n when (n >= 40):
                    Console.WriteLine("– a weź wyprowadzam się na Alaskę.");
                    break;

                default:
                    Console.WriteLine("Wprowadzono nieprawidłową wartość");
                    break;
            };
        }

        private static void ExercisesEight()
        {
            int mathScore = 70;
            int physicsScore = 55;
            int chemistryScore = 45;

            int ScoreSum = mathScore + physicsScore + chemistryScore;

            if (ScoreSum > 180 || mathScore + physicsScore > 150 || mathScore + chemistryScore > 150)
            {
                Console.WriteLine("You can become a student");
            }
            else
            {
                Console.WriteLine("You can not become a student");
            }


        }

        private static void ExercisesSeven()
        {
            int[] highestNumber = new int[3];

            Console.WriteLine("Enter first number:");
            string firstNumberString = Console.ReadLine();
            highestNumber[0] = int.Parse(firstNumberString);

            Console.WriteLine("Enter second number:");
            string secondNumberString = Console.ReadLine();
            highestNumber[1] = int.Parse(secondNumberString);

            Console.WriteLine("Enter third number:");
            string thirdtNumberString = Console.ReadLine();
            highestNumber[2] = int.Parse(thirdtNumberString);
            int maxValue = highestNumber[0];
            for (int i = 0; i < highestNumber.Length; i++)
            {
                if (highestNumber[i] > maxValue)
                {
                    maxValue = highestNumber[i];
                }
            }

            Console.WriteLine($"Max entered value is {maxValue}");
        }

        private static void ExercisesSix()
        {
            Console.WriteLine("Enter height:");
            string heightString = Console.ReadLine();
            int height = int.Parse(heightString);

            if (height <= 140)
            {
                Console.WriteLine("Jestes krasnoludem");
            }
            if (height > 140 && height <= 175)
            {
                Console.WriteLine("Jestes nisko wysoki");
            }
            if (height > 175)
            {
                Console.WriteLine("Jestes wysoki");
            }

        }

        private static void ExercisesFive()
        {
            Console.WriteLine("Enter your birth year:");
            string birthYearString = Console.ReadLine();
            int birthYear = int.Parse(birthYearString);

            if (birthYear >= 21)
            {
                Console.WriteLine("Możesz zostać posłem.");
            }
            if (birthYear >= 30)
            {
                Console.WriteLine("Możesz zostać senatorem.");
            }
            if (birthYear >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem.");
            }
            if (birthYear >= 21)
            {
                Console.WriteLine("Możesz zostać premierem.");
            }
        }

        private static void ExercisesFour()
        {
            Console.WriteLine("Enter the year:");
            string isLeapYearString = Console.ReadLine();
            int isLeapYear = int.Parse(isLeapYearString);

            if (isLeapYear % 4 == 0)
            {
                Console.WriteLine($"{isLeapYear} is a  leap year.");
            }
            else if (isLeapYear % 100 == 0)
            {
                Console.WriteLine($"{isLeapYear} is a  leap year.");
            }
            else if (isLeapYear % 400 == 0)
            {
                Console.WriteLine($"{isLeapYear} is not a  leap year.");
            }
            else
            {
                Console.WriteLine($"{isLeapYear} is not a  leap year.");
            }

            if (DateTime.IsLeapYear(isLeapYear))
            {
                Console.WriteLine($"{isLeapYear} is a  leap year.");
            }
            else
            {
                Console.WriteLine($"{isLeapYear} is not a  leap year.");
            }
        }

        private static void ExercisesThree()
        {
            Console.WriteLine("Enter number:");
            string signCheckString = Console.ReadLine();
            int signCheck = int.Parse(signCheckString);
            if (signCheck > 0)
            {
                Console.WriteLine("Given number is positive");
            }
            else if (signCheck == 0)
            {
                Console.WriteLine("Given number is equal 0");
            }
            else
            {
                Console.WriteLine("Given number is negative");
            }


        }

        private static void ExercisesTwo()
        {
            Console.WriteLine("Enter number:");
            string evenOrOddString = Console.ReadLine();

            int evenOrOddNumber = int.Parse(evenOrOddString);

            if (evenOrOddNumber % 2 == 0)
            {
                Console.WriteLine($"Number {evenOrOddNumber} is even");
            }
            else
            {
                Console.WriteLine($"Number {evenOrOddNumber} is odd");
            }
        }

        private static void ExercisesOne()
        {
            Console.WriteLine("Enter first number:");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Eneter second number:");
            string secondNumber = Console.ReadLine();

            if (int.Parse(firstNumber) == int.Parse(secondNumber))
            {
                Console.WriteLine($"{firstNumber} and {secondNumber} are equal");
            }
            else
            {
                Console.WriteLine("Given values are not equal");
            }


        }
    }
}

