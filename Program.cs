using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StudentsMethods
{
    class Program
    {
        static string UserName(string name, string phone)
        {

            string userInfo = name + phone;
            return userInfo;
        }

        static void PrintArray(string[] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.WriteLine(arrayToPrint[i]);
            }
        }
        static void FamilyGuy(string[] familyGuy)
        {
            for (int i = 0; i < familyGuy.Length; i++)
            {
                Console.WriteLine(familyGuy[i]);
            }
        }

        static void AlphaSplitter(string[] words)
        {
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
        static void SobrietyTest (string [] alpha)
        {
            Array.Reverse(alpha);
            for (int i = 0; i < alpha.Length; i++)
            {
                Console.Write(alpha[i]);
            }
        }
        static string NameAgeState ()
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("What state do you live in?");
            string state = Console.ReadLine();

            string nameAgeState = name + " is " + age + " and lives in " + state + ".";
            return nameAgeState;
        }
        static double CircleArea (double radius)
        {
            double area = radius * radius * Math.PI;
            return area;
        }
        static int NumberCheck ()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Enter a number");
               string res = Console.ReadLine();
                bool result = int.TryParse(res, out number);
                if (result == true)
                {
                    Console.WriteLine(number);
                    break;
                }
                else
                {
                    Console.WriteLine("Error\nPlease try agian");
                    continue;
                }
            }
            return number;
        }
        static void TopStudent (int [] studentA, int [] studentB) // we want to average 3 grades for each student and see who has the best average
        {
            int averageA = (studentA[0] + studentA[1] + studentA[2]) / 3;
            int averageB = (studentB[0] + studentB[1] + studentB[2]) / 3;
            if (averageA>averageB)
            {
                Console.WriteLine("Student A has the higher average, it is " + averageA);
            }
            else if (averageB>averageA)
            {
                Console.WriteLine("Student B has the higher average, it is " + averageB);
            }

            else if (averageA==averageB)
            {
                Console.WriteLine("Both students have the same average, it is " + averageB);
            }
        }
        public static string ProperName(string line)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                if (i == 0)
                {
                    ch = Char.ToUpper(line[0]);
                    result.Append(ch);
                }
                else
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }

        static bool ValidName(string name)
        {
            if (Regex.IsMatch(name, @"^[a-z,A-Z]+$")) 
            {
                Console.WriteLine(name + " is a valid name.");
                return true;
            }
            else
            {
                Console.WriteLine("The first and/or last name is not valid.");
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            ValidName(name);
            Console.WriteLine("What is your phone number");
            string phone = Console.ReadLine();
            Console.WriteLine(UserName(name, phone));
            string[] stuff = { "rock", "paper", "scissors" };
            PrintArray(stuff);
            string[] familyGuy = { "Lois", "Brian", "Peter", "Meg", "Quagmire", "Stewy" };
            FamilyGuy(familyGuy);
            string[] words = { "apple", "peach", "pear", "plum", "pineapple", "mango", "melon" };
            AlphaSplitter(words);
            string[] alpha = { "q", "w", "e", "r", "t", "y", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m", "u" };
            Array.Sort(alpha);
            SobrietyTest(alpha);
            Console.WriteLine();
            Console.WriteLine(NameAgeState());
            Console.Clear();
            Console.WriteLine(CircleArea(2));
            Console.WriteLine(NumberCheck());
            int []studentA= { 98, 76, 92};
            int[] studentB = { 99, 77, 93 };
            TopStudent(studentA, studentB);
            string myname = ( "ashley stewart" );
            ProperName(myname);

        }
    }
}
