using System;

namespace W2L4_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
            //ExerciseFive();

        }

        private static void ExerciseFive()
        {
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter mobile number:");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine("Enter body weight:");
            string bodyWeight = Console.ReadLine();
            Console.WriteLine("Enter email adress:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter body height:");
            string bodyHeight = Console.ReadLine();

            long mobileNumberLong = long.Parse(mobileNumber);
            int bodyWeightInt = int.Parse(bodyWeight);
            int bodyHeightInt = int.Parse(bodyHeight);


        }

        private static void ExerciseFour()
        {
            int number1 = 10;
            string name = "Szkoła Dotneta";
            double number2 = 12.5;
        }

        private static void ExerciseThree()
        {
            Console.WriteLine("Enter length a:");
            string lengthA = Console.ReadLine();
            Console.WriteLine("Enter length a:");
            string lengthB = Console.ReadLine();

            double result = Math.Sqrt(Math.Pow(double.Parse(lengthA, System.Globalization.CultureInfo.InvariantCulture), 2) + Math.Pow(double.Parse(lengthB, System.Globalization.CultureInfo.InvariantCulture), 2));
            Console.WriteLine("Result: {0}", result);
        }

        private static void ExerciseTwo()
        {


            Console.WriteLine("Give a char:");
            string a = Console.ReadLine();
            Console.WriteLine("Give a char:");
            string b = Console.ReadLine();
            Console.WriteLine("Give a char:");
            string c = Console.ReadLine();

            Console.WriteLine("{0},{1},{2}", c, b, a);
        }

        private static void ExerciseOne()
        {
            string firstname = "Jan";
            string surname = "Kolwaski";
            byte age = 26;
            Sex sex = Sex.Male;
            long pesel = 94010123334;
            long workerID = 2509324094;

            Console.WriteLine("First name: {0}", firstname);
            Console.WriteLine("Last  name: {0}", surname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Sex: {0}", sex);
            Console.WriteLine("Pesel: {0}", pesel);
            Console.WriteLine("Worker ID: {0}", workerID);
        }
        enum Sex
        {
            Famale,
            Male,
        }
    }
}
