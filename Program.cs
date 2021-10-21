using System;

namespace MethodsExercise
{
    class Program
    {
        public  static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
                return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {

            var amountOfBoobs = Sum(5, 9);
            var canGoods = Multiply(21, 12, 3);

            /// *//-----------------------------Exercise 1--------------------------------------------------------------
            //Console.WriteLine("Hello - What is your first name?");
            //var userName = Console.ReadLine();

            //Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            //var color = Console.ReadLine();

            //Console.WriteLine($"{color} is an interesting color! What is your favorite animal?");
            //var animal = Console.ReadLine();

            //Console.WriteLine("Excellent!!  Now, what is your favorite music group?");
            //var musicGroup = Console.ReadLine();

            //Console.WriteLine($"Thanks, {userName}!!  Here is your profile");
            //Console.WriteLine("--------------------------------------------------");



            //Console.WriteLine($"Name: {userName}");
            //Console.WriteLine($"Favorite color {color}");
            //Console.WriteLine($"Favorite animal {animal}");
            //Console.WriteLine($"Favorite musicgroup {musicGroup}");

            //Console.ReadLine();*//

          







            
        }
    }
}
