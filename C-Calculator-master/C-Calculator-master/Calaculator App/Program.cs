using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Calaculator_App
{
    internal class Program
    {



        static public double Add(string a,string b)
        {
            double.TryParse(a,out double num1);
            double.TryParse(b,out double num2);
            return num1 + num2;
        }
        static public double Subtract(string a,string b)
        {

            double.TryParse(a, out double num1);
            double.TryParse(b, out double num2);
            return num1 - num2;
        }
        static public double Multiply(string a,string b)
        {
            double.TryParse(a, out double num1);
            double.TryParse(b, out double num2);
            return num1 * num2;
        }
        static public double Divide(string a,string b)
        {
            double.TryParse(a, out double num1);
            double.TryParse(b, out double num2);
            if (num2 == 0) Console.WriteLine("No Zero Division");
            return num1 / num2;
        }


        static public void print(int index, in string[]arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++) { 
                if(i==index) Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(50, i+10);
                Console.WriteLine(arr[i]);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static public void DoOperation(string operation,string number1,string number2)
        {
            switch (operation)
            {
                case "Add":
                    Console.WriteLine($"{number1}+{number2}={Add(number1, number2)}");
                    break;
                case "Subtract":
                    Console.WriteLine($"{number1}-{number2}={Subtract(number1, number2)}");
                    break;
                case "Multiply":
                    Console.WriteLine($"{number1}*{number2}={Multiply(number1, number2)}");
                    break;
                case "Divide":
                    Console.WriteLine($"{number1}/{number2}={Divide(number1, number2)}");
                    break;
                default:
                    break;
            }
            Thread.Sleep(1800);
        }
        static void Main(string[] args)
        {
            string[] array = { "Add", "Subtract", "Multiply", "Divide" };

            
            int index = 0;
            print(index, array);
            while(true)
            {
                print(index, array);
                var key = Console.ReadKey(true);
                switch(key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (index == 0) continue;
                        index--;
                        //print(index, array);
                        break;
                    case ConsoleKey.DownArrow:
                        if (index == 3) continue;
                        index++;
                        //print(index, array);
                        break;
                    case ConsoleKey.Enter:
                        Console.Write("Enter number 1: ");
                        string number1 = Console.ReadLine();
                        Console.Write("Enter number 2: ");
                        string number2 = Console.ReadLine();
                        DoOperation(array[index], number1, number2);
                        index = 0;
                        break;
                }
            }
        }
    }
}

