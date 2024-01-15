using System;
using System.IO;

namespace Lab0Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1: User Input the low and high number
            Console.WriteLine("Enter a low number: ");
            int lowNum = GetLowNumber();
            Console.WriteLine("Enter a high number: ");
            int highNum = GetHighNumber(lowNum);

            //Task 1: Calculate and Print difference between low and high number
            int difference = highNum - lowNum;
            Console.WriteLine($"The difference between {highNum} and {lowNum} is: {difference}");


            //Task 3: Create List
            List<double> ListOfNumbers = new List<double>();
            for (int i = lowNum; i <= highNum; i++)
            {
                ListOfNumbers.Add(i);
            }

            //Task 3: Create a new txt file
            string filePath = "/Users/elysia/Sait/OOP2_C#/Lab0Assignment/Lab0Assignment/numbers.txt";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                ListOfNumbers.Reverse();

                foreach (double number in ListOfNumbers)
                {
                    //Console.WriteLine(number);
                    sw.WriteLine(number);
                }
            }

            //Additional Task: Reading numbers from file and print out the sum of the numbers
            string content = File.ReadAllText(filePath);
            List<double> txtNumbers = new List<double>(Array.ConvertAll(File.ReadAllLines(filePath), double.Parse));
            double sum = 0;
            foreach (double num in txtNumbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum of numbers from file: {sum}");

            //Print primeNumber
            Console.Write("The prime Numbers between low number and high number: ");
            foreach (double num in ListOfNumbers){
                if (IsPrimeNumber(num))
                {
                    Console.Write($"{num} ");
                }
            }
        }

        //Task 2: Looping and Input Vaildation (low number)
        static int GetLowNumber()
        {
            int lowNum;
            while (true)
            {
                string low = Console.ReadLine();
                if (int.TryParse(low, out lowNum) && lowNum > 0)
                {
                    return lowNum;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }

        //Task 2: Looping and Input Vaildation (high number)
        static int GetHighNumber(int lowNum)
        {
            int highNum;
            while (true)
            {
                string high = Console.ReadLine();
                if (int.TryParse(high, out highNum) && highNum > lowNum)
                {
                    return highNum;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }

        //Additional Task: Prime numbers
        static bool  IsPrimeNumber(double num)
        {
            for(int i =2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
